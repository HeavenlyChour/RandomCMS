namespace CourseManagementSystem
{
    partial class CourseForm
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
            this.components = new System.ComponentModel.Container();
            this.CourseToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbSemesterID = new System.Windows.Forms.ComboBox();
            this.cmbSuburbName = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNumOfUnits = new System.Windows.Forms.TextBox();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblNumOfUnits = new System.Windows.Forms.Label();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.lblCourseLocation = new System.Windows.Forms.Label();
            this.lblCourseSemester = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseForm = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCourseDelivery = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.lblCStartDate = new System.Windows.Forms.Label();
            this.lblCEndDate = new System.Windows.Forms.Label();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.pnlCourseDelivery = new System.Windows.Forms.Panel();
            this.rdbFaceToFace = new System.Windows.Forms.RadioButton();
            this.rdbOnline = new System.Windows.Forms.RadioButton();
            this.cmbSuburbID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlCourseDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSemesterID
            // 
            this.cmbSemesterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemesterID.FormattingEnabled = true;
            this.cmbSemesterID.Location = new System.Drawing.Point(241, 255);
            this.cmbSemesterID.Name = "cmbSemesterID";
            this.cmbSemesterID.Size = new System.Drawing.Size(275, 28);
            this.cmbSemesterID.TabIndex = 5;
            this.cmbSemesterID.Tag = "Course Semester";
            this.CourseToolTip.SetToolTip(this.cmbSemesterID, "press the down arrow to make a selection");
            // 
            // cmbSuburbName
            // 
            this.cmbSuburbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuburbName.FormattingEnabled = true;
            this.cmbSuburbName.Location = new System.Drawing.Point(282, 187);
            this.cmbSuburbName.Name = "cmbSuburbName";
            this.cmbSuburbName.Size = new System.Drawing.Size(234, 28);
            this.cmbSuburbName.TabIndex = 3;
            this.cmbSuburbName.Tag = "Course Location";
            this.CourseToolTip.SetToolTip(this.cmbSuburbName, "press the down arrow to make a selection");
            this.cmbSuburbName.SelectedIndexChanged += new System.EventHandler(this.cmbSuburbName_Changed);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(423, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 60;
            this.CourseToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNumOfUnits
            // 
            this.txtNumOfUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfUnits.Location = new System.Drawing.Point(241, 418);
            this.txtNumOfUnits.Name = "txtNumOfUnits";
            this.txtNumOfUnits.Size = new System.Drawing.Size(113, 26);
            this.txtNumOfUnits.TabIndex = 10;
            this.txtNumOfUnits.Tag = "No. of Units";
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursPerWeek.Location = new System.Drawing.Point(241, 386);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.Size = new System.Drawing.Size(113, 26);
            this.txtHoursPerWeek.TabIndex = 9;
            this.txtHoursPerWeek.Tag = "Hours Per Week";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(241, 123);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(176, 26);
            this.txtCourseID.TabIndex = 1;
            this.txtCourseID.Tag = "Course ID";
            // 
            // lblNumOfUnits
            // 
            this.lblNumOfUnits.AutoSize = true;
            this.lblNumOfUnits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNumOfUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfUnits.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumOfUnits.Location = new System.Drawing.Point(117, 421);
            this.lblNumOfUnits.Name = "lblNumOfUnits";
            this.lblNumOfUnits.Size = new System.Drawing.Size(109, 20);
            this.lblNumOfUnits.TabIndex = 57;
            this.lblNumOfUnits.Text = "No. of Units:";
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPerWeek.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(82, 389);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(144, 20);
            this.lblHoursPerWeek.TabIndex = 55;
            this.lblHoursPerWeek.Text = "Hours Per Week:";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete,
            this.mnuUpdate,
            this.mnuViewAll});
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
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(166, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.ToolTipText = "Update record";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
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
            // dgvCourse
            // 
            this.dgvCourse.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Location = new System.Drawing.Point(12, 498);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.Size = new System.Drawing.Size(642, 208);
            this.dgvCourse.TabIndex = 54;
            // 
            // lblCourseLocation
            // 
            this.lblCourseLocation.AutoSize = true;
            this.lblCourseLocation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseLocation.Location = new System.Drawing.Point(83, 192);
            this.lblCourseLocation.Name = "lblCourseLocation";
            this.lblCourseLocation.Size = new System.Drawing.Size(145, 20);
            this.lblCourseLocation.TabIndex = 52;
            this.lblCourseLocation.Text = "Course Location:";
            // 
            // lblCourseSemester
            // 
            this.lblCourseSemester.AutoSize = true;
            this.lblCourseSemester.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSemester.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseSemester.Location = new System.Drawing.Point(74, 258);
            this.lblCourseSemester.Name = "lblCourseSemester";
            this.lblCourseSemester.Size = new System.Drawing.Size(153, 20);
            this.lblCourseSemester.TabIndex = 41;
            this.lblCourseSemester.Text = "Course Semester:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseName.Location = new System.Drawing.Point(106, 158);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(122, 20);
            this.lblCourseName.TabIndex = 35;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseForm
            // 
            this.lblCourseForm.AutoSize = true;
            this.lblCourseForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseForm.Location = new System.Drawing.Point(234, 47);
            this.lblCourseForm.Name = "lblCourseForm";
            this.lblCourseForm.Size = new System.Drawing.Size(216, 37);
            this.lblCourseForm.TabIndex = 33;
            this.lblCourseForm.Text = "Course Form";
            this.lblCourseForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseID.Location = new System.Drawing.Point(133, 126);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(95, 20);
            this.lblCourseID.TabIndex = 32;
            this.lblCourseID.Text = "Course ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
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
            this.mnuClearAll.Click += new System.EventHandler(this.mnuClearAll_Click);
            // 
            // lblCourseDelivery
            // 
            this.lblCourseDelivery.AutoSize = true;
            this.lblCourseDelivery.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDelivery.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseDelivery.Location = new System.Drawing.Point(85, 358);
            this.lblCourseDelivery.Name = "lblCourseDelivery";
            this.lblCourseDelivery.Size = new System.Drawing.Size(139, 20);
            this.lblCourseDelivery.TabIndex = 61;
            this.lblCourseDelivery.Text = "Course Delivery:";
            // 
            // lblCourseFee
            // 
            this.lblCourseFee.AutoSize = true;
            this.lblCourseFee.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseFee.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseFee.Location = new System.Drawing.Point(117, 453);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(107, 20);
            this.lblCourseFee.TabIndex = 65;
            this.lblCourseFee.Text = "Course Fee:";
            // 
            // lblCStartDate
            // 
            this.lblCStartDate.AutoSize = true;
            this.lblCStartDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCStartDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCStartDate.Location = new System.Drawing.Point(126, 292);
            this.lblCStartDate.Name = "lblCStartDate";
            this.lblCStartDate.Size = new System.Drawing.Size(98, 20);
            this.lblCStartDate.TabIndex = 69;
            this.lblCStartDate.Text = "Start Date:";
            // 
            // lblCEndDate
            // 
            this.lblCEndDate.AutoSize = true;
            this.lblCEndDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEndDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCEndDate.Location = new System.Drawing.Point(129, 324);
            this.lblCEndDate.Name = "lblCEndDate";
            this.lblCEndDate.Size = new System.Drawing.Size(95, 20);
            this.lblCEndDate.TabIndex = 71;
            this.lblCEndDate.Text = "End  Date:";
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDuration.Location = new System.Drawing.Point(241, 223);
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(113, 26);
            this.txtCourseDuration.TabIndex = 4;
            this.txtCourseDuration.Tag = "Course Duration";
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDuration.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseDuration.Location = new System.Drawing.Point(82, 226);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(145, 20);
            this.lblCourseDuration.TabIndex = 73;
            this.lblCourseDuration.Text = "Course Duration:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(241, 289);
            this.dtpStartDate.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(275, 26);
            this.dtpStartDate.TabIndex = 74;
            this.dtpStartDate.Tag = "Start Date";
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(241, 321);
            this.dtpEndDate.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(275, 26);
            this.dtpEndDate.TabIndex = 75;
            this.dtpEndDate.Tag = "End Date";
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(241, 155);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(275, 26);
            this.txtCourseName.TabIndex = 76;
            this.txtCourseName.Tag = "Course Name";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseFee.Location = new System.Drawing.Point(241, 450);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(113, 26);
            this.txtCourseFee.TabIndex = 77;
            this.txtCourseFee.Tag = "Course Fee";
            // 
            // pnlCourseDelivery
            // 
            this.pnlCourseDelivery.Controls.Add(this.rdbFaceToFace);
            this.pnlCourseDelivery.Controls.Add(this.rdbOnline);
            this.pnlCourseDelivery.Location = new System.Drawing.Point(241, 353);
            this.pnlCourseDelivery.Name = "pnlCourseDelivery";
            this.pnlCourseDelivery.Size = new System.Drawing.Size(246, 25);
            this.pnlCourseDelivery.TabIndex = 103;
            // 
            // rdbFaceToFace
            // 
            this.rdbFaceToFace.AutoSize = true;
            this.rdbFaceToFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFaceToFace.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbFaceToFace.Location = new System.Drawing.Point(3, 3);
            this.rdbFaceToFace.Name = "rdbFaceToFace";
            this.rdbFaceToFace.Size = new System.Drawing.Size(133, 24);
            this.rdbFaceToFace.TabIndex = 67;
            this.rdbFaceToFace.TabStop = true;
            this.rdbFaceToFace.Tag = "Course Delivery";
            this.rdbFaceToFace.Text = "Face to Face";
            this.rdbFaceToFace.UseVisualStyleBackColor = true;
            // 
            // rdbOnline
            // 
            this.rdbOnline.AutoSize = true;
            this.rdbOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbOnline.Location = new System.Drawing.Point(142, 3);
            this.rdbOnline.Name = "rdbOnline";
            this.rdbOnline.Size = new System.Drawing.Size(78, 24);
            this.rdbOnline.TabIndex = 68;
            this.rdbOnline.TabStop = true;
            this.rdbOnline.Tag = "Course Delivery";
            this.rdbOnline.Text = "Online";
            this.rdbOnline.UseVisualStyleBackColor = true;
            // 
            // cmbSuburbID
            // 
            this.cmbSuburbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSuburbID.Enabled = false;
            this.cmbSuburbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuburbID.FormattingEnabled = true;
            this.cmbSuburbID.Location = new System.Drawing.Point(241, 187);
            this.cmbSuburbID.Name = "cmbSuburbID";
            this.cmbSuburbID.Size = new System.Drawing.Size(35, 28);
            this.cmbSuburbID.TabIndex = 127;
            this.cmbSuburbID.Tag = "Suburb ID";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(666, 719);
            this.Controls.Add(this.cmbSuburbID);
            this.Controls.Add(this.pnlCourseDelivery);
            this.Controls.Add(this.txtCourseFee);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtCourseDuration);
            this.Controls.Add(this.lblCourseDuration);
            this.Controls.Add(this.lblCEndDate);
            this.Controls.Add(this.lblCStartDate);
            this.Controls.Add(this.lblCourseFee);
            this.Controls.Add(this.cmbSuburbName);
            this.Controls.Add(this.cmbSemesterID);
            this.Controls.Add(this.lblCourseDelivery);
            this.Controls.Add(this.txtNumOfUnits);
            this.Controls.Add(this.lblNumOfUnits);
            this.Controls.Add(this.txtHoursPerWeek);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.lblCourseLocation);
            this.Controls.Add(this.lblCourseSemester);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseForm);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Form";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCourseDelivery.ResumeLayout(false);
            this.pnlCourseDelivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip CourseToolTip;
        private System.Windows.Forms.TextBox txtNumOfUnits;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblNumOfUnits;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAll;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigate;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrolmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCourseForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitForm;
        private System.Windows.Forms.ToolStripMenuItem mnuAssessmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuTeacherForm;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label lblCourseLocation;
        private System.Windows.Forms.Label lblCourseSemester;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseForm;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblCourseDelivery;
        private System.Windows.Forms.ComboBox cmbSemesterID;
        private System.Windows.Forms.ComboBox cmbSuburbName;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.Label lblCStartDate;
        private System.Windows.Forms.Label lblCEndDate;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuClearAll;
        private System.Windows.Forms.Panel pnlCourseDelivery;
        private System.Windows.Forms.RadioButton rdbFaceToFace;
        private System.Windows.Forms.RadioButton rdbOnline;
        private System.Windows.Forms.ComboBox cmbSuburbID;
    }
}