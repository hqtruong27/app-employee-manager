namespace Shop
{
    partial class frmAdmin
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_hoatdong = new System.Windows.Forms.RadioButton();
            this.rdo_bikhoa = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_checkpassswordagain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCheckPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(540, 21);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(120, 35);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(467, 149);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(225, 22);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Đăng Nhập:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(467, 199);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(225, 22);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật Khẩu:";
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(467, 300);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(225, 22);
            this.txt_FullName.TabIndex = 8;
            this.txt_FullName.TextChanged += new System.EventHandler(this.txt_FullName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ và Tên:";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(760, 253);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(100, 28);
            this.btn_lammoi.TabIndex = 34;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(760, 168);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 33;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(760, 88);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 28);
            this.btn_new.TabIndex = 30;
            this.btn_new.Text = "Thêm mới";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.AllowUserToAddRows = false;
            this.dgv_admin.AllowUserToDeleteRows = false;
            this.dgv_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Password,
            this.Fullname,
            this.Status});
            this.dgv_admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_admin.Location = new System.Drawing.Point(0, 447);
            this.dgv_admin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_admin.MultiSelect = false;
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.ReadOnly = true;
            this.dgv_admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_admin.Size = new System.Drawing.Size(1075, 256);
            this.dgv_admin.TabIndex = 35;
            this.dgv_admin.VirtualMode = true;
            this.dgv_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên đăng nhập";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Passwords";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "FullName";
            this.Fullname.HeaderText = "Họ và Tên";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(466, 91);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(225, 22);
            this.txt_id.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_hoatdong
            // 
            this.rdo_hoatdong.AutoSize = true;
            this.rdo_hoatdong.Location = new System.Drawing.Point(594, 346);
            this.rdo_hoatdong.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_hoatdong.Name = "rdo_hoatdong";
            this.rdo_hoatdong.Size = new System.Drawing.Size(97, 21);
            this.rdo_hoatdong.TabIndex = 11;
            this.rdo_hoatdong.TabStop = true;
            this.rdo_hoatdong.Text = "Hoạt Động";
            this.rdo_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rdo_bikhoa
            // 
            this.rdo_bikhoa.AutoSize = true;
            this.rdo_bikhoa.Location = new System.Drawing.Point(467, 346);
            this.rdo_bikhoa.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_bikhoa.Name = "rdo_bikhoa";
            this.rdo_bikhoa.Size = new System.Drawing.Size(100, 21);
            this.rdo_bikhoa.TabIndex = 10;
            this.rdo_bikhoa.TabStop = true;
            this.rdo_bikhoa.Text = "Đã Bị Khóa";
            this.rdo_bikhoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trạng Thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nhập lại Mật Khẩu:";
            // 
            // txt_checkpassswordagain
            // 
            this.txt_checkpassswordagain.Location = new System.Drawing.Point(467, 250);
            this.txt_checkpassswordagain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_checkpassswordagain.Name = "txt_checkpassswordagain";
            this.txt_checkpassswordagain.Size = new System.Drawing.Size(225, 22);
            this.txt_checkpassswordagain.TabIndex = 38;
            this.txt_checkpassswordagain.UseSystemPasswordChar = true;
            this.txt_checkpassswordagain.TextChanged += new System.EventHandler(this.txt_checkpassswordagain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(378, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(464, 128);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 17);
            this.lblUserName.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(464, 178);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 17);
            this.lblPassword.TabIndex = 5;
            // 
            // lblCheckPassword
            // 
            this.lblCheckPassword.AutoSize = true;
            this.lblCheckPassword.Location = new System.Drawing.Point(464, 229);
            this.lblCheckPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckPassword.Name = "lblCheckPassword";
            this.lblCheckPassword.Size = new System.Drawing.Size(0, 17);
            this.lblCheckPassword.TabIndex = 37;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(464, 279);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 7;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 703);
            this.Controls.Add(this.txt_checkpassswordagain);
            this.Controls.Add(this.lblCheckPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.rdo_hoatdong);
            this.Controls.Add(this.rdo_bikhoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_FullName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdmin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_hoatdong;
        private System.Windows.Forms.RadioButton rdo_bikhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_checkpassswordagain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCheckPassword;
        private System.Windows.Forms.Label lblName;
    }
}