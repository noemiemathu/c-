Console.WriteLine("*** MENU ***");
Console.WriteLine(" ");
Console.WriteLine("1. Display Menu 1");
Console.WriteLine("2. Display Menu 2");
Console.WriteLine("3. Exit");
Console.WriteLine("");
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.KeyChar == '1'|| key.KeyChar == '2' || key.KeyChar == '3') {
        if (key.KeyChar == '1')
        {
            Console.WriteLine("Menu 1");
        }
        if (key.KeyChar == '2')
        {
            Console.WriteLine("Menu 2");
        }
        if (key.KeyChar == '3')
        {
            Console.WriteLine("Exit");
        }
    } else
    {
        Console.WriteLine("Invalid Selection. Please enter 1, 2 or 3");
    }
}

