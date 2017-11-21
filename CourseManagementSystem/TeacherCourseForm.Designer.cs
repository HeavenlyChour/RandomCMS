namespace CourseManagementSystem
{
    partial class TeacherCourseForm
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
            this.lblTeacherCourseForm = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.dgvTeacherCourse = new System.Windows.Forms.DataGridView();
            this.cmbTeacherID = new System.Windows.Forms.ComboBox();
            this.cmbCourseID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeacherCourseForm
            // 
            this.lblTeacherCourseForm.AutoSize = true;
            this.lblTeacherCourseForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherCourseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherCourseForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherCourseForm.Location = new System.Drawing.Point(60, 35);
            this.lblTeacherCourseForm.Name = "lblTeacherCourseForm";
            this.lblTeacherCourseForm.Size = new System.Drawing.Size(351, 37);
            this.lblTeacherCourseForm.TabIndex = 34;
            this.lblTeacherCourseForm.Text = "Teacher-Course Form";
            this.lblTeacherCourseForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherID.Location = new System.Drawing.Point(4, 99);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(103, 20);
            this.lblTeacherID.TabIndex = 37;
            this.lblTeacherID.Text = "Teacher ID:";
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Items.AddRange(new object[] {
            "IT",
            "Science",
            "Maths",
            "Food",
            "Music"});
            this.cmbTeacherName.Location = new System.Drawing.Point(154, 96);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(305, 28);
            this.cmbTeacherName.TabIndex = 2;
            this.cmbTeacherName.Tag = "Teacher Name";
            this.cmbTeacherName.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherName_Changed);
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Items.AddRange(new object[] {
            "IT",
            "Science",
            "Maths",
            "Food",
            "Music"});
            this.cmbCourseName.Location = new System.Drawing.Point(154, 130);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(305, 28);
            this.cmbCourseName.TabIndex = 3;
            this.cmbCourseName.Tag = "Course Name";
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_Changed);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseID.Location = new System.Drawing.Point(12, 133);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(95, 20);
            this.lblCourseID.TabIndex = 40;
            this.lblCourseID.Text = "Course ID:";
            // 
            // dgvTeacherCourse
            // 
            this.dgvTeacherCourse.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeacherCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherCourse.Location = new System.Drawing.Point(12, 164);
            this.dgvTeacherCourse.Name = "dgvTeacherCourse";
            this.dgvTeacherCourse.ReadOnly = true;
            this.dgvTeacherCourse.Size = new System.Drawing.Size(447, 235);
            this.dgvTeacherCourse.TabIndex = 55;
            // 
            // cmbTeacherID
            // 
            this.cmbTeacherID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbTeacherID.Enabled = false;
            this.cmbTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacherID.FormattingEnabled = true;
            this.cmbTeacherID.Location = new System.Drawing.Point(113, 96);
            this.cmbTeacherID.Name = "cmbTeacherID";
            this.cmbTeacherID.Size = new System.Drawing.Size(35, 28);
            this.cmbTeacherID.TabIndex = 128;
            this.cmbTeacherID.Tag = "Teacher ID";
            // 
            // cmbCourseID
            // 
            this.cmbCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCourseID.Enabled = false;
            this.cmbCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseID.FormattingEnabled = true;
            this.cmbCourseID.Location = new System.Drawing.Point(113, 130);
            this.cmbCourseID.Name = "cmbCourseID";
            this.cmbCourseID.Size = new System.Drawing.Size(35, 28);
            this.cmbCourseID.TabIndex = 129;
            this.cmbCourseID.Tag = "Course ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 130;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete,
            this.mnuViewAll,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(42, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.ToolTipText = "Press to add, delete, update or view all";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAdd.Size = new System.Drawing.Size(166, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add a new record";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(166, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.ToolTipText = "Delete  record";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuViewAll
            // 
            this.mnuViewAll.Name = "mnuViewAll";
            this.mnuViewAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuViewAll.Size = new System.Drawing.Size(166, 22);
            this.mnuViewAll.Text = "View All";
            this.mnuViewAll.ToolTipText = "View All record";
            this.mnuViewAll.Click += new System.EventHandler(this.mnuViewAll_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(166, 22);
            this.mnuExit.Text = "Exit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClearAll});
            this.mnuEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(43, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuClearAll
            // 
            this.mnuClearAll.Name = "mnuClearAll";
            this.mnuClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.mnuClearAll.Size = new System.Drawing.Size(191, 22);
            this.mnuClearAll.Text = "Clear All";
            // 
            // mnuNavigate
            // 
            this.mnuNavigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnrolmentForm,
            this.mnuCourseForm,
            this.mnuUnitForm,
            this.mnuAssessmentForm,
            this.mnuTeacherForm});
            this.mnuNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNavigate.Name = "mnuNavigate";
            this.mnuNavigate.Size = new System.Drawing.Size(75, 20);
            this.mnuNavigate.Text = "Navigate";
            this.mnuNavigate.ToolTipText = "Navigate to enrolment form";
            // 
            // mnuEnrolmentForm
            // 
            this.mnuEnrolmentForm.Name = "mnuEnrolmentForm";
            this.mnuEnrolmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuEnrolmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuEnrolmentForm.Text = "Enrolment Form";
            this.mnuEnrolmentForm.ToolTipText = "Go to enrolment form";
            // 
            // mnuCourseForm
            // 
            this.mnuCourseForm.Name = "mnuCourseForm";
            this.mnuCourseForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuCourseForm.Size = new System.Drawing.Size(259, 22);
            this.mnuCourseForm.Text = "Course Form";
            this.mnuCourseForm.ToolTipText = "Go to course form";
            // 
            // mnuUnitForm
            // 
            this.mnuUnitForm.Name = "mnuUnitForm";
            this.mnuUnitForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.mnuUnitForm.Size = new System.Drawing.Size(259, 22);
            this.mnuUnitForm.Text = "Unit Form";
            this.mnuUnitForm.ToolTipText = "Go to unit form";
            // 
            // mnuAssessmentForm
            // 
            this.mnuAssessmentForm.Name = "mnuAssessmentForm";
            this.mnuAssessmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuAssessmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuAssessmentForm.Text = "Assessment Form";
            this.mnuAssessmentForm.ToolTipText = "Go to assessment form";
            // 
            // mnuTeacherForm
            // 
            this.mnuTeacherForm.Name = "mnuTeacherForm";
            this.mnuTeacherForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mnuTeacherForm.Size = new System.Drawing.Size(259, 22);
            this.mnuTeacherForm.Text = "Teacher Form";
            this.mnuTeacherForm.ToolTipText = "Go to teacher form";
            // 
            // TeacherCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(471, 411);
            this.Controls.Add(this.cmbCourseID);
            this.Controls.Add(this.cmbTeacherID);
            this.Controls.Add(this.dgvTeacherCourse);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.cmbTeacherName);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lblTeacherCourseForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TeacherCourseForm";
            this.Text = "Unit Course Form";
            this.Load += new System.EventHandler(this.TeacherCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacherCourseForm;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.DataGridView dgvTeacherCourse;
        private System.Windows.Forms.ComboBox cmbTeacherID;
        private System.Windows.Forms.ComboBox cmbCourseID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigate;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrolmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCourseForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitForm;
        private System.Windows.Forms.ToolStripMenuItem mnuAssessmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuTeacherForm;
    }
}