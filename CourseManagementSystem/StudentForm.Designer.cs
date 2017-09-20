namespace CourseManagementSystem
{
    partial class StudentForm
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentForm = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.txtStudStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStudStreetAddress = new System.Windows.Forms.Label();
            this.txtStudentPhoneNum = new System.Windows.Forms.TextBox();
            this.lblStudentPhoneNum = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.lblDisability = new System.Windows.Forms.Label();
            this.rdbDisabilityYes = new System.Windows.Forms.RadioButton();
            this.rdbDisabilityNo = new System.Windows.Forms.RadioButton();
            this.lblDisabilityDescription = new System.Windows.Forms.Label();
            this.txtDisabilityDescription = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblStudentDateOfBirth = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblStudentSuburb = new System.Windows.Forms.Label();
            this.txtStudPostCode = new System.Windows.Forms.TextBox();
            this.lblStudPostCode = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbStudSuburb = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.pnlDisability = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.pnlDisability.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(283, 115);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(176, 26);
            this.txtStudentID.TabIndex = 1;
            this.txtStudentID.Tag = "Student ID";
            this.StudentToolTip.SetToolTip(this.txtStudentID, "Student ID must be numeric");
            // 
            // lblStudentForm
            // 
            this.lblStudentForm.AutoSize = true;
            this.lblStudentForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentForm.Location = new System.Drawing.Point(235, 52);
            this.lblStudentForm.Name = "lblStudentForm";
            this.lblStudentForm.Size = new System.Drawing.Size(224, 37);
            this.lblStudentForm.TabIndex = 4;
            this.lblStudentForm.Text = "Student Form";
            this.lblStudentForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentID.Location = new System.Drawing.Point(175, 118);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(102, 20);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentFirstName.Location = new System.Drawing.Point(283, 147);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(347, 26);
            this.txtStudentFirstName.TabIndex = 2;
            this.txtStudentFirstName.Tag = "Student First Name";
            this.StudentToolTip.SetToolTip(this.txtStudentFirstName, "First name must only contain alphabetic characters and begin with a capital lette" +
        "r");
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentFirstName.Location = new System.Drawing.Point(175, 150);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(101, 20);
            this.lblStudentFirstName.TabIndex = 6;
            this.lblStudentFirstName.Text = "First Name:";
            // 
            // txtStudStreetAddress
            // 
            this.txtStudStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudStreetAddress.Location = new System.Drawing.Point(283, 274);
            this.txtStudStreetAddress.Name = "txtStudStreetAddress";
            this.txtStudStreetAddress.Size = new System.Drawing.Size(347, 26);
            this.txtStudStreetAddress.TabIndex = 6;
            this.txtStudStreetAddress.Tag = "Student Street Address";
            this.StudentToolTip.SetToolTip(this.txtStudStreetAddress, "Street address must begin with street number and then street name");
            // 
            // lblStudStreetAddress
            // 
            this.lblStudStreetAddress.AutoSize = true;
            this.lblStudStreetAddress.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudStreetAddress.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudStreetAddress.Location = new System.Drawing.Point(133, 277);
            this.lblStudStreetAddress.Name = "lblStudStreetAddress";
            this.lblStudStreetAddress.Size = new System.Drawing.Size(140, 20);
            this.lblStudStreetAddress.TabIndex = 8;
            this.lblStudStreetAddress.Text = "Street Address::";
            // 
            // txtStudentPhoneNum
            // 
            this.txtStudentPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPhoneNum.Location = new System.Drawing.Point(283, 370);
            this.txtStudentPhoneNum.Name = "txtStudentPhoneNum";
            this.txtStudentPhoneNum.Size = new System.Drawing.Size(176, 26);
            this.txtStudentPhoneNum.TabIndex = 9;
            this.txtStudentPhoneNum.Tag = "Student Phone Number";
            this.StudentToolTip.SetToolTip(this.txtStudentPhoneNum, "Phone number must contain only numeric characters");
            // 
            // lblStudentPhoneNum
            // 
            this.lblStudentPhoneNum.AutoSize = true;
            this.lblStudentPhoneNum.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentPhoneNum.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentPhoneNum.Location = new System.Drawing.Point(144, 373);
            this.lblStudentPhoneNum.Name = "lblStudentPhoneNum";
            this.lblStudentPhoneNum.Size = new System.Drawing.Size(132, 20);
            this.lblStudentPhoneNum.TabIndex = 10;
            this.lblStudentPhoneNum.Text = "Phone Number:";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNationality.Location = new System.Drawing.Point(175, 437);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(98, 20);
            this.lblNationality.TabIndex = 12;
            this.lblNationality.Text = "Nationality:";
            // 
            // cmbNationality
            // 
            this.cmbNationality.DisplayMember = "Cake";
            this.cmbNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Items.AddRange(new object[] {
            "Cake",
            "Coke",
            "Fries",
            "Pasta"});
            this.cmbNationality.Location = new System.Drawing.Point(283, 434);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(176, 28);
            this.cmbNationality.TabIndex = 11;
            this.cmbNationality.Tag = "Student Nationality";
            this.StudentToolTip.SetToolTip(this.cmbNationality, "Press the down arrow to make a selection");
            // 
            // lblDisability
            // 
            this.lblDisability.AutoSize = true;
            this.lblDisability.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisability.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDisability.Location = new System.Drawing.Point(29, 470);
            this.lblDisability.Name = "lblDisability";
            this.lblDisability.Size = new System.Drawing.Size(244, 20);
            this.lblDisability.TabIndex = 14;
            this.lblDisability.Text = "Does student have disability?";
            // 
            // rdbDisabilityYes
            // 
            this.rdbDisabilityYes.AutoSize = true;
            this.rdbDisabilityYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDisabilityYes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbDisabilityYes.Location = new System.Drawing.Point(3, 3);
            this.rdbDisabilityYes.Name = "rdbDisabilityYes";
            this.rdbDisabilityYes.Size = new System.Drawing.Size(58, 24);
            this.rdbDisabilityYes.TabIndex = 15;
            this.rdbDisabilityYes.Tag = "Disability";
            this.rdbDisabilityYes.Text = "Yes";
            this.rdbDisabilityYes.UseVisualStyleBackColor = true;
            this.rdbDisabilityYes.CheckedChanged += new System.EventHandler(this.rdbDisabilityYes_CheckedChanged);
            // 
            // rdbDisabilityNo
            // 
            this.rdbDisabilityNo.AutoSize = true;
            this.rdbDisabilityNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDisabilityNo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbDisabilityNo.Location = new System.Drawing.Point(71, 3);
            this.rdbDisabilityNo.Name = "rdbDisabilityNo";
            this.rdbDisabilityNo.Size = new System.Drawing.Size(49, 24);
            this.rdbDisabilityNo.TabIndex = 16;
            this.rdbDisabilityNo.Tag = "Disability";
            this.rdbDisabilityNo.Text = "No";
            this.rdbDisabilityNo.UseVisualStyleBackColor = true;
            this.rdbDisabilityNo.CheckedChanged += new System.EventHandler(this.rdbDisabilityNo_CheckedChanged);
            // 
            // lblDisabilityDescription
            // 
            this.lblDisabilityDescription.AutoSize = true;
            this.lblDisabilityDescription.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblDisabilityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisabilityDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDisabilityDescription.Location = new System.Drawing.Point(87, 501);
            this.lblDisabilityDescription.Name = "lblDisabilityDescription";
            this.lblDisabilityDescription.Size = new System.Drawing.Size(186, 20);
            this.lblDisabilityDescription.TabIndex = 17;
            this.lblDisabilityDescription.Text = "If Yes, please specify:";
            // 
            // txtDisabilityDescription
            // 
            this.txtDisabilityDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisabilityDescription.Location = new System.Drawing.Point(283, 498);
            this.txtDisabilityDescription.Multiline = true;
            this.txtDisabilityDescription.Name = "txtDisabilityDescription";
            this.txtDisabilityDescription.Size = new System.Drawing.Size(347, 87);
            this.txtDisabilityDescription.TabIndex = 13;
            this.txtDisabilityDescription.Tag = "Disability Description";
            this.StudentToolTip.SetToolTip(this.txtDisabilityDescription, "Enter the details regarding disability");
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.Location = new System.Drawing.Point(283, 402);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(347, 26);
            this.txtStudentEmail.TabIndex = 10;
            this.txtStudentEmail.Tag = "Student Email";
            this.txtStudentEmail.Text = "FirstnameLastname@dummyMail.com.au";
            this.StudentToolTip.SetToolTip(this.txtStudentEmail, "Email address must follow the format: FirstnameLastname@dummyMail.com.au");
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentEmail.Location = new System.Drawing.Point(215, 405);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(58, 20);
            this.lblStudentEmail.TabIndex = 19;
            this.lblStudentEmail.Text = "Email:";
            // 
            // lblStudentDateOfBirth
            // 
            this.lblStudentDateOfBirth.AutoSize = true;
            this.lblStudentDateOfBirth.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDateOfBirth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentDateOfBirth.Location = new System.Drawing.Point(156, 214);
            this.lblStudentDateOfBirth.Name = "lblStudentDateOfBirth";
            this.lblStudentDateOfBirth.Size = new System.Drawing.Size(117, 20);
            this.lblStudentDateOfBirth.TabIndex = 21;
            this.lblStudentDateOfBirth.Text = "Date of Birth:";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentLastName.Location = new System.Drawing.Point(283, 179);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(347, 26);
            this.txtStudentLastName.TabIndex = 3;
            this.txtStudentLastName.Tag = "Student Last Name";
            this.StudentToolTip.SetToolTip(this.txtStudentLastName, "Last name must only contain alphabetic characters and begin with a capital letter" +
        "");
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentLastName.Location = new System.Drawing.Point(175, 182);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(100, 20);
            this.lblStudentLastName.TabIndex = 23;
            this.lblStudentLastName.Text = "Last Name:";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(11, 625);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(645, 120);
            this.dgvStudent.TabIndex = 25;
            // 
            // lblStudentSuburb
            // 
            this.lblStudentSuburb.AutoSize = true;
            this.lblStudentSuburb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudentSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSuburb.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudentSuburb.Location = new System.Drawing.Point(201, 309);
            this.lblStudentSuburb.Name = "lblStudentSuburb";
            this.lblStudentSuburb.Size = new System.Drawing.Size(72, 20);
            this.lblStudentSuburb.TabIndex = 26;
            this.lblStudentSuburb.Text = "Suburb:";
            // 
            // txtStudPostCode
            // 
            this.txtStudPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudPostCode.Location = new System.Drawing.Point(283, 338);
            this.txtStudPostCode.Name = "txtStudPostCode";
            this.txtStudPostCode.Size = new System.Drawing.Size(113, 26);
            this.txtStudPostCode.TabIndex = 8;
            this.txtStudPostCode.Tag = "Student Post Code";
            this.StudentToolTip.SetToolTip(this.txtStudPostCode, "Post code must contain only numeric characters");
            // 
            // lblStudPostCode
            // 
            this.lblStudPostCode.AutoSize = true;
            this.lblStudPostCode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblStudPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudPostCode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblStudPostCode.Location = new System.Drawing.Point(175, 341);
            this.lblStudPostCode.Name = "lblStudPostCode";
            this.lblStudPostCode.Size = new System.Drawing.Size(97, 20);
            this.lblStudPostCode.TabIndex = 28;
            this.lblStudPostCode.Text = "Post Code:";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 30;
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
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(465, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 31;
            this.StudentToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbStudSuburb
            // 
            this.cmbStudSuburb.DisplayMember = "Cake";
            this.cmbStudSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudSuburb.FormattingEnabled = true;
            this.cmbStudSuburb.Items.AddRange(new object[] {
            "Campbelltown",
            "Liverpool",
            "Ultimo",
            "Granville"});
            this.cmbStudSuburb.Location = new System.Drawing.Point(283, 304);
            this.cmbStudSuburb.Name = "cmbStudSuburb";
            this.cmbStudSuburb.Size = new System.Drawing.Size(176, 28);
            this.cmbStudSuburb.TabIndex = 7;
            this.cmbStudSuburb.Tag = "Student Suburb";
            this.StudentToolTip.SetToolTip(this.cmbStudSuburb, "Press the down arrow to make a selection");
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.AllowDrop = true;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(283, 209);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(274, 26);
            this.dtpDateOfBirth.TabIndex = 4;
            this.dtpDateOfBirth.Tag = "Date of Birth";
            this.StudentToolTip.SetToolTip(this.dtpDateOfBirth, "Press the down arrow to make a selection");
            this.dtpDateOfBirth.Value = new System.DateTime(2001, 12, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbFemale.Location = new System.Drawing.Point(71, 1);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(86, 24);
            this.rdbFemale.TabIndex = 34;
            this.rdbFemale.Tag = "Gender";
            this.rdbFemale.Text = "Female";
            this.StudentToolTip.SetToolTip(this.rdbFemale, "Female");
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbMale.Location = new System.Drawing.Point(0, 1);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(65, 24);
            this.rdbMale.TabIndex = 33;
            this.rdbMale.Tag = "Gender";
            this.rdbMale.Text = "Male";
            this.StudentToolTip.SetToolTip(this.rdbMale, "Male");
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGender.Location = new System.Drawing.Point(198, 246);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 20);
            this.lblGender.TabIndex = 32;
            this.lblGender.Text = "Gender:";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdbFemale);
            this.pnlGender.Controls.Add(this.rdbMale);
            this.pnlGender.Location = new System.Drawing.Point(283, 243);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(176, 25);
            this.pnlGender.TabIndex = 5;
            // 
            // pnlDisability
            // 
            this.pnlDisability.Controls.Add(this.rdbDisabilityYes);
            this.pnlDisability.Controls.Add(this.rdbDisabilityNo);
            this.pnlDisability.Location = new System.Drawing.Point(283, 465);
            this.pnlDisability.Name = "pnlDisability";
            this.pnlDisability.Size = new System.Drawing.Size(176, 27);
            this.pnlDisability.TabIndex = 12;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(665, 756);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.cmbStudSuburb);
            this.Controls.Add(this.pnlDisability);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtStudPostCode);
            this.Controls.Add(this.lblStudPostCode);
            this.Controls.Add(this.lblStudentSuburb);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.lblStudentLastName);
            this.Controls.Add(this.lblStudentDateOfBirth);
            this.Controls.Add(this.txtStudentEmail);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.txtDisabilityDescription);
            this.Controls.Add(this.lblDisabilityDescription);
            this.Controls.Add(this.lblDisability);
            this.Controls.Add(this.cmbNationality);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.txtStudentPhoneNum);
            this.Controls.Add(this.lblStudentPhoneNum);
            this.Controls.Add(this.txtStudStreetAddress);
            this.Controls.Add(this.lblStudStreetAddress);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.lblStudentFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentForm);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.pnlDisability.ResumeLayout(false);
            this.pnlDisability.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentForm;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.Label lblStudentFirstName;
        private System.Windows.Forms.TextBox txtStudStreetAddress;
        private System.Windows.Forms.Label lblStudStreetAddress;
        private System.Windows.Forms.TextBox txtStudentPhoneNum;
        private System.Windows.Forms.Label lblStudentPhoneNum;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.Label lblDisability;
        private System.Windows.Forms.RadioButton rdbDisabilityYes;
        private System.Windows.Forms.RadioButton rdbDisabilityNo;
        private System.Windows.Forms.Label lblDisabilityDescription;
        private System.Windows.Forms.TextBox txtDisabilityDescription;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblStudentDateOfBirth;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.Label lblStudentLastName;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblStudentSuburb;
        private System.Windows.Forms.TextBox txtStudPostCode;
        private System.Windows.Forms.Label lblStudPostCode;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolTip StudentToolTip;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Panel pnlDisability;
        private System.Windows.Forms.ComboBox cmbStudSuburb;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}