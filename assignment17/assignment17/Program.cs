using System.Security.Cryptography;

Console.WriteLine("Please enter the length of the array.");
try
{
    int number = int.Parse(Console.ReadLine());
    string[] names = new string[5] { "Merry", "John", "Tim", "Matt", "Jeff" };
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine(names[i]);
    }
}
catch (System.IndexOutOfRangeException e)
{
    Console.WriteLine("Out of range Error. Error Massage: {0}", e.Message);
}
catch (System.FormatException e)
{
    Console.WriteLine("Format Error. Please enter a number. Error Massage: {0}", e.Message);
}



