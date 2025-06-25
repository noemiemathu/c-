
int[] listnumbers = new int[5];
Console.WriteLine("Enter 5 numbers.");

for (int i = 0; i < listnumbers.Length; i++)
{
    Console.WriteLine($"number {i + 1}");

    bool isNumber = int.TryParse(Console.ReadLine(), out int getal);
    while (!isNumber)
    {
        Console.WriteLine("Please enter a number.");
        isNumber = int.TryParse(Console.ReadLine(), out getal);
    }

        listnumbers[i] = getal;
 
   
}
foreach(int i in listnumbers)
{
    Console.WriteLine(i);
}




