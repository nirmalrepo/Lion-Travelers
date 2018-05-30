using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LionTravelers
{
    class ClsVehicleCost:ClsCost
    {
        private decimal _KmCharge;
        private decimal _Distance;
        private static FrmVehicleCost _Form = new FrmVehicleCost();

        public decimal KmCharge { get => _KmCharge; set => _KmCharge = value; }
        public decimal Distance { get => _Distance; set => _Distance = value; }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this) == DialogResult.OK;

        }

        public override string typeOfStudent()
        {
            return "Vehicle";
        }
    }
}
