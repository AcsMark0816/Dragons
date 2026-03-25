using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jk
{
    public class Place
    {
        public string country { get; set; }
        public string ccity { get; set; }
        public int capacity { get; set; }
        public string Name { get; set; }

        public double foodstorage { get; set; }
        public int money { get; set; }
        public int locationif { get; set; }
        private List<Sarkanyok> Sarkanyok { get; set;}


        public override string ToString()
        {
            string temp = $"{country},{ccity},{capacity},{Name},{foodstorage},{money},{locationif},";
            string temp2 = String.Join(';', Sarkanyok);
            temp += temp2;
            return temp;
        }
        public Place(string[] data)
        {
            country = data[0];
            ccity = data[1];
            capacity = int.Parse(data[2]);
            Name = data[3];
            foodstorage = double.Parse(data[4].Replace('.',','));
            money = int.Parse(data[5]);
            locationif = int.Parse(data[6]);
            Sarkanyok = new List<Sarkanyok>();
        }
        public Place(string country,string ccity,int capacity,string Name,double foodstorage,int money,int locationif)
        {
            this.country = country;
            this.ccity = ccity;
            this.capacity = capacity;
            this.Name = Name;
            this.foodstorage = foodstorage;
            this.money = money;
            this.locationif = locationif;
            Sarkanyok = new  List<Sarkanyok>();
          
        }

        public void AddDragon(Sarkanyok Dragon)
        {
            Sarkanyok.Add(Dragon);
        }
        public void WriteDragon()
        {
            Console.WriteLine(String.Join('\n',Sarkanyok));
        }
    }
}
