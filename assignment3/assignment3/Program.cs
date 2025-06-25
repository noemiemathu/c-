// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

int x = 6;
string y = "2";

string result1 = x.ToString() + y;
int result2 = x + int.Parse(y);

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.ReadLine();
