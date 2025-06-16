namespace C__project_1.viwes
{
    partial class Lecturer
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
            this.txt_letc_name = new System.Windows.Forms.TextBox();
            this.txt_letc_addres = new System.Windows.Forms.TextBox();
            this.txt_letc_nic = new System.Windows.Forms.TextBox();
            this.dgv_lecturer = new System.Windows.Forms.DataGridView();
            this.btn_add_letc = new System.Windows.Forms.Button();
            this.btn_update_lect = new System.Windows.Forms.Button();
            this.btn_delete_lect = new System.Windows.Forms.Button();
            this.btn_backletc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ltec_sub = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LectureName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NICnumber";
            // 
            // txt_letc_name
            // 
            this.txt_letc_name.Location = new System.Drawing.Point(345, 54);
            this.txt_letc_name.Name = "txt_letc_name";
            this.txt_letc_name.Size = new System.Drawing.Size(194, 22);
            this.txt_letc_name.TabIndex = 4;
            // 
            // txt_letc_addres
            // 
            this.txt_letc_addres.Location = new System.Drawing.Point(345, 99);
            this.txt_letc_addres.Name = "txt_letc_addres";
            this.txt_letc_addres.Size = new System.Drawing.Size(194, 22);
            this.txt_letc_addres.TabIndex = 5;
            // 
            // txt_letc_nic
            // 
            this.txt_letc_nic.Location = new System.Drawing.Point(345, 149);
            this.txt_letc_nic.Name = "txt_letc_nic";
            this.txt_letc_nic.Size = new System.Drawing.Size(194, 22);
            this.txt_letc_nic.TabIndex = 6;
            // 
            // dgv_lecturer
            // 
            this.dgv_lecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lecturer.Location = new System.Drawing.Point(223, 225);
            this.dgv_lecturer.Name = "dgv_lecturer";
            this.dgv_lecturer.RowHeadersWidth = 51;
            this.dgv_lecturer.RowTemplate.Height = 24;
            this.dgv_lecturer.Size = new System.Drawing.Size(391, 150);
            this.dgv_lecturer.TabIndex = 8;
            // 
            // btn_add_letc
            // 
            this.btn_add_letc.Location = new System.Drawing.Point(223, 390);
            this.btn_add_letc.Name = "btn_add_letc";
            this.btn_add_letc.Size = new System.Drawing.Size(75, 23);
            this.btn_add_letc.TabIndex = 9;
            this.btn_add_letc.Text = "Add";
            this.btn_add_letc.UseVisualStyleBackColor = true;
            // 
            // btn_update_lect
            // 
            this.btn_update_lect.Location = new System.Drawing.Point(332, 390);
            this.btn_update_lect.Name = "btn_update_lect";
            this.btn_update_lect.Size = new System.Drawing.Size(75, 23);
            this.btn_update_lect.TabIndex = 10;
            this.btn_update_lect.Text = "Update";
            this.btn_update_lect.UseVisualStyleBackColor = true;
            // 
            // btn_delete_lect
            // 
            this.btn_delete_lect.Location = new System.Drawing.Point(435, 390);
            this.btn_delete_lect.Name = "btn_delete_lect";
            this.btn_delete_lect.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_lect.TabIndex = 11;
            this.btn_delete_lect.Text = "Delete";
            this.btn_delete_lect.UseVisualStyleBackColor = true;
            // 
            // btn_backletc
            // 
            this.btn_backletc.Location = new System.Drawing.Point(535, 390);
            this.btn_backletc.Name = "btn_backletc";
            this.btn_backletc.Size = new System.Drawing.Size(75, 23);
            this.btn_backletc.TabIndex = 12;
            this.btn_backletc.Text = "Back";
            this.btn_backletc.UseVisualStyleBackColor = true;
            this.btn_backletc.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "subject";
            // 
            // txt_ltec_sub
            // 
            this.txt_ltec_sub.Location = new System.Drawing.Point(345, 185);
            this.txt_ltec_sub.Name = "txt_ltec_sub";
            this.txt_ltec_sub.Size = new System.Drawing.Size(194, 22);
            this.txt_ltec_sub.TabIndex = 14;
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ltec_sub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_backletc);
            this.Controls.Add(this.btn_delete_lect);
            this.Controls.Add(this.btn_update_lect);
            this.Controls.Add(this.btn_add_letc);
            this.Controls.Add(this.dgv_lecturer);
            this.Controls.Add(this.txt_letc_nic);
            this.Controls.Add(this.txt_letc_addres);
            this.Controls.Add(this.txt_letc_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_letc_name;
        private System.Windows.Forms.TextBox txt_letc_addres;
        private System.Windows.Forms.TextBox txt_letc_nic;
        private System.Windows.Forms.DataGridView dgv_lecturer;
        private System.Windows.Forms.Button btn_add_letc;
        private System.Windows.Forms.Button btn_update_lect;
        private System.Windows.Forms.Button btn_delete_lect;
        private System.Windows.Forms.Button btn_backletc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ltec_sub;
    }
}