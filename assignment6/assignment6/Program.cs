
        Console.WriteLine("Please Enter your Year of Birth:");
        var today = DateTime.Today;
        var birthday =  Console.ReadLine();
        var age = today.Year - int.Parse(birthday);
        Console.WriteLine("Your age is " + age + ".");
