using System;
using System.Windows.Forms;

namespace LionTravelers
{
    [Serializable]
    class ClsStaffCost: ClsCost
    {
        private string _StaffType= Constants.STAFF_TYPE_DRIVER;
        private decimal _NoOfDays;
       
        private static FrmStaffCost _Form = new FrmStaffCost();

        public string StaffType { get => _StaffType; set => _StaffType = value; }
        public decimal NoOfDays { get => _NoOfDays; set => _NoOfDays = value; }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this) == DialogResult.OK;
        }

        public override string typeOfCost()
        {
            return "Staff";
        }
    }
}
