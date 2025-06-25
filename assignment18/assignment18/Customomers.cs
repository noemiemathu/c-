using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment18
{
    class Customers
    {
        //fields
        private int id;
        private string name;
        public int telephone;
        //getters & setters
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        //Constructor
      
        public Customers(int id, string name, int telephone)
        {
            this.id = id;
            this.name = name;
            this.telephone = telephone;
        }
    }
}


