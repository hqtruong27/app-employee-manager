namespace Shop
{
    partial class frmBasicSalary
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
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.dgvBasicSalary = new System.Windows.Forms.DataGridView();
            this.SalaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(665, 235);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(100, 28);
            this.btn_lammoi.TabIndex = 27;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(521, 235);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Location = new System.Drawing.Point(372, 235);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(100, 28);
            this.btn_themmoi.TabIndex = 25;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // dgvBasicSalary
            // 
            this.dgvBasicSalary.AllowUserToAddRows = false;
            this.dgvBasicSalary.AllowUserToDeleteRows = false;
            this.dgvBasicSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBasicSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasicSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaryId,
            this.Position,
            this.BasicSalary,
            this.MaCV});
            this.dgvBasicSalary.Location = new System.Drawing.Point(-1, 337);
            this.dgvBasicSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBasicSalary.Name = "dgvBasicSalary";
            this.dgvBasicSalary.ReadOnly = true;
            this.dgvBasicSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicSalary.Size = new System.Drawing.Size(1263, 320);
            this.dgvBasicSalary.TabIndex = 24;
            this.dgvBasicSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasicSalary_CellClick);
            // 
            // SalaryId
            // 
            this.SalaryId.DataPropertyName = "SalaryId";
            this.SalaryId.HeaderText = "Mã Lương";
            this.SalaryId.Name = "SalaryId";
            this.SalaryId.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Chức Vụ";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // BasicSalary
            // 
            this.BasicSalary.DataPropertyName = "BasicSalary";
            this.BasicSalary.HeaderText = "Lương cơ bản";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            this.MaCV.Visible = false;
            // 
            // txt_Salary
            // 
            this.txt_Salary.Location = new System.Drawing.Point(503, 164);
            this.txt_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(251, 22);
            this.txt_Salary.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lương Cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Chức Vụ;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lương Cơ Bản";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(503, 113);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(500, 143);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(0, 20);
            this.lblChucVu.TabIndex = 21;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(813, 115);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(54, 22);
            this.txt_Id.TabIndex = 22;
            this.txt_Id.Visible = false;
            // 
            // frmBasicSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 654);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.dgvBasicSalary);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBasicSalary";
            this.Text = "frmBasicSalary";
            this.Load += new System.EventHandler(this.frmBasicSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.DataGridView dgvBasicSalary;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txt_Id;
    }
}