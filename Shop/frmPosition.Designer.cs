namespace Shop
{
    partial class frmPosition
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
            this.dgv_Position = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_hien = new System.Windows.Forms.RadioButton();
            this.rdo_ẩn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Position)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(740, 247);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(100, 28);
            this.btn_lammoi.TabIndex = 15;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(596, 247);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.Location = new System.Drawing.Point(447, 247);
            this.btn_themmoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(100, 28);
            this.btn_themmoi.TabIndex = 13;
            this.btn_themmoi.Text = "Thêm mới";
            this.btn_themmoi.UseVisualStyleBackColor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // dgv_Position
            // 
            this.dgv_Position.AllowUserToAddRows = false;
            this.dgv_Position.AllowUserToDeleteRows = false;
            this.dgv_Position.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Position.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Position.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.Status});
            this.dgv_Position.Location = new System.Drawing.Point(0, 334);
            this.dgv_Position.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Position.Name = "dgv_Position";
            this.dgv_Position.ReadOnly = true;
            this.dgv_Position.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Position.Size = new System.Drawing.Size(1263, 320);
            this.dgv_Position.TabIndex = 12;
            this.dgv_Position.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Position_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "PositionId";
            this.id.HeaderText = "Mã Phòng Ban";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "PositionName";
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
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(567, 172);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(251, 22);
            this.txt_name.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Chức Vụ:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(567, 128);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(251, 22);
            this.txt_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Chức Vụ;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản Lý Chức Vụ";
            // 
            // rdo_hien
            // 
            this.rdo_hien.AutoSize = true;
            this.rdo_hien.Location = new System.Drawing.Point(633, 208);
            this.rdo_hien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_hien.Name = "rdo_hien";
            this.rdo_hien.Size = new System.Drawing.Size(58, 21);
            this.rdo_hien.TabIndex = 17;
            this.rdo_hien.TabStop = true;
            this.rdo_hien.Text = "Hiện";
            this.rdo_hien.UseVisualStyleBackColor = true;
            // 
            // rdo_ẩn
            // 
            this.rdo_ẩn.AutoSize = true;
            this.rdo_ẩn.Location = new System.Drawing.Point(567, 208);
            this.rdo_ẩn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdo_ẩn.Name = "rdo_ẩn";
            this.rdo_ẩn.Size = new System.Drawing.Size(46, 21);
            this.rdo_ẩn.TabIndex = 17;
            this.rdo_ẩn.TabStop = true;
            this.rdo_ẩn.Text = "Ẩn";
            this.rdo_ẩn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trạng Thái:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(564, 154);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 17);
            this.lblPosition.TabIndex = 8;
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdo_ẩn);
            this.Controls.Add(this.rdo_hien);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_themmoi);
            this.Controls.Add(this.dgv_Position);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPosition";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.DataGridView dgv_Position;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_hien;
        private System.Windows.Forms.RadioButton rdo_ẩn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblPosition;
    }
}