using assignment18;
using System.Collections.Generic;
class Program
{


    static void Main(string[] args)
    {
        List<Customers> listofcustomers = new List<Customers>();

        listofcustomers.Add(new Customers(1, "Merry", 0612344444));
        listofcustomers.Add(new Customers(2, "John", 0612345678));
        listofcustomers.Add(new Customers(3, "Tim", 0612345677));
        listofcustomers.Add(new Customers(4, "Matt", 0612345666));
        listofcustomers.Add(new Customers(5, "Jeff", 0612345555));

        //foreach
        foreach (Customers customer in listofcustomers)
        {
            Console.WriteLine("ID:" + customer.Id + " Name:" + customer.Name + " Telephone:" + customer.telephone);
        }
        
    }
}
