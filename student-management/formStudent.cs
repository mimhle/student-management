using System.Windows.Forms;

namespace studentManagement {
    public partial class StudentForm : Form {
        public StudentForm() {
            InitializeComponent();
        }
        private void groupBoxFind_Show(bool check) {
            if (check) groupBoxFind.Show();
            else groupBoxFind.Hide();
        }
        private void groupBoxEdit_Show(bool check) {
            if (check) groupBoxEdit.Show();
            else groupBoxEdit.Hide();
        }
        private void btnReturn_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void btnFind_Click(object sender, System.EventArgs e) {
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(true);
            groupBoxFind_Show(false);
        }

        private void btnReturnToFind_Click(object sender, System.EventArgs e) {
            groupBoxEdit_Show(false);
            groupBoxFind_Show(true);
        }
    }
}
