


    Console.WriteLine("What is my lucky number?");
    ConsoleKeyInfo keyName = new ConsoleKeyInfo();
    keyName = Console.ReadKey();

    //Console.WriteLine(keyName.KeyChar);
    if (Char.IsNumber(keyName.KeyChar))
{
    if (keyName.KeyChar == '5')
    {
        Console.WriteLine(" Correct! My lucky number is 5!");
    } else
    {
        Console.WriteLine(" is Incorrect");
    }
} else
{
    Console.WriteLine(" is incorrect. Please key in a number.");
}



