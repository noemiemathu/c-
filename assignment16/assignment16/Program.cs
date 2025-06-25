double[] numbers = new double[1];

for(int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Please enter a number.");

    bool isnumber = double.TryParse(Console.ReadLine(), out double getal);
    while (!isnumber)
    {
        Console.WriteLine("Invalid. Please enter a number.");
        isnumber = double.TryParse(Console.ReadLine(), out getal);
    }
    numbers[i] = getal;

    Console.WriteLine("Please enter another number.");

    bool isnumber2 = double.TryParse(Console.ReadLine(), out double getal2);
    while (!isnumber2)
    {
        Console.WriteLine("Invalid. Please enter a number.");
        isnumber = double.TryParse(Console.ReadLine(), out getal);
    }
    numbers[i] = getal2;

    

    Console.WriteLine("What do you want to do with the numbers?");
    Console.WriteLine("1. Addition & Subtraction");
    Console.WriteLine("2. Addition & Multiplication");
    Console.WriteLine("3. Addition & Division");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.KeyChar == '1' || key.KeyChar == '2' || key.KeyChar == '3')
        {
            if (key.KeyChar == '1')
            {
                Console.WriteLine("\nAddition:    " + getal + " + " + getal2 + " = " + addition(getal, getal2));
                Console.WriteLine("\nSubtraction: " + getal + " - " + getal2 + " = " + subtraction(getal, getal2));
            }
            if (key.KeyChar == '2')
            {
                Console.WriteLine("\nAddition:    " + getal + " + " + getal2 + " = " + addition(getal, getal2));
                Console.WriteLine("\nMultiplication: " + getal + " * " + getal2 + " = " + muliplication(getal, getal2));
            }
            if (key.KeyChar == '3')
            {
                Console.WriteLine("\nAddition:    " + getal + " + " + getal2 + " = " + addition(getal, getal2));
                Console.WriteLine("\nDivision: " + getal + " / " + getal2 + " = " + division(getal, getal2));
            }
        }
        else
        {
            Console.WriteLine("Invalid Selection. Please enter 1, 2 or 3");
        }
    }
}

double addition(double add1, double add2)
{
    double result = add1 + add2;
    return result;
}
double subtraction(double add1, double add2)
{
    double result = add1 - add2;
    return result;
}
double muliplication(double add1, double add2)
{
    double result = add1 * add2;
    return result;
}
double division(double add1, double add2)
{
    double result = add1 / add2;
    return result;
}

