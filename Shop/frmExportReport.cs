using Shop.Export;

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
    public partial class frmExportReport : Form
    {
        EmployeeManagerDataContext db = new EmployeeManagerDataContext();
        public frmExportReport()
        {
            InitializeComponent();
        }

        private void frmExportReport_Load(object sender, EventArgs e)
        {
            // tạo mẫu báo cáo
            CrystalReportEmployee rpt = new CrystalReportEmployee();
            // đưa dư liêu lên báo cáo
            rpt.SetDataSource(frmSalary.salaryEntities);
            // dua vao báo cao
            crystalReportViewer1.ReportSource = rpt;
            // hien thi
            crystalReportViewer1.Show();

        }
    }
}
