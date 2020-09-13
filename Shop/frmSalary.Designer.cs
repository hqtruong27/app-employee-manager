namespace Shop
{
    partial class frmSalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryBasic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txtSNC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.Nh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToAddRows = false;
            this.dgvSalary.AllowUserToDeleteRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Gender,
            this.Department,
            this.Position,
            this.publicDay,
            this.SalaryBasic,
            this.Salary});
            this.dgvSalary.Location = new System.Drawing.Point(27, 135);
            this.dgvSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowTemplate.Height = 24;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(1207, 527);
            this.dgvSalary.TabIndex = 7;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Mã NV";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Họ Tên";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Phòng Ban";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Chức Vụ";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // publicDay
            // 
            this.publicDay.DataPropertyName = "publicDay";
            this.publicDay.HeaderText = "Ngày công";
            this.publicDay.Name = "publicDay";
            this.publicDay.ReadOnly = true;
            // 
            // SalaryBasic
            // 
            this.SalaryBasic.DataPropertyName = "SalaryBasic";
            this.SalaryBasic.HeaderText = "Lương Cơ Bản";
            this.SalaryBasic.Name = "SalaryBasic";
            this.SalaryBasic.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Lương";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Shop.Employee);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bảng Lương Nhân Viên";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1149, 98);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(923, 100);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(199, 22);
            this.txt_search.TabIndex = 9;
            // 
            // txtSNC
            // 
            this.txtSNC.Location = new System.Drawing.Point(27, 106);
            this.txtSNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSNC.Name = "txtSNC";
            this.txtSNC.Size = new System.Drawing.Size(199, 22);
            this.txtSNC.TabIndex = 9;
            this.txtSNC.TextChanged += new System.EventHandler(this.txtSNC_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(635, 100);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(100, 28);
            this.btn_preview.TabIndex = 11;
            this.btn_preview.Text = "Xem trước";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(777, 100);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 28);
            this.btn_export.TabIndex = 12;
            this.btn_export.Text = "xuất file";
            this.btn_export.UseVisualStyleBackColor = true;
            // 
            // Nh
            // 
            this.Nh.AutoSize = true;
            this.Nh.Location = new System.Drawing.Point(24, 81);
            this.Nh.Name = "Nh";
            this.Nh.Size = new System.Drawing.Size(158, 17);
            this.Nh.TabIndex = 13;
            this.Nh.Text = "Nhập vào số ngày công";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.Nh);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSNC);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSalary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSalary";
            this.Text = "frmSalary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txtSNC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label Nh;
    }
}