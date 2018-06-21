using System;

namespace LionTravelers
{
    public partial class FrmOtherCost : LionTravelers.FrmCost
    {
        public FrmOtherCost()
        {
            InitializeComponent();
        }
        protected override void pushData()
        {
            base.pushData();

            ClsOtherCost lcCost = (ClsOtherCost)_Cost;

            lcCost.OtherFees = txtOtherCostAmount.Text;
        }
        protected override void updateDisplay()
        {
            base.updateDisplay();

            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
            txtOtherCostAmount.Text = Convert.ToString(lcCost.OtherFees);

        }

        private void txtOtherCostAmount_TextChanged(object sender, EventArgs e)
        {
            lblAmountValue.Text = txtOtherCostAmount.Text;
        }
    }
}
