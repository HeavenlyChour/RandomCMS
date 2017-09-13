namespace CourseManagementSystem
{
    partial class EnrolmentForm
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
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.lblExpectedEndDate = new System.Windows.Forms.Label();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblEnrolmentForm = new System.Windows.Forms.Label();
            this.lblEnrolmentID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.EnrolmentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtExpectedEndDate = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.txtEnrolmentID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblEnrolmentDate = new System.Windows.Forms.Label();
            this.txtEnrolmentDate = new System.Windows.Forms.TextBox();
            this.lblPaymentDueDate = new System.Windows.Forms.Label();
            this.txtPaymentDueDate = new System.Windows.Forms.TextBox();
            this.lblBalanceOwing = new System.Windows.Forms.Label();
            this.txtBalanceOwing = new System.Windows.Forms.TextBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.rdbDisabilityNo = new System.Windows.Forms.RadioButton();
            this.rdbDisabilityYes = new System.Windows.Forms.RadioButton();
            this.lblDisability = new System.Windows.Forms.Label();
            this.lblStudyStatus = new System.Windows.Forms.Label();
            this.cmbStudyStatus = new System.Windows.Forms.ComboBox();
            this.txtDisabilityDescription = new System.Windows.Forms.TextBox();
            this.lblDisabilityDescription = new System.Windows.Forms.Label();
            this.rdbOnline = new System.Windows.Forms.RadioButton();
            this.rdbFaceToFace = new System.Windows.Forms.RadioButton();
            this.lblCourseDelivery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // mnuUnitForm
            // 
            this.mnuUnitForm.Name = "mnuUnitForm";
            this.mnuUnitForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.mnuUnitForm.Size = new System.Drawing.Size(259, 22);
            this.mnuUnitForm.Text = "Unit Form";
            this.mnuUnitForm.ToolTipText = "Go to unit form";
            // 
            // lblExpectedEndDate
            // 
            this.lblExpectedEndDate.AutoSize = true;
            this.lblExpectedEndDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblExpectedEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedEndDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblExpectedEndDate.Location = new System.Drawing.Point(142, 266);
            this.lblExpectedEndDate.Name = "lblExpectedEndDate";
            this.lblExpectedEndDate.Size = new System.Drawing.Size(170, 20);
            this.lblExpectedEndDate.TabIndex = 100;
            this.lblExpectedEndDate.Text = "Expected End Date:";
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(12, 660);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(642, 120);
            this.dgvTeacher.TabIndex = 93;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPaymentStatus.Location = new System.Drawing.Point(172, 459);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(141, 20);
            this.lblPaymentStatus.TabIndex = 85;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // lblEnrolmentForm
            // 
            this.lblEnrolmentForm.AutoSize = true;
            this.lblEnrolmentForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblEnrolmentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolmentForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEnrolmentForm.Location = new System.Drawing.Point(239, 60);
            this.lblEnrolmentForm.Name = "lblEnrolmentForm";
            this.lblEnrolmentForm.Size = new System.Drawing.Size(262, 37);
            this.lblEnrolmentForm.TabIndex = 77;
            this.lblEnrolmentForm.Text = "Enrolment Form";
            this.lblEnrolmentForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnrolmentID
            // 
            this.lblEnrolmentID.AutoSize = true;
            this.lblEnrolmentID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblEnrolmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolmentID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEnrolmentID.Location = new System.Drawing.Point(195, 138);
            this.lblEnrolmentID.Name = "lblEnrolmentID";
            this.lblEnrolmentID.Size = new System.Drawing.Size(120, 20);
            this.lblEnrolmentID.TabIndex = 76;
            this.lblEnrolmentID.Text = "Enrolment ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 98;
            this.menuStrip1.Text = "menuStrip1";
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
            // txtExpectedEndDate
            // 
            this.txtExpectedEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpectedEndDate.Location = new System.Drawing.Point(325, 263);
            this.txtExpectedEndDate.Name = "txtExpectedEndDate";
            this.txtExpectedEndDate.Size = new System.Drawing.Size(224, 26);
            this.txtExpectedEndDate.TabIndex = 101;
            this.txtExpectedEndDate.Tag = "Expected End Date";
            this.EnrolmentToolTip.SetToolTip(this.txtExpectedEndDate, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(507, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 99;
            this.EnrolmentToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(325, 456);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(176, 28);
            this.cmbPaymentStatus.TabIndex = 86;
            this.cmbPaymentStatus.Tag = "Payment Status";
            this.EnrolmentToolTip.SetToolTip(this.cmbPaymentStatus, "press the down arrow to make a selection");
            // 
            // txtEnrolmentID
            // 
            this.txtEnrolmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrolmentID.Location = new System.Drawing.Point(325, 135);
            this.txtEnrolmentID.Name = "txtEnrolmentID";
            this.txtEnrolmentID.Size = new System.Drawing.Size(176, 26);
            this.txtEnrolmentID.TabIndex = 78;
            this.txtEnrolmentID.Tag = "Enrolment ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(325, 167);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(176, 26);
            this.txtStudentID.TabIndex = 113;
            this.txtStudentID.Tag = "Student ID";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentID.Location = new System.Drawing.Point(211, 170);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(102, 20);
            this.lblStudentID.TabIndex = 112;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(325, 199);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(176, 26);
            this.txtCourseID.TabIndex = 115;
            this.txtCourseID.Tag = "Course ID";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseID.Location = new System.Drawing.Point(217, 202);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(95, 20);
            this.lblCourseID.TabIndex = 114;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblEnrolmentDate
            // 
            this.lblEnrolmentDate.AutoSize = true;
            this.lblEnrolmentDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblEnrolmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrolmentDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEnrolmentDate.Location = new System.Drawing.Point(172, 234);
            this.lblEnrolmentDate.Name = "lblEnrolmentDate";
            this.lblEnrolmentDate.Size = new System.Drawing.Size(140, 20);
            this.lblEnrolmentDate.TabIndex = 116;
            this.lblEnrolmentDate.Text = "Enrolment Date:";
            // 
            // txtEnrolmentDate
            // 
            this.txtEnrolmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrolmentDate.Location = new System.Drawing.Point(325, 231);
            this.txtEnrolmentDate.Name = "txtEnrolmentDate";
            this.txtEnrolmentDate.Size = new System.Drawing.Size(224, 26);
            this.txtEnrolmentDate.TabIndex = 117;
            this.txtEnrolmentDate.Tag = "Enrolment Date";
            this.EnrolmentToolTip.SetToolTip(this.txtEnrolmentDate, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // lblPaymentDueDate
            // 
            this.lblPaymentDueDate.AutoSize = true;
            this.lblPaymentDueDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPaymentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDueDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPaymentDueDate.Location = new System.Drawing.Point(147, 363);
            this.lblPaymentDueDate.Name = "lblPaymentDueDate";
            this.lblPaymentDueDate.Size = new System.Drawing.Size(165, 20);
            this.lblPaymentDueDate.TabIndex = 121;
            this.lblPaymentDueDate.Text = "Payment Due Date:";
            // 
            // txtPaymentDueDate
            // 
            this.txtPaymentDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentDueDate.Location = new System.Drawing.Point(325, 360);
            this.txtPaymentDueDate.Name = "txtPaymentDueDate";
            this.txtPaymentDueDate.Size = new System.Drawing.Size(224, 26);
            this.txtPaymentDueDate.TabIndex = 122;
            this.txtPaymentDueDate.Tag = "Payment Due Date";
            this.EnrolmentToolTip.SetToolTip(this.txtPaymentDueDate, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // lblBalanceOwing
            // 
            this.lblBalanceOwing.AutoSize = true;
            this.lblBalanceOwing.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblBalanceOwing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceOwing.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBalanceOwing.Location = new System.Drawing.Point(179, 427);
            this.lblBalanceOwing.Name = "lblBalanceOwing";
            this.lblBalanceOwing.Size = new System.Drawing.Size(133, 20);
            this.lblBalanceOwing.TabIndex = 123;
            this.lblBalanceOwing.Text = "Balance Owing:";
            // 
            // txtBalanceOwing
            // 
            this.txtBalanceOwing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceOwing.Location = new System.Drawing.Point(325, 424);
            this.txtBalanceOwing.Name = "txtBalanceOwing";
            this.txtBalanceOwing.Size = new System.Drawing.Size(176, 26);
            this.txtBalanceOwing.TabIndex = 124;
            this.txtBalanceOwing.Tag = "Balance Owing";
            this.EnrolmentToolTip.SetToolTip(this.txtBalanceOwing, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPaid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAmountPaid.Location = new System.Drawing.Point(195, 395);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(116, 20);
            this.lblAmountPaid.TabIndex = 125;
            this.lblAmountPaid.Text = "Amount Paid:";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Location = new System.Drawing.Point(325, 392);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(176, 26);
            this.txtAmountPaid.TabIndex = 126;
            this.txtAmountPaid.Tag = "Amount Paid";
            this.EnrolmentToolTip.SetToolTip(this.txtAmountPaid, "Date format must be yyyy-mm-dd and contain only numeric characters");
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPaymentMethod.Location = new System.Drawing.Point(163, 329);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(148, 20);
            this.lblPaymentMethod.TabIndex = 127;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(325, 326);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(176, 28);
            this.cmbPaymentMethod.TabIndex = 128;
            this.cmbPaymentMethod.Tag = "Payment Method";
            this.EnrolmentToolTip.SetToolTip(this.cmbPaymentMethod, "press the down arrow to make a selection");
            // 
            // rdbDisabilityNo
            // 
            this.rdbDisabilityNo.AutoSize = true;
            this.rdbDisabilityNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDisabilityNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbDisabilityNo.Location = new System.Drawing.Point(396, 490);
            this.rdbDisabilityNo.Name = "rdbDisabilityNo";
            this.rdbDisabilityNo.Size = new System.Drawing.Size(49, 24);
            this.rdbDisabilityNo.TabIndex = 131;
            this.rdbDisabilityNo.TabStop = true;
            this.rdbDisabilityNo.Tag = "Disability";
            this.rdbDisabilityNo.Text = "No";
            this.rdbDisabilityNo.UseVisualStyleBackColor = true;
            // 
            // rdbDisabilityYes
            // 
            this.rdbDisabilityYes.AutoSize = true;
            this.rdbDisabilityYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDisabilityYes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbDisabilityYes.Location = new System.Drawing.Point(325, 490);
            this.rdbDisabilityYes.Name = "rdbDisabilityYes";
            this.rdbDisabilityYes.Size = new System.Drawing.Size(58, 24);
            this.rdbDisabilityYes.TabIndex = 130;
            this.rdbDisabilityYes.TabStop = true;
            this.rdbDisabilityYes.Tag = "Disability";
            this.rdbDisabilityYes.Text = "Yes";
            this.rdbDisabilityYes.UseVisualStyleBackColor = true;
            // 
            // lblDisability
            // 
            this.lblDisability.AutoSize = true;
            this.lblDisability.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisability.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDisability.Location = new System.Drawing.Point(67, 492);
            this.lblDisability.Name = "lblDisability";
            this.lblDisability.Size = new System.Drawing.Size(244, 20);
            this.lblDisability.TabIndex = 129;
            this.lblDisability.Text = "Does student have disability?";
            // 
            // lblStudyStatus
            // 
            this.lblStudyStatus.AutoSize = true;
            this.lblStudyStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudyStatus.Location = new System.Drawing.Point(193, 601);
            this.lblStudyStatus.Name = "lblStudyStatus";
            this.lblStudyStatus.Size = new System.Drawing.Size(118, 20);
            this.lblStudyStatus.TabIndex = 132;
            this.lblStudyStatus.Text = "Study Status:";
            // 
            // cmbStudyStatus
            // 
            this.cmbStudyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudyStatus.FormattingEnabled = true;
            this.cmbStudyStatus.Location = new System.Drawing.Point(325, 598);
            this.cmbStudyStatus.Name = "cmbStudyStatus";
            this.cmbStudyStatus.Size = new System.Drawing.Size(176, 28);
            this.cmbStudyStatus.TabIndex = 133;
            this.cmbStudyStatus.Tag = "Study Status";
            this.EnrolmentToolTip.SetToolTip(this.cmbStudyStatus, "press the down arrow to make a selection");
            // 
            // txtDisabilityDescription
            // 
            this.txtDisabilityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisabilityDescription.Location = new System.Drawing.Point(325, 520);
            this.txtDisabilityDescription.Multiline = true;
            this.txtDisabilityDescription.Name = "txtDisabilityDescription";
            this.txtDisabilityDescription.Size = new System.Drawing.Size(312, 72);
            this.txtDisabilityDescription.TabIndex = 135;
            this.txtDisabilityDescription.Tag = "Disability Description";
            // 
            // lblDisabilityDescription
            // 
            this.lblDisabilityDescription.AutoSize = true;
            this.lblDisabilityDescription.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisabilityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabilityDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDisabilityDescription.Location = new System.Drawing.Point(129, 523);
            this.lblDisabilityDescription.Name = "lblDisabilityDescription";
            this.lblDisabilityDescription.Size = new System.Drawing.Size(186, 20);
            this.lblDisabilityDescription.TabIndex = 134;
            this.lblDisabilityDescription.Text = "If Yes, please specify:";
            // 
            // rdbOnline
            // 
            this.rdbOnline.AutoSize = true;
            this.rdbOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbOnline.Location = new System.Drawing.Point(464, 296);
            this.rdbOnline.Name = "rdbOnline";
            this.rdbOnline.Size = new System.Drawing.Size(78, 24);
            this.rdbOnline.TabIndex = 138;
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
            this.rdbFaceToFace.Location = new System.Drawing.Point(325, 296);
            this.rdbFaceToFace.Name = "rdbFaceToFace";
            this.rdbFaceToFace.Size = new System.Drawing.Size(133, 24);
            this.rdbFaceToFace.TabIndex = 137;
            this.rdbFaceToFace.TabStop = true;
            this.rdbFaceToFace.Tag = "Course Delivery";
            this.rdbFaceToFace.Text = "Face to Face";
            this.rdbFaceToFace.UseVisualStyleBackColor = true;
            // 
            // lblCourseDelivery
            // 
            this.lblCourseDelivery.AutoSize = true;
            this.lblCourseDelivery.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCourseDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDelivery.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCourseDelivery.Location = new System.Drawing.Point(171, 298);
            this.lblCourseDelivery.Name = "lblCourseDelivery";
            this.lblCourseDelivery.Size = new System.Drawing.Size(139, 20);
            this.lblCourseDelivery.TabIndex = 136;
            this.lblCourseDelivery.Text = "Course Delivery:";
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(665, 792);
            this.Controls.Add(this.rdbOnline);
            this.Controls.Add(this.rdbFaceToFace);
            this.Controls.Add(this.lblCourseDelivery);
            this.Controls.Add(this.txtDisabilityDescription);
            this.Controls.Add(this.lblDisabilityDescription);
            this.Controls.Add(this.lblStudyStatus);
            this.Controls.Add(this.cmbStudyStatus);
            this.Controls.Add(this.rdbDisabilityNo);
            this.Controls.Add(this.rdbDisabilityYes);
            this.Controls.Add(this.lblDisability);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.lblBalanceOwing);
            this.Controls.Add(this.txtBalanceOwing);
            this.Controls.Add(this.lblPaymentDueDate);
            this.Controls.Add(this.txtPaymentDueDate);
            this.Controls.Add(this.lblEnrolmentDate);
            this.Controls.Add(this.txtEnrolmentDate);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblExpectedEndDate);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblEnrolmentForm);
            this.Controls.Add(this.lblEnrolmentID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtExpectedEndDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.txtEnrolmentID);
            this.MaximizeBox = false;
            this.Name = "EnrolmentForm";
            this.Text = "Enrolment Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuCourseForm;
        private System.Windows.Forms.ToolStripMenuItem mnuAssessmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuTeacherForm;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitForm;
        private System.Windows.Forms.Label lblExpectedEndDate;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblEnrolmentForm;
        private System.Windows.Forms.Label lblEnrolmentID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAll;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigate;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrolmentForm;
        private System.Windows.Forms.ToolTip EnrolmentToolTip;
        private System.Windows.Forms.TextBox txtExpectedEndDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.TextBox txtEnrolmentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblEnrolmentDate;
        private System.Windows.Forms.TextBox txtEnrolmentDate;
        private System.Windows.Forms.Label lblPaymentDueDate;
        private System.Windows.Forms.TextBox txtPaymentDueDate;
        private System.Windows.Forms.Label lblBalanceOwing;
        private System.Windows.Forms.TextBox txtBalanceOwing;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.RadioButton rdbDisabilityNo;
        private System.Windows.Forms.RadioButton rdbDisabilityYes;
        private System.Windows.Forms.Label lblDisability;
        private System.Windows.Forms.Label lblStudyStatus;
        private System.Windows.Forms.ComboBox cmbStudyStatus;
        private System.Windows.Forms.TextBox txtDisabilityDescription;
        private System.Windows.Forms.Label lblDisabilityDescription;
        private System.Windows.Forms.RadioButton rdbOnline;
        private System.Windows.Forms.RadioButton rdbFaceToFace;
        private System.Windows.Forms.Label lblCourseDelivery;
    }
}