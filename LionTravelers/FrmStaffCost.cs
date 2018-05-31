using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LionTravelers
{
    public partial class FrmStaffCost : LionTravelers.FrmCost
    {
        public FrmStaffCost()
        {
            InitializeComponent();
        }
        protected override void pushData()
        {
            base.pushData();

            ClsStaffCost lcCost = (ClsStaffCost)_Cost;
            lcCost.StaffType = comboBoxStaffType.SelectedItem.ToString();
        }
        protected override void updateDisplay()
        {
            base.updateDisplay();

            ClsStaffCost lcCost = (ClsStaffCost)_Cost;
            var StaffType = lcCost.StaffType;
            var NoOfDays = lcCost.NoOfDays;
            comboBoxStaffType.SelectedValue = StaffType ;
            lblAmountValue.Text =  (StaffType == "Driver") 
                ? Convert.ToString(Convert.ToDecimal(200) * NoOfDays) 
                :(StaffType == "Driver")
                ? Convert.ToString(Convert.ToDecimal(100) * NoOfDays)
                : "";

        }

        private void comboBoxStaffType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = comboBoxStaffType.SelectedIndex;
            ClsStaffCost lcCost = (ClsStaffCost)_Cost;
            lblAmountValue.Text = (selectedIndex  == 0) 
                ? Convert.ToString(200 * lcCost.NoOfDays)
                : (selectedIndex == 1)
                ? Convert.ToString(100 * lcCost.NoOfDays)
                : "";
        }
    }
}
