namespace C__project_1.viwes
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_tt = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_lecture = new System.Windows.Forms.Button();
            this.btn_teacher = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btn_marks = new System.Windows.Forms.Button();
            this.btn_Exam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btnAddCourse);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Exam);
            this.panel1.Controls.Add(this.btn_tt);
            this.panel1.Controls.Add(this.btn_marks);
            this.panel1.Controls.Add(this.btn_staff);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.btn_lecture);
            this.panel1.Controls.Add(this.btn_teacher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(133, 421);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(64, 26);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(28, 328);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(101, 23);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "AddCourse";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_tt
            // 
            this.btn_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tt.Location = new System.Drawing.Point(23, 357);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(170, 23);
            this.btn_tt.TabIndex = 1;
            this.btn_tt.Text = "ViewTimetables";
            this.btn_tt.UseVisualStyleBackColor = true;
            this.btn_tt.Click += new System.EventHandler(this.btn_tt_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.White;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.Location = new System.Drawing.Point(28, 255);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(139, 58);
            this.btn_staff.TabIndex = 3;
            this.btn_staff.Text = "Staff Management";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.White;
            this.btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.Location = new System.Drawing.Point(28, 193);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(139, 56);
            this.btn_student.TabIndex = 2;
            this.btn_student.Text = "Student Management";
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_lecture
            // 
            this.btn_lecture.BackColor = System.Drawing.Color.White;
            this.btn_lecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lecture.Location = new System.Drawing.Point(28, 64);
            this.btn_lecture.Name = "btn_lecture";
            this.btn_lecture.Size = new System.Drawing.Size(139, 59);
            this.btn_lecture.TabIndex = 0;
            this.btn_lecture.Text = "Lecture Management";
            this.btn_lecture.UseVisualStyleBackColor = false;
            this.btn_lecture.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_teacher
            // 
            this.btn_teacher.BackColor = System.Drawing.Color.White;
            this.btn_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher.Location = new System.Drawing.Point(28, 129);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(139, 58);
            this.btn_teacher.TabIndex = 1;
            this.btn_teacher.Text = "Teacher Management";
            this.btn_teacher.UseVisualStyleBackColor = false;
            this.btn_teacher.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 450);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_marks
            // 
            this.btn_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marks.Location = new System.Drawing.Point(93, 386);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(100, 23);
            this.btn_marks.TabIndex = 2;
            this.btn_marks.Text = "Marks";
            this.btn_marks.UseVisualStyleBackColor = true;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // btn_Exam
            // 
            this.btn_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exam.Location = new System.Drawing.Point(133, 328);
            this.btn_Exam.Name = "btn_Exam";
            this.btn_Exam.Size = new System.Drawing.Size(60, 23);
            this.btn_Exam.TabIndex = 5;
            this.btn_Exam.Text = "Exam";
            this.btn_Exam.UseVisualStyleBackColor = true;
            this.btn_Exam.Click += new System.EventHandler(this.btn_Exam_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Main Menu";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_lecture;
        private System.Windows.Forms.Button btn_teacher;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Exam;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.Label label1;
    }
}