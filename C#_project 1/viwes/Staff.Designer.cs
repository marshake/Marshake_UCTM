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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(187, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "StaffName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(187, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(187, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "NICnumber";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_staffname
            // 
            this.txt_staffname.Location = new System.Drawing.Point(327, 84);
            this.txt_staffname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_staffname.Name = "txt_staffname";
            this.txt_staffname.Size = new System.Drawing.Size(223, 22);
            this.txt_staffname.TabIndex = 4;
            // 
            // txt_staffAddress
            // 
            this.txt_staffAddress.Location = new System.Drawing.Point(327, 131);
            this.txt_staffAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_staffAddress.Name = "txt_staffAddress";
            this.txt_staffAddress.Size = new System.Drawing.Size(223, 22);
            this.txt_staffAddress.TabIndex = 5;
            // 
            // txt_staffNIC
            // 
            this.txt_staffNIC.Location = new System.Drawing.Point(327, 181);
            this.txt_staffNIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_staffNIC.Name = "txt_staffNIC";
            this.txt_staffNIC.Size = new System.Drawing.Size(223, 22);
            this.txt_staffNIC.TabIndex = 6;
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(100, 249);
            this.dgv_staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.Size = new System.Drawing.Size(497, 185);
            this.dgv_staff.TabIndex = 8;
            this.dgv_staff.SelectionChanged += new System.EventHandler(this.dgv_staff_SelectionChanged);
            // 
            // btn_add_stf
            // 
            this.btn_add_stf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_add_stf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_stf.Location = new System.Drawing.Point(117, 442);
            this.btn_add_stf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_stf.Name = "btn_add_stf";
            this.btn_add_stf.Size = new System.Drawing.Size(100, 28);
            this.btn_add_stf.TabIndex = 9;
            this.btn_add_stf.Text = "Add";
            this.btn_add_stf.UseVisualStyleBackColor = false;
            this.btn_add_stf.Click += new System.EventHandler(this.btn_add_stf_Click);
            // 
            // btn_Update_stf
            // 
            this.btn_Update_stf.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update_stf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_stf.Location = new System.Drawing.Point(244, 442);
            this.btn_Update_stf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update_stf.Name = "btn_Update_stf";
            this.btn_Update_stf.Size = new System.Drawing.Size(100, 28);
            this.btn_Update_stf.TabIndex = 10;
            this.btn_Update_stf.Text = "Update";
            this.btn_Update_stf.UseVisualStyleBackColor = false;
            this.btn_Update_stf.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete_stf
            // 
            this.btn_delete_stf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_stf.Location = new System.Drawing.Point(366, 442);
            this.btn_delete_stf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete_stf.Name = "btn_delete_stf";
            this.btn_delete_stf.Size = new System.Drawing.Size(100, 28);
            this.btn_delete_stf.TabIndex = 11;
            this.btn_delete_stf.Text = "Delete";
            this.btn_delete_stf.UseVisualStyleBackColor = true;
            this.btn_delete_stf.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_back_stf
            // 
            this.btn_back_stf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_stf.Location = new System.Drawing.Point(483, 442);
            this.btn_back_stf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back_stf.Name = "btn_back_stf";
            this.btn_back_stf.Size = new System.Drawing.Size(100, 28);
            this.btn_back_stf.TabIndex = 12;
            this.btn_back_stf.Text = "back";
            this.btn_back_stf.UseVisualStyleBackColor = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(695, 554);
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
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
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