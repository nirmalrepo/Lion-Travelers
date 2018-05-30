namespace LionTravelers
{
    partial class FrmStaffCost
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStaffType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Type";
            // 
            // comboBoxStaffType
            // 
            this.comboBoxStaffType.FormattingEnabled = true;
            this.comboBoxStaffType.Items.AddRange(new object[] {
            "Driver",
            "Tour Guide"});
            this.comboBoxStaffType.Location = new System.Drawing.Point(133, 67);
            this.comboBoxStaffType.Name = "comboBoxStaffType";
            this.comboBoxStaffType.Size = new System.Drawing.Size(101, 21);
            this.comboBoxStaffType.TabIndex = 69;
            this.comboBoxStaffType.SelectedIndexChanged += new System.EventHandler(this.comboBoxStaffType_SelectedIndexChanged);
            // 
            // FrmStaffCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(273, 312);
            this.Controls.Add(this.comboBoxStaffType);
            this.Controls.Add(this.label6);
            this.Name = "FrmStaffCost";
            this.Text = "Staff Cost";
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.comboBoxStaffType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStaffType;
    }
}
