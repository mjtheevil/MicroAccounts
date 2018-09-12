﻿namespace MicroAccounts.UserControls
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLedgerDr = new System.Windows.Forms.Label();
            this.cmbLedgerDR = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDrBal = new System.Windows.Forms.Label();
            this.lblLedgerCR = new System.Windows.Forms.Label();
            this.cmbLedgerCR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCrBal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDetailsGrid = new System.Windows.Forms.Label();
            this.dgPaymentDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblNoteForAmt = new System.Windows.Forms.Label();
            this.SidePanel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLedgerDr
            // 
            this.lblLedgerDr.AutoSize = true;
            this.lblLedgerDr.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblLedgerDr.Location = new System.Drawing.Point(23, 19);
            this.lblLedgerDr.Name = "lblLedgerDr";
            this.lblLedgerDr.Size = new System.Drawing.Size(103, 20);
            this.lblLedgerDr.TabIndex = 25;
            this.lblLedgerDr.Text = "Ledger (Dr) : ";
            // 
            // cmbLedgerDR
            // 
            this.cmbLedgerDR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLedgerDR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLedgerDR.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbLedgerDR.FormattingEnabled = true;
            this.cmbLedgerDR.Items.AddRange(new object[] {
            "--Select--"});
            this.cmbLedgerDR.Location = new System.Drawing.Point(133, 15);
            this.cmbLedgerDR.Name = "cmbLedgerDR";
            this.cmbLedgerDR.Size = new System.Drawing.Size(519, 28);
            this.cmbLedgerDR.TabIndex = 0;
            this.cmbLedgerDR.SelectedIndexChanged += new System.EventHandler(this.cmbLedgerDR_SelectedIndexChanged);
            this.cmbLedgerDR.Enter += new System.EventHandler(this.cmbLedgerDR_Enter);
            this.cmbLedgerDR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLedgerDR_KeyDown);
            this.cmbLedgerDR.Leave += new System.EventHandler(this.cmbLedgerDR_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker1.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(825, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Date : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 110;
            this.label3.Text = "Bal. : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDrBal
            // 
            this.lblDrBal.AutoSize = true;
            this.lblDrBal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrBal.Location = new System.Drawing.Point(711, 23);
            this.lblDrBal.Name = "lblDrBal";
            this.lblDrBal.Size = new System.Drawing.Size(36, 18);
            this.lblDrBal.TabIndex = 110;
            this.lblDrBal.Text = "0.00";
            this.lblDrBal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLedgerCR
            // 
            this.lblLedgerCR.AutoSize = true;
            this.lblLedgerCR.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblLedgerCR.Location = new System.Drawing.Point(22, 55);
            this.lblLedgerCR.Name = "lblLedgerCR";
            this.lblLedgerCR.Size = new System.Drawing.Size(104, 20);
            this.lblLedgerCR.TabIndex = 25;
            this.lblLedgerCR.Text = "Ledger (Cr) : ";
            // 
            // cmbLedgerCR
            // 
            this.cmbLedgerCR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLedgerCR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbLedgerCR.Enabled = false;
            this.cmbLedgerCR.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cmbLedgerCR.FormattingEnabled = true;
            this.cmbLedgerCR.Location = new System.Drawing.Point(133, 52);
            this.cmbLedgerCR.Name = "cmbLedgerCR";
            this.cmbLedgerCR.Size = new System.Drawing.Size(519, 28);
            this.cmbLedgerCR.TabIndex = 1;
            this.cmbLedgerCR.SelectedIndexChanged += new System.EventHandler(this.cmbLedgerCR_SelectedIndexChanged);
            this.cmbLedgerCR.Enter += new System.EventHandler(this.cmbLedgerCR_Enter);
            this.cmbLedgerCR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLedgerCR_KeyDown);
            this.cmbLedgerCR.Leave += new System.EventHandler(this.cmbLedgerCR_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 110;
            this.label5.Text = "Bal. : ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCrBal
            // 
            this.lblCrBal.AutoSize = true;
            this.lblCrBal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrBal.Location = new System.Drawing.Point(711, 61);
            this.lblCrBal.Name = "lblCrBal";
            this.lblCrBal.Size = new System.Drawing.Size(36, 18);
            this.lblCrBal.TabIndex = 110;
            this.lblCrBal.Text = "0.00";
            this.lblCrBal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(24, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Amount : ";
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAmt.Location = new System.Drawing.Point(133, 92);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(115, 26);
            this.txtAmt.TabIndex = 2;
            this.txtAmt.Text = "0.00";
            this.txtAmt.TextChanged += new System.EventHandler(this.txtAmt_TextChanged);
            this.txtAmt.Enter += new System.EventHandler(this.txtAmt_Enter);
            this.txtAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmt_KeyDown);
            this.txtAmt.Leave += new System.EventHandler(this.txtAmt_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label16.Location = new System.Drawing.Point(258, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 126;
            this.label16.Text = "/- rs";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(476, 181);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 32);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(567, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(133, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 30);
            this.panel3.TabIndex = 125;
            this.panel3.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblError.Location = new System.Drawing.Point(4, 4);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(152, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Confirm Password : ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRemark.Location = new System.Drawing.Point(133, 132);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(519, 39);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.Enter += new System.EventHandler(this.txtRemark_Enter);
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label14.Location = new System.Drawing.Point(24, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 129;
            this.label14.Text = "Remarks : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Goldenrod;
            this.panel4.Location = new System.Drawing.Point(25, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 3);
            this.panel4.TabIndex = 131;
            // 
            // lblDetailsGrid
            // 
            this.lblDetailsGrid.AutoSize = true;
            this.lblDetailsGrid.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsGrid.Location = new System.Drawing.Point(19, 217);
            this.lblDetailsGrid.Name = "lblDetailsGrid";
            this.lblDetailsGrid.Size = new System.Drawing.Size(229, 33);
            this.lblDetailsGrid.TabIndex = 130;
            this.lblDetailsGrid.Text = "Payment Details";
            // 
            // dgPaymentDetails
            // 
            this.dgPaymentDetails.AllowUserToAddRows = false;
            this.dgPaymentDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPaymentDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPaymentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaymentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Delete});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPaymentDetails.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgPaymentDetails.Location = new System.Drawing.Point(21, 262);
            this.dgPaymentDetails.Name = "dgPaymentDetails";
            this.dgPaymentDetails.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPaymentDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgPaymentDetails.Size = new System.Drawing.Size(983, 325);
            this.dgPaymentDetails.TabIndex = 132;
            this.dgPaymentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaymentDetails_CellContentClick);
            this.dgPaymentDetails.DoubleClick += new System.EventHandler(this.dgPaymentDetails_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "voucherRefNo";
            this.Column1.HeaderText = "SrNo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "rowNo";
            this.Column8.HeaderText = "#";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "date";
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "drcrLedger";
            this.Column2.HeaderText = "Ledger";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "amt";
            this.Column3.HeaderText = "Dr Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 230;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "amt";
            this.Column4.HeaderText = "Cr Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 230;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete.HeaderText = "Actions";
            this.Delete.Image = global::MicroAccounts.Properties.Resources.delete1;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(24, 590);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 17);
            this.label15.TabIndex = 137;
            this.label15.Text = "* Note : Double-Click on any one row to EDIT.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "Actions";
            this.dataGridViewImageColumn1.Image = global::MicroAccounts.Properties.Resources.delete1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // lblNoteForAmt
            // 
            this.lblNoteForAmt.AutoSize = true;
            this.lblNoteForAmt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteForAmt.ForeColor = System.Drawing.Color.Red;
            this.lblNoteForAmt.Location = new System.Drawing.Point(300, 101);
            this.lblNoteForAmt.Name = "lblNoteForAmt";
            this.lblNoteForAmt.Size = new System.Drawing.Size(455, 17);
            this.lblNoteForAmt.TabIndex = 138;
            this.lblNoteForAmt.Text = "* Note : To enter bill reference click here and then enter tab.(Amt Required)";
            // 
            // SidePanel2
            // 
            this.SidePanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.SidePanel2.Location = new System.Drawing.Point(13, 13);
            this.SidePanel2.Name = "SidePanel2";
            this.SidePanel2.Size = new System.Drawing.Size(5, 34);
            this.SidePanel2.TabIndex = 139;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SidePanel2);
            this.Controls.Add(this.lblNoteForAmt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgPaymentDetails);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDetailsGrid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCrBal);
            this.Controls.Add(this.lblDrBal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLedgerCR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLedgerCR);
            this.Controls.Add(this.cmbLedgerDR);
            this.Controls.Add(this.lblLedgerDr);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1023, 612);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLedgerDr;
        private System.Windows.Forms.ComboBox cmbLedgerDR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDrBal;
        private System.Windows.Forms.Label lblLedgerCR;
        private System.Windows.Forms.ComboBox cmbLedgerCR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCrBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDetailsGrid;
        private System.Windows.Forms.DataGridView dgPaymentDetails;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblNoteForAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel SidePanel2;
    }
}
