namespace oyutnii_burtgel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode(" Мэдээллийн технологи");
            TreeNode treeNode2 = new TreeNode("Програм хангамж");
            TreeNode treeNode3 = new TreeNode("Компьютерийн ухаан", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode(" Математик");
            TreeNode treeNode5 = new TreeNode("   Физик");
            TreeNode treeNode6 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode4, treeNode5 });
            btnRegister = new Button();
            txtCode = new TextBox();
            lblTotal = new Label();
            lnkClear = new LinkLabel();
            chkScholarship = new CheckBox();
            rdoDay = new CheckBox();
            clbSubjects = new CheckedListBox();
            numAge = new NumericUpDown();
            lstLanguage = new ListBox();
            picStudent = new PictureBox();
            dgvStudents = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            treeDepartments = new TreeView();
            cmbDepartment = new ComboBox();
            txtPhone = new TextBox();
            dtpBirth = new DateTimePicker();
            penal1 = new Panel();
            lblStudentInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            penal1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(11, 508);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 61);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "бүртгэх ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 8);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 1;
            txtCode.Text = "M.IT19D002";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(205, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Нийт: 1";
            // 
            // lnkClear
            // 
            lnkClear.AutoSize = true;
            lnkClear.Location = new Point(389, 15);
            lnkClear.Name = "lnkClear";
            lnkClear.Size = new Size(73, 20);
            lnkClear.TabIndex = 3;
            lnkClear.TabStop = true;
            lnkClear.Text = "Цэвэрлэх";
            // 
            // chkScholarship
            // 
            chkScholarship.AutoSize = true;
            chkScholarship.Checked = true;
            chkScholarship.CheckState = CheckState.Checked;
            chkScholarship.Location = new Point(12, 63);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(108, 24);
            chkScholarship.TabIndex = 4;
            chkScholarship.Text = "Тэтгэлэгтэй";
            chkScholarship.UseVisualStyleBackColor = true;
            // 
            // rdoDay
            // 
            rdoDay.AutoSize = true;
            rdoDay.Checked = true;
            rdoDay.CheckState = CheckState.Checked;
            rdoDay.Location = new Point(11, 93);
            rdoDay.Name = "rdoDay";
            rdoDay.Size = new Size(141, 24);
            rdoDay.TabIndex = 5;
            rdoDay.Text = "Өдрийн сургалт";
            rdoDay.UseVisualStyleBackColor = true;
            // 
            // clbSubjects
            // 
            clbSubjects.CheckOnClick = true;
            clbSubjects.FormattingEnabled = true;
            clbSubjects.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан ", "Сүлжээ" });
            clbSubjects.Location = new Point(10, 156);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(151, 114);
            clbSubjects.TabIndex = 6;
            clbSubjects.SelectedIndexChanged += clbSubjects_SelectedIndexChanged_1;
            // 
            // numAge
            // 
            numAge.Location = new Point(11, 288);
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 7;
            numAge.Value = new decimal(new int[] { 21, 0, 0, 0 });
            numAge.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lstLanguage
            // 
            lstLanguage.FormattingEnabled = true;
            lstLanguage.Items.AddRange(new object[] { "Монгол ", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            lstLanguage.Location = new Point(205, 63);
            lstLanguage.Name = "lstLanguage";
            lstLanguage.Size = new Size(150, 124);
            lstLanguage.TabIndex = 8;
            // 
            // picStudent
            // 
            picStudent.Image = Properties.Resources.profile;
            picStudent.Location = new Point(205, 218);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(172, 183);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 9;
            picStudent.TabStop = false;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colAge });
            dgvStudents.Location = new Point(389, 63);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(298, 124);
            dgvStudents.TabIndex = 10;
            // 
            // colName
            // 
            colName.HeaderText = "Овог нэр";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Утас";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            // 
            // colAge
            // 
            colAge.HeaderText = "Нас";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            // 
            // treeDepartments
            // 
            treeDepartments.Location = new Point(389, 218);
            treeDepartments.Name = "treeDepartments";
            treeNode1.Name = "Node1";
            treeNode1.Text = " Мэдээллийн технологи";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Програм хангамж";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Компьютерийн ухаан";
            treeNode4.Name = "Node4";
            treeNode4.Text = " Математик";
            treeNode5.Name = "Node5";
            treeNode5.Text = "   Физик";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Байгалийн ухааны сургууль";
            treeDepartments.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            treeDepartments.Size = new Size(298, 183);
            treeDepartments.TabIndex = 11;
            treeDepartments.AfterSelect += treeDepartments_AfterSelect;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Мэдээллийн технологи", "Компьютерийн ухаан", "Программ хангамж", "Байгалийн ухаан" });
            cmbDepartment.Location = new Point(10, 373);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 12;
            cmbDepartment.Text = "--Тэнхим сонгох";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 407);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(151, 27);
            txtPhone.TabIndex = 13;
            txtPhone.Text = "99990000";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(11, 440);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(170, 27);
            dtpBirth.TabIndex = 14;
            // 
            // penal1
            // 
            penal1.Controls.Add(lblStudentInfo);
            penal1.Location = new Point(205, 416);
            penal1.Name = "penal1";
            penal1.Size = new Size(482, 237);
            penal1.TabIndex = 15;
            // 
            // lblStudentInfo
            // 
            lblStudentInfo.AutoSize = true;
            lblStudentInfo.Location = new Point(22, 13);
            lblStudentInfo.Name = "lblStudentInfo";
            lblStudentInfo.Size = new Size(102, 180);
            lblStudentInfo.TabIndex = 0;
            lblStudentInfo.Text = "Код:\r\nУтас:\r\nНас:\r\nТөрсөн өдөр:\r\nСургалт:\r\nТэнхим:\r\nТэтгэлэг:\r\nХичээл:\r\nХэл: \r\n";
            lblStudentInfo.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 733);
            Controls.Add(penal1);
            Controls.Add(dtpBirth);
            Controls.Add(txtPhone);
            Controls.Add(cmbDepartment);
            Controls.Add(treeDepartments);
            Controls.Add(dgvStudents);
            Controls.Add(picStudent);
            Controls.Add(lstLanguage);
            Controls.Add(numAge);
            Controls.Add(clbSubjects);
            Controls.Add(rdoDay);
            Controls.Add(chkScholarship);
            Controls.Add(lnkClear);
            Controls.Add(lblTotal);
            Controls.Add(txtCode);
            Controls.Add(btnRegister);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            penal1.ResumeLayout(false);
            penal1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtCode;
        private Label lblTotal;
        private LinkLabel lnkClear;
        private CheckBox chkScholarship;
        private CheckBox rdoDay;
        private CheckedListBox clbSubjects;
        private NumericUpDown numAge;
        private ListBox lstLanguage;
        private PictureBox picStudent;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAge;
        private TreeView treeDepartments;
        private ComboBox cmbDepartment;
        private TextBox txtPhone;
        private DateTimePicker dtpBirth;
        private Panel penal1;
        private Label lblStudentInfo;
    }
}
