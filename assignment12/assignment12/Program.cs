
string[] listofnames = new string[5];
Console.WriteLine($"Enter {listofnames.Length} names.");
for (int i = 0; i < listofnames.Length; i++)
{
    Console.WriteLine($"Enter name {i + 1}");
    listofnames[i] = Console.ReadLine();
}

foreach (string name in listofnames)
{
    Console.WriteLine(name);
}
