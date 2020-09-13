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
    public partial class frmSalary : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        public static List<salaryEntity> salaryEntities = new List<salaryEntity>();
        public frmSalary()
        {
            InitializeComponent();
        }
        private void loadSalary()
        {
            var list = (from em in db.Employees
                        select new
                        {
                            EmployeeId = em.EmployeeId,
                            EmployeeName = em.EmployeeName,
                            Gender = (bool)em.Gender ? "Nam" : "Nữ",
                            Department = em.Department.DepartmentName,
                            Position = em.Position.PositionName,
                            publicDay = 0,
                            SalaryBasic = db.Salaries.SingleOrDefault(s => s.Position == em.PositionId).BasicSalary,
                            Salary = 0
                        }).ToList();
            if (salaryEntities.Count == 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    salaryEntity s = new salaryEntity();
                    s.EmployeeId = list[i].EmployeeId;
                    s.EmployeeName = list[i].EmployeeName;
                    s.Gender = list[i].Gender;
                    s.Department = list[i].Department;
                    s.Position = list[i].Position;
                    s.PublicDay = list[i].publicDay;
                    s.SalaryBasic = (int)list[i].SalaryBasic;
                    s.Salary = list[i].Salary;
                    salaryEntities.Add(s);
                }
                dgvSalary.DataSource = salaryEntities;
            }
            else
            {
                dgvSalary.DataSource = salaryEntities;
            }

        }
        private void frmSalary_Load(object sender, EventArgs e)
        {
            loadSalary();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex checkdate = new Regex("^[0-9]{1,2}$");
            if (!checkdate.IsMatch(txtSNC.Text))
            {
                txtSNC.BackColor = Color.LightPink;
                Nh.Text = "Vui lòng nhập đúng định dạng";
                Nh.ForeColor = Color.Red;
            }
            else
            {
                var current = dgvSalary.CurrentRow;
                current.Cells["publicDay"].Value = txtSNC.Text;
                int salaryB = int.Parse(current.Cells["SalaryBasic"].Value + "");
                current.Cells["Salary"].Value = int.Parse(txtSNC.Text) * salaryB;
                for (int i = 0; i < salaryEntities.Count; i++)
                {
                    if ((int)current.Cells["EmployeeId"].Value == salaryEntities[i].EmployeeId)
                    {
                        salaryEntities[i].PublicDay = int.Parse(txtSNC.Text);
                        if (salaryEntities[i].Position.Equals("Giám Đốc"))
                        {
                            salaryEntities[i].Salary = int.Parse(txtSNC.Text) * salaryB / 30 + 300000;
                        }
                        else if (salaryEntities[i].Position.Equals("Trưởng Phòng"))
                        {
                            salaryEntities[i].Salary = int.Parse(txtSNC.Text) * salaryB / 30 + 200000;
                        }
                        else if (salaryEntities[i].Position.Equals("Nhân Viên"))
                        {
                            salaryEntities[i].Salary = int.Parse(txtSNC.Text) * salaryB / 30 + 100000;
                        }
                        else
                        {
                            salaryEntities[i].Salary = int.Parse(txtSNC.Text) * salaryB / 30;
                        }
                    }
                }
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            frmExportReport frm = new frmExportReport();
            frm.Show();
        }

        private void txtSNC_TextChanged(object sender, EventArgs e)
        {
            txtSNC.BackColor = Color.White;
            Nh.Text = "Nhập vào số ngày công";
            Nh.ForeColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                loadSalary();
            }
            else
            {
                var query = db.Employees.Where(x => x.EmployeeName.Contains(txt_search.Text)).Select(em => new
                {
                    EmployeeId = em.EmployeeId,
                    EmployeeName = em.EmployeeName,
                    Gender = (bool)em.Gender ? "Nam" : "Nữ",
                    Department = em.Department.DepartmentName,
                    Position = em.Position.PositionName,
                    publicDay = 0,
                    SalaryBasic = db.Salaries.SingleOrDefault(s => s.Position == em.PositionId).BasicSalary,
                    Salary = 0
                });
                dgvSalary.DataSource = query.ToList();

            }
        }
    }
}
