using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionTravelers
{
    public abstract class ClsCost
    {
        private const string DISTANCE = "distance";
        private const string NO_OF_DAYS = "noOfDays";
        private string _ID;
        private string _Name;
        private decimal _Cost;
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public decimal Cost { get => _Cost; set => _Cost = value; }

        public static ClsCost NewCost(int prChoice, Dictionary<string, string> TourDetails )

        {

            if (prChoice == 0) {
                ClsVehicleCost cost = new ClsVehicleCost();
                cost.Distance = Convert.ToDecimal(TourDetails[DISTANCE]);
                return cost;

                
            }else if (prChoice == 1)
            {
                ClsStaffCost cost = new ClsStaffCost();
                cost.NoOfDays = Convert.ToDecimal(TourDetails[NO_OF_DAYS]);
                return cost;
            }
            else
            {
                return new ClsOtherCost();
            }
                

        }

        public abstract bool ViewEdit();

        public abstract string typeOfCost();
    }
}
