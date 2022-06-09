namespace FitnessCenterAutomation
{
    partial class UpdateDeleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeleteCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new FitnessCenterAutomation.CustomerDataSet();
            this.btnCustomerReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.txtCustomerMail = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerMail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.customerTableAdapter = new FitnessCenterAutomation.CustomerDataSetTableAdapters.customerTableAdapter();
            this.txtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.fitnessCenterDBDataSet = new FitnessCenterAutomation.FitnessCenterDBDataSet();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new FitnessCenterAutomation.FitnessCenterDBDataSetTableAdapters.customerTableAdapter();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessCenterDBDataSet1 = new FitnessCenterAutomation.FitnessCenterDBDataSet1();
            this.customerTableAdapter2 = new FitnessCenterAutomation.FitnessCenterDBDataSet1TableAdapters.customerTableAdapter();
            this.CustomerDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.fitnessCenterDBDataSet2 = new FitnessCenterAutomation.FitnessCenterDBDataSet2();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter3 = new FitnessCenterAutomation.FitnessCenterDBDataSet2TableAdapters.customerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCustomerReset
            // 
            this.btnCustomerReset.BorderRadius = 15;
            this.btnCustomerReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btnCustomerReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerReset.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerReset.Location = new System.Drawing.Point(927, 609);
            this.btnCustomerReset.Name = "btnCustomerReset";
            this.btnCustomerReset.Size = new System.Drawing.Size(180, 45);
            this.btnCustomerReset.TabIndex = 9;
            this.btnCustomerReset.Text = "Reset";
            this.btnCustomerReset.Click += new System.EventHandler(this.btnCustomerReset_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BorderRadius = 15;
            this.btnCustomerDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(253)))), ((int)(((byte)(62)))));
            this.btnCustomerDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerDelete.Location = new System.Drawing.Point(693, 609);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(180, 45);
            this.btnCustomerDelete.TabIndex = 8;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BorderRadius = 15;
            this.btnCustomerUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(253)))), ((int)(((byte)(62)))));
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(463, 609);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnCustomerUpdate.TabIndex = 7;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1226, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 48);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtCustomerAge.Location = new System.Drawing.Point(77, 401);
            this.txtCustomerAge.Multiline = true;
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(207, 39);
            this.txtCustomerAge.TabIndex = 4;
            // 
            // txtCustomerMail
            // 
            this.txtCustomerMail.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtCustomerMail.Location = new System.Drawing.Point(81, 592);
            this.txtCustomerMail.Multiline = true;
            this.txtCustomerMail.Name = "txtCustomerMail";
            this.txtCustomerMail.Size = new System.Drawing.Size(207, 39);
            this.txtCustomerMail.TabIndex = 6;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.txtCustomerSurname.Location = new System.Drawing.Point(77, 312);
            this.txtCustomerSurname.Multiline = true;
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(207, 39);
            this.txtCustomerSurname.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerName.Location = new System.Drawing.Point(77, 212);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(207, 39);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerMail
            // 
            this.lblCustomerMail.AutoSize = true;
            this.lblCustomerMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblCustomerMail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerMail.ForeColor = System.Drawing.Color.White;
            this.lblCustomerMail.Location = new System.Drawing.Point(77, 554);
            this.lblCustomerMail.Name = "lblCustomerMail";
            this.lblCustomerMail.Size = new System.Drawing.Size(46, 22);
            this.lblCustomerMail.TabIndex = 34;
            this.lblCustomerMail.Text = "Mail";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblCustomerPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.lblCustomerPhone.Location = new System.Drawing.Point(73, 461);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(148, 22);
            this.lblCustomerPhone.TabIndex = 33;
            this.lblCustomerPhone.Text = "Phone Number";
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblCustomerAge.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAge.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAge.Location = new System.Drawing.Point(73, 367);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(50, 22);
            this.lblCustomerAge.TabIndex = 32;
            this.lblCustomerAge.Text = "Age";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblCustomerSurname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSurname.ForeColor = System.Drawing.Color.White;
            this.lblCustomerSurname.Location = new System.Drawing.Point(73, 277);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(91, 22);
            this.lblCustomerSurname.TabIndex = 31;
            this.lblCustomerSurname.Text = "Surname";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(73, 178);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(66, 22);
            this.lblCustomerName.TabIndex = 30;
            this.lblCustomerName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(523, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Update or Delete Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "IEU FITNESS CLUB";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerId.Location = new System.Drawing.Point(77, 136);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(207, 39);
            this.txtCustomerId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(73, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 22);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "ID";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(77, 495);
            this.txtCustomerPhone.Mask = "(999) 000-0000";
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(207, 37);
            this.txtCustomerPhone.TabIndex = 5;
            // 
            // fitnessCenterDBDataSet
            // 
            this.fitnessCenterDBDataSet.DataSetName = "FitnessCenterDBDataSet";
            this.fitnessCenterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.fitnessCenterDBDataSet;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.fitnessCenterDBDataSet1;
            // 
            // fitnessCenterDBDataSet1
            // 
            this.fitnessCenterDBDataSet1.DataSetName = "FitnessCenterDBDataSet1";
            this.fitnessCenterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGridView.AutoGenerateColumns = false;
            this.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CustomerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDataGridView.ColumnHeadersHeight = 50;
            this.CustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.CustomerDataGridView.DataSource = this.customerBindingSource3;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerDataGridView.EnableHeadersVisualStyles = false;
            this.CustomerDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.CustomerDataGridView.Location = new System.Drawing.Point(372, 123);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.ReadOnly = true;
            this.CustomerDataGridView.RowHeadersVisible = false;
            this.CustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDataGridView.Size = new System.Drawing.Size(896, 453);
            this.CustomerDataGridView.TabIndex = 49;
            this.CustomerDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerDataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.CustomerDataGridView.ThemeStyle.ReadOnly = true;
            this.CustomerDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CustomerDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.CustomerDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGridView_CellClick);
            // 
            // fitnessCenterDBDataSet2
            // 
            this.fitnessCenterDBDataSet2.DataSetName = "FitnessCenterDBDataSet2";
            this.fitnessCenterDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "customer";
            this.customerBindingSource3.DataSource = this.fitnessCenterDBDataSet2;
            // 
            // customerTableAdapter3
            // 
            this.customerTableAdapter3.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UpdateDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 668);
            this.Controls.Add(this.CustomerDataGridView);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnCustomerReset);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCustomerAge);
            this.Controls.Add(this.txtCustomerMail);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerMail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerAge);
            this.Controls.Add(this.lblCustomerSurname);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteCustomer";
            this.Load += new System.EventHandler(this.UpdateDeleteCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessCenterDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCustomerReset;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDelete;
        private Guna.UI2.WinForms.Guna2Button btnCustomerUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.TextBox txtCustomerMail;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerMail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblId;
        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhone;
        private FitnessCenterDBDataSet fitnessCenterDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private FitnessCenterDBDataSetTableAdapters.customerTableAdapter customerTableAdapter1;
        private FitnessCenterDBDataSet1 fitnessCenterDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private FitnessCenterDBDataSet1TableAdapters.customerTableAdapter customerTableAdapter2;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDataGridView;
        private FitnessCenterDBDataSet2 fitnessCenterDBDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private FitnessCenterDBDataSet2TableAdapters.customerTableAdapter customerTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
    }
}