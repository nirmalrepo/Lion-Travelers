using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionTravelers
{
    public class clsTour
    {
        private string _Code;
        private string _Name;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        private int _NoOfPassengers;
        private int _Distance;
        private int _Markup;
        private decimal _PricePerPassenger;
        private FrmTour _Form = new FrmTour();

        public string Code { get => _Code; set => _Code = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }
        public int NoOfPassengers { get => _NoOfPassengers; set =>_NoOfPassengers = value; }
        public int Distance { get => _Distance; set => _Distance = value; }
        public int Markup { get => _Markup; set => _Markup = value; }
        public decimal PricePerPassenger { get => _PricePerPassenger; set => _PricePerPassenger = value; }

        public static clsTour newTour()
        {
            return new clsTour();
        }

        public bool viewEdit()
        {
            return _Form.ShowDialog(this);
        }
    }
}
