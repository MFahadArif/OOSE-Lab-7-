namespace Bill_System
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.lgnBtn = new System.Windows.Forms.Button();
            this.sgnBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slgnBtn = new System.Windows.Forms.Button();
            this.CnfrmPassSU_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordSU_TB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UNameSU_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(173, 59);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(192, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(173, 96);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(192, 20);
            this.passTxt.TabIndex = 4;
            // 
            // lgnBtn
            // 
            this.lgnBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnBtn.Location = new System.Drawing.Point(73, 138);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Size = new System.Drawing.Size(132, 30);
            this.lgnBtn.TabIndex = 5;
            this.lgnBtn.Text = "Login";
            this.lgnBtn.UseVisualStyleBackColor = true;
            this.lgnBtn.Click += new System.EventHandler(this.lgnBtn_Click);
            // 
            // sgnBtn
            // 
            this.sgnBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgnBtn.Location = new System.Drawing.Point(233, 138);
            this.sgnBtn.Name = "sgnBtn";
            this.sgnBtn.Size = new System.Drawing.Size(132, 30);
            this.sgnBtn.TabIndex = 6;
            this.sgnBtn.Text = "Register";
            this.sgnBtn.UseVisualStyleBackColor = true;
            this.sgnBtn.Click += new System.EventHandler(this.sgnBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sgnBtn);
            this.panel1.Controls.Add(this.passTxt);
            this.panel1.Controls.Add(this.lgnBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 249);
            this.panel1.TabIndex = 7;
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.Location = new System.Drawing.Point(20, 188);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(142, 34);
            this.regBtn.TabIndex = 13;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.slgnBtn);
            this.panel2.Controls.Add(this.CnfrmPassSU_TB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PasswordSU_TB);
            this.panel2.Controls.Add(this.regBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.UNameSU_TB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 298);
            this.panel2.TabIndex = 8;
            // 
            // slgnBtn
            // 
            this.slgnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slgnBtn.Location = new System.Drawing.Point(180, 188);
            this.slgnBtn.Name = "slgnBtn";
            this.slgnBtn.Size = new System.Drawing.Size(142, 34);
            this.slgnBtn.TabIndex = 14;
            this.slgnBtn.Text = "Login";
            this.slgnBtn.UseVisualStyleBackColor = true;
            this.slgnBtn.Click += new System.EventHandler(this.SULogin_Btn_Click);
            // 
            // CnfrmPassSU_TB
            // 
            this.CnfrmPassSU_TB.Location = new System.Drawing.Point(180, 146);
            this.CnfrmPassSU_TB.Name = "CnfrmPassSU_TB";
            this.CnfrmPassSU_TB.PasswordChar = '*';
            this.CnfrmPassSU_TB.Size = new System.Drawing.Size(238, 20);
            this.CnfrmPassSU_TB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Re-enter Password";
            // 
            // PasswordSU_TB
            // 
            this.PasswordSU_TB.Location = new System.Drawing.Point(180, 117);
            this.PasswordSU_TB.Name = "PasswordSU_TB";
            this.PasswordSU_TB.PasswordChar = '*';
            this.PasswordSU_TB.Size = new System.Drawing.Size(238, 20);
            this.PasswordSU_TB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "User Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password";
            // 
            // UNameSU_TB
            // 
            this.UNameSU_TB.Location = new System.Drawing.Point(180, 87);
            this.UNameSU_TB.Name = "UNameSU_TB";
            this.UNameSU_TB.Size = new System.Drawing.Size(238, 20);
            this.UNameSU_TB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sign Up";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 247);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button lgnBtn;
        private System.Windows.Forms.Button sgnBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CnfrmPassSU_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswordSU_TB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UNameSU_TB;
        private System.Windows.Forms.Button slgnBtn;
    }
}

