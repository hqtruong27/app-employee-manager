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
    public partial class frmPosition : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        bool edit = false;

        public frmPosition()
        {
            InitializeComponent();
        }

        private void Detail_Position()
        {
            if (dgv_Position.CurrentRow != null)
            {
                var row = dgv_Position.CurrentRow;
                txt_id.Text = row.Cells["id"].Value.ToString();
                txt_name.Text = row.Cells["name"].Value.ToString();
                rdo_ẩn.Checked = true;
                rdo_hien.Checked = row.Cells["Status"].Value.ToString() == "Hiện" ? true : false;
                txt_id.ReadOnly = true;
            }
            else
            {
                txt_id.Text = txt_name.Text = "";
            }
        }

        private void Load_Position()
        {
            dgv_Position.DataSource = (from p in db.Positions
                                       select new
                                       {
                                           PositionId = p.PositionId,
                                           PositionName = p.PositionName,
                                           Status = (bool)p.Status ? "Ẩn" : "Hiện"
                                       }).ToList();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Cập nhật thất bại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            } 
            else
            {
                var model = db.Positions.SingleOrDefault(o => o.PositionId == int.Parse(txt_id.Text));
                var model_name_exist = db.Positions.SingleOrDefault(o => o.PositionName == txt_name.Text && o.PositionId != int.Parse(txt_id.Text));
                if (model_name_exist != null)
                {
                    MessageBox.Show("Tên chức vụ đã tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else
                {
                    if (edit)
                    {
                        model.PositionName = txt_name.Text;
                        if (rdo_hien.Checked)
                        {
                            model.Status = false;
                        }
                        else
                        {
                            model.Status = true;
                        }
                        db.SubmitChanges();
                        MessageBox.Show("Cập Nhật Thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Load_Position();
                        txt_id.Text = txt_name.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được phép thêm thông tin!!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            Load_Position();
            rdo_hien.Checked = true;
            txt_id.ReadOnly = true;
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                lblPosition.Text = "Tên chức vụ không được để trống !!";
                lblPosition.ForeColor = Color.Red;
            }
            else
            {
                var model = db.Positions.SingleOrDefault(o => o.PositionName == txt_name.Text);
                if (model != null)
                {
                    lblPosition.Text = "Tên chức vụ đã tồn tại !!";
                    lblPosition.ForeColor = Color.Red;
                }
                else
                {
                    if (!edit)
                    {
                        Position p = new Position();
                        p.PositionName = txt_name.Text;
                        p.Status = false;
                        // thêm vào bảng
                        db.Positions.InsertOnSubmit(p);
                        //lưu lại
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Position();
                        txt_id.Text = txt_name.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bạn không được phép sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

            }
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_id.Text = txt_name.Text = "";
            edit = false;
        }
        private void dgv_Position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Detail_Position();
            edit = true;
        }
    }
}
