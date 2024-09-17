using wannabeduolingo;

Data data = new Data();
Console.WriteLine("zkouseni z dat");
Console.WriteLine("vyber:");
Console.WriteLine("1: pridej pojem");
Console.WriteLine("2: zkouseni");
int volba = int.Parse(Console.ReadLine());
switch (volba)
{
    case 1: //pridani pojmu
        string key = "";
        string value;
        Console.WriteLine("zadavej pojmy,pro ukonceni napis 1");

        while (key != "1")
        {
            Console.WriteLine("udalost:");
            key = Console.ReadLine();
            if (key != "1")
            {
                Console.WriteLine("Datum: ");
                value = Console.ReadLine() ;
                data.addthing(key, value);
            }
            
        }
    break;
}