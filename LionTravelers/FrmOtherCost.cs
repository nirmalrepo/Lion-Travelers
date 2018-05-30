using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            lcCost.OtherFees = Convert.ToDecimal(txtOtherCostAmount.Text);
        }
        protected override void updateDisplay()
        {
            base.updateDisplay();

            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
            txtOtherCostAmount.Text = Convert.ToString(lcCost.OtherFees);

        }
    }
}
