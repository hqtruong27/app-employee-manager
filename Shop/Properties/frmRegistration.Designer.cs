namespace Shop
{
    partial class Đangky
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_brithday = new System.Windows.Forms.DateTimePicker();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.email,
            this.phone,
            this.password,
            this.address,
            this.gioitinh,
            this.brithday});
            this.dgv_users.Location = new System.Drawing.Point(-6, 353);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(807, 150);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.SelectionChanged += new System.EventHandler(this.dgv_users_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Họ và Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Mật khẩu";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gender";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // brithday
            // 
            this.brithday.DataPropertyName = "birthday";
            this.brithday.HeaderText = "Ngày sinh";
            this.brithday.Name = "brithday";
            this.brithday.ReadOnly = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(120, 123);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(247, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.Validated += new System.EventHandler(this.txt_name_Validated);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 163);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(247, 20);
            this.txt_email.TabIndex = 4;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(120, 204);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(247, 20);
            this.txt_phone.TabIndex = 6;
            this.txt_phone.Validated += new System.EventHandler(this.txt_phone_Validated);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(528, 79);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(236, 20);
            this.txt_password.TabIndex = 8;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(448, 236);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(57, 13);
            this.lable.TabIndex = 9;
            this.lable.Text = "Ngày sinh:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(528, 107);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(236, 76);
            this.txt_address.TabIndex = 10;
            // 
            // txt_brithday
            // 
            this.txt_brithday.CustomFormat = "dd/MM/yyyy";
            this.txt_brithday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_brithday.Location = new System.Drawing.Point(528, 230);
            this.txt_brithday.Name = "txt_brithday";
            this.txt_brithday.Size = new System.Drawing.Size(200, 20);
            this.txt_brithday.TabIndex = 11;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(528, 193);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(47, 17);
            this.rdo_nam.TabIndex = 12;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(611, 193);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_nu.TabIndex = 13;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đăng Ký Thành Viên";
          
            // 
            // btn_dangky
            // 
            this.btn_dangky.Location = new System.Drawing.Point(137, 281);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(75, 23);
            this.btn_dangky.TabIndex = 15;
            this.btn_dangky.Text = "Thêm mới";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(468, 281);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(575, 281);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 18;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(253, 281);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Lưu";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(120, 82);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.ReadOnly = true;
            this.txt_ma.Size = new System.Drawing.Size(247, 20);
            this.txt_ma.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Giới tính:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(363, 281);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 28;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Đangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdo_nu);
            this.Controls.Add(this.rdo_nam);
            this.Controls.Add(this.txt_brithday);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_users);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Đangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký thành viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Đangky_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Đangky_FormClosed);
            this.Load += new System.EventHandler(this.Đangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.DateTimePicker txt_brithday;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithday;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

