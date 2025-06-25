
string word = "lucky";
Console.WriteLine("What is my lucky word?");
string word2 = Console.ReadLine();
string word22 = word2.ToUpper();
if (word == word2)
{
    Console.WriteLine("You typed LUCKY and you are... Correct!");
}
else
{
    Console.WriteLine("You typed " + (word22) + " and you are... Wrong!");
}
