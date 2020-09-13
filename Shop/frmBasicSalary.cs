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
    public partial class frmBasicSalary : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        public frmBasicSalary()
        {
            InitializeComponent();
        }
        private void Load_BasicSalary()
        {
            dgvBasicSalary.DataSource = (from em in db.Salaries join sb in db.Positions on em.SalaryId equals sb.PositionId where sb.Status == false
                                         select new
                                         {
                                             SalaryId = em.SalaryId,
                                             BasicSalary = em.BasicSalary,
                                             Position = em.Position1.PositionName
                                         }).ToList();
        }
        private void load_cbo()
        {
            var query = from sb in db.Positions
                        where sb.Status == false
                        select new {
                            positionid = sb.PositionId,
                            positionName = sb.PositionName
                        };
            comboBox1.DataSource = query;
            comboBox1.DisplayMember = "PositionName";
            comboBox1.ValueMember = "PositionId";


        }
        private void frmBasicSalary_Load(object sender, EventArgs e)
        {
            load_cbo();
            Load_BasicSalary();
        }
        private void deltailSalary()
        {
            if (dgvBasicSalary.CurrentRow != null)
            {
                var row = dgvBasicSalary.CurrentRow;
                comboBox1.Text = row.Cells["Position"].Value.ToString();
                txt_Id.Text = row.Cells["SalaryId"].Value.ToString();
                txt_Salary.Text = row.Cells["BasicSalary"].Value.ToString();
            }
        }

        private void dgvBasicSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deltailSalary();
        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            if (txt_Salary.Text == "")
            {
                MessageBox.Show("Lương cơ bản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var nameLBS = db.Salaries.SingleOrDefault(l => l.Position == int.Parse(comboBox1.SelectedValue+""));
                if (nameLBS != null)
                {
                    lblChucVu.Text = "✘ Chức vụ này đã có lương cơ bản";
                    lblChucVu.ForeColor = Color.Red;
                }
                else
                {
                Salary s = new Salary();
                s.BasicSalary = double.Parse(txt_Salary.Text);
                s.Position = int.Parse(comboBox1.SelectedValue.ToString());
                db.Salaries.InsertOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_BasicSalary();
                lblChucVu.Text = "";
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if( txt_Id.Text == "")
            {
                MessageBox.Show("Cập nhập thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            else
            {
                if(txt_Salary.Text == "")
                {
                    lblChucVu.Text = "⚠  Vui lòng nhập Lương Cơ bản";
                    lblChucVu.ForeColor = Color.Purple;
                    return;
                }
                var udSalary = db.Salaries.SingleOrDefault(o => o.SalaryId == int.Parse(txt_Id.Text));
                udSalary.BasicSalary = double.Parse(txt_Salary.Text);
                db.SubmitChanges();
                Load_BasicSalary();
                txt_Salary.Text = "";
                MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_Salary.Text = txt_Id.Text = "";
            comboBox1.SelectedIndex = 1;
        }
    }
}
