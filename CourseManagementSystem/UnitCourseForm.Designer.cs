namespace CourseManagementSystem
{
    partial class UnitCourseForm
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
            this.lblUnitCourseForm = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.dgvUnitCourse = new System.Windows.Forms.DataGridView();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnitCourseForm
            // 
            this.lblUnitCourseForm.AutoSize = true;
            this.lblUnitCourseForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitCourseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCourseForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitCourseForm.Location = new System.Drawing.Point(89, 33);
            this.lblUnitCourseForm.Name = "lblUnitCourseForm";
            this.lblUnitCourseForm.Size = new System.Drawing.Size(288, 37);
            this.lblUnitCourseForm.TabIndex = 34;
            this.lblUnitCourseForm.Text = "Unit-Course Form";
            this.lblUnitCourseForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitID.Location = new System.Drawing.Point(36, 99);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(71, 20);
            this.lblUnitID.TabIndex = 37;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Items.AddRange(new object[] {
            "IT",
            "Science",
            "Maths",
            "Food",
            "Music"});
            this.cmbUnitName.Location = new System.Drawing.Point(154, 96);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(305, 28);
            this.cmbUnitName.TabIndex = 2;
            this.cmbUnitName.Tag = "Unit Name";
            this.cmbUnitName.SelectedIndexChanged += new System.EventHandler(this.cmbUnitName_Changed);
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
            // dgvUnitCourse
            // 
            this.dgvUnitCourse.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUnitCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitCourse.Location = new System.Drawing.Point(12, 164);
            this.dgvUnitCourse.Name = "dgvUnitCourse";
            this.dgvUnitCourse.ReadOnly = true;
            this.dgvUnitCourse.Size = new System.Drawing.Size(447, 235);
            this.dgvUnitCourse.TabIndex = 55;
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbUnitID.Enabled = false;
            this.cmbUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(113, 96);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(35, 28);
            this.cmbUnitID.TabIndex = 128;
            this.cmbUnitID.Tag = "Unit ID";
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
            // UnitCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(471, 411);
            this.Controls.Add(this.cmbCourseID);
            this.Controls.Add(this.cmbUnitID);
            this.Controls.Add(this.dgvUnitCourse);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.cmbUnitName);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.lblUnitCourseForm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UnitCourseForm";
            this.Text = "Unit Course Form";
            this.Load += new System.EventHandler(this.UnitCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitCourseForm;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.DataGridView dgvUnitCourse;
        private System.Windows.Forms.ComboBox cmbUnitID;
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