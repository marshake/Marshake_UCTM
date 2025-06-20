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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_USERNAME = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 106);
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
            this.label2.Location = new System.Drawing.Point(94, 148);
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
            this.label3.Location = new System.Drawing.Point(94, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ROLE";
            // 
            // TXT_USERNAME
            // 
            this.TXT_USERNAME.Location = new System.Drawing.Point(218, 104);
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.Size = new System.Drawing.Size(192, 20);
            this.TXT_USERNAME.TabIndex = 4;
            this.TXT_USERNAME.TextChanged += new System.EventHandler(this.TXT_USERNAME_TextChanged);
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Location = new System.Drawing.Point(218, 148);
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.PasswordChar = '*';
            this.TXT_PASSWORD.Size = new System.Drawing.Size(192, 20);
            this.TXT_PASSWORD.TabIndex = 5;
            this.TXT_PASSWORD.TextChanged += new System.EventHandler(this.TXT_PASSWORD_TextChanged);
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.BackColor = System.Drawing.Color.Lavender;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.Red;
            this.BTN_LOGIN.Location = new System.Drawing.Point(335, 252);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.BTN_LOGIN.TabIndex = 7;
            this.BTN_LOGIN.Text = "LOGIN";
            this.BTN_LOGIN.UseVisualStyleBackColor = false;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(219, 196);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(191, 21);
            this.cmb_role.TabIndex = 8;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(72, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "WELLCOME TO UNICOME TIC LOGIN SYSTEM";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(540, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TXT_PASSWORD);
            this.Controls.Add(this.TXT_USERNAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_USERNAME;
        private System.Windows.Forms.TextBox TXT_PASSWORD;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label4;
    }
}