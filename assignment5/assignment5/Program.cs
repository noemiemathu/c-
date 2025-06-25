
double width;
Console.WriteLine("please enter width");
width = double.Parse(Console.ReadLine());
double height;
Console.WriteLine("please enter height");
height = double.Parse(Console.ReadLine());
double resultaat = Math.Round(width * height,2);
Console.WriteLine(resultaat + " cm");
