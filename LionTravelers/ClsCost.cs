using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionTravelers
{
    public abstract class ClsCost
    {

        private string _ID;
        private string _Name;
        private string _Cost;
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Cost { get => _Cost; set => _Cost = value; }

        public static ClsCost NewCost(int prChoice)

        {

            if (prChoice == 0)
                return new ClsVehicleCost();
            else if (prChoice == 1)
                return new ClsStaffCost();
            else
                return new ClsOtherCost();

        }

        public abstract bool ViewEdit();

        public abstract string typeOfStudent();
    }
}
