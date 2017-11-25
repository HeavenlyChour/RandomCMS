namespace CourseManagementSystem
{
    partial class MainForm
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
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAssessment = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnSemester = new System.Windows.Forms.Button();
            this.btnEnrolment = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.btnTeacherCourse = new System.Windows.Forms.Button();
            this.btnTeacherSkill = new System.Windows.Forms.Button();
            this.btnUnitCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDashBoard.Location = new System.Drawing.Point(368, 41);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(228, 37);
            this.lblDashBoard.TabIndex = 164;
            this.lblDashBoard.Text = "DASHBOARD";
            this.lblDashBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = global::CourseManagementSystem.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(260, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(446, 39);
            this.btnExit.TabIndex = 172;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAssessment
            // 
            this.btnAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssessment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAssessment.Image = global::CourseManagementSystem.Properties.Resources.assessment;
            this.btnAssessment.Location = new System.Drawing.Point(712, 270);
            this.btnAssessment.Name = "btnAssessment";
            this.btnAssessment.Size = new System.Drawing.Size(220, 150);
            this.btnAssessment.TabIndex = 171;
            this.btnAssessment.UseVisualStyleBackColor = true;
            this.btnAssessment.Click += new System.EventHandler(this.btnAssessment_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUnit.Image = global::CourseManagementSystem.Properties.Resources.units;
            this.btnUnit.Location = new System.Drawing.Point(486, 270);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(220, 150);
            this.btnUnit.TabIndex = 170;
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkills.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSkills.Image = global::CourseManagementSystem.Properties.Resources.skills;
            this.btnSkills.Location = new System.Drawing.Point(260, 270);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(220, 150);
            this.btnSkills.TabIndex = 169;
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTeacher.Image = global::CourseManagementSystem.Properties.Resources.teacher;
            this.btnTeacher.Location = new System.Drawing.Point(34, 270);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(220, 150);
            this.btnTeacher.TabIndex = 168;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnSemester
            // 
            this.btnSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemester.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSemester.Image = global::CourseManagementSystem.Properties.Resources.semester;
            this.btnSemester.Location = new System.Drawing.Point(712, 114);
            this.btnSemester.Name = "btnSemester";
            this.btnSemester.Size = new System.Drawing.Size(220, 150);
            this.btnSemester.TabIndex = 167;
            this.btnSemester.UseVisualStyleBackColor = true;
            this.btnSemester.Click += new System.EventHandler(this.btnSemester_Click);
            // 
            // btnEnrolment
            // 
            this.btnEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnrolment.Image = global::CourseManagementSystem.Properties.Resources.enrolment;
            this.btnEnrolment.Location = new System.Drawing.Point(260, 114);
            this.btnEnrolment.Name = "btnEnrolment";
            this.btnEnrolment.Size = new System.Drawing.Size(220, 150);
            this.btnEnrolment.TabIndex = 166;
            this.btnEnrolment.UseVisualStyleBackColor = true;
            this.btnEnrolment.Click += new System.EventHandler(this.btnEnrolment_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCourse.Image = global::CourseManagementSystem.Properties.Resources.course;
            this.btnCourse.Location = new System.Drawing.Point(486, 114);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(220, 150);
            this.btnCourse.TabIndex = 165;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStudent.Image = global::CourseManagementSystem.Properties.Resources.student;
            this.btnStudent.Location = new System.Drawing.Point(34, 114);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(220, 150);
            this.btnStudent.TabIndex = 163;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCourse.Location = new System.Drawing.Point(34, 426);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Size = new System.Drawing.Size(220, 57);
            this.btnStudentCourse.TabIndex = 173;
            this.btnStudentCourse.Text = "Student-Course";
            this.btnStudentCourse.UseVisualStyleBackColor = true;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // btnTeacherCourse
            // 
            this.btnTeacherCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherCourse.Location = new System.Drawing.Point(260, 426);
            this.btnTeacherCourse.Name = "btnTeacherCourse";
            this.btnTeacherCourse.Size = new System.Drawing.Size(220, 57);
            this.btnTeacherCourse.TabIndex = 174;
            this.btnTeacherCourse.Text = "Teacher-Course";
            this.btnTeacherCourse.UseVisualStyleBackColor = true;
            this.btnTeacherCourse.Click += new System.EventHandler(this.btnTeacherCourse_Click);
            // 
            // btnTeacherSkill
            // 
            this.btnTeacherSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherSkill.Location = new System.Drawing.Point(486, 426);
            this.btnTeacherSkill.Name = "btnTeacherSkill";
            this.btnTeacherSkill.Size = new System.Drawing.Size(220, 57);
            this.btnTeacherSkill.TabIndex = 175;
            this.btnTeacherSkill.Text = "Teacher-Skill";
            this.btnTeacherSkill.UseVisualStyleBackColor = true;
            this.btnTeacherSkill.Click += new System.EventHandler(this.btnTeacherSkill_Click);
            // 
            // btnUnitCourse
            // 
            this.btnUnitCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitCourse.Location = new System.Drawing.Point(712, 426);
            this.btnUnitCourse.Name = "btnUnitCourse";
            this.btnUnitCourse.Size = new System.Drawing.Size(220, 57);
            this.btnUnitCourse.TabIndex = 176;
            this.btnUnitCourse.Text = "Unit-Course";
            this.btnUnitCourse.UseVisualStyleBackColor = true;
            this.btnUnitCourse.Click += new System.EventHandler(this.btnUnitCourse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(963, 584);
            this.Controls.Add(this.btnUnitCourse);
            this.Controls.Add(this.btnTeacherSkill);
            this.Controls.Add(this.btnTeacherCourse);
            this.Controls.Add(this.btnStudentCourse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAssessment);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.btnSemester);
            this.Controls.Add(this.btnEnrolment);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.lblDashBoard);
            this.Controls.Add(this.btnStudent);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAssessment;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnSemester;
        private System.Windows.Forms.Button btnEnrolment;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnStudentCourse;
        private System.Windows.Forms.Button btnTeacherCourse;
        private System.Windows.Forms.Button btnTeacherSkill;
        private System.Windows.Forms.Button btnUnitCourse;
    }
}