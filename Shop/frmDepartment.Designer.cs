namespace Shop
{
    partial class frmDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_Department = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_an = new System.Windows.Forms.RadioButton();
            this.rdo_hien = new System.Windows.Forms.RadioButton();
            this.lblDepartment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Department)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(412, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phòng Ban:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(540, 121);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 22);
            this.txt_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(412, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Phòng Ban:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(540, 170);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(271, 22);
            this.txt_name.TabIndex = 2;
            // 
            // dgv_Department
            // 
            this.dgv_Department.AllowUserToAddRows = false;
            this.dgv_Department.AllowUserToDeleteRows = false;
            this.dgv_Department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Status});
            this.dgv_Department.Location = new System.Drawing.Point(0, 334);
            this.dgv_Department.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Department.Name = "dgv_Department";
            this.dgv_Department.ReadOnly = true;
            this.dgv_Department.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Department.Size = new System.Drawing.Size(1263, 320);
            this.dgv_Department.TabIndex = 3;
            this.dgv_Department.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Department_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "DepartmentId";
            this.id.HeaderText = "Mã Phòng Ban";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "DepartmentName";
            this.name.HeaderText = "Tên Phòng Ban";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Location = new System.Drawing.Point(416, 252);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(100, 28);
            this.btn_themmoi.TabIndex = 4;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(585, 252);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(760, 252);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(100, 28);
            this.btn_lammoi.TabIndex = 6;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(412, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trạng Thái:";
            // 
            // rdo_an
            // 
            this.rdo_an.AutoSize = true;
            this.rdo_an.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_an.Location = new System.Drawing.Point(540, 209);
            this.rdo_an.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_an.Name = "rdo_an";
            this.rdo_an.Size = new System.Drawing.Size(46, 22);
            this.rdo_an.TabIndex = 8;
            this.rdo_an.TabStop = true;
            this.rdo_an.Text = "Ẩn";
            this.rdo_an.UseVisualStyleBackColor = true;
            // 
            // rdo_hien
            // 
            this.rdo_hien.AutoSize = true;
            this.rdo_hien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_hien.Location = new System.Drawing.Point(611, 209);
            this.rdo_hien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_hien.Name = "rdo_hien";
            this.rdo_hien.Size = new System.Drawing.Size(59, 22);
            this.rdo_hien.TabIndex = 9;
            this.rdo_hien.TabStop = true;
            this.rdo_hien.Text = "Hiển";
            this.rdo_hien.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDepartment.Location = new System.Drawing.Point(537, 149);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 18);
            this.lblDepartment.TabIndex = 1;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 654);
            this.Controls.Add(this.rdo_hien);
            this.Controls.Add(this.rdo_an);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.dgv_Department);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Department)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv_Department;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_an;
        private System.Windows.Forms.RadioButton rdo_hien;
        private System.Windows.Forms.Label lblDepartment;
    }
}