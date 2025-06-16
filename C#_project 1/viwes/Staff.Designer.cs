namespace C__project_1.viwes
{
    partial class Staff
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
            this.txt_staffname = new System.Windows.Forms.TextBox();
            this.txt_staffAddress = new System.Windows.Forms.TextBox();
            this.txt_staffNIC = new System.Windows.Forms.TextBox();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.btn_add_stf = new System.Windows.Forms.Button();
            this.btn_Update_stf = new System.Windows.Forms.Button();
            this.btn_delete_stf = new System.Windows.Forms.Button();
            this.btn_back_stf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NICnumber";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_staffname
            // 
            this.txt_staffname.Location = new System.Drawing.Point(151, 56);
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.Size = new System.Drawing.Size(168, 20);
            this.txt_staffname.TabIndex = 4;
            // 
            // txt_staffAddress
            // 
            this.txt_staffAddress.Location = new System.Drawing.Point(151, 97);
            this.txt_staffAddress.Name = "txt_staffAddress";
            this.txt_staffAddress.Size = new System.Drawing.Size(168, 20);
            this.txt_staffAddress.TabIndex = 5;
            // 
            // txt_staffNIC
            // 
            this.txt_staffNIC.Location = new System.Drawing.Point(151, 133);
            this.txt_staffNIC.Name = "txt_staffNIC";
            this.txt_staffNIC.Size = new System.Drawing.Size(168, 20);
            this.txt_staffNIC.TabIndex = 6;
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(43, 169);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.Size = new System.Drawing.Size(373, 150);
            this.dgv_staff.TabIndex = 8;
            this.dgv_staff.SelectionChanged += new System.EventHandler(this.dgv_staff_SelectionChanged);
            // 
            // btn_add_stf
            // 
            this.btn_add_stf.Location = new System.Drawing.Point(60, 325);
            this.btn_add_stf.Name = "btn_add_stf";
            this.btn_add_stf.Size = new System.Drawing.Size(75, 23);
            this.btn_add_stf.TabIndex = 9;
            this.btn_add_stf.Text = "Add";
            this.btn_add_stf.UseVisualStyleBackColor = true;
            this.btn_add_stf.Click += new System.EventHandler(this.btn_add_stf_Click);
            // 
            // btn_Update_stf
            // 
            this.btn_Update_stf.Location = new System.Drawing.Point(151, 325);
            this.btn_Update_stf.Name = "btn_Update_stf";
            this.btn_Update_stf.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_stf.TabIndex = 10;
            this.btn_Update_stf.Text = "Update";
            this.btn_Update_stf.UseVisualStyleBackColor = true;
            this.btn_Update_stf.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete_stf
            // 
            this.btn_delete_stf.Location = new System.Drawing.Point(243, 325);
            this.btn_delete_stf.Name = "btn_delete_stf";
            this.btn_delete_stf.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_stf.TabIndex = 11;
            this.btn_delete_stf.Text = "Delete";
            this.btn_delete_stf.UseVisualStyleBackColor = true;
            this.btn_delete_stf.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_back_stf
            // 
            this.btn_back_stf.Location = new System.Drawing.Point(324, 325);
            this.btn_back_stf.Name = "btn_back_stf";
            this.btn_back_stf.Size = new System.Drawing.Size(75, 23);
            this.btn_back_stf.TabIndex = 12;
            this.btn_back_stf.Text = "back";
            this.btn_back_stf.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_stf);
            this.Controls.Add(this.btn_delete_stf);
            this.Controls.Add(this.btn_Update_stf);
            this.Controls.Add(this.btn_add_stf);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.txt_staffNIC);
            this.Controls.Add(this.txt_staffAddress);
            this.Controls.Add(this.txt_staffname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_staffname;
        private System.Windows.Forms.TextBox txt_staffAddress;
        private System.Windows.Forms.TextBox txt_staffNIC;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Button btn_add_stf;
        private System.Windows.Forms.Button btn_Update_stf;
        private System.Windows.Forms.Button btn_delete_stf;
        private System.Windows.Forms.Button btn_back_stf;
    }
}