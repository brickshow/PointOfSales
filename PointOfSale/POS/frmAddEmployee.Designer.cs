﻿namespace POS
{
    partial class frmAddEmployee
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
            this.lblNames = new System.Windows.Forms.Label();
            this.btnViewAllEmp = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.rbtnStaff = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbtnHumanRes = new System.Windows.Forms.RadioButton();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlCivilStatus = new System.Windows.Forms.Panel();
            this.rbtnWidowed = new System.Windows.Forms.RadioButton();
            this.rbtnMarried = new System.Windows.Forms.RadioButton();
            this.lblCivilStatus = new System.Windows.Forms.Label();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnSeparated = new System.Windows.Forms.RadioButton();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.pnlDisplayEmployee = new System.Windows.Forms.Panel();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.rbtnStaffList = new System.Windows.Forms.RadioButton();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.rbtnHr = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.txtMidInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.pnlCivilStatus.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlDisplayEmployee.SuspendLayout();
            this.pnlPosition.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.Color.Transparent;
            this.lblNames.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNames.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.Color.White;
            this.lblNames.Location = new System.Drawing.Point(13, 151);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(81, 24);
            this.lblNames.TabIndex = 62;
            this.lblNames.Text = "NAMES";
            // 
            // btnViewAllEmp
            // 
            this.btnViewAllEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAllEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAllEmp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllEmp.ForeColor = System.Drawing.Color.White;
            this.btnViewAllEmp.Location = new System.Drawing.Point(13, 713);
            this.btnViewAllEmp.Name = "btnViewAllEmp";
            this.btnViewAllEmp.Size = new System.Drawing.Size(227, 33);
            this.btnViewAllEmp.TabIndex = 57;
            this.btnViewAllEmp.Text = "View Employee Details";
            this.btnViewAllEmp.UseVisualStyleBackColor = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(159, 497);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 15);
            this.lblAge.TabIndex = 31;
            this.lblAge.Text = "Age*";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 497);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender*";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 447);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Password*";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 398);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 15);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username*";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 349);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 15);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Address*";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(15, 301);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(93, 15);
            this.lblContactNum.TabIndex = 29;
            this.lblContactNum.Text = "Contact Number*";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(317, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 29);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(320, 151);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(88, 24);
            this.lblUserID.TabIndex = 62;
            this.lblUserID.Text = "USER ID";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(15, 254);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(68, 15);
            this.lblNationality.TabIndex = 29;
            this.lblNationality.Text = "Nationality*";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(15, 207);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(58, 15);
            this.lblBdate.TabIndex = 28;
            this.lblBdate.Text = "Birthdate*";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(13, 113);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(73, 15);
            this.lblMName.TabIndex = 25;
            this.lblMName.Text = "Middle Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(13, 66);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(67, 15);
            this.lblFName.TabIndex = 23;
            this.lblFName.Text = "First Name*";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(380, 711);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 35);
            this.btnRefresh.TabIndex = 65;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // listBoxID
            // 
            this.listBoxID.BackColor = System.Drawing.Color.Black;
            this.listBoxID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxID.ForeColor = System.Drawing.Color.White;
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.ItemHeight = 22;
            this.listBoxID.Location = new System.Drawing.Point(320, 184);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(194, 510);
            this.listBoxID.TabIndex = 61;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(13, 160);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(65, 15);
            this.lblLName.TabIndex = 56;
            this.lblLName.Text = "Last Name*";
            // 
            // rbtnStaff
            // 
            this.rbtnStaff.AutoSize = true;
            this.rbtnStaff.Location = new System.Drawing.Point(193, 8);
            this.rbtnStaff.Name = "rbtnStaff";
            this.rbtnStaff.Size = new System.Drawing.Size(48, 19);
            this.rbtnStaff.TabIndex = 13;
            this.rbtnStaff.TabStop = true;
            this.rbtnStaff.Text = "Staff";
            this.rbtnStaff.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(162, 515);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(123, 29);
            this.txtAge.TabIndex = 6;
            // 
            // rbtnHumanRes
            // 
            this.rbtnHumanRes.AutoSize = true;
            this.rbtnHumanRes.Location = new System.Drawing.Point(81, 58);
            this.rbtnHumanRes.Name = "rbtnHumanRes";
            this.rbtnHumanRes.Size = new System.Drawing.Size(43, 20);
            this.rbtnHumanRes.TabIndex = 14;
            this.rbtnHumanRes.TabStop = true;
            this.rbtnHumanRes.Text = "HR";
            this.rbtnHumanRes.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Location = new System.Drawing.Point(15, 515);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(123, 29);
            this.txtGender.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(70, 711);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(165, 35);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlCivilStatus
            // 
            this.pnlCivilStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCivilStatus.Controls.Add(this.rbtnWidowed);
            this.pnlCivilStatus.Controls.Add(this.rbtnMarried);
            this.pnlCivilStatus.Controls.Add(this.lblCivilStatus);
            this.pnlCivilStatus.Controls.Add(this.rbtnSingle);
            this.pnlCivilStatus.Controls.Add(this.rbtnSeparated);
            this.pnlCivilStatus.Location = new System.Drawing.Point(15, 552);
            this.pnlCivilStatus.Name = "pnlCivilStatus";
            this.pnlCivilStatus.Size = new System.Drawing.Size(270, 62);
            this.pnlCivilStatus.TabIndex = 12;
            // 
            // rbtnWidowed
            // 
            this.rbtnWidowed.AutoSize = true;
            this.rbtnWidowed.Location = new System.Drawing.Point(194, 33);
            this.rbtnWidowed.Name = "rbtnWidowed";
            this.rbtnWidowed.Size = new System.Drawing.Size(71, 19);
            this.rbtnWidowed.TabIndex = 10;
            this.rbtnWidowed.TabStop = true;
            this.rbtnWidowed.Text = "Widowed";
            this.rbtnWidowed.UseVisualStyleBackColor = true;
            // 
            // rbtnMarried
            // 
            this.rbtnMarried.AutoSize = true;
            this.rbtnMarried.Location = new System.Drawing.Point(104, 10);
            this.rbtnMarried.Name = "rbtnMarried";
            this.rbtnMarried.Size = new System.Drawing.Size(64, 19);
            this.rbtnMarried.TabIndex = 7;
            this.rbtnMarried.TabStop = true;
            this.rbtnMarried.Text = "Married";
            this.rbtnMarried.UseVisualStyleBackColor = true;
            // 
            // lblCivilStatus
            // 
            this.lblCivilStatus.AutoSize = true;
            this.lblCivilStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCivilStatus.Location = new System.Drawing.Point(5, 6);
            this.lblCivilStatus.Name = "lblCivilStatus";
            this.lblCivilStatus.Size = new System.Drawing.Size(99, 21);
            this.lblCivilStatus.TabIndex = 9;
            this.lblCivilStatus.Text = "Civil Status:";
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.Location = new System.Drawing.Point(194, 8);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(53, 19);
            this.rbtnSingle.TabIndex = 8;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "Single";
            this.rbtnSingle.UseVisualStyleBackColor = true;
            // 
            // rbtnSeparated
            // 
            this.rbtnSeparated.AutoSize = true;
            this.rbtnSeparated.Location = new System.Drawing.Point(104, 33);
            this.rbtnSeparated.Name = "rbtnSeparated";
            this.rbtnSeparated.Size = new System.Drawing.Size(72, 19);
            this.rbtnSeparated.TabIndex = 9;
            this.rbtnSeparated.TabStop = true;
            this.rbtnSeparated.Text = "Separated";
            this.rbtnSeparated.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.rbtnActive);
            this.pnlStatus.Controls.Add(this.rbtnInactive);
            this.pnlStatus.Location = new System.Drawing.Point(15, 666);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(270, 36);
            this.pnlStatus.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(5, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(103, 8);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(57, 19);
            this.rbtnActive.TabIndex = 12;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(193, 8);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(63, 19);
            this.rbtnInactive.TabIndex = 13;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // pnlDisplayEmployee
            // 
            this.pnlDisplayEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlDisplayEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayEmployee.Controls.Add(this.btnSearch);
            this.pnlDisplayEmployee.Controls.Add(this.btnRefresh);
            this.pnlDisplayEmployee.Controls.Add(this.lblUserID);
            this.pnlDisplayEmployee.Controls.Add(this.lblNames);
            this.pnlDisplayEmployee.Controls.Add(this.listBoxID);
            this.pnlDisplayEmployee.Controls.Add(this.listBoxNames);
            this.pnlDisplayEmployee.Controls.Add(this.btnViewAllEmp);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnStaffList);
            this.pnlDisplayEmployee.Controls.Add(this.rbtnHumanRes);
            this.pnlDisplayEmployee.Controls.Add(this.lblEmployeeList);
            this.pnlDisplayEmployee.Controls.Add(this.txtSearch);
            this.pnlDisplayEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDisplayEmployee.Location = new System.Drawing.Point(314, 8);
            this.pnlDisplayEmployee.Name = "pnlDisplayEmployee";
            this.pnlDisplayEmployee.Size = new System.Drawing.Size(528, 757);
            this.pnlDisplayEmployee.TabIndex = 66;
            // 
            // listBoxNames
            // 
            this.listBoxNames.BackColor = System.Drawing.Color.Black;
            this.listBoxNames.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNames.ForeColor = System.Drawing.Color.White;
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.ItemHeight = 22;
            this.listBoxNames.Location = new System.Drawing.Point(13, 184);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(301, 510);
            this.listBoxNames.TabIndex = 60;
            // 
            // rbtnStaffList
            // 
            this.rbtnStaffList.AutoSize = true;
            this.rbtnStaffList.Location = new System.Drawing.Point(14, 58);
            this.rbtnStaffList.Name = "rbtnStaffList";
            this.rbtnStaffList.Size = new System.Drawing.Size(51, 20);
            this.rbtnStaffList.TabIndex = 13;
            this.rbtnStaffList.TabStop = true;
            this.rbtnStaffList.Text = "Staff";
            this.rbtnStaffList.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeList.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeList.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeList.Location = new System.Drawing.Point(13, 12);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(234, 34);
            this.lblEmployeeList.TabIndex = 13;
            this.lblEmployeeList.Text = "EMPLOYEE LIST";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(13, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlReg
            // 
            this.pnlReg.Location = new System.Drawing.Point(-4, -5);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(844, 767);
            this.pnlReg.TabIndex = 68;
            // 
            // pnlPosition
            // 
            this.pnlPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPosition.Controls.Add(this.lblRole);
            this.pnlPosition.Controls.Add(this.rbtnHr);
            this.pnlPosition.Controls.Add(this.rbtnStaff);
            this.pnlPosition.Location = new System.Drawing.Point(16, 621);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(270, 36);
            this.pnlPosition.TabIndex = 12;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(5, 6);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(49, 21);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role:";
            // 
            // rbtnHr
            // 
            this.rbtnHr.AutoSize = true;
            this.rbtnHr.Location = new System.Drawing.Point(103, 8);
            this.rbtnHr.Name = "rbtnHr";
            this.rbtnHr.Size = new System.Drawing.Size(42, 19);
            this.rbtnHr.TabIndex = 12;
            this.rbtnHr.TabStop = true;
            this.rbtnHr.Text = "HR";
            this.rbtnHr.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(267, 228);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(14, 21);
            this.dtpBirthdate.TabIndex = 20;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(15, 465);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(270, 29);
            this.txtPass.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(15, 416);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 29);
            this.txtUsername.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(15, 367);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 29);
            this.txtAddress.TabIndex = 6;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.Location = new System.Drawing.Point(15, 319);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(270, 29);
            this.txtContactNumber.TabIndex = 5;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.Location = new System.Drawing.Point(15, 272);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(270, 29);
            this.txtNationality.TabIndex = 4;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Enabled = false;
            this.txtBirthdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthdate.ForeColor = System.Drawing.Color.Black;
            this.txtBirthdate.Location = new System.Drawing.Point(15, 225);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(270, 29);
            this.txtBirthdate.TabIndex = 3;
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.Black;
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddEmployee.Controls.Add(this.lblAge);
            this.pnlAddEmployee.Controls.Add(this.lblGender);
            this.pnlAddEmployee.Controls.Add(this.lblPassword);
            this.pnlAddEmployee.Controls.Add(this.lblUsername);
            this.pnlAddEmployee.Controls.Add(this.lblAddress);
            this.pnlAddEmployee.Controls.Add(this.lblContactNum);
            this.pnlAddEmployee.Controls.Add(this.lblNationality);
            this.pnlAddEmployee.Controls.Add(this.lblBdate);
            this.pnlAddEmployee.Controls.Add(this.lblLName);
            this.pnlAddEmployee.Controls.Add(this.lblMName);
            this.pnlAddEmployee.Controls.Add(this.lblFName);
            this.pnlAddEmployee.Controls.Add(this.txtAge);
            this.pnlAddEmployee.Controls.Add(this.txtGender);
            this.pnlAddEmployee.Controls.Add(this.btnRegister);
            this.pnlAddEmployee.Controls.Add(this.pnlCivilStatus);
            this.pnlAddEmployee.Controls.Add(this.pnlStatus);
            this.pnlAddEmployee.Controls.Add(this.pnlPosition);
            this.pnlAddEmployee.Controls.Add(this.dtpBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtPass);
            this.pnlAddEmployee.Controls.Add(this.txtUsername);
            this.pnlAddEmployee.Controls.Add(this.txtAddress);
            this.pnlAddEmployee.Controls.Add(this.txtContactNumber);
            this.pnlAddEmployee.Controls.Add(this.txtNationality);
            this.pnlAddEmployee.Controls.Add(this.txtBirthdate);
            this.pnlAddEmployee.Controls.Add(this.txtMidInitial);
            this.pnlAddEmployee.Controls.Add(this.txtLastName);
            this.pnlAddEmployee.Controls.Add(this.lblInstruction);
            this.pnlAddEmployee.Controls.Add(this.txtFirstName);
            this.pnlAddEmployee.Controls.Add(this.lblAddEmployee);
            this.pnlAddEmployee.Controls.Add(this.pnlReg);
            this.pnlAddEmployee.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAddEmployee.Location = new System.Drawing.Point(8, 8);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(300, 757);
            this.pnlAddEmployee.TabIndex = 67;
            // 
            // txtMidInitial
            // 
            this.txtMidInitial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidInitial.ForeColor = System.Drawing.Color.Black;
            this.txtMidInitial.Location = new System.Drawing.Point(15, 131);
            this.txtMidInitial.Name = "txtMidInitial";
            this.txtMidInitial.Size = new System.Drawing.Size(270, 29);
            this.txtMidInitial.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(15, 178);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(67, 49);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(177, 15);
            this.lblInstruction.TabIndex = 22;
            this.lblInstruction.Text = "Please fill in the information below ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(16, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(269, 29);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddEmployee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.White;
            this.lblAddEmployee.Location = new System.Drawing.Point(37, 12);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(232, 34);
            this.lblAddEmployee.TabIndex = 20;
            this.lblAddEmployee.Text = "ADD EMPLOYEE";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(850, 773);
            this.Controls.Add(this.pnlDisplayEmployee);
            this.Controls.Add(this.pnlAddEmployee);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.pnlCivilStatus.ResumeLayout(false);
            this.pnlCivilStatus.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlDisplayEmployee.ResumeLayout(false);
            this.pnlDisplayEmployee.PerformLayout();
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Button btnViewAllEmp;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.RadioButton rbtnStaff;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbtnHumanRes;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlCivilStatus;
        private System.Windows.Forms.RadioButton rbtnWidowed;
        private System.Windows.Forms.RadioButton rbtnMarried;
        private System.Windows.Forms.Label lblCivilStatus;
        private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.RadioButton rbtnSeparated;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.Panel pnlDisplayEmployee;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.RadioButton rbtnStaffList;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.RadioButton rbtnHr;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.TextBox txtMidInitial;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddEmployee;
    }
}