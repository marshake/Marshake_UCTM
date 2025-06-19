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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_backletc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "LectureName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NICnumber";
            // 
            // txt_letc_name
            // 
            this.txt_letc_name.Location = new System.Drawing.Point(259, 44);
            this.txt_letc_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_letc_name.Name = "txt_letc_name";
            this.txt_letc_name.Size = new System.Drawing.Size(146, 20);
            this.txt_letc_name.TabIndex = 4;
            // 
            // txt_letc_addres
            // 
            this.txt_letc_addres.Location = new System.Drawing.Point(259, 80);
            this.txt_letc_addres.Margin = new System.Windows.Forms.Padding(2);
            this.txt_letc_addres.Name = "txt_letc_addres";
            this.txt_letc_addres.Size = new System.Drawing.Size(146, 20);
            this.txt_letc_addres.TabIndex = 5;
            // 
            // txt_letc_nic
            // 
            this.txt_letc_nic.Location = new System.Drawing.Point(259, 121);
            this.txt_letc_nic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_letc_nic.Name = "txt_letc_nic";
            this.txt_letc_nic.Size = new System.Drawing.Size(146, 20);
            this.txt_letc_nic.TabIndex = 6;
            this.txt_letc_nic.TextChanged += new System.EventHandler(this.txt_letc_nic_TextChanged);
            // 
            // dgv_lecturer
            // 
            this.dgv_lecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lecturer.Location = new System.Drawing.Point(133, 182);
            this.dgv_lecturer.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_lecturer.Name = "dgv_lecturer";
            this.dgv_lecturer.RowHeadersWidth = 51;
            this.dgv_lecturer.RowTemplate.Height = 24;
            this.dgv_lecturer.Size = new System.Drawing.Size(293, 122);
            this.dgv_lecturer.TabIndex = 8;
            this.dgv_lecturer.SelectionChanged += new System.EventHandler(this.dgv_lecturer_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.IndianRed;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(133, 317);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 31);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_letc_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.IndianRed;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(201, 317);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 31);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_lect_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(285, 317);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 31);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_lect_Click);
            // 
            // btn_backletc
            // 
            this.btn_backletc.BackColor = System.Drawing.Color.IndianRed;
            this.btn_backletc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backletc.Location = new System.Drawing.Point(359, 317);
            this.btn_backletc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_backletc.Name = "btn_backletc";
            this.btn_backletc.Size = new System.Drawing.Size(71, 31);
            this.btn_backletc.TabIndex = 12;
            this.btn_backletc.Text = "Back";
            this.btn_backletc.UseVisualStyleBackColor = false;
            this.btn_backletc.Click += new System.EventHandler(this.button4_Click);
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btn_backletc);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_lecturer);
            this.Controls.Add(this.txt_letc_nic);
            this.Controls.Add(this.txt_letc_addres);
            this.Controls.Add(this.txt_letc_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
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
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_backletc;
    }
}