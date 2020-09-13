namespace Shop
{
    partial class frmLogin
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
            this.txt_namelogin = new System.Windows.Forms.TextBox();
            this.txt_passwordlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ckb_nho = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // txt_namelogin
            // 
            this.txt_namelogin.Location = new System.Drawing.Point(230, 78);
            this.txt_namelogin.Name = "txt_namelogin";
            this.txt_namelogin.Size = new System.Drawing.Size(160, 20);
            this.txt_namelogin.TabIndex = 1;
            // 
            // txt_passwordlogin
            // 
            this.txt_passwordlogin.Location = new System.Drawing.Point(230, 116);
            this.txt_passwordlogin.Name = "txt_passwordlogin";
            this.txt_passwordlogin.Size = new System.Drawing.Size(160, 20);
            this.txt_passwordlogin.TabIndex = 3;
            this.txt_passwordlogin.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đăng Nhập";
            // 
            // ckb_nho
            // 
            this.ckb_nho.AutoSize = true;
            this.ckb_nho.Location = new System.Drawing.Point(230, 155);
            this.ckb_nho.Name = "ckb_nho";
            this.ckb_nho.Size = new System.Drawing.Size(93, 17);
            this.ckb_nho.TabIndex = 8;
            this.ckb_nho.Text = "Nhớ mật khẩu";
            this.ckb_nho.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 338);
            this.Controls.Add(this.ckb_nho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_passwordlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_namelogin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_namelogin;
        private System.Windows.Forms.TextBox txt_passwordlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckb_nho;
    }
}