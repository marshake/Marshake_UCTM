namespace C__project_1.viwes
{
    partial class Student
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.txt_studentAddress = new System.Windows.Forms.TextBox();
            this.txt_studentNIC = new System.Windows.Forms.TextBox();
            this.student_grw = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_course = new System.Windows.Forms.Label();
            this.back_student = new System.Windows.Forms.Button();
            this.cmb_coure = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.student_grw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "StudentAddress";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "NICnumber";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_studentname
            // 
            this.txt_studentname.Location = new System.Drawing.Point(236, 63);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.Size = new System.Drawing.Size(221, 20);
            this.txt_studentname.TabIndex = 5;
            // 
            // txt_studentAddress
            // 
            this.txt_studentAddress.Location = new System.Drawing.Point(236, 102);
            this.txt_studentAddress.Name = "txt_studentAddress";
            this.txt_studentAddress.Size = new System.Drawing.Size(221, 20);
            this.txt_studentAddress.TabIndex = 7;
            // 
            // txt_studentNIC
            // 
            this.txt_studentNIC.Location = new System.Drawing.Point(236, 136);
            this.txt_studentNIC.Name = "txt_studentNIC";
            this.txt_studentNIC.Size = new System.Drawing.Size(221, 20);
            this.txt_studentNIC.TabIndex = 9;
            // 
            // student_grw
            // 
            this.student_grw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_grw.GridColor = System.Drawing.Color.White;
            this.student_grw.Location = new System.Drawing.Point(66, 198);
            this.student_grw.Name = "student_grw";
            this.student_grw.RowHeadersWidth = 51;
            this.student_grw.Size = new System.Drawing.Size(464, 150);
            this.student_grw.TabIndex = 10;
            this.student_grw.SelectionChanged += new System.EventHandler(this.student_grw_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Teal;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(115, 365);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(317, 365);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Teal;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(217, 365);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_course
            // 
            this.txt_course.AutoSize = true;
            this.txt_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.Location = new System.Drawing.Point(112, 173);
            this.txt_course.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(63, 18);
            this.txt_course.TabIndex = 14;
            this.txt_course.Text = "Course";
            // 
            // back_student
            // 
            this.back_student.BackColor = System.Drawing.Color.Teal;
            this.back_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_student.Location = new System.Drawing.Point(405, 364);
            this.back_student.Margin = new System.Windows.Forms.Padding(2);
            this.back_student.Name = "back_student";
            this.back_student.Size = new System.Drawing.Size(68, 23);
            this.back_student.TabIndex = 16;
            this.back_student.Text = "back";
            this.back_student.UseVisualStyleBackColor = false;
            this.back_student.Click += new System.EventHandler(this.back_student_Click);
            // 
            // cmb_coure
            // 
            this.cmb_coure.FormattingEnabled = true;
            this.cmb_coure.Location = new System.Drawing.Point(236, 173);
            this.cmb_coure.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_coure.Name = "cmb_coure";
            this.cmb_coure.Size = new System.Drawing.Size(221, 21);
            this.cmb_coure.TabIndex = 17;
            this.cmb_coure.SelectedIndexChanged += new System.EventHandler(this.cmb_coure_SelectedIndexChanged);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cmb_coure);
            this.Controls.Add(this.back_student);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.student_grw);
            this.Controls.Add(this.txt_studentNIC);
            this.Controls.Add(this.txt_studentAddress);
            this.Controls.Add(this.txt_studentname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_grw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.TextBox txt_studentAddress;
        private System.Windows.Forms.TextBox txt_studentNIC;
        private System.Windows.Forms.DataGridView student_grw;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label txt_course;
        private System.Windows.Forms.Button back_student;
        private System.Windows.Forms.ComboBox cmb_coure;
    }
}