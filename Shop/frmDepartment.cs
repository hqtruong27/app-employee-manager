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
    public partial class frmDepartment : Form
    {

        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        bool edit = false;
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            load_Department();
            rdo_hien.Checked = true;
            txt_id.ReadOnly = true;

        }

        private void load_Department()
        {
            dgv_Department.DataSource = (from d in db.Departments
                                         select new
                                         {
                                             DepartmentId = d.DepartmentId,
                                             DepartmentName = d.DepartmentName,
                                             Status = (bool)d.Status ? "Ẩn" : "Hiện"
                                         }).ToList();

        }

        private void detail_Department()
        {
            if (dgv_Department.CurrentRow != null)
            {
                var row = dgv_Department.CurrentRow;
                txt_id.Text = row.Cells["id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                rdo_an.Checked = true;
                rdo_hien.Checked = row.Cells["Status"].Value.ToString() == "Hiện" ? true : false;
                txt_id.ReadOnly = true;
            }

        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            var model = db.Departments.SingleOrDefault(x => x.DepartmentName.Equals(txt_name.Text));
            if (model != null)
            {
                lblDepartment.Text = "Tên phòng ban đã tồn tại !! ";
                lblDepartment.ForeColor = Color.Red;
            }
            else
            {
                if (txt_name.Text == "")
                {
                    lblDepartment.Text = "Tên phòng ban không được để trống !! ";
                    lblDepartment.ForeColor = Color.Red;
                }
                else
                {
                    if (!edit)
                    {
                        Department d = new Department();
                        d.DepartmentName = txt_name.Text;
                        d.Status = false;
                        // thêm vào bảng
                        db.Departments.InsertOnSubmit(d);
                        //LƯU
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Department();
                        txt_id.Text = txt_name.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Bạn chỉ được sửa thông tin không được thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Cập Nhật Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                var model = db.Departments.SingleOrDefault(o => o.DepartmentId == int.Parse(txt_id.Text));
                var model_exit = db.Departments.SingleOrDefault(a => a.DepartmentName == txt_name.Text && a.DepartmentId != int.Parse(txt_id.Text));
                if (model_exit != null)
                {
                    lblDepartment.Text = "Tên phòng ban đã tồn tại !! ";
                    lblDepartment.ForeColor = Color.Red;
                }
                else
                {
                    if (edit)
                    {
                        model.DepartmentName = txt_name.Text;
                        if (rdo_an.Checked)
                        {
                            model.Status = true;
                        }
                        else
                        {
                            model.Status = false;
                        }
                        db.SubmitChanges();
                        load_Department();
                        txt_id.Text = txt_name.Text = "";
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bạn chỉ được thêm mới thông tin không được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_id.Text = txt_name.Text = "";
            edit = false;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Xóa Không", "Hệ Thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var d = (from deparment in db.Departments where deparment.DepartmentId == int.Parse(txt_id.Text) select deparment).FirstOrDefault();
                d.Status = true;
                db.SubmitChanges();
                load_Department();
            }
        }
        private void dgv_Department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detail_Department();
            edit = true;
        }

    }
}
