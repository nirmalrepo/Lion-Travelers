using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionTravelers
{
    class ClsStaffCost: ClsCost
    {
        private string _StaffType;
        private static FrmStaffCost _Form = new FrmStaffCost();

        public string StaffType { get => _StaffType; set => _StaffType = value; }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this) == DialogResult.OK;
        }

        public override string typeOfStudent()
        {
            return "Staff";
        }
    }
}
