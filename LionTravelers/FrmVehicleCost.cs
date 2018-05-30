using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LionTravelers
{
    public partial class FrmVehicleCost : LionTravelers.FrmCost
    {
        public FrmVehicleCost()
        {
            InitializeComponent();
        }

        protected override void pushData()
        {
            base.pushData();

            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
            

            lcCost.KmCharge = Convert.ToDecimal(txtKmCharge.Text);
            
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
            txtKmCharge.Text = Convert.ToString(lcCost.KmCharge);
            lblAmountValue.Text = Convert.ToString(lcCost.KmCharge * lcCost.Distance);

        }

        private void txtKmCharge_TextChanged(object sender, EventArgs e)
        {
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
            lblAmountValue.Text = (txtKmCharge.Text.Length > 0) ? Convert.ToString(Convert.ToDecimal(txtKmCharge.Text) * lcCost.Distance) : "";
        }
    }
}
