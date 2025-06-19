namespace C__project_1.viwes
{
    partial class Teacher
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
            this.txt_tec_name = new System.Windows.Forms.TextBox();
            this.txt_tec_Address = new System.Windows.Forms.TextBox();
            this.txt_tec_NIC = new System.Windows.Forms.TextBox();
            this.dgv_Teacher = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_back_tec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TeacherName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NICnumber";
            // 
            // txt_tec_name
            // 
            this.txt_tec_name.Location = new System.Drawing.Point(288, 78);
            this.txt_tec_name.Name = "txt_tec_name";
            this.txt_tec_name.Size = new System.Drawing.Size(198, 20);
            this.txt_tec_name.TabIndex = 4;
            // 
            // txt_tec_Address
            // 
            this.txt_tec_Address.Location = new System.Drawing.Point(288, 113);
            this.txt_tec_Address.Name = "txt_tec_Address";
            this.txt_tec_Address.Size = new System.Drawing.Size(198, 20);
            this.txt_tec_Address.TabIndex = 5;
            // 
            // txt_tec_NIC
            // 
            this.txt_tec_NIC.Location = new System.Drawing.Point(288, 146);
            this.txt_tec_NIC.Name = "txt_tec_NIC";
            this.txt_tec_NIC.Size = new System.Drawing.Size(198, 20);
            this.txt_tec_NIC.TabIndex = 6;
            // 
            // dgv_Teacher
            // 
            this.dgv_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Teacher.Location = new System.Drawing.Point(156, 189);
            this.dgv_Teacher.Name = "dgv_Teacher";
            this.dgv_Teacher.Size = new System.Drawing.Size(360, 150);
            this.dgv_Teacher.TabIndex = 8;
            this.dgv_Teacher.SelectionChanged += new System.EventHandler(this.dgv_Teacher_SelectionChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Teal;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(163, 364);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_tec_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(356, 364);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_tec_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Teal;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(263, 364);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_tec_Click);
            // 
            // btn_back_tec
            // 
            this.btn_back_tec.BackColor = System.Drawing.Color.Teal;
            this.btn_back_tec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_tec.Location = new System.Drawing.Point(452, 364);
            this.btn_back_tec.Name = "btn_back_tec";
            this.btn_back_tec.Size = new System.Drawing.Size(75, 23);
            this.btn_back_tec.TabIndex = 12;
            this.btn_back_tec.Text = "Back";
            this.btn_back_tec.UseVisualStyleBackColor = false;
            this.btn_back_tec.Click += new System.EventHandler(this.btn_back_tec_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btn_back_tec);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_Teacher);
            this.Controls.Add(this.txt_tec_NIC);
            this.Controls.Add(this.txt_tec_Address);
            this.Controls.Add(this.txt_tec_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tec_name;
        private System.Windows.Forms.TextBox txt_tec_Address;
        private System.Windows.Forms.TextBox txt_tec_NIC;
        private System.Windows.Forms.DataGridView dgv_Teacher;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_back_tec;
    }
}