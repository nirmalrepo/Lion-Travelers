﻿using System;

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

        protected override bool IsValidForm()
        {
            if (!base.IsValidForm())
            {
                return false;
            }
            
            if (txtKmCharge.Text == "" )
            {
                ShowErrorMessage("Please provide all the required fields.", "Required Fields");
                return false;
            }
           
            else
            {
                return true;
            }
        }

        protected override void ShowErrorMessage(string detail, string title)
        {
            base.ShowErrorMessage(detail, title);
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
