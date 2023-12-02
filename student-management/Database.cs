using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace studentManagement {

    /// <summary>
    ///   Sqlite connector (wrapper for SQLiteConnection)
    ///   Only for internal use, do not use outside this file
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
        ///   Create database and tables if not exists
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
                    LopTruong INTEGER DEFAULT 0
                );
                CREATE TABLE IF NOT EXISTS DSKhoa (
                    MaKhoa TEXT PRIMARY KEY,
                    TenKhoa TEXT
                );
                CREATE TABLE IF NOT EXISTS DSMonHoc (
                    MaMonHoc TEXT PRIMARY KEY,
                    TenMonHoc TEXT
                );
                CREATE TABLE IF NOT EXISTS DSLop (
                    MaLop TEXT PRIMARY KEY,
                    TenLop TEXT,
                    MaKhoa TEXT REFERENCES DSKhoa(MaKhoa),
                    MaMonHoc TEXT REFERENCES DSMonHoc(MaMonHoc)
                );
                CREATE TABLE IF NOT EXISTS DSSinhVienLop (
                    MaSinhVien TEXT REFERENCES DSSinhVien(MaSinhVien),
                    MaLop TEXT REFERENCES DSLop(MaLop),
                    PRIMARY KEY (MaSinhVien, MaLop)
                );
                CREATE TABLE IF NOT EXISTS DSDiem (
                    MaSinhVien TEXT REFERENCES DSSinhVien(MaSinhVien),
                    MaMonHoc TEXT REFERENCES DSMonHoc(MaMonHoc),
                    Diem INTEGER,
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
        ///   Insert student
        ///   If student exists, update student info
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="hoTen"></param>
        /// <param name="ngaySinh"></param>
        /// <param name="gioiTinh"></param>
        /// <param name="maKhoa"></param>
        /// <param name="lopTruong"></param>
        /// <returns> true if insert success </returns>
        public bool insertStudent(string maSinhVien, string hoTen, string ngaySinh, string gioiTinh, string maKhoa,
            bool lopTruong = false) {
            try {
                _connector.createAndExecuteCommand(@"
                    INSERT OR REPLACE INTO DSSinhVien (MaSinhVien, HoTen, NgaySinh, GioiTinh, MaKhoa, LopTruong)
                    VALUES (@MaSinhVien, @hoTen, @ngaySinh, @gioiTinh, @maKhoa, @lopTruong)
                ", maSinhVien, hoTen, ngaySinh, gioiTinh, maKhoa, lopTruong ? "1" : "0");
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
        ///   Check login
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
        ///   Update password
        /// </summary>
        /// <returns> true if username exists </returns>
        public bool updatePassword(string username, string password) {
            var command = _connector.createAndExecuteCommand(@"
                UPDATE DSUser SET Password = @password WHERE Username = @username
            ", _hashPassword(password), username);
            return command.ExecuteNonQuery() > 0;
        }

        /// <summary>
        ///   Insert faculty
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
        ///   Insert subject
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <param name="tenMonHoc"></param>
        /// <returns> true if insert success </returns>
        public bool insertSubject(string maMonHoc, string tenMonHoc) {
            try {
                _connector.createAndExecuteCommand(@"
                INSERT OR REPLACE INTO DSMonHoc (MaMonHoc, TenMonHoc)
                VALUES (@maMonHoc, @tenMonHoc)
            ", maMonHoc, tenMonHoc);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert class
        /// </summary>
        /// <param name="maLop"></param>
        /// <param name="tenLop"></param>
        /// <param name="maKhoa"></param>
        /// <param name="maMonHoc"></param>
        /// <returns> true if insert success </returns>
        public bool insertClass(string maLop, string tenLop, string maKhoa, string maMonHoc) {
            try {
                _connector.createAndExecuteCommand(@"
                INSERT OR REPLACE INTO DSLop (MaLop, TenLop, MaKhoa, MaMonHoc)
                VALUES (@maLop, @tenLop, @maKhoa, @maMonHoc)
            ", maLop, tenLop, maKhoa, maMonHoc);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert class student
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maLop"></param>
        /// <returns> true if insert success </returns>
        public bool insertClassStudent(string maSinhVien, string maLop) {
            try {
                _connector.createAndExecuteCommand(@"
                INSERT OR REPLACE INTO DSSinhVienLop (MaSinhVien, MaLop)
                VALUES (@MaSinhVien, @maLop)
            ", maSinhVien, maLop);
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        /// <summary>
        ///   Insert score
        /// </summary>
        /// <param name="maSinhVien"></param>
        /// <param name="maMonHoc"></param>
        /// <param name="diem"></param>
        /// <returns> true if insert success </returns>
        public bool insertScore(string maSinhVien, string maMonHoc, int diem) {
            try {
                _connector.createAndExecuteCommand(@"
                INSERT OR REPLACE INTO DSDiem (MaSinhVien, MaMonHoc, Diem)
                VALUES (@MaSinhVien, @maMonHoc, @diem)
            ", maSinhVien, maMonHoc, diem.ToString());
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }
    }
}