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
    public partial class frmLogin : Form
    {
        EmployeeManagerDataContext db;
        public static String UserName { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            db = new EmployeeManagerDataContext();
            txt_namelogin.Text = Properties.Settings.Default.UsesName;
            txt_passwordlogin.Text = Properties.Settings.Default.Password;
            ckb_nho.Checked = Properties.Settings.Default.Remember;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tim tai khoản
            var user = db.Admins.SingleOrDefault(x => x.UserName.Equals(txt_namelogin.Text) && x.Passwords.Equals(txt_passwordlogin.Text) && x.Status == false);
            // kiêm tra
            if (user != null) // tim thấy
            {
                MessageBox.Show("Đăng nhập thành công!", "hệ thống",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                frmLogin.UserName = user.UserName;
                if (ckb_nho.Checked)
                {
                    Properties.Settings.Default.UsesName = txt_namelogin.Text;
                    Properties.Settings.Default.Password = txt_passwordlogin.Text;
                    Properties.Settings.Default.Remember = ckb_nho.Checked;
                }
                else
                {
                    Properties.Settings.Default.UsesName = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Remember = false;
                }
                Properties.Settings.Default.Save();
                frmMain frm = new frmMain();
                frm.Dock = DockStyle.Fill;
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không chính xác!", "hệ thống");
                //txt_namelogin.Text = txt_passwordlogin.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            txt_namelogin.Text = txt_passwordlogin.Text = "";
        }
    }
}
