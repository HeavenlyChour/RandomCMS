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
            this.cmbCourseSemester = new System.Windows.Forms.ComboBox();
            this.cmbCourseLocation = new System.Windows.Forms.ComboBox();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.cmbCourseFee = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNumOfUnits = new System.Windows.Forms.TextBox();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.txtCStartDate = new System.Windows.Forms.TextBox();
            this.txtCEndDate = new System.Windows.Forms.TextBox();
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
            this.lblCourseDelivery = new System.Windows.Forms.Label();
            this.lblCourseFee = new System.Windows.Forms.Label();
            this.rdbOnline = new System.Windows.Forms.RadioButton();
            this.rdbFaceToFace = new System.Windows.Forms.RadioButton();
            this.lblCStartDate = new System.Windows.Forms.Label();
            this.lblCEndDate = new System.Windows.Forms.Label();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCourseSemester
            // 
            this.cmbCourseSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseSemester.FormattingEnabled = true;
            this.cmbCourseSemester.Location = new System.Drawing.Point(241, 255);
            this.cmbCourseSemester.Name = "cmbCourseSemester";
            this.cmbCourseSemester.Size = new System.Drawing.Size(176, 28);
            this.cmbCourseSemester.TabIndex = 5;
            this.cmbCourseSemester.Tag = "Course Semester";
            this.CourseToolTip.SetToolTip(this.cmbCourseSemester, "press the down arrow to make a selection");
            // 
            // cmbCourseLocation
            // 
            this.cmbCourseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseLocation.FormattingEnabled = true;
            this.cmbCourseLocation.Location = new System.Drawing.Point(241, 189);
            this.cmbCourseLocation.Name = "cmbCourseLocation";
            this.cmbCourseLocation.Size = new System.Drawing.Size(217, 28);
            this.cmbCourseLocation.TabIndex = 3;
            this.cmbCourseLocation.Tag = "Course Location";
            this.CourseToolTip.SetToolTip(this.cmbCourseLocation, "press the down arrow to make a selection");
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(241, 155);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(347, 28);
            this.cmbCourseName.TabIndex = 2;
            this.cmbCourseName.Tag = "Course Name";
            this.CourseToolTip.SetToolTip(this.cmbCourseName, "press the down arrow to make a selection");
            // 
            // cmbCourseFee
            // 
            this.cmbCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseFee.FormattingEnabled = true;
            this.cmbCourseFee.Location = new System.Drawing.Point(241, 448);
            this.cmbCourseFee.Name = "cmbCourseFee";
            this.cmbCourseFee.Size = new System.Drawing.Size(176, 28);
            this.cmbCourseFee.TabIndex = 11;
            this.cmbCourseFee.Tag = "Course Fee";
            this.CourseToolTip.SetToolTip(this.cmbCourseFee, "press the down arrow to make a selection");
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
            // 
            // txtNumOfUnits
            // 
            this.txtNumOfUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfUnits.Location = new System.Drawing.Point(241, 416);
            this.txtNumOfUnits.Name = "txtNumOfUnits";
            this.txtNumOfUnits.Size = new System.Drawing.Size(113, 26);
            this.txtNumOfUnits.TabIndex = 10;
            this.txtNumOfUnits.Tag = "No. of Units";
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursPerWeek.Location = new System.Drawing.Point(241, 384);
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.Size = new System.Drawing.Size(113, 26);
            this.txtHoursPerWeek.TabIndex = 9;
            this.txtHoursPerWeek.Tag = "Hours Per Week";
            // 
            // txtCStartDate
            // 
            this.txtCStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCStartDate.Location = new System.Drawing.Point(241, 289);
            this.txtCStartDate.Name = "txtCStartDate";
            this.txtCStartDate.Size = new System.Drawing.Size(176, 26);
            this.txtCStartDate.TabIndex = 6;
            this.txtCStartDate.Tag = "Course Start Date";
            // 
            // txtCEndDate
            // 
            this.txtCEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEndDate.Location = new System.Drawing.Point(241, 321);
            this.txtCEndDate.Name = "txtCEndDate";
            this.txtCEndDate.Size = new System.Drawing.Size(176, 26);
            this.txtCEndDate.TabIndex = 7;
            this.txtCEndDate.Tag = "Course End Date";
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
            this.lblNumOfUnits.Location = new System.Drawing.Point(117, 419);
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
            this.lblHoursPerWeek.Location = new System.Drawing.Point(82, 387);
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
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(166, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.ToolTipText = "Delete  record";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(166, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.ToolTipText = "Update record";
            // 
            // mnuViewAll
            // 
            this.mnuViewAll.Name = "mnuViewAll";
            this.mnuViewAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuViewAll.Size = new System.Drawing.Size(166, 22);
            this.mnuViewAll.Text = "View All";
            this.mnuViewAll.ToolTipText = "View All record";
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
            this.dgvCourse.Location = new System.Drawing.Point(12, 586);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.Size = new System.Drawing.Size(642, 120);
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
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblCourseDelivery
            // 
            this.lblCourseDelivery.AutoSize = true;
            this.lblCourseDelivery.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDelivery.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseDelivery.Location = new System.Drawing.Point(89, 356);
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
            this.lblCourseFee.Location = new System.Drawing.Point(117, 451);
            this.lblCourseFee.Name = "lblCourseFee";
            this.lblCourseFee.Size = new System.Drawing.Size(107, 20);
            this.lblCourseFee.TabIndex = 65;
            this.lblCourseFee.Text = "Course Fee:";
            // 
            // rdbOnline
            // 
            this.rdbOnline.AutoSize = true;
            this.rdbOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbOnline.Location = new System.Drawing.Point(382, 354);
            this.rdbOnline.Name = "rdbOnline";
            this.rdbOnline.Size = new System.Drawing.Size(78, 24);
            this.rdbOnline.TabIndex = 68;
            this.rdbOnline.TabStop = true;
            this.rdbOnline.Tag = "Course Delivery";
            this.rdbOnline.Text = "Online";
            this.rdbOnline.UseVisualStyleBackColor = true;
            // 
            // rdbFaceToFace
            // 
            this.rdbFaceToFace.AutoSize = true;
            this.rdbFaceToFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFaceToFace.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbFaceToFace.Location = new System.Drawing.Point(243, 354);
            this.rdbFaceToFace.Name = "rdbFaceToFace";
            this.rdbFaceToFace.Size = new System.Drawing.Size(133, 24);
            this.rdbFaceToFace.TabIndex = 67;
            this.rdbFaceToFace.TabStop = true;
            this.rdbFaceToFace.Tag = "Course Delivery";
            this.rdbFaceToFace.Text = "Face to Face";
            this.rdbFaceToFace.UseVisualStyleBackColor = true;
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
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(666, 719);
            this.Controls.Add(this.txtCourseDuration);
            this.Controls.Add(this.lblCourseDuration);
            this.Controls.Add(this.txtCEndDate);
            this.Controls.Add(this.lblCEndDate);
            this.Controls.Add(this.txtCStartDate);
            this.Controls.Add(this.lblCStartDate);
            this.Controls.Add(this.rdbOnline);
            this.Controls.Add(this.rdbFaceToFace);
            this.Controls.Add(this.cmbCourseFee);
            this.Controls.Add(this.lblCourseFee);
            this.Controls.Add(this.cmbCourseName);
            this.Controls.Add(this.cmbCourseLocation);
            this.Controls.Add(this.cmbCourseSemester);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbCourseSemester;
        private System.Windows.Forms.ComboBox cmbCourseLocation;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.ComboBox cmbCourseFee;
        private System.Windows.Forms.Label lblCourseFee;
        private System.Windows.Forms.RadioButton rdbOnline;
        private System.Windows.Forms.RadioButton rdbFaceToFace;
        private System.Windows.Forms.TextBox txtCStartDate;
        private System.Windows.Forms.Label lblCStartDate;
        private System.Windows.Forms.TextBox txtCEndDate;
        private System.Windows.Forms.Label lblCEndDate;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label lblCourseDuration;
    }
}