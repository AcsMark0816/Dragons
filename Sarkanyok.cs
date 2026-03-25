using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace jk
{
    public class Sarkanyok
    {
        public string color { get; set; }

        public string name { get; set; } 
        public string species { get; set; } 
        public string element { get; set; } 
        public double wingspan { get; set; } 
        public int age { get; set; }
        public int headcount { get; set; } 
        public double dailyfood { get; set; }
        public int locationid { get; set; }
        

        public Sarkanyok(string[] data)
        {
            if(data.Length == 7)
            {
                color = data[0];
                name = data[1];
                species = data[2];
                element = data[3];
               wingspan = double.Parse(data[4].Replace('.',','));
                age = int.Parse(data[5]);
                headcount = int.Parse(data[6]);
               dailyfood = double.Parse(data[7].Replace('.',','));
                locationid = int.Parse(data[8]);
            }
        }
        public Sarkanyok(string color,string name,string species,string element,double wingspan,int age,int headcount,double dailyfood,int locationid)
        {
            this.color = color;
            this.name = name;
            this.species = species;
            this.element = element;
            this.wingspan = wingspan;
            this.age = age;
            this.headcount = headcount;
            this.dailyfood = dailyfood;
            this.locationid = locationid;
        }




        public override string ToString()
        {
            return $"{color},{name},{species},{element},{wingspan},{age},{headcount},{dailyfood}";
        }

        public double Feed(double food)
        {
            double maradek = 0;
            if(food > dailyfood)
            {
                maradek = food - dailyfood;
            }
            else if(food < dailyfood)
            {
                maradek = dailyfood - food;
            }
            return maradek;
        }

    }
}
