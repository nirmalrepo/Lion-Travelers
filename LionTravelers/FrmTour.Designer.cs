namespace LionTravelers
{
    partial class FrmTour
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
            this.btnAddTourCancel = new System.Windows.Forms.Button();
            this.btnEditTourCost = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCostType = new System.Windows.Forms.ComboBox();
            this.btnDeleteTourCost = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTourCost = new System.Windows.Forms.Button();
            this.listViewTourCost = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMarkup = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxPassengers = new System.Windows.Forms.NumericUpDown();
            this.dateTimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.btnAddTourOk = new System.Windows.Forms.Button();
            this.lblTourPrice = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTourCancel
            // 
            this.btnAddTourCancel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTourCancel.ForeColor = System.Drawing.Color.Olive;
            this.btnAddTourCancel.Location = new System.Drawing.Point(119, 313);
            this.btnAddTourCancel.Name = "btnAddTourCancel";
            this.btnAddTourCancel.Size = new System.Drawing.Size(64, 32);
            this.btnAddTourCancel.TabIndex = 62;
            this.btnAddTourCancel.Text = "Cancel";
            this.btnAddTourCancel.Click += new System.EventHandler(this.btnAddTourCancel_Click);
            // 
            // btnEditTourCost
            // 
            this.btnEditTourCost.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTourCost.ForeColor = System.Drawing.Color.Olive;
            this.btnEditTourCost.Location = new System.Drawing.Point(83, 206);
            this.btnEditTourCost.Name = "btnEditTourCost";
            this.btnEditTourCost.Size = new System.Drawing.Size(61, 21);
            this.btnEditTourCost.TabIndex = 56;
            this.btnEditTourCost.Text = "Edit";
            this.btnEditTourCost.Click += new System.EventHandler(this.btnEditTourCost_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 14);
            this.label13.TabIndex = 55;
            this.label13.Text = "Select cost type:";
            // 
            // comboBoxCostType
            // 
            this.comboBoxCostType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCostType.FormattingEnabled = true;
            this.comboBoxCostType.Items.AddRange(new object[] {
            "Vehicle",
            "Staff",
            "Other"});
            this.comboBoxCostType.Location = new System.Drawing.Point(126, 170);
            this.comboBoxCostType.Name = "comboBoxCostType";
            this.comboBoxCostType.Size = new System.Drawing.Size(152, 22);
            this.comboBoxCostType.TabIndex = 54;
            // 
            // btnDeleteTourCost
            // 
            this.btnDeleteTourCost.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTourCost.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteTourCost.Location = new System.Drawing.Point(217, 206);
            this.btnDeleteTourCost.Name = "btnDeleteTourCost";
            this.btnDeleteTourCost.Size = new System.Drawing.Size(61, 22);
            this.btnDeleteTourCost.TabIndex = 53;
            this.btnDeleteTourCost.Text = "Delete";
            this.btnDeleteTourCost.Click += new System.EventHandler(this.btnDeleteTourCost_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalCost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEditTourCost);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBoxCostType);
            this.groupBox2.Controls.Add(this.btnDeleteTourCost);
            this.groupBox2.Controls.Add(this.btnAddTourCost);
            this.groupBox2.Controls.Add(this.listViewTourCost);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(352, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 247);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(188, 150);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(69, 16);
            this.lblTotalCost.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Total Cost:";
            // 
            // btnAddTourCost
            // 
            this.btnAddTourCost.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTourCost.ForeColor = System.Drawing.Color.Green;
            this.btnAddTourCost.Location = new System.Drawing.Point(16, 206);
            this.btnAddTourCost.Name = "btnAddTourCost";
            this.btnAddTourCost.Size = new System.Drawing.Size(61, 21);
            this.btnAddTourCost.TabIndex = 52;
            this.btnAddTourCost.Text = "Add";
            this.btnAddTourCost.Click += new System.EventHandler(this.btnAddTourCost_Click);
            // 
            // listViewTourCost
            // 
            this.listViewTourCost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listViewTourCost.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTourCost.FullRowSelect = true;
            this.listViewTourCost.Location = new System.Drawing.Point(15, 25);
            this.listViewTourCost.Name = "listViewTourCost";
            this.listViewTourCost.Size = new System.Drawing.Size(262, 113);
            this.listViewTourCost.TabIndex = 45;
            this.listViewTourCost.UseCompatibleStateImageBehavior = false;
            this.listViewTourCost.View = System.Windows.Forms.View.Details;
            this.listViewTourCost.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTourCost_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cost";
            this.columnHeader5.Width = 71;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "Km";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Markup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMarkup);
            this.groupBox1.Controls.Add(this.numericUpDownDistance);
            this.groupBox1.Controls.Add(this.numericUpDownMaxPassengers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimeEndDate);
            this.groupBox1.Controls.Add(this.dateTimeStartDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 249);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tour Details";
            // 
            // numericUpDownMarkup
            // 
            this.numericUpDownMarkup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMarkup.Location = new System.Drawing.Point(79, 213);
            this.numericUpDownMarkup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMarkup.Name = "numericUpDownMarkup";
            this.numericUpDownMarkup.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMarkup.TabIndex = 57;
            this.numericUpDownMarkup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMarkup.ValueChanged += new System.EventHandler(this.numericUpDownMarkup_ValueChanged);
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDistance.Location = new System.Drawing.Point(79, 186);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownDistance.TabIndex = 56;
            this.numericUpDownDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDistance.ValueChanged += new System.EventHandler(this.numericUpDownDistance_ValueChanged);
            // 
            // numericUpDownMaxPassengers
            // 
            this.numericUpDownMaxPassengers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMaxPassengers.Location = new System.Drawing.Point(149, 155);
            this.numericUpDownMaxPassengers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxPassengers.Name = "numericUpDownMaxPassengers";
            this.numericUpDownMaxPassengers.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMaxPassengers.TabIndex = 55;
            this.numericUpDownMaxPassengers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxPassengers.ValueChanged += new System.EventHandler(this.numericUpDownMaxPassengers_ValueChanged);
            // 
            // dateTimeEndDate
            // 
            this.dateTimeEndDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEndDate.Location = new System.Drawing.Point(153, 120);
            this.dateTimeEndDate.Name = "dateTimeEndDate";
            this.dateTimeEndDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimeEndDate.TabIndex = 50;
            this.dateTimeEndDate.ValueChanged += new System.EventHandler(this.dateTimeEndDate_ValueChanged);
            // 
            // dateTimeStartDate
            // 
            this.dateTimeStartDate.CustomFormat = "";
            this.dateTimeStartDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStartDate.Location = new System.Drawing.Point(19, 120);
            this.dateTimeStartDate.Name = "dateTimeStartDate";
            this.dateTimeStartDate.Size = new System.Drawing.Size(124, 20);
            this.dateTimeStartDate.TabIndex = 49;
            this.dateTimeStartDate.ValueChanged += new System.EventHandler(this.dateTimeStartDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Max. No of Passengers";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "End Date";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 94);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "%";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Distance";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(150, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Name";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(19, 62);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(51, 20);
            this.txtCode.TabIndex = 42;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Code";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(348, 273);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(171, 25);
            this.Label5.TabIndex = 57;
            this.Label5.Text = "Price Per Passenger:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(585, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 32);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.Location = new System.Drawing.Point(442, 246);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(90, 16);
            this.labelTotalCost.TabIndex = 59;
            // 
            // btnAddTourOk
            // 
            this.btnAddTourOk.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTourOk.ForeColor = System.Drawing.Color.Green;
            this.btnAddTourOk.Location = new System.Drawing.Point(37, 313);
            this.btnAddTourOk.Name = "btnAddTourOk";
            this.btnAddTourOk.Size = new System.Drawing.Size(64, 32);
            this.btnAddTourOk.TabIndex = 63;
            this.btnAddTourOk.Text = "OK";
            this.btnAddTourOk.Click += new System.EventHandler(this.btnAddTourOk_Click);
            // 
            // lblTourPrice
            // 
            this.lblTourPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTourPrice.Location = new System.Drawing.Point(525, 273);
            this.lblTourPrice.Name = "lblTourPrice";
            this.lblTourPrice.Size = new System.Drawing.Size(124, 16);
            this.lblTourPrice.TabIndex = 64;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 357);
            this.Controls.Add(this.lblTourPrice);
            this.Controls.Add(this.btnAddTourOk);
            this.Controls.Add(this.btnAddTourCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelTotalCost);
            this.Name = "FrmTour";
            this.Text = "Tour Detaills";
            this.Load += new System.EventHandler(this.FrmTour_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPassengers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnAddTourCancel;
        internal System.Windows.Forms.Button btnEditTourCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCostType;
        internal System.Windows.Forms.Button btnDeleteTourCost;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnAddTourCost;
        private System.Windows.Forms.ListView listViewTourCost;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeEndDate;
        private System.Windows.Forms.DateTimePicker dateTimeStartDate;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.NumericUpDown numericUpDownMarkup;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPassengers;
        internal System.Windows.Forms.Button btnAddTourOk;
        internal System.Windows.Forms.Label lblTotalCost;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblTourPrice;
    }
}