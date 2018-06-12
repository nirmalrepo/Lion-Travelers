using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LionTravelers
{
    class ClsSystem
    {
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();
        private static string fileName = "LionTravelers.dat";
        public static Dictionary<string, ClsTour> TourList
        {
            get
            {
                return _TourList;
            }
        }
        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }


        public static void Retrieve()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)lcFormatter.Deserialize(lcFileStream);
            }

        }

    }
}
