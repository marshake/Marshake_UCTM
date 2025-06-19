namespace C__project_1.Views
{
    partial class LoginForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_USERNAME = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(201, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(390, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WELLCOME TO UNICOME TIC LOGIN SYSTEM";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ROLE";
            // 
            // TXT_USERNAME
            // 
            this.TXT_USERNAME.Location = new System.Drawing.Point(374, 118);
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.Size = new System.Drawing.Size(192, 20);
            this.TXT_USERNAME.TabIndex = 4;
            this.TXT_USERNAME.TextChanged += new System.EventHandler(this.TXT_USERNAME_TextChanged);
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(374, 164);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.PasswordChar = '#';
            this.TXT_PASSWORD.Size = new System.Drawing.Size(192, 20);
            this.TXT_PASSWORD.TabIndex = 5;
            this.TXT_PASSWORD.TextChanged += new System.EventHandler(this.TXT_PASSWORD_TextChanged);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.Location = new System.Drawing.Point(490, 265);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTN_LOGIN.TabIndex = 7;
            this.BTN_LOGIN.Text = "LOGIN";
            this.BTN_LOGIN.UseVisualStyleBackColor = true;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(374, 214);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(191, 21);
            this.cmb_role.TabIndex = 8;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TXT_PASSWORD);
            this.Controls.Add(this.TXT_USERNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_USERNAME;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.ComboBox cmb_role;
    }
}