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
    public partial class frmEmployee : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        bool edit = false;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            Load_Employee();
            load_cbo_Department();
            load_cbo_Position();
            rdoMale.Checked = true;
            refresh();

        }

        private void Load_Employee()
        {
            dgvEmployee.DataSource = (from em in db.Employees
                                      select new
                                      {
                                          EmployeeId = em.EmployeeId,
                                          EmployeeName = em.EmployeeName,
                                          Email = em.Email,
                                          Phone = em.Phone,
                                          Address = em.Address,
                                          BirthDay = em.BirthDay,
                                          identitycardnumber = em.identitycardnumber,
                                          Gender = (bool)em.Gender ? "Nam" : "Nữ",
                                          Department = em.Department.DepartmentName,
                                          Position = em.Position.PositionName,
                                          Status = (bool)em.Status ? "Ẩn" : "Hiện",
                                      }).ToList();
            

        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAdress.Text == "")
            {
                MessageBox.Show("vui lòng điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!edit)
                {
                    var email = db.Employees.SingleOrDefault(em => em.Email == txtEmail.Text);
                    var phone = db.Employees.SingleOrDefault(p => p.Phone == txtPhone.Text);
                    var CMND = db.Employees.SingleOrDefault(c => c.identitycardnumber == txtCmnd.Text);
                    if (email != null)
                    {
                        lblResultEmail.Text = "✘ Email này đã tồn tại vui lòng nhập Email khác !";
                        lblResultEmail.ForeColor = Color.Red;
                        txtEmail.Focus();
                    }
                    else if (phone != null)
                    {
                        lblResultPhone.Text = "✘ Số điện thoại đã tồn tại !!";
                        lblResultPhone.ForeColor = Color.Red;
                        txtPhone.Focus();
                    }
                    else if (CMND != null)
                    {
                        lblResultcmnd.Text = "✘ Chứng minh nhân dân đã tồn tại !!";
                        lblResultcmnd.ForeColor = Color.Red;
                        txtPhone.Focus();
                    }
                    else
                    {
                        Regex regex = new Regex(@"^(08|09|03|07)[0-9]{8}$");
                        Regex regexCmnd = new Regex(@"^[0-9]{9,12}$");
                        Regex regexEmail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                        if (!regex.IsMatch(txtPhone.Text))
                        {
                            lblResultPhone.Text = "✘ Số điện thoại không đúng định dạng";
                            lblResultPhone.ForeColor = Color.Red;
                            return;
                        }
                        if (!regexEmail.IsMatch(txtEmail.Text))
                        {
                            lblResultEmail.Text = "✘ Email không đúng định dạng";
                            lblResultEmail.ForeColor = Color.Red;
                            return;
                        }
                        if (!regexCmnd.IsMatch(txtCmnd.Text))
                        {
                            lblResultcmnd.Text = "✘ CMND không đúng định dạng";
                            lblResultcmnd.ForeColor = Color.Red;
                            return;
                        }
                        else
                        {
                            Employee employee = new Employee();
                            employee.EmployeeName = txtName.Text;
                            employee.Email = txtEmail.Text;
                            employee.Phone = txtPhone.Text;
                            employee.Address = txtAdress.Text;
                            employee.BirthDay = txtBirthday.Value;
                            employee.identitycardnumber = txtCmnd.Text;
                            employee.Gender = rdoMale.Checked ? true : false;
                            employee.PositionId = int.Parse(cboPosition.SelectedValue.ToString());
                            employee.DepartmentId = int.Parse(cboDepartment.SelectedValue.ToString());
                            employee.Status = false;
                            //them vao bang

                            db.Employees.InsertOnSubmit(employee);
                            //luw lai
                            db.SubmitChanges();
                            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_Employee();
                            refresh();
                            lblResultcmnd.Text = lblResultEmail.Text = lblResultPhone.Text = "";
                            var query = db.Employees.OrderByDescending(em => em.EmployeeId).First();
                            /////////////////////////////////////
                            ///n
                            if ( frmSalary.salaryEntities.Count > 0)
                            {
                                salaryEntity s = new salaryEntity();
                                s.EmployeeId = query.EmployeeId;
                                s.EmployeeName = query.EmployeeName;
                                s.Gender = query.Gender == true ? "Nam" : "Nữ";
                                s.Department = query.Department.DepartmentName;
                                s.Position = query.Position.PositionName;
                                s.PublicDay = 0;
                                s.SalaryBasic = (float)db.Salaries.FirstOrDefault(sa => sa.Position == int.Parse(cboPosition.SelectedValue.ToString())).BasicSalary;
                                s.Salary = 0;
                                frmSalary.salaryEntities.Add(s);
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Bạn chỉ được phép sửa thông tin không được thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void detail_Employee()
        {

            if (dgvEmployee.CurrentRow != null)
            {
                var row = dgvEmployee.CurrentRow;
                txtId.Text = row.Cells["EmployeeId"].Value.ToString();
                txtName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAdress.Text = row.Cells["Address"].Value.ToString();
                txtBirthday.Value = Convert.ToDateTime(row.Cells["BirthDay"].Value.ToString());
                txtCmnd.Text = row.Cells["identitycardnumber"].Value.ToString();
                rdoFamale.Checked = true;
                rdoMale.Checked = row.Cells["Gender"].Value.ToString() == "Nam" ? true : false;
                cboPosition.Text = row.Cells["Position"].Value.ToString();
                cboDepartment.Text = row.Cells["Department"].Value.ToString();

            }
            else
            {
                txtId.Text = txtName.Text = txtBirthday.Text = txtCmnd.Text = txtPhone.Text = txtAdress.Text = txtEmail.Text = "";
            }
        }
        private void load_cbo_Department()
        {
            var cQuery = from cbo in db.Departments
                         where cbo.Status == false
                         select new {
                             DepartmentId = cbo.DepartmentId,
                             DepartmentName = cbo.DepartmentName
                         };
            cboDepartment.DataSource = cQuery;
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentId";

        }
        private void load_cbo_Position()
        {
            var query = from s in db.Salaries join
                        p in db.Positions on s.Position equals p.PositionId where p.Status == false
                        select new {
                            PositionId = p.PositionId,
                            PositionName = p.PositionName
                        };
            cboPosition.DataSource = query;
            cboPosition.DisplayMember = "PositionName";
            cboPosition.ValueMember = "PositionId";
        }
        private void refresh()
        {
            Load_Employee();
            txtId.Text = txtName.Text = txtBirthday.Text = txtCmnd.Text = txtPhone.Text = txtAdress.Text = txtEmail.Text = "";
            //cboDepartment.SelectedIndex = 2;
            //cboPosition.SelectedIndex = 2;



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            edit = false;
            this.txtName.Focus();
            refresh();
            
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Cập Nhật Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var model = db.Employees.SingleOrDefault(o => o.EmployeeId == int.Parse(txtId.Text));
                if (txtName.Text == "" || txtEmail.Text == "" || txtCmnd.Text == "" || txtPhone.Text == "" || txtAdress.Text == "")
                {
                    MessageBox.Show("vui lòng điền đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    if (edit)
                    {
                        Regex regex = new Regex(@"^(08|09|03|07)[0-9]{8}$");
                        Regex regexCmnd = new Regex(@"^[0-9]{9,12}$");
                        Regex regexEmail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                        if (!regex.IsMatch(txtPhone.Text))
                        {
                            lblResultPhone.Text = "✘ Số điện thoại không đúng định dạng";
                            lblResultPhone.ForeColor = Color.Red;
                            return;
                        }
                        if (!regexEmail.IsMatch(txtEmail.Text))
                        {
                            lblResultEmail.Text = "✘ Email không đúng định dạng";
                            lblResultEmail.ForeColor = Color.Red;
                            return;
                        }
                        if (!regexCmnd.IsMatch(txtCmnd.Text))
                        {
                            lblResultcmnd.Text = "✘ CMND không đúng định dạng";
                            lblResultcmnd.ForeColor = Color.Red;
                            return;
                        }
                        else
                        {
                            model.EmployeeName = txtName.Text;
                            model.Email = txtEmail.Text;
                            model.Phone = txtPhone.Text;
                            model.Address = txtAdress.Text;
                            model.BirthDay = txtBirthday.Value;
                            model.identitycardnumber = txtCmnd.Text;
                            model.Gender = rdoMale.Checked ? true : false;
                            model.PositionId = int.Parse(cboPosition.SelectedValue.ToString());
                            model.DepartmentId = int.Parse(cboDepartment.SelectedValue.ToString());
                            //model.Status = false;
                            db.SubmitChanges();
                            Load_Employee();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                            lblResultcmnd.Text = lblResultEmail.Text = lblResultPhone.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chỉ được phép sửa thông tin không được thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                Load_Employee();
            }
            else
            {
                var query = db.Employees.Where(x => x.EmployeeName.Contains(txt_search.Text)).Select(em => new
                {
                    EmployeeId = em.EmployeeId,
                    EmployeeName = em.EmployeeName,
                    Email = em.Email,
                    Phone = em.Phone,
                    Address = em.Address,
                    BirthDay = em.BirthDay,
                    identitycardnumber = em.identitycardnumber,
                    Gender = (bool)em.Gender ? "Nam" : "Nữ",
                    Department = em.Department.DepartmentName,
                    Position = em.Position.PositionName,
                    Status = (bool)em.Status ? "Ẩn" : "Hiện",
                });

                dgvEmployee.DataSource = query.ToList();

            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            detail_Employee();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên này không không", "Hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var model = db.Employees.SingleOrDefault(o => o.EmployeeId == int.Parse(txtId.Text));
                db.Employees.DeleteOnSubmit(model);
                db.SubmitChanges();
                MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_Employee();
                refresh();
            }

        }

        //Regex

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex regexEmail = new Regex("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$");
            if (txtEmail.Text == "")
            {
                lblResultEmail.Text = "";
                return;
            }
            if (!regexEmail.IsMatch(txtEmail.Text))
            {
                lblResultEmail.Text = "✘ Email không đúng định dạng";
                lblResultEmail.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResultEmail.Text = "✔";
                lblResultEmail.ForeColor = Color.Green;
            }
        }

        private void txtCmnd_TextChanged(object sender, EventArgs e)
        {
            if (txtCmnd.Text == "")
            {
                lblResultcmnd.Text = "";
                return;
            }
            Regex regexCmnd = new Regex(@"^[0-9]{9,12}$");
            if (!regexCmnd.IsMatch(txtCmnd.Text))
            {
                lblResultcmnd.Text = "✘ CMND không đúng định dạng";
                lblResultcmnd.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResultcmnd.Text = "✔";
                lblResultcmnd.ForeColor = Color.Green;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                lblResultPhone.Text = "";
                return;
            }
            Regex regex = new Regex(@"^(08|09|03|07)[0-9]{8}$");
            if (!regex.IsMatch(txtPhone.Text))
            {
                lblResultPhone.Text = "✘ Số điện thoại không đúng định dạng";
                lblResultPhone.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResultPhone.Text = "✔";
                lblResultPhone.ForeColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$");
            if (reg.IsMatch(txtName.Text))
            {
                lblFullName.Text = "✔";
                lblFullName.ForeColor = Color.Green;
            }
            else
            {
                lblFullName.Text = "✘";
                lblFullName.ForeColor = Color.Red;
                return;
            }
        }
    }
}
