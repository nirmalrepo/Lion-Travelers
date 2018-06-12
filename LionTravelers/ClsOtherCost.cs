using System;
using System.Windows.Forms;

namespace LionTravelers
{
    [Serializable]
    class ClsOtherCost:ClsCost
    {
        private string _OtherFees;
       
        private static FrmOtherCost _Form = new FrmOtherCost();

        public string OtherFees { get => _OtherFees; set => _OtherFees = value; }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this) == DialogResult.OK;
        }

        public override string typeOfCost()
        {
            return "Other";
        }
    }
}
