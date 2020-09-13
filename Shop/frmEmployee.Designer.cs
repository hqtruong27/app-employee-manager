namespace Shop
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFamale = new System.Windows.Forms.RadioButton();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identitycardnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.lblResultEmail = new System.Windows.Forms.Label();
            this.lblResultPhone = new System.Windows.Forms.Label();
            this.lblResultcmnd = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(176, 79);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(199, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 137);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(560, 193);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 22);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(77, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(461, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(852, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phòng Ban";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(852, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(461, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(461, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "CMND";
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(949, 78);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(199, 24);
            this.cboDepartment.TabIndex = 2;
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(949, 135);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(199, 24);
            this.cboPosition.TabIndex = 2;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(560, 82);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 21);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFamale
            // 
            this.rdoFamale.AutoSize = true;
            this.rdoFamale.Location = new System.Drawing.Point(645, 82);
            this.rdoFamale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFamale.Name = "rdoFamale";
            this.rdoFamale.Size = new System.Drawing.Size(47, 21);
            this.rdoFamale.TabIndex = 4;
            this.rdoFamale.TabStop = true;
            this.rdoFamale.Text = "Nữ";
            this.rdoFamale.UseVisualStyleBackColor = true;
            // 
            // txtBirthday
            // 
            this.txtBirthday.CustomFormat = "dd/MM/yyyy";
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBirthday.Location = new System.Drawing.Point(176, 199);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(199, 22);
            this.txtBirthday.TabIndex = 5;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.BirthDay,
            this.Email,
            this.Gender,
            this.identitycardnumber,
            this.Phone,
            this.Department,
            this.Position,
            this.Address,
            this.Status});
            this.dgvEmployee.Location = new System.Drawing.Point(-3, 350);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1271, 305);
            this.dgvEmployee.TabIndex = 6;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
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
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "BirthDay";
            this.BirthDay.HeaderText = "Ngày Sinh";
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // identitycardnumber
            // 
            this.identitycardnumber.DataPropertyName = "identitycardnumber";
            this.identitycardnumber.HeaderText = "CMND";
            this.identitycardnumber.Name = "identitycardnumber";
            this.identitycardnumber.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số Điện Thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
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
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(397, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 45);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quản Lý Nhân Viên";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(949, 193);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(199, 68);
            this.txtAdress.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(852, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa chỉ";
            // 
            // btnAddnew
            // 
            this.btnAddnew.Location = new System.Drawing.Point(80, 306);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(83, 27);
            this.btnAddnew.TabIndex = 8;
            this.btnAddnew.Text = "Thêm mới";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(208, 306);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 27);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(360, 306);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 27);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(511, 306);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(948, 309);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(199, 22);
            this.txt_search.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1173, 306);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 8;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 260);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(77, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(560, 135);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(195, 22);
            this.txtCmnd.TabIndex = 11;
            this.txtCmnd.TextChanged += new System.EventHandler(this.txtCmnd_TextChanged);
            // 
            // lblResultEmail
            // 
            this.lblResultEmail.AutoSize = true;
            this.lblResultEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultEmail.Location = new System.Drawing.Point(173, 241);
            this.lblResultEmail.Name = "lblResultEmail";
            this.lblResultEmail.Size = new System.Drawing.Size(0, 17);
            this.lblResultEmail.TabIndex = 1;
            // 
            // lblResultPhone
            // 
            this.lblResultPhone.AutoSize = true;
            this.lblResultPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultPhone.Location = new System.Drawing.Point(557, 174);
            this.lblResultPhone.Name = "lblResultPhone";
            this.lblResultPhone.Size = new System.Drawing.Size(0, 17);
            this.lblResultPhone.TabIndex = 1;
            // 
            // lblResultcmnd
            // 
            this.lblResultcmnd.AutoSize = true;
            this.lblResultcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultcmnd.Location = new System.Drawing.Point(557, 114);
            this.lblResultcmnd.Name = "lblResultcmnd";
            this.lblResultcmnd.Size = new System.Drawing.Size(0, 17);
            this.lblResultcmnd.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFullName.Location = new System.Drawing.Point(173, 117);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 18);
            this.lblFullName.TabIndex = 1;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 654);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.rdoFamale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblResultcmnd);
            this.Controls.Add(this.lblResultPhone);
            this.Controls.Add(this.lblResultEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEmployee";
            this.Text = "Employee Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFamale;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn identitycardnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.Label lblResultcmnd;
        private System.Windows.Forms.Label lblResultPhone;
        private System.Windows.Forms.Label lblResultEmail;
        private System.Windows.Forms.Label lblFullName;
    }
}