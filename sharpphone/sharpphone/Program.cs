using System.Numerics;
using System.Runtime.CompilerServices;
using Sharpphone;
class Program
{
    private const string gebruikersnaam = "admin";
    const string Wachtwoord = "PHONESHARP";
    public static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            if (args[0] == gebruikersnaam && args[1] == Wachtwoord)
            {
                overzicht();
                voorraad();
                Statistieken();
            }
            else
            {
                Inloggen();
            }
        }
        else
        {
            Inloggen();
        }
    }
    public static void Inloggen()
    {
        Console.WriteLine("Geef uw naam op:");
        string naam = Console.ReadLine();
        Console.WriteLine("Welkom bij SharpPhone " + naam + ".");

        switch (LogIn())
        {
            case Inlog.OK:
                Console.WriteLine("Welkom bij SharpPhone " + naam + ".");
                ShowMenu();
                break;
            case Inlog.NietOK:
                break;
        }
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Voer het wachtwoord in: ");
            if (i == 1)
            {
                Console.WriteLine("LET OP: laatste poging!");
            }
            string WW = Console.ReadLine();

            if (WW == Wachtwoord)
            {
                Console.WriteLine("Wachtwoord is juist.");
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Password is onjuist.");
            }
        }
    }
    public static Inlog LogIn()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Voer het wachtwoord in: ");
            if (i == 2)
            {
                Console.WriteLine("LET OP: laatste poging!");
            }
            string WW = Console.ReadLine();

            if (WW == Wachtwoord)
            {
                return Inlog.OK;
            }
            else
            {
                Console.WriteLine("Password is onjuist.");
                return Inlog.NietOK;
            }
        }
        return Inlog.Onbekend;
    }
    public static void ShowMenu()
    {
        Menu();
        Phone.Init();
        while (true)
        {
            ConsoleKeyInfo Key = Console.ReadKey();
            switch (Key.KeyChar)
            {
                case '1':
                    overzicht();
                    break;
                case '2':
                    voorraad();
                    break;
                case '3':
                    Mutatie();
                    break;
                case '4':
                    Statistieken();
                    break;
                case '5':
                    Toevoegen();
                    break;
                case '8':
                    Menu();
                    break;
                case '9':
                    return;
            }
        }
    }
    public static void Menu()
    {
        Console.WriteLine("Kies een optie");
        Console.WriteLine("1. Overzicht telefoons");
        Console.WriteLine("2. Overzicht voorraad");
        Console.WriteLine("3. Muteer voorraad");
        Console.WriteLine("4. Statistieken");
        Console.WriteLine("5. Toevoegen smartphone");
        Console.WriteLine("8. Toon menu");
        Console.WriteLine("9. Exit");
    }
    public static void overzicht()
    {
        foreach (Phone p in Phone.Phones)
        {
            Console.WriteLine($"ID: {p.Id} \n Merk: {p.Make} \n Model: {p.Model} \n MBSize: {p.Mbsize} \n Prize: {p.Price}");
        }
    }
    public static void voorraad()
    {
        foreach (Phone p in Phone.Phones)
        {
            Console.WriteLine($"ID: {p.Id} Voorraad: {p.Voorraad}");
        }
    }
    public static void Mutatie()
    {
        // bool id = int.TryParse(Console.ReadLine(), out int result);

        // ophalen id van gebruiker
        bool intParse = false;
        int intId = 0;
        string input = "";
        bool isId = false;
        string antwoord = "";
        int intvooraad = 0;
        bool isvoorraad = false;
        string ant = "";
        int mutatie;

        Console.WriteLine("Vul het ID van het type smartphone in:");

        input = Console.ReadLine();

        intParse = int.TryParse(input, out intId);

        if (!intParse)
        {
            Console.WriteLine("Voer een nummer in");
            Mutatie();
        }

        // controleren id
        foreach (Phone p in Phone.Phones)
        {
            if (p.Id == intId)
            {
                Console.WriteLine("Gevonden!");
                isId = true;
                break;
            }
        }

        if (!isId)
        {
            Console.WriteLine("Id niet gevonden");
            Mutatie();
        }

        Console.WriteLine("Voer de mutatie in (positief of negatief aantal):");
        if (!int.TryParse(Console.ReadLine(), out mutatie))
        {
            Console.WriteLine("Ongeldige invoer. Voer een gatal in");
            Mutatie();
        }
        foreach (Phone p in Phone.Phones)
        {
            p.Voorraad += mutatie;
            if (p.Voorraad < 0)
            {
                Console.WriteLine("Mutatie niet uitgevoerd. De voorraad mag niet negatief zijn.");
            }
        }
        Console.WriteLine("Mutaie is uitgevoerd!");
        ShowMenu();
    }
    public static void Statistieken()
    {
        int totalevoorraad = 0;
        double totalewaarde = 0;
        double gemiddeldeprijs = 0;
        double gemiddelde;
        Console.WriteLine("Kies optie:");
        Console.WriteLine("1. Het totale aantal telefoons dat in voorraad is.");
        Console.WriteLine("2. De totale waarde van de voorraad smartphones.");
        Console.WriteLine("3. De gemiddelde prijs van een telefoon bij SharpPhone");
        Console.WriteLine("4. De smartphone met de beste prijs per mB.");
        switch (Console.ReadLine())
        {
            case "1":
                foreach (Phone p in Phone.Phones)
                {
                    totalevoorraad += p.Voorraad;
                    Console.WriteLine(totalevoorraad);
                }
                break;
            case "2":
                foreach (Phone p in Phone.Phones)
                {
                    totalewaarde += p.Price;
                    Console.WriteLine(totalewaarde);
                }
                break;
            case "3":
                foreach (Phone p in Phone.Phones)
                {
                    gemiddeldeprijs += p.Price / p.Id;
                    Console.WriteLine(gemiddeldeprijs);
                }
                break;
            case "4":
                foreach (Phone p in Phone.Phones)
                {
                    gemiddelde = p.Price / p.Voorraad;
                    Console.WriteLine(gemiddelde);
                }
                break;
        }
        ShowMenu();
    }
    public static void Toevoegen()
    {
        Console.WriteLine("Voeg een nieuwe smartphone toe:");

        Console.Write("Merk: ");
        string merk = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        Console.Write("Opslagcapaciteit (in MB): ");
        int opslagcapaciteit = int.Parse(Console.ReadLine());

        Console.Write("Prijs: ");
        double prijs = double.Parse(Console.ReadLine());
        Phone nieuweTelefoon = new Phone(id: Phone.Phones.Count + 1, merk, model, opslagcapaciteit, prijs, 0);
        Phone.Phones.Add(nieuweTelefoon);

        Console.WriteLine("De nieuwe smartphone is toegevoegd.");
    }
}
enum Inlog
{
    OK,
    NietOK,
    Onbekend
}

