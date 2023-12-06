using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace studentManagement {
    /// <summary>
    ///   Sqlite connector (wrapper for SQLiteConnection).
    ///   Only for internal use, do not use outside this file.
    /// </summary>
    internal class SqliteConnector {
        private readonly SQLiteConnection _connection;

        public SqliteConnector(string connectionString) {
            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        public SQLiteCommand createAndExecuteCommand(string commandText, params string[] args) {
            var command = _connection.CreateCommand();
            command.CommandText = commandText;
            var parameters = Regex.Match(commandText, @"@\w+");
            var i = 0;
            while (parameters.Success) {
                command.Parameters.AddWithValue(parameters.Value, args[i++]);
                parameters = parameters.NextMatch();
            }

            command.ExecuteNonQuery();
            return command;
        }
    }

    public class Database {
        private readonly SqliteConnector _connector;

        private static string _hashPassword(string password) {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var hashBytes = new SHA256Managed().ComputeHash(passwordBytes);
            password = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return password;
        }

        /// <summary>
        ///   Create database and tables if not exists.
        /// </summary>
        public Database(string connectionString) {
            _connector = new SqliteConnector(connectionString);
            _connector.createAndExecuteCommand(@"
                CREATE TABLE IF NOT EXISTS DSSinhVien (
                    MaSinhVien TEXT PRIMARY KEY,
                    HoTen TEXT,
                    NgaySinh TEXT,
                    GioiTinh TEXT,
                    MaKhoa TEXT REFERENCES DSKhoa(MaKhoa),
                    MaLop TEXT REFERENCES DSLop(MaLop),
                    LopTruong INTEGER DEFAULT 0
                );
                CREATE TABLE IF NOT EXISTS DSKhoa (
                    MaKhoa TEXT PRIMARY KEY,
                    TenKhoa TEXT
                );
                CREATE TABLE IF NOT EXISTS DSLop (
                    MaLop TEXT PRIMARY KEY,
                    TenLop TEXT,
                    MaKhoa TEXT REFERENCES DSKhoa(MaKhoa)
                );
                CREATE TABLE IF NOT EXISTS DSMonHoc (
                    MaMonHoc TEXT PRIMARY KEY,
                    TenMonHoc TEXT,
                    MaKhoa TEXT REFERENCES DSKhoa(MaKhoa),
                    SoTinChi INTEGER DEFAULT 0
                );
                CREATE TABLE IF NOT EXISTS DSLopHocPhan (
                    MaLopHocPhan TEXT PRIMARY KEY,
                    TenLopHocPhan TEXT,
                    MaKhoa TEXT REFERENCES DSKhoa(MaKhoa),
                    MaMonHoc TEXT REFERENCES DSMonHoc(MaMonHoc)
                );
                CREATE TABLE IF NOT EXISTS DSSinhVienLopHocPhan (
                    MaSinhVien TEXT REFERENCES DSSinhVien(MaSinhVien),
                    MaLopHocPhan TEXT REFERENCES DSLopHocPhan(MaLopHocPhan),
                    PRIMARY KEY (MaSinhVien, MaLopHocPhan)
                );
                CREATE TABLE IF NOT EXISTS DSDiem (
                    MaSinhVien TEXT REFERENCES DSSinhVien(MaSinhVien),
                    MaMonHoc TEXT REFERENCES DSMonHoc(MaMonHoc),
                    Diem REAL,
                    PRIMARY KEY (MaSinhVien, MaMonHoc)
                );
                CREATE TABLE IF NOT EXISTS DSUser (
                    Username TEXT PRIMARY KEY,
                    Password TEXT,
                    MaSinhVien TEXT REFERENCES DSSinhVien(MaSinhVien)
                );
            ");
        }

        /// <summary>
        ///   Insert student.
        ///   If student exists, update student info
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="maKhoa"></param>
        /// <param name="maLop"></param>
        /// <param name="lopTruong"></param>
        /// <returns> true if insert success </returns>
        public bool insertStudent(
            string maSinhVien,
            string hoTen,
            string ngaySinh,
            string gioiTinh,
            string maKhoa,
            string maLop,
            bool lopTruong = false
        ) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSSinhVien (MaSinhVien, HoTen, NgaySinh, GioiTinh, MaKhoa, MaLop, LopTruong)
                    VALUES (@MaSinhVien, @hoTen, @ngaySinh, @gioiTinh, @maKhoa, @maLop, @lopTruong)
                ", maSinhVien, hoTen, ngaySinh, gioiTinh, maKhoa, maLop, lopTruong ? "1" : "0");
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSUser (Username, Password, MaSinhVien)
                    VALUES (@MaSinhVien, @password, @MaSinhVien)
                ", maSinhVien, _hashPassword(maSinhVien), maSinhVien);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Check login.
        /// </summary>
        /// <returns> true if username and password is correct </returns>
        public bool checkLogin(string username, string password) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT Password FROM DSUser WHERE Username = @username
            ", username);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return false;
            }

            var hashPassword = reader.GetString(0);
            return hashPassword == _hashPassword(password);
        }

        /// <summary>
        ///   Update password.
        /// </summary>
        /// <returns> true if username exists </returns>
        public bool updatePassword(string username, string password) {
            var command = _connector.createAndExecuteCommand(@"
                UPDATE DSUser SET Password = @password WHERE Username = @username
            ", _hashPassword(password), username);
            return command.ExecuteNonQuery() > 0;
        }

        /// <summary>
        ///   Insert faculty.
        ///   If faculty exists, update faculty info.
        /// </summary>
        /// <param name="maKhoa"></param>
        /// <param name="tenKhoa"></param>
        /// <returns> true if insert success </returns>
        public bool insertFaculty(string maKhoa, string tenKhoa) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSKhoa (MaKhoa, TenKhoa)
                    VALUES (@maKhoa, @tenKhoa)
                ", maKhoa, tenKhoa);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert class.
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="tenLop"></param>
        /// <param name="maKhoa"></param>
        /// <returns> true if insert success </returns>
        public bool insertClass(string maLop, string tenLop, string maKhoa) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSLop (MaLop, TenLop, MaKhoa)
                    VALUES (@maLop, @tenLop, @maKhoa)
                ", maLop, tenLop, maKhoa);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert subject.
        ///   If subject exists, update subject info.
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <param name="tenMonHoc"></param>
        /// <param name="maKhoa"></param>
        /// <param name="soTinChi"></param>
        /// <returns> true if insert success </returns>
        public bool insertSubject(string maMonHoc, string tenMonHoc, string maKhoa, int soTinChi) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSMonHoc (MaMonHoc, TenMonHoc, MaKhoa, SoTinChi)
                    VALUES (@maMonHoc, @tenMonHoc, @maKhoa, @soTinChi)
                ", maMonHoc, tenMonHoc, maKhoa, soTinChi.ToString());
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert class.
        ///   If class exists, update class info.
        /// </summary>
        /// <param name="maLopHocPhan"></param>
        /// <param name="tenLopHocPhan"></param>
        /// <param name="maKhoa"></param>
        /// <param name="maMonHoc"></param>
        /// <returns> true if insert success </returns>
        public bool insertSubjectClass(string maLopHocPhan, string tenLopHocPhan, string maKhoa, string maMonHoc) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSLopHocPhan (MaLopHocPhan, TenLopHocPhan, MaKhoa, MaMonHoc)
                    VALUES (@maLopHocPhan, @tenLopHocPhan, @maKhoa, @maMonHoc)
                ", maLopHocPhan, tenLopHocPhan, maKhoa, maMonHoc);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert class student.
        ///   If class student exists, update class student info.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maLopHocPhan"></param>
        /// <returns> true if insert success </returns>
        public bool insertSubjectClassStudent(string maSinhVien, string maLopHocPhan) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSSinhVienLopHocPhan (MaSinhVien, MaLopHocPhan)
                    VALUES (@MaSinhVien, @maLopHocPhan)
                ", maSinhVien, maLopHocPhan);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert score
        ///   If score exists, update score info.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maMonHoc"></param>
        /// <param name="diem"></param>
        /// <returns> true if insert success </returns>
        public bool insertScore(string maSinhVien, string maMonHoc, float diem) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSDiem (MaSinhVien, MaMonHoc, Diem)
                    VALUES (@MaSinhVien, @maMonHoc, @diem)
                ", maSinhVien, maMonHoc, diem.ToString("0.00"));
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }


        /// <summary>
        ///   Get student info.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <returns> null if student not exists </returns>
        public Dictionary<string, string> getStudent(string maSinhVien) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSSinhVien WHERE MaSinhVien = @maSinhVien
            ", maSinhVien);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var student = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                student[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return student;
        }

        /// <summary>
        ///   Get faculty info.
        /// </summary>
        /// <param name="maKhoa"></param>
        /// <returns> null if faculty not exists </returns>
        public Dictionary<string, string> getFaculty(string maKhoa) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSKhoa WHERE MaKhoa = @maKhoa
            ", maKhoa);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var faculty = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                faculty[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return faculty;
        }

        /// <summary>
        ///   Get class info.
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns> null if class not exists </returns>
        public Dictionary<string, string> getClass(string maLop) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSLop WHERE MaLop = @maLop
            ", maLop);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var class_ = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                class_[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return class_;
        }

        /// <summary>
        ///   Get subject info.
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <returns> null if subject not exists </returns>
        public Dictionary<string, string> getSubject(string maMonHoc) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSMonHoc WHERE MaMonHoc = @maMonHoc
            ", maMonHoc);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var subject = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                subject[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return subject;
        }

        /// <summary>
        ///   Get class info.
        /// </summary>
        /// <param name="maLopHocPhan"></param>
        /// <returns> null if class not exists </returns>
        public Dictionary<string, string> getSubjectClass(string maLopHocPhan) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSLopHocPhan WHERE MaLopHocPhan = @maLopHocPhan
            ", maLopHocPhan);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var subjectClass = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                subjectClass[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return subjectClass;
        }

        /// <summary>
        ///   Get score info.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maMonHoc"></param>
        /// <returns> null if score not exists </returns>
        public Dictionary<string, string> getScore(string maSinhVien, string maMonHoc) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSDiem WHERE MaSinhVien = @maSinhVien AND MaMonHoc = @maMonHoc
            ", maSinhVien, maMonHoc);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var score = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                score[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return score;
        }

        /// <summary>
        ///   Get class student info.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maLopHocPhan"></param>
        /// <returns> null if class student not exists </returns>
        public Dictionary<string, string> getSubjectClassStudents(string maSinhVien, string maLopHocPhan) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSSinhVienLopHocPhan WHERE MaSinhVien = @maSinhVien AND MaLopHocPhan = @maLopHocPhan
            ", maSinhVien, maLopHocPhan);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var studentClass = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                studentClass[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return studentClass;
        }

        /// <summary>
        ///   Get user info.
        /// </summary>
        /// <param name="username"></param>
        /// <returns> null if user not exists </returns>
        public Dictionary<string, string> getUser(string username) {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSUser WHERE Username = @username
            ", username);
            var reader = command.ExecuteReader();
            if (!reader.Read()) {
                return null;
            }

            var user = new Dictionary<string, string>();
            for (var i = 0; i < reader.FieldCount; i++) {
                var columnName = reader.GetName(i);
                var columnValue = reader.GetValue(i);
                user[columnName] = columnValue is DBNull ? null : columnValue.ToString();
            }

            return user;
        }

        /// <summary>
        ///   Get all students.
        /// </summary>
        /// <returns> list of students </returns>
        public List<Dictionary<string, string>> getAllStudents() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSSinhVien
            ");
            var reader = command.ExecuteReader();
            var students = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var student = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    student[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                students.Add(student);
            }

            return students;
        }

        /// <summary>
        ///   Get all faculties.
        /// </summary>
        /// <returns> list of faculties </returns>
        public List<Dictionary<string, string>> getAllFaculties() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSKhoa
            ");
            var reader = command.ExecuteReader();
            var faculties = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var faculty = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    faculty[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                faculties.Add(faculty);
            }

            return faculties;
        }

        /// <summary>
        ///   Get all classes.
        /// </summary>
        /// <returns> list of classes </returns>
        public List<Dictionary<string, string>> getAllClasses() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSLop
            ");
            var reader = command.ExecuteReader();
            var classes = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var @class = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    @class[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                classes.Add(@class);
            }

            return classes;
        }

        /// <summary>
        ///   Get all subjects.
        /// </summary>
        /// <returns> list of subjects </returns>
        public List<Dictionary<string, string>> getAllSubject() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSMonHoc
            ");
            var reader = command.ExecuteReader();
            var subjects = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var subject = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    subject[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                subjects.Add(subject);
            }

            return subjects;
        }

        /// <summary>
        ///   Get all subject classes.
        /// </summary>
        /// <returns> list of subject classes </returns>
        public List<Dictionary<string, string>> getAllSubjectClass() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSLopHocPhan
            ");
            var reader = command.ExecuteReader();
            var subjectClasses = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var subjectClass = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    subjectClass[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                subjectClasses.Add(subjectClass);
            }

            return subjectClasses;
        }

        /// <summary>
        ///   Get all scores.
        /// </summary>
        /// <returns> list of scores </returns>
        public List<Dictionary<string, string>> getAllScores() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSDiem
            ");
            var reader = command.ExecuteReader();
            var scores = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var score = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    score[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                scores.Add(score);
            }

            return scores;
        }

        /// <summary>
        ///   Get all class students.
        /// </summary>
        /// <returns> list of class students </returns>
        public List<Dictionary<string, string>> getAllSubjectClassStudents() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSSinhVienLopHocPhan
            ");
            var reader = command.ExecuteReader();
            var studentClasses = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var studentClass = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    studentClass[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                studentClasses.Add(studentClass);
            }

            return studentClasses;
        }

        /// <summary>
        ///   Get all users.
        /// </summary>
        /// <returns> list of users </returns>
        public List<Dictionary<string, string>> getAllUsers() {
            var command = _connector.createAndExecuteCommand(@"
                SELECT * FROM DSUser
            ");
            var reader = command.ExecuteReader();
            var users = new List<Dictionary<string, string>>();
            while (reader.Read()) {
                var user = new Dictionary<string, string>();
                for (var i = 0; i < reader.FieldCount; i++) {
                    var columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);
                    user[columnName] = columnValue is DBNull ? null : columnValue.ToString();
                }

                users.Add(user);
            }

            return users;
        }

        /// <summary>
        ///   Remove student.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <returns> true if success whether student exists or not </returns>
        public bool removeStudent(string maSinhVien) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVien WHERE MaSinhVien = @MaSinhVien
                ", maSinhVien);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSUser WHERE MaSinhVien = @MaSinhVien
                ", maSinhVien);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove faculty.
        /// </summary>
        /// <param name="maKhoa"></param>
        /// <returns> true if success whether faculty exists or not </returns>
        public bool removeFaculty(string maKhoa) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSKhoa WHERE MaKhoa = @MaKhoa
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLop WHERE MaKhoa = @MaKhoa
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSMonHoc WHERE MaKhoa = @MaKhoa
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLopHocPhan WHERE MaKhoa = @MaKhoa
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSDiem WHERE MaKhoa = @MaKhoa
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSUser WHERE MaSinhVien IN (SELECT MaSinhVien FROM DSSinhVien WHERE MaKhoa = @MaKhoa)
                ", maKhoa);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVien WHERE MaKhoa = @MaKhoa
                ", maKhoa);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove class.
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns> true if success whether class exists or not </returns>
        public bool removeClass(string maLop) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLop WHERE MaLop = @MaLop
                ", maLop);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSUser WHERE MaSinhVien IN (SELECT MaSinhVien FROM DSSinhVien WHERE MaLop = @MaLop)
                ", maLop);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVien WHERE MaLop = @MaLop
                ", maLop);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLopHocPhan WHERE MaLop = @MaLop
                ", maLop);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVienLopHocPhan WHERE MaLop = @MaLop
                ", maLop);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSDiem WHERE MaLop = @MaLop
                ", maLop);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove subject.
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <returns> true if success whether subject exists or not </returns>
        public bool removeSubject(string maMonHoc) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSMonHoc WHERE MaMonHoc = @MaMonHoc
                ", maMonHoc);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLopHocPhan WHERE MaMonHoc = @MaMonHoc
                ", maMonHoc);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSDiem WHERE MaMonHoc = @MaMonHoc
                ", maMonHoc);
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVienLopHocPhan WHERE MaLopHocPhan IN (SELECT MaLopHocPhan FROM DSLopHocPhan WHERE MaMonHoc = @MaMonHoc)
                ", maMonHoc);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove subject class.
        /// </summary>
        /// <param name="maLopHocPhan"></param>
        /// <returns> true if success whether subject class exists or not </returns>
        public bool removeSubjectClass(string maLopHocPhan) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSLopHocPhan WHERE MaLopHocPhan = @MaLopHocPhan
                ", maLopHocPhan);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove class student.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maLopHocPhan"></param>
        /// <returns> true if success whether class student exists or not </returns>
        public bool removeSubjectClassStudent(string maSinhVien, string maLopHocPhan) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSSinhVienLopHocPhan WHERE MaSinhVien = @MaSinhVien AND MaLopHocPhan = @MaLopHocPhan
                ", maSinhVien, maLopHocPhan);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Remove score.
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maMonHoc"></param>
        /// <returns> true if success whether score exists or not </returns>
        public bool removeScore(string maSinhVien, string maMonHoc) {
            try {
                _connector.createAndExecuteCommand(@"
                    DELETE FROM DSDiem WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc
                ", maSinhVien, maMonHoc);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}