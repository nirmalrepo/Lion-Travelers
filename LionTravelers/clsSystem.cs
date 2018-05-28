using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionTravelers
{
    class clsSystem
    {
        private static Dictionary<string, clsTour> _TourList = new Dictionary<string, clsTour>();

        public static Dictionary<string, clsTour> TourList
        {
            get
            {
                return _TourList;
            }
        }

    }
}
