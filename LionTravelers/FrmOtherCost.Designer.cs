namespace LionTravelers
{
    partial class FrmOtherCost
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
            this.lblOtherFee = new System.Windows.Forms.Label();
            this.txtOtherCostAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOtherFee
            // 
            this.lblOtherFee.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherFee.Location = new System.Drawing.Point(130, 47);
            this.lblOtherFee.Name = "lblOtherFee";
            this.lblOtherFee.Size = new System.Drawing.Size(64, 16);
            this.lblOtherFee.TabIndex = 69;
            this.lblOtherFee.Text = "Other Fee";
            // 
            // txtOtherCostAmount
            // 
            this.txtOtherCostAmount.Location = new System.Drawing.Point(133, 66);
            this.txtOtherCostAmount.Name = "txtOtherCostAmount";
            this.txtOtherCostAmount.Size = new System.Drawing.Size(101, 20);
            this.txtOtherCostAmount.TabIndex = 68;
            this.txtOtherCostAmount.Text = " ";
            // 
            // FrmOtherCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(273, 312);
            this.Controls.Add(this.lblOtherFee);
            this.Controls.Add(this.txtOtherCostAmount);
            this.Name = "FrmOtherCost";
            this.Controls.SetChildIndex(this.txtOtherCostAmount, 0);
            this.Controls.SetChildIndex(this.lblOtherFee, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblOtherFee;
        private System.Windows.Forms.TextBox txtOtherCostAmount;
    }
}
