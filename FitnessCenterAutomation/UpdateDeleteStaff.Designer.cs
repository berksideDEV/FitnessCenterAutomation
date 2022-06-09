namespace FitnessCenterAutomation
{
    partial class UpdateDeleteStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeleteStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStaffReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaffUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtStaffAge = new System.Windows.Forms.TextBox();
            this.txtStaffSalary = new System.Windows.Forms.TextBox();
            this.txtStaffMail = new System.Windows.Forms.TextBox();
            this.txtStaffSurname = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffSalary = new System.Windows.Forms.Label();
            this.lblStaffMail = new System.Windows.Forms.Label();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.lblStaffAge = new System.Windows.Forms.Label();
            this.lblStaffSurname = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new FitnessCenterAutomation.StaffDataSet();
            this.btnStaffDelete = new Guna.UI2.WinForms.Guna2Button();
            this.staffTableAdapter = new FitnessCenterAutomation.StaffDataSetTableAdapters.staffTableAdapter();
            this.lblId = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStaffReset
            // 
            this.btnStaffReset.BorderRadius = 15;
            this.btnStaffReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btnStaffReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffReset.ForeColor = System.Drawing.Color.Black;
            this.btnStaffReset.Location = new System.Drawing.Point(972, 604);
            this.btnStaffReset.Name = "btnStaffReset";
            this.btnStaffReset.Size = new System.Drawing.Size(180, 45);
            this.btnStaffReset.TabIndex = 10;
            this.btnStaffReset.Text = "Reset";
            this.btnStaffReset.Click += new System.EventHandler(this.btnStaffReset_Click);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BorderRadius = 15;
            this.btnStaffUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(253)))), ((int)(((byte)(62)))));
            this.btnStaffUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnStaffUpdate.Location = new System.Drawing.Point(508, 604);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnStaffUpdate.TabIndex = 8;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1271, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 48);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtStaffAge
            // 
            this.txtStaffAge.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtStaffAge.Location = new System.Drawing.Point(90, 370);
            this.txtStaffAge.Multiline = true;
            this.txtStaffAge.Name = "txtStaffAge";
            this.txtStaffAge.Size = new System.Drawing.Size(207, 39);
            this.txtStaffAge.TabIndex = 4;
            // 
            // txtStaffSalary
            // 
            this.txtStaffSalary.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtStaffSalary.Location = new System.Drawing.Point(94, 653);
            this.txtStaffSalary.Multiline = true;
            this.txtStaffSalary.Name = "txtStaffSalary";
            this.txtStaffSalary.Size = new System.Drawing.Size(207, 39);
            this.txtStaffSalary.TabIndex = 7;
            // 
            // txtStaffMail
            // 
            this.txtStaffMail.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtStaffMail.Location = new System.Drawing.Point(94, 561);
            this.txtStaffMail.Multiline = true;
            this.txtStaffMail.Name = "txtStaffMail";
            this.txtStaffMail.Size = new System.Drawing.Size(207, 39);
            this.txtStaffMail.TabIndex = 6;
            // 
            // txtStaffSurname
            // 
            this.txtStaffSurname.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtStaffSurname.Location = new System.Drawing.Point(90, 281);
            this.txtStaffSurname.Multiline = true;
            this.txtStaffSurname.Name = "txtStaffSurname";
            this.txtStaffSurname.Size = new System.Drawing.Size(207, 39);
            this.txtStaffSurname.TabIndex = 3;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffName.Location = new System.Drawing.Point(90, 181);
            this.txtStaffName.Multiline = true;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(207, 39);
            this.txtStaffName.TabIndex = 2;
            // 
            // lblStaffSalary
            // 
            this.lblStaffSalary.AutoSize = true;
            this.lblStaffSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffSalary.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffSalary.ForeColor = System.Drawing.Color.White;
            this.lblStaffSalary.Location = new System.Drawing.Point(90, 615);
            this.lblStaffSalary.Name = "lblStaffSalary";
            this.lblStaffSalary.Size = new System.Drawing.Size(65, 22);
            this.lblStaffSalary.TabIndex = 17;
            this.lblStaffSalary.Text = "Salary";
            // 
            // lblStaffMail
            // 
            this.lblStaffMail.AutoSize = true;
            this.lblStaffMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffMail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffMail.ForeColor = System.Drawing.Color.White;
            this.lblStaffMail.Location = new System.Drawing.Point(90, 523);
            this.lblStaffMail.Name = "lblStaffMail";
            this.lblStaffMail.Size = new System.Drawing.Size(46, 22);
            this.lblStaffMail.TabIndex = 16;
            this.lblStaffMail.Text = "Mail";
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffPhone.ForeColor = System.Drawing.Color.White;
            this.lblStaffPhone.Location = new System.Drawing.Point(86, 430);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(148, 22);
            this.lblStaffPhone.TabIndex = 15;
            this.lblStaffPhone.Text = "Phone Number";
            // 
            // lblStaffAge
            // 
            this.lblStaffAge.AutoSize = true;
            this.lblStaffAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffAge.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffAge.ForeColor = System.Drawing.Color.White;
            this.lblStaffAge.Location = new System.Drawing.Point(86, 336);
            this.lblStaffAge.Name = "lblStaffAge";
            this.lblStaffAge.Size = new System.Drawing.Size(50, 22);
            this.lblStaffAge.TabIndex = 14;
            this.lblStaffAge.Text = "Age";
            // 
            // lblStaffSurname
            // 
            this.lblStaffSurname.AutoSize = true;
            this.lblStaffSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffSurname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffSurname.ForeColor = System.Drawing.Color.White;
            this.lblStaffSurname.Location = new System.Drawing.Point(86, 246);
            this.lblStaffSurname.Name = "lblStaffSurname";
            this.lblStaffSurname.Size = new System.Drawing.Size(91, 22);
            this.lblStaffSurname.TabIndex = 13;
            this.lblStaffSurname.Text = "Surname";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblStaffName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(86, 147);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(66, 22);
            this.lblStaffName.TabIndex = 12;
            this.lblStaffName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(568, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Update or Delete Staff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "IEU FITNESS CLUB";
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StaffDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffDataGridView.AutoGenerateColumns = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StaffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffDataGridView.ColumnHeadersHeight = 50;
            this.StaffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.StaffDataGridView.DataSource = this.staffBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffDataGridView.EnableHeadersVisualStyles = false;
            this.StaffDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.StaffDataGridView.Location = new System.Drawing.Point(394, 104);
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.RowHeadersVisible = false;
            this.StaffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDataGridView.Size = new System.Drawing.Size(896, 453);
            this.StaffDataGridView.TabIndex = 27;
            this.StaffDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.StaffDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.StaffDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.StaffDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.StaffDataGridView.ThemeStyle.ReadOnly = true;
            this.StaffDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.StaffDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StaffDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.StaffDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.StaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.staffDataSet;
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "StaffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BorderRadius = 15;
            this.btnStaffDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaffDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaffDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaffDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(253)))), ((int)(((byte)(62)))));
            this.btnStaffDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffDelete.ForeColor = System.Drawing.Color.Black;
            this.btnStaffDelete.Location = new System.Drawing.Point(738, 604);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(180, 45);
            this.btnStaffDelete.TabIndex = 9;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(86, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 22);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Enabled = false;
            this.txtStaffId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffId.Location = new System.Drawing.Point(90, 95);
            this.txtStaffId.Multiline = true;
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(207, 39);
            this.txtStaffId.TabIndex = 1;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffPhone.Location = new System.Drawing.Point(90, 467);
            this.txtStaffPhone.Mask = "(999) 000-0000";
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(207, 37);
            this.txtStaffPhone.TabIndex = 5;
            // 
            // UpdateDeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1325, 707);
            this.Controls.Add(this.txtStaffPhone);
            this.Controls.Add(this.StaffDataGridView);
            this.Controls.Add(this.btnStaffReset);
            this.Controls.Add(this.btnStaffDelete);
            this.Controls.Add(this.btnStaffUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStaffAge);
            this.Controls.Add(this.txtStaffSalary);
            this.Controls.Add(this.txtStaffMail);
            this.Controls.Add(this.txtStaffSurname);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaffSalary);
            this.Controls.Add(this.lblStaffMail);
            this.Controls.Add(this.lblStaffPhone);
            this.Controls.Add(this.lblStaffAge);
            this.Controls.Add(this.lblStaffSurname);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDeleteStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteStaff";
            this.Load += new System.EventHandler(this.UpdateDeleteStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStaffReset;
        private Guna.UI2.WinForms.Guna2Button btnStaffUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtStaffAge;
        private System.Windows.Forms.TextBox txtStaffSalary;
        private System.Windows.Forms.TextBox txtStaffMail;
        private System.Windows.Forms.TextBox txtStaffSurname;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffSalary;
        private System.Windows.Forms.Label lblStaffMail;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.Label lblStaffAge;
        private System.Windows.Forms.Label lblStaffSurname;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView StaffDataGridView;
        private Guna.UI2.WinForms.Guna2Button btnStaffDelete;
        private StaffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private StaffDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.MaskedTextBox txtStaffPhone;
    }
}