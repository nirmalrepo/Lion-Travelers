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

        }
    }
}
