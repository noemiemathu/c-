
Console.WriteLine("Drink sizes: 1=small 2=medium 3=large");
Console.WriteLine("Please enter your selection:");
string userValue = Console.ReadLine();
switch (userValue)
{
    case "1" or "small":
        Console.WriteLine("Please insert 25 cents.");
        Console.WriteLine("Thank you. Please come again.");
        Console.ReadLine();
        break;
    case "2" or "medium":
        Console.WriteLine("Please insert 50 cents.");
        Console.WriteLine("Thank you. Please come again.");
        Console.ReadLine();
        break;
    case "3" or "large":
        Console.WriteLine("Please insert 75 cents.");
        Console.WriteLine("Thank you. Please come again.");
        Console.ReadLine();
        break;
    default:
        Console.WriteLine("Invalid selection. Please enter 1, small, 2, medium, 3 or large.");
        Console.ReadLine();
        break;
}
