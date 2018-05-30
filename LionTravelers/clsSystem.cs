using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionTravelers
{
    class ClsSystem
    {
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();

        public static Dictionary<string, ClsTour> TourList
        {
            get
            {
                return _TourList;
            }
        }

    }
}
