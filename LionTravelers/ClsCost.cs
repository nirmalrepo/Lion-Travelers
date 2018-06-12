using System;
using System.Collections.Generic;

namespace LionTravelers
{
    [Serializable]
    public abstract class ClsCost
    {
        private string _ID;
        private string _Name;
        private decimal _Cost;
        private Dictionary<string, ClsCost> _TourCostList = new Dictionary<string, ClsCost>();
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public decimal Cost { get => _Cost; set => _Cost = value; }
        public Dictionary<string, ClsCost> TourCostList { get => _TourCostList; set => _TourCostList = value; }

        public static ClsCost NewCost(int prChoice, Dictionary<string, dynamic> TourDetails )

        {

            if (prChoice == 0) {
                ClsVehicleCost cost = new ClsVehicleCost();
                cost.Distance = Convert.ToDecimal(TourDetails[Constants.DISTANCE]);
                cost.TourCostList = TourDetails[Constants.COST_LIST];
                return cost;

                
            }else if (prChoice == 1)
            {
                ClsStaffCost cost = new ClsStaffCost();
                cost.NoOfDays = Convert.ToDecimal(TourDetails[Constants.NO_OF_DAYS]);
                cost.TourCostList = TourDetails[Constants.COST_LIST];
                return cost;
            }
            else
            {
                ClsOtherCost cost = new ClsOtherCost();
                cost.TourCostList = TourDetails[Constants.COST_LIST];
                return cost;
            }
                

        }

        public abstract bool ViewEdit();

        public abstract string typeOfCost();
    }
}
