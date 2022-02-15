using Nesto;

do
{
    Meni.PrviMeni();

    string unos = Console.ReadLine();
    switch (unos)
    {
        case "1":
            Console.Clear();
            Meni.MeniPredavac();
            Console.ReadLine();
            break;

        case "2":
            Console.Clear();
            Meni.MeniPolaznik();
            Console.ReadLine();
            break;

        case "3":
            break;

        default:
            Console.WriteLine("Ovo ti nesto ne valja");
            break;
    }
    Console.Clear();

} while (true);
