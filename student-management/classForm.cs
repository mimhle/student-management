using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management {
    public partial class classForm : Form {
        public classForm() {
            InitializeComponent();
        }

        public void formAdd(int iNum) {
            if (iNum == 0) gbAddClass.Show();
            else gbAddClass.Hide();
        }

        public void formChange(int iNum) {
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
