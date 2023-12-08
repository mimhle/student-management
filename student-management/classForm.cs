using System;
using System.Windows.Forms;

namespace studentManagement {
    public partial class ClassForm : Form {
        public ClassForm() {
            InitializeComponent();
        }

        private void formAdd(int iNum) {
            if (iNum == 0) gbAddClass.Show();
            else gbAddClass.Hide();
        }

        private void formChange(int iNum) {
            if (iNum == 0) gbChangeClass.Show();
            else gbChangeClass.Hide();
        }

        private void btnDeleteClassAdd_Click(object sender, EventArgs e) {
            formChange(0);
            formAdd(1);
        }

        private void btnReturnMenuAdd_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddClassChange_Click(object sender, EventArgs e) {
            formAdd(0);
            formChange(1);
        }

        private void classForm_Load(object sender, EventArgs e) {

        }

       
    }
}
