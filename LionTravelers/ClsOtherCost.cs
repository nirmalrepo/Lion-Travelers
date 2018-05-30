using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionTravelers
{
    class ClsOtherCost:ClsCost
    {
        private decimal _OtherFees;
        private static FrmOtherCost _Form = new FrmOtherCost();

        public decimal OtherFees { get => _OtherFees; set => _OtherFees = value; }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this) == DialogResult.OK;
        }

        public override string typeOfStudent()
        {
            return "Other";
        }
    }
}
