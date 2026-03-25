using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jk
{
    public class FileManager
    {
        private static List<Sarkanyok> DragonReader(string filename)
        {
            List<Sarkanyok> dragons = new List<Sarkanyok>();
            try
            {
                foreach (var i in File.ReadAllLines(filename, Encoding.UTF8).Skip(1))
                {
                    string[] temp = i.Split(';');
                    if (temp.Length == 9)
                    {
                        dragons.Add(new Sarkanyok(temp));
                    }
                }
                return dragons;
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return null;
            }
        }
        public static List<Place> ReadPlace(string fileName)
        {
            try
            {
                List<Place> places = new();
                foreach(string i in File.ReadLines(fileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = i.Split(';');
                    if(temp.Length == 7)
                    {
                        places.Add(new Place(temp));
                    }
                }
                List<Sarkanyok> dragonok = DragonReader("dragons.csv");
                foreach(Sarkanyok i in dragonok)
                {
                    foreach(Place LocationIDhelper in places)
                    {
                        LocationIDhelper.AddDragon(i);
                        if(i.locationid == LocationIDhelper.locationif)
                        {
                            LocationIDhelper.AddDragon(i);
                        }
                    }
                }
                return places;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
        }

    }
}
   
