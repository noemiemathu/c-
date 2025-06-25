using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpphone
{
    public class Phone
    {
        public int Id;
        public string Make;
        public string Model;
        public int Mbsize;
        public double Price;
        public static List<Phone> Phones = new List<Phone>();

        public int Voorraad;

        public static int Count { get; internal set; }

        public Phone(int id, string make, string model, int mbsize, double price, int voorraad)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Mbsize = mbsize;
            this.Price = price;
            this.Voorraad = voorraad;
        }

        public static void Init()
        {
            Phone p1 = new Phone(1, "Simsang", "HF 410", 16000, 129.95, 500);
            Phone p2 = new Phone(2, "Pear", "XM 600", 32000, 224.95, 500);
            Phone p3 = new Phone(3, "Hoeowoei", "Z3", 8000, 79.95, 500);
            Phone p4 = new Phone(4, "OneMillion+", "3001", 16000, 124.95, 500);
            Phone p5 = new Phone(5, "UnfairPhone", "NXT12", 32000, 159.05, 500);
            Phones.Add(p1);
            Phones.Add(p2);
            Phones.Add(p3);
            Phones.Add(p4);
            Phones.Add(p5);
        }

    }
}
