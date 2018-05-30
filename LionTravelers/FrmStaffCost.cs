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
            comboBoxStaffType.SelectedValue = lcCost.StaffType;

        }
    }
}
