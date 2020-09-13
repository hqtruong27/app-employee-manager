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
    public partial class Đangky : Form
    {
        // khoi tao ket noi
        EmployeeManagerDataContext db = new EmployeeManagerDataContext()
        bool edit = false;

        public Đangky()
        {
            InitializeComponent();

        }
        private void Đangky_Load(object sender, EventArgs e)
        {
            Load_Users();
        }

        private void Load_Users()
        {
            dgv_users.DataSource = (from u in _ctx.Users
                                    select new
                                    {
                                        id = u.id,
                                        name = u.name,
                                        email = u.email,
                                        phone = u.phone,
                                        password = u.password,
                                        address = u.address,
                                        birthday = u.birthday,
                                        gender = (bool)u.gender ? "Nam" : "Nữ"

                                    }).ToList();
            txt_ma.ReadOnly = true;
        }

        private void dgv_users_SelectionChanged(object sender, EventArgs e)
        {
            Details_Users();

        }
        private void Details_Users()
        {
            // kiem tra len view
            if (dgv_users.CurrentCell != null)
            {
                var row = dgv_users.CurrentRow;
                txt_ma.Text = row.Cells["id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                txt_phone.Text = row.Cells["phone"].Value.ToString();
                txt_password.Text = row.Cells["password"].Value.ToString();
                txt_address.Text = row.Cells["address"].Value.ToString();

                rdo_nu.Checked = true;
                rdo_nam.Checked = row.Cells["gioitinh"].Value.ToString() == "Nam" ? true : false;
                txt_brithday.Value = Convert.ToDateTime(row.Cells["brithday"].Value.ToString());
                edit = true;
                txt_ma.ReadOnly = false;


            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            txt_ma.Text = txt_name.Text = txt_email.Text = txt_phone.Text = txt_password.Text = txt_address.Text = "";
            edit = false;
            txt_ma.ReadOnly = true;



        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                var _u = (from u in _ctx.Users where u.id == int.Parse(txt_ma.Text) select u).FirstOrDefault();
                //cập nhật thông tin
                _u.name = txt_name.Text;
                _u.email = txt_email.Text;
                _u.phone = txt_phone.Text;
                _u.password = txt_password.Text;
                _u.address = txt_address.Text;
                _u.gender = rdo_nam.Checked ? true : false;
                _u.birthday = txt_brithday.Value;
                //lưu
                _ctx.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                bool success = true;
                if (success)
                {
                    
                    txt_ma.Text = txt_name.Text = txt_email.Text = txt_phone.Text = txt_password.Text = txt_address.Text = "";
                    MessageBox.Show("Không được để trông");
                   
                }
                else
                {
                    User u = new User();
                    u.name = txt_name.Text;
                    u.email = txt_email.Text;
                    u.phone = txt_phone.Text;
                    u.password = txt_password.Text;
                    u.address = txt_address.Text;
                    u.gender = rdo_nam.Checked ? true : false;
                    u.birthday = txt_brithday.Value;
                    // thêm vào bảng
                    _ctx.Users.InsertOnSubmit(u);
                    //LƯU
                    _ctx.SubmitChanges();
                    MessageBox.Show("Thêm mới thành công!");

                }

            }

            //tìm bản ghi cần sửa

            Load_Users();


        }


        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var _u = (from u in _ctx.Users where u.id == int.Parse(txt_ma.Text) select u).FirstOrDefault();
                // xoá
                _ctx.Users.DeleteOnSubmit(_u);
                //lưu
                _ctx.SubmitChanges();
                Load_Users();

            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không!", "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();

            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Details_Users();
        }

        private void Đangky_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi không", "hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //OK THOÁT

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Đangky_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void txt_email_Leave(object sender, EventArgs e)
        {
            string email = (@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (Regex.IsMatch(txt_email.Text, email))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_email, "Nhập lại email của bạn");
                MessageBox.Show("Nhập lại email của bạn");
                return;
            }
        }

        private void txt_phone_Validated(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"^(01[2689]|09)[0-9]{8}$");
            if (phoneNumpattern.IsMatch(txt_phone.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
                txt_phone.Text = "";
            }
        }

        private void txt_name_Validated(object sender, EventArgs e)
        {
            if(txt_name.TextLength >= 6 &&  txt_name.TextLength<=12)
            {
                MessageBox.Show("đúng");
            }
            else
            {
                MessageBox.Show("Tên tư 6 đen 12 kí tự");
                 txt_ma.Text = txt_name.Text = txt_email.Text = txt_phone.Text = txt_password.Text = txt_address.Text = "";
            }
        }

       
    }
}
