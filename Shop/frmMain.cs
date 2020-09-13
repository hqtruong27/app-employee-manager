using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class frmMain : Form
    {
        //private int childFormNumber = 0;
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        public frmMain()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee fem = new frmEmployee();
            loadMid_child(fem);
         
        }
        private void loadMid_child( Form frm)
        {
            frm.MdiParent = this;

            frm.StartPosition = FormStartPosition.Manual;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            if (this.ActiveMdiChild != null)
            {
                var frmCurrent = this.ActiveMdiChild;
                if (frm.Name != frmCurrent.Name)
                {
                    frmCurrent.Close();
                    frm.Show();
                }
            }
            else
            {
                frm.Show();
            }
        }

        private void departmentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            loadMid_child(frm);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("bạn muốn thoát khỏi không", "hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //ok thoát

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmEmployee fem = new frmEmployee();
            loadMid_child(fem);
        }

        private void positionManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosition frmP = new frmPosition();
            loadMid_child(frmP);
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            frmSalary frmSalary = new frmSalary();
            loadMid_child(frmSalary);

        }

        private void lươngCơBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasicSalary frmBS = new frmBasicSalary();
            loadMid_child(frmBS);
        }

        private void adminManager_Click_1(object sender, EventArgs e)
        {
            var group_name = (bool)db.Admins.SingleOrDefault(x => x.UserName.Equals(frmLogin.UserName)).GroupName;
            var _name = db.Admins.SingleOrDefault(x => x.UserName.Equals(frmLogin.UserName)).FullName;
            
            if (group_name)
            {
                frmAdmin frmA = new frmAdmin();
                loadMid_child(frmA);
                var qr = from s in db.Admins
                         select new {
                            Id = s.Id,
                            UserName = s.UserName
                         };
                MessageBox.Show("Xin chào: "+_name, "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn không được quyền vào trang này");

            }
        }
    }
}
