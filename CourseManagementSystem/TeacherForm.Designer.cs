namespace CourseManagementSystem
{
    partial class TeacherForm
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
            this.TeacherToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtTeachPostCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.txtTeacherEmail = new System.Windows.Forms.TextBox();
            this.cmbTeachDepartment = new System.Windows.Forms.ComboBox();
            this.txtTeacherPhoneNum = new System.Windows.Forms.TextBox();
            this.txtTeachStreetAddress = new System.Windows.Forms.TextBox();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.cmbClassTaught = new System.Windows.Forms.ComboBox();
            this.txtTeacherSkills = new System.Windows.Forms.TextBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbTeachSuburb = new System.Windows.Forms.ComboBox();
            this.dtpCommencementDate = new System.Windows.Forms.DateTimePicker();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lblTeachPostCode = new System.Windows.Forms.Label();
            this.lblTeacherSuburb = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.lblTeacherLastName = new System.Windows.Forms.Label();
            this.lblTeacherDateOfBirth = new System.Windows.Forms.Label();
            this.lblTeacherEmail = new System.Windows.Forms.Label();
            this.lblTeachDepartment = new System.Windows.Forms.Label();
            this.lblTeacherPhoneNum = new System.Windows.Forms.Label();
            this.lblTeachStreetAddress = new System.Windows.Forms.Label();
            this.lblTeacherFirstName = new System.Windows.Forms.Label();
            this.lblTeacherForm = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCommencementDate = new System.Windows.Forms.Label();
            this.lblClassTaught = new System.Windows.Forms.Label();
            this.lblTeacherSkills = new System.Windows.Forms.Label();
            this.lblAnnualSickLeave = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdbASNo = new System.Windows.Forms.RadioButton();
            this.rdbASYes = new System.Windows.Forms.RadioButton();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.pnlAnnualSickLeave = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            this.pnlAnnualSickLeave.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeachPostCode
            // 
            this.txtTeachPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachPostCode.Location = new System.Drawing.Point(241, 350);
            this.txtTeachPostCode.Name = "txtTeachPostCode";
            this.txtTeachPostCode.Size = new System.Drawing.Size(113, 26);
            this.txtTeachPostCode.TabIndex = 8;
            this.txtTeachPostCode.Tag = "Teacher Post Code";
            this.TeacherToolTip.SetToolTip(this.txtTeachPostCode, "Post code must contain only numeric characters");
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(423, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 60;
            this.TeacherToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherLastName.Location = new System.Drawing.Point(241, 188);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(347, 26);
            this.txtTeacherLastName.TabIndex = 3;
            this.txtTeacherLastName.Tag = "Teacher Last Name";
            this.TeacherToolTip.SetToolTip(this.txtTeacherLastName, "Last name must only contain alphabetic characters and begin with a capital letter" +
        "");
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherEmail.Location = new System.Drawing.Point(241, 414);
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Size = new System.Drawing.Size(347, 26);
            this.txtTeacherEmail.TabIndex = 10;
            this.txtTeacherEmail.Tag = "Teacher Email";
            this.txtTeacherEmail.Text = "FirstnameLastname@dummyMail.com.au";
            this.TeacherToolTip.SetToolTip(this.txtTeacherEmail, "Email address must follow the format: FirstnameLastname@dummyMail.com.au");
            // 
            // cmbTeachDepartment
            // 
            this.cmbTeachDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeachDepartment.FormattingEnabled = true;
            this.cmbTeachDepartment.Items.AddRange(new object[] {
            "IT",
            "Science",
            "Maths",
            "Food",
            "Music"});
            this.cmbTeachDepartment.Location = new System.Drawing.Point(241, 478);
            this.cmbTeachDepartment.Name = "cmbTeachDepartment";
            this.cmbTeachDepartment.Size = new System.Drawing.Size(176, 28);
            this.cmbTeachDepartment.TabIndex = 13;
            this.cmbTeachDepartment.Tag = "Teaching Department";
            this.TeacherToolTip.SetToolTip(this.cmbTeachDepartment, "Press the down arrow to make a selection");
            // 
            // txtTeacherPhoneNum
            // 
            this.txtTeacherPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherPhoneNum.Location = new System.Drawing.Point(241, 382);
            this.txtTeacherPhoneNum.Name = "txtTeacherPhoneNum";
            this.txtTeacherPhoneNum.Size = new System.Drawing.Size(176, 26);
            this.txtTeacherPhoneNum.TabIndex = 9;
            this.txtTeacherPhoneNum.Tag = "Teacher Phone Number";
            this.TeacherToolTip.SetToolTip(this.txtTeacherPhoneNum, "Phone number must contain only numeric characters");
            // 
            // txtTeachStreetAddress
            // 
            this.txtTeachStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachStreetAddress.Location = new System.Drawing.Point(241, 283);
            this.txtTeachStreetAddress.Name = "txtTeachStreetAddress";
            this.txtTeachStreetAddress.Size = new System.Drawing.Size(347, 26);
            this.txtTeachStreetAddress.TabIndex = 6;
            this.txtTeachStreetAddress.Tag = "Teacher Street Address";
            this.TeacherToolTip.SetToolTip(this.txtTeachStreetAddress, "Street address must begin with street number and then street name");
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherFirstName.Location = new System.Drawing.Point(241, 156);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(347, 26);
            this.txtTeacherFirstName.TabIndex = 2;
            this.txtTeacherFirstName.Tag = "Teacher First Name";
            this.TeacherToolTip.SetToolTip(this.txtTeacherFirstName, "First name must only contain alphabetic characters and begin with a capital lette" +
        "r");
            // 
            // cmbClassTaught
            // 
            this.cmbClassTaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassTaught.FormattingEnabled = true;
            this.cmbClassTaught.Items.AddRange(new object[] {
            "Web Design",
            "Software Development",
            "Baking 101",
            "Donut Frying",
            "Burger Design",
            "Steak Cutting"});
            this.cmbClassTaught.Location = new System.Drawing.Point(241, 512);
            this.cmbClassTaught.Name = "cmbClassTaught";
            this.cmbClassTaught.Size = new System.Drawing.Size(176, 28);
            this.cmbClassTaught.TabIndex = 14;
            this.cmbClassTaught.Tag = "Class Taught";
            this.TeacherToolTip.SetToolTip(this.cmbClassTaught, "Press the down arrow to make a selection");
            // 
            // txtTeacherSkills
            // 
            this.txtTeacherSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherSkills.Location = new System.Drawing.Point(241, 546);
            this.txtTeacherSkills.Name = "txtTeacherSkills";
            this.txtTeacherSkills.Size = new System.Drawing.Size(224, 26);
            this.txtTeacherSkills.TabIndex = 15;
            this.txtTeacherSkills.Tag = "Skills";
            this.TeacherToolTip.SetToolTip(this.txtTeacherSkills, "Enter teacher\'s qualification");
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbFemale.Location = new System.Drawing.Point(90, 0);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(86, 24);
            this.rdbFemale.TabIndex = 73;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Tag = "Gender";
            this.rdbFemale.Text = "Female";
            this.TeacherToolTip.SetToolTip(this.rdbFemale, "Female");
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbMale.Location = new System.Drawing.Point(3, 0);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(65, 24);
            this.rdbMale.TabIndex = 72;
            this.rdbMale.TabStop = true;
            this.rdbMale.Tag = "Gender";
            this.rdbMale.Text = "Male";
            this.TeacherToolTip.SetToolTip(this.rdbMale, "Male");
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.AllowDrop = true;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(241, 220);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(274, 26);
            this.dtpDateOfBirth.TabIndex = 4;
            this.dtpDateOfBirth.Tag = "Date of Birth";
            this.TeacherToolTip.SetToolTip(this.dtpDateOfBirth, "Press the down arrow to make a selection");
            this.dtpDateOfBirth.Value = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // cmbTeachSuburb
            // 
            this.cmbTeachSuburb.DisplayMember = "Cake";
            this.cmbTeachSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeachSuburb.FormattingEnabled = true;
            this.cmbTeachSuburb.Items.AddRange(new object[] {
            "Campbelltown",
            "Liverpool",
            "Ultimo",
            "Granville"});
            this.cmbTeachSuburb.Location = new System.Drawing.Point(241, 315);
            this.cmbTeachSuburb.Name = "cmbTeachSuburb";
            this.cmbTeachSuburb.Size = new System.Drawing.Size(176, 28);
            this.cmbTeachSuburb.TabIndex = 7;
            this.cmbTeachSuburb.Tag = "Teacher Suburb";
            this.TeacherToolTip.SetToolTip(this.cmbTeachSuburb, "Press the down arrow to make a selection");
            // 
            // dtpCommencementDate
            // 
            this.dtpCommencementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCommencementDate.Location = new System.Drawing.Point(241, 446);
            this.dtpCommencementDate.MaxDate = new System.DateTime(4000, 12, 31, 0, 0, 0, 0);
            this.dtpCommencementDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCommencementDate.Name = "dtpCommencementDate";
            this.dtpCommencementDate.Size = new System.Drawing.Size(275, 26);
            this.dtpCommencementDate.TabIndex = 11;
            this.dtpCommencementDate.Tag = "Commencement Date";
            this.TeacherToolTip.SetToolTip(this.dtpCommencementDate, "Press the down arrow to make a selection");
            this.dtpCommencementDate.ValueChanged += new System.EventHandler(this.dtpCommencementDate_ValueChanged);
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherID.Location = new System.Drawing.Point(241, 124);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(176, 26);
            this.txtTeacherID.TabIndex = 1;
            this.txtTeacherID.Tag = "Teacher ID";
            // 
            // lblTeachPostCode
            // 
            this.lblTeachPostCode.AutoSize = true;
            this.lblTeachPostCode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeachPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeachPostCode.Location = new System.Drawing.Point(132, 353);
            this.lblTeachPostCode.Name = "lblTeachPostCode";
            this.lblTeachPostCode.Size = new System.Drawing.Size(97, 20);
            this.lblTeachPostCode.TabIndex = 57;
            this.lblTeachPostCode.Text = "Post Code:";
            // 
            // lblTeacherSuburb
            // 
            this.lblTeacherSuburb.AutoSize = true;
            this.lblTeacherSuburb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherSuburb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherSuburb.Location = new System.Drawing.Point(159, 318);
            this.lblTeacherSuburb.Name = "lblTeacherSuburb";
            this.lblTeacherSuburb.Size = new System.Drawing.Size(72, 20);
            this.lblTeacherSuburb.TabIndex = 55;
            this.lblTeacherSuburb.Text = "Suburb:";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete,
            this.mnuUpdate,
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
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(166, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
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
            // dgvTeacher
            // 
            this.dgvTeacher.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(12, 651);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(642, 120);
            this.dgvTeacher.TabIndex = 54;
            // 
            // lblTeacherLastName
            // 
            this.lblTeacherLastName.AutoSize = true;
            this.lblTeacherLastName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherLastName.Location = new System.Drawing.Point(133, 191);
            this.lblTeacherLastName.Name = "lblTeacherLastName";
            this.lblTeacherLastName.Size = new System.Drawing.Size(100, 20);
            this.lblTeacherLastName.TabIndex = 52;
            this.lblTeacherLastName.Text = "Last Name:";
            // 
            // lblTeacherDateOfBirth
            // 
            this.lblTeacherDateOfBirth.AutoSize = true;
            this.lblTeacherDateOfBirth.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherDateOfBirth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherDateOfBirth.Location = new System.Drawing.Point(114, 223);
            this.lblTeacherDateOfBirth.Name = "lblTeacherDateOfBirth";
            this.lblTeacherDateOfBirth.Size = new System.Drawing.Size(117, 20);
            this.lblTeacherDateOfBirth.TabIndex = 50;
            this.lblTeacherDateOfBirth.Text = "Date of Birth:";
            // 
            // lblTeacherEmail
            // 
            this.lblTeacherEmail.AutoSize = true;
            this.lblTeacherEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherEmail.Location = new System.Drawing.Point(171, 417);
            this.lblTeacherEmail.Name = "lblTeacherEmail";
            this.lblTeacherEmail.Size = new System.Drawing.Size(58, 20);
            this.lblTeacherEmail.TabIndex = 48;
            this.lblTeacherEmail.Text = "Email:";
            // 
            // lblTeachDepartment
            // 
            this.lblTeachDepartment.AutoSize = true;
            this.lblTeachDepartment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeachDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachDepartment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeachDepartment.Location = new System.Drawing.Point(43, 481);
            this.lblTeachDepartment.Name = "lblTeachDepartment";
            this.lblTeachDepartment.Size = new System.Drawing.Size(187, 20);
            this.lblTeachDepartment.TabIndex = 41;
            this.lblTeachDepartment.Text = "Teaching Department:";
            // 
            // lblTeacherPhoneNum
            // 
            this.lblTeacherPhoneNum.AutoSize = true;
            this.lblTeacherPhoneNum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherPhoneNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherPhoneNum.Location = new System.Drawing.Point(97, 385);
            this.lblTeacherPhoneNum.Name = "lblTeacherPhoneNum";
            this.lblTeacherPhoneNum.Size = new System.Drawing.Size(132, 20);
            this.lblTeacherPhoneNum.TabIndex = 39;
            this.lblTeacherPhoneNum.Text = "Phone Number:";
            // 
            // lblTeachStreetAddress
            // 
            this.lblTeachStreetAddress.AutoSize = true;
            this.lblTeachStreetAddress.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeachStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachStreetAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeachStreetAddress.Location = new System.Drawing.Point(91, 286);
            this.lblTeachStreetAddress.Name = "lblTeachStreetAddress";
            this.lblTeachStreetAddress.Size = new System.Drawing.Size(140, 20);
            this.lblTeachStreetAddress.TabIndex = 37;
            this.lblTeachStreetAddress.Text = "Street Address::";
            // 
            // lblTeacherFirstName
            // 
            this.lblTeacherFirstName.AutoSize = true;
            this.lblTeacherFirstName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherFirstName.Location = new System.Drawing.Point(133, 159);
            this.lblTeacherFirstName.Name = "lblTeacherFirstName";
            this.lblTeacherFirstName.Size = new System.Drawing.Size(101, 20);
            this.lblTeacherFirstName.TabIndex = 35;
            this.lblTeacherFirstName.Text = "First Name:";
            // 
            // lblTeacherForm
            // 
            this.lblTeacherForm.AutoSize = true;
            this.lblTeacherForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherForm.Location = new System.Drawing.Point(234, 47);
            this.lblTeacherForm.Name = "lblTeacherForm";
            this.lblTeacherForm.Size = new System.Drawing.Size(231, 37);
            this.lblTeacherForm.TabIndex = 33;
            this.lblTeacherForm.Text = "Teacher Form";
            this.lblTeacherForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherID.Location = new System.Drawing.Point(133, 127);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(103, 20);
            this.lblTeacherID.TabIndex = 32;
            this.lblTeacherID.Text = "Teacher ID:";
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
            // lblCommencementDate
            // 
            this.lblCommencementDate.AutoSize = true;
            this.lblCommencementDate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblCommencementDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommencementDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCommencementDate.Location = new System.Drawing.Point(40, 451);
            this.lblCommencementDate.Name = "lblCommencementDate";
            this.lblCommencementDate.Size = new System.Drawing.Size(187, 20);
            this.lblCommencementDate.TabIndex = 61;
            this.lblCommencementDate.Text = "Commencement Date:";
            // 
            // lblClassTaught
            // 
            this.lblClassTaught.AutoSize = true;
            this.lblClassTaught.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblClassTaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassTaught.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblClassTaught.Location = new System.Drawing.Point(110, 515);
            this.lblClassTaught.Name = "lblClassTaught";
            this.lblClassTaught.Size = new System.Drawing.Size(119, 20);
            this.lblClassTaught.TabIndex = 63;
            this.lblClassTaught.Text = "Class Taught:";
            // 
            // lblTeacherSkills
            // 
            this.lblTeacherSkills.AutoSize = true;
            this.lblTeacherSkills.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblTeacherSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherSkills.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeacherSkills.Location = new System.Drawing.Point(171, 549);
            this.lblTeacherSkills.Name = "lblTeacherSkills";
            this.lblTeacherSkills.Size = new System.Drawing.Size(56, 20);
            this.lblTeacherSkills.TabIndex = 67;
            this.lblTeacherSkills.Text = "Skills:";
            // 
            // lblAnnualSickLeave
            // 
            this.lblAnnualSickLeave.AutoSize = true;
            this.lblAnnualSickLeave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAnnualSickLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualSickLeave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAnnualSickLeave.Location = new System.Drawing.Point(65, 580);
            this.lblAnnualSickLeave.Name = "lblAnnualSickLeave";
            this.lblAnnualSickLeave.Size = new System.Drawing.Size(162, 20);
            this.lblAnnualSickLeave.TabIndex = 69;
            this.lblAnnualSickLeave.Text = "Annual/Sick Leave:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGender.Location = new System.Drawing.Point(156, 255);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 20);
            this.lblGender.TabIndex = 71;
            this.lblGender.Text = "Gender:";
            // 
            // rdbASNo
            // 
            this.rdbASNo.AutoSize = true;
            this.rdbASNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbASNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbASNo.Location = new System.Drawing.Point(90, 3);
            this.rdbASNo.Name = "rdbASNo";
            this.rdbASNo.Size = new System.Drawing.Size(49, 24);
            this.rdbASNo.TabIndex = 75;
            this.rdbASNo.Tag = "Annual/SickLeave";
            this.rdbASNo.Text = "No";
            this.rdbASNo.UseVisualStyleBackColor = true;
            // 
            // rdbASYes
            // 
            this.rdbASYes.AutoSize = true;
            this.rdbASYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbASYes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbASYes.Location = new System.Drawing.Point(3, 3);
            this.rdbASYes.Name = "rdbASYes";
            this.rdbASYes.Size = new System.Drawing.Size(58, 24);
            this.rdbASYes.TabIndex = 74;
            this.rdbASYes.Tag = "Annual/SickLeave";
            this.rdbASYes.Text = "Yes";
            this.rdbASYes.UseVisualStyleBackColor = true;
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.Controls.Add(this.rdbFemale);
            this.pnlTeacher.Controls.Add(this.rdbMale);
            this.pnlTeacher.Location = new System.Drawing.Point(241, 252);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(176, 25);
            this.pnlTeacher.TabIndex = 5;
            // 
            // pnlAnnualSickLeave
            // 
            this.pnlAnnualSickLeave.Controls.Add(this.rdbASNo);
            this.pnlAnnualSickLeave.Controls.Add(this.rdbASYes);
            this.pnlAnnualSickLeave.Location = new System.Drawing.Point(241, 578);
            this.pnlAnnualSickLeave.Name = "pnlAnnualSickLeave";
            this.pnlAnnualSickLeave.Size = new System.Drawing.Size(176, 29);
            this.pnlAnnualSickLeave.TabIndex = 16;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(666, 782);
            this.Controls.Add(this.dtpCommencementDate);
            this.Controls.Add(this.pnlAnnualSickLeave);
            this.Controls.Add(this.cmbTeachSuburb);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAnnualSickLeave);
            this.Controls.Add(this.txtTeacherSkills);
            this.Controls.Add(this.lblTeacherSkills);
            this.Controls.Add(this.cmbClassTaught);
            this.Controls.Add(this.lblClassTaught);
            this.Controls.Add(this.lblCommencementDate);
            this.Controls.Add(this.txtTeachPostCode);
            this.Controls.Add(this.lblTeachPostCode);
            this.Controls.Add(this.lblTeacherSuburb);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.txtTeacherLastName);
            this.Controls.Add(this.lblTeacherLastName);
            this.Controls.Add(this.lblTeacherDateOfBirth);
            this.Controls.Add(this.txtTeacherEmail);
            this.Controls.Add(this.lblTeacherEmail);
            this.Controls.Add(this.cmbTeachDepartment);
            this.Controls.Add(this.lblTeachDepartment);
            this.Controls.Add(this.txtTeacherPhoneNum);
            this.Controls.Add(this.lblTeacherPhoneNum);
            this.Controls.Add(this.txtTeachStreetAddress);
            this.Controls.Add(this.lblTeachStreetAddress);
            this.Controls.Add(this.txtTeacherFirstName);
            this.Controls.Add(this.lblTeacherFirstName);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.lblTeacherForm);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            this.pnlAnnualSickLeave.ResumeLayout(false);
            this.pnlAnnualSickLeave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip TeacherToolTip;
        private System.Windows.Forms.TextBox txtTeachPostCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTeacherLastName;
        private System.Windows.Forms.TextBox txtTeacherEmail;
        private System.Windows.Forms.ComboBox cmbTeachDepartment;
        private System.Windows.Forms.TextBox txtTeacherPhoneNum;
        private System.Windows.Forms.TextBox txtTeachStreetAddress;
        private System.Windows.Forms.TextBox txtTeacherFirstName;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label lblTeachPostCode;
        private System.Windows.Forms.Label lblTeacherSuburb;
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
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Label lblTeacherLastName;
        private System.Windows.Forms.Label lblTeacherDateOfBirth;
        private System.Windows.Forms.Label lblTeacherEmail;
        private System.Windows.Forms.Label lblTeachDepartment;
        private System.Windows.Forms.Label lblTeacherPhoneNum;
        private System.Windows.Forms.Label lblTeachStreetAddress;
        private System.Windows.Forms.Label lblTeacherFirstName;
        private System.Windows.Forms.Label lblTeacherForm;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblCommencementDate;
        private System.Windows.Forms.ComboBox cmbClassTaught;
        private System.Windows.Forms.Label lblClassTaught;
        private System.Windows.Forms.TextBox txtTeacherSkills;
        private System.Windows.Forms.Label lblTeacherSkills;
        private System.Windows.Forms.Label lblAnnualSickLeave;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdbASNo;
        private System.Windows.Forms.RadioButton rdbASYes;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbTeachSuburb;
        private System.Windows.Forms.Panel pnlAnnualSickLeave;
        private System.Windows.Forms.DateTimePicker dtpCommencementDate;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}