using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class frmAdmin : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        bool edit = false;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Load_Admin();
            rdo_hoatdong.Checked = true;
            var _name = db.Admins.SingleOrDefault(x => x.UserName.Equals(frmLogin.UserName)).FullName;
            lblAdmin.Text = "" + _name;
            lblAdmin.ForeColor = Color.Purple;
        }

        private void Load_Admin()
        {
            dgv_admin.DataSource = (from u in db.Admins
                                    where u.GroupName == false
                                    select new
                                    {
                                        Id = u.Id,
                                        UserName = u.UserName,
                                        Passwords = u.Passwords,
                                        FullName = u.FullName,
                                        Status = (bool)u.Status ? "Đã Bị Khóa" : "Hoạt Động",
                                    }).ToList();
            txt_id.Text = txt_UserName.Text = txt_FullName.Text = txt_password.Text = "";

        }
        private void detail_admin()
        {
            if (dgv_admin.CurrentRow != null)
            {
                var row = dgv_admin.CurrentRow;
                txt_id.Text = row.Cells["Id"].Value.ToString();
                txt_UserName.Text = row.Cells["UserName"].Value.ToString();
                txt_password.Text = row.Cells["Password"].Value.ToString();
                txt_FullName.Text = row.Cells["Fullname"].Value.ToString();
                rdo_bikhoa.Checked = true;
                rdo_hoatdong.Checked = row.Cells["Status"].Value.ToString() == "Hoạt Động" ? true : false;
                txt_id.ReadOnly = true;

            }
            else
            {
                refresh();
                rdo_hoatdong.Checked = false;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text == "")
            {
                lblUserName.Text = "✘ Tên Không Được Để Trống!";
                lblUserName.ForeColor = Color.Red;
                return;
            }
            if (txt_password.Text == "")
            {
                lblPassword.Text = "✘ Tên Không Được Để Trống!";
                lblPassword.ForeColor = Color.Red;
                return;
            }if (txt_checkpassswordagain.Text == "")
            {
                lblCheckPassword.Text = "✘ Tên Không Được Để Trống!";
                lblCheckPassword.ForeColor = Color.Red;
                return;
            }
            if (txt_FullName.Text == "")
            {
                lblName.Text = "✘ Họ và Tên Không Được Để Trống!";
                lblName.ForeColor = Color.Red;
                return;
            }
            else
            {
                var m = db.Admins.SingleOrDefault(x => x.UserName.Equals(txt_UserName.Text));
                if (m != null)
                {
                    MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_id.Text = txt_UserName.Text = txt_FullName.Text = txt_password.Text = "";
                }
                else
                {
                    if (!edit)
                    {

                        Admin a = new Admin();
                        if (txt_password.Text == txt_checkpassswordagain.Text)
                        {

                            a.UserName = txt_UserName.Text;
                            a.Passwords = txt_password.Text;
                            a.Checkpasswordagain = txt_checkpassswordagain.Text;
                            a.GroupName = false;
                            a.FullName = txt_FullName.Text;
                            a.Status = false;
                            // thêm vào bảng
                            db.Admins.InsertOnSubmit(a);
                            //LƯU
                            db.SubmitChanges();
                            MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_Admin();
                        }
                        //else
                        //{
                        //    lblCheckPassword.Text = "✘ Mật khẩu không khớp !!";
                        //    txt_checkpassswordagain.Focus();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được thêm mới thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            else
            {
                var model = db.Admins.SingleOrDefault(o => o.Id == int.Parse(txt_id.Text));
                var model_name_exist = db.Admins.SingleOrDefault(o => o.UserName == txt_UserName.Text && o.Id != int.Parse(txt_id.Text));
                if (model_name_exist != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                }
                else
                {
                    if (edit)
                    {

                        if (txt_password.Text == txt_checkpassswordagain.Text)
                        {

                            model.Passwords = txt_password.Text;
                            model.Checkpasswordagain = txt_checkpassswordagain.Text;
                            if (rdo_hoatdong.Checked)
                            {
                                model.Status = false;
                            }
                            else
                            {
                                model.Status = true;
                            }
                            db.SubmitChanges();
                            MessageBox.Show("Cập Nhật Thành công!");
                            refresh();

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không khớp.Vui lòng nhập lại");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được cập nhật thông tin mới");

                    }

                }
            }
            Load_Admin();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            refresh();
            edit = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dgv_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detail_admin();
            edit = true;
            txt_UserName.ReadOnly = true;

        }

        private void refresh()
        {
            txt_id.Text = txt_UserName.Text = txt_FullName.Text = txt_password.Text = txt_checkpassswordagain.Text = "";
            rdo_hoatdong.Checked = true;
            edit = false;
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                lblUserName.Text = "✘ Tên Không Được Để Trống!";
                return;
            }
            if (txt_UserName.TextLength < 3)
            {
                lblUserName.Text = "✘ Tên đăng nhập phải có ít nhất 3 ký tự";
                return;
            }
            Regex _regex = new Regex("^[a-z0-9_-]{3,15}$");
            if (_regex.IsMatch(txt_UserName.Text))
            {
                lblUserName.Text = "✔";
                lblUserName.ForeColor = Color.Green;
            }
            else
            {
                lblUserName.Text = "✘ Tên đăng nhập không đúng định dạng !";
                lblUserName.ForeColor = Color.Red;
                return;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
             if (txt_password.TextLength < 6)
            {
                lblPassword.Text = "✘ Mật khẩu phải có ít nhất 6 kí tự";
                lblPassword.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblPassword.Text = "✔";
                lblPassword.ForeColor = Color.Green;

            }
            if (txt_password.Text.Equals(txt_checkpassswordagain.Text))
            {
                lblCheckPassword.Text = "✔";
                lblCheckPassword.ForeColor = Color.Green;
            }
            else
            {
                lblCheckPassword.Text = "✘";
                lblCheckPassword.ForeColor = Color.Red;
                return;
            }
        }

        private void txt_checkpassswordagain_TextChanged(object sender, EventArgs e)
        {
            if(txt_password.Text != txt_checkpassswordagain.Text)
            {
                lblCheckPassword.Text = "✘ Mật khẩu không khớp !!";
                lblCheckPassword.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblCheckPassword.Text = "✔";
                lblCheckPassword.ForeColor = Color.Green;
            }
        }

        private void txt_FullName_TextChanged(object sender, EventArgs e)
        {
            
            Regex reg = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            if (reg.IsMatch(txt_FullName.Text))
            {
                lblName.Text = "✔";
                lblName.ForeColor = Color.Green;
            }
            else
            {
                lblName.Text = "✘";
                lblName.ForeColor = Color.Red;
                return;
            }
        }
    }

}
