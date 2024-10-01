using wannabeduolingo;
while (true)
{
    Data data = new Data();
    Console.WriteLine("zkouseni z dat");
    Console.WriteLine("vyber:");
    Console.WriteLine("1: pridej pojem");
    Console.WriteLine("2: zkouseni");
    int volba = int.Parse(Console.ReadLine());
    bool bol = true;
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
                    value = Console.ReadLine();
                    data.addthing(key, value);
                }

            }
            break;
        case 2: //zkouseni
            while (bol== true)
            {
                Console.WriteLine("odpovidej datum nebo rok, nebo co chces co ja vim");
                Console.WriteLine("kolik chces otazek?");
                int lop = int.Parse(Console.ReadLine());
                string answer;
                int wrong = 0;
                int correct = 0;
                for (int i = 0; i < lop; i++)
                {
                    key = data.giveKey();
                    Console.WriteLine(key);

                    answer = Console.ReadLine();
                    if (answer == data.giveValue(key))
                    {
                        Console.WriteLine("ANO");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine("blby");
                        wrong++;
                    }

                }
                Console.WriteLine($"spravne: {correct}, spatne {wrong}");
                Console.WriteLine("by stacilo ne? (ANO/NE)");
                answer = Console.ReadLine();
                if (answer == "NE")
                {
                    bol = true ;
                }
                if (answer == "ANO")
                {
                    bol = false ;
                }
            }
            
            
            break;
    }
}