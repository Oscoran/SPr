using mapa;
// uvítání do hry
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Páteční expedice po Mělníku");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Je pátek a ty se svýma soudruhama, jste se vydali na expedici po mělníku. Vašim cílem je prozkoumat všechny kouty a tajemství, které se zde nealézají. Začínáte v cihelně a vašim cílem je získat všechny skryté předměty.");
Console.WriteLine("Jaké je tvoje jméno dobrodruhu? Jmeno: ");
string name = Console.ReadLine();
Player player = new Player(name);
Console.WriteLine(player);

lokalizace cihelna = new lokalizace("Cihelna", "zde pracuje Rosťa"); 
lokalizace bill = new lokalizace("Bill", "Tady je největší šance, že tě zmlátí");
lokalizace era = new lokalizace("Era", "Tady je prej dobrý disco");
lokalizace mlazickyles = new lokalizace("Mlazický les", "Jen pro odvážné, nebo pro ty co už nebaví žít");
lokalizace kebab = new lokalizace("Kebab","Odpočívací místo, když už toho máš dost");

// vytvoření světa
cihelna.nastavLokaci("vychod", bill);
cihelna.nastavLokaci("jih",era);
bill.nastavLokaci("zapad", cihelna);
bill.nastavLokaci("jih", mlazickyles);
era.nastavLokaci("sever", cihelna);
era.nastavLokaci("vychod", mlazickyles);
era.nastavLokaci("jih", kebab);
kebab.nastavLokaci("sever", era);
mlazickyles.nastavLokaci("zapad", era);
mlazickyles.nastavLokaci("sever",bill);


Enemy mlazickymuz = new Enemy("Mlazický muž zfetovaný", 20, 8);
mlazickyles.setenemy(mlazickymuz);
//pr;chod svetem
lokalizace aktivnilokace = cihelna;//start
string smer;
while (true)
{
    Console.WriteLine(aktivnilokace);
    Console.WriteLine("Kam chcete pokračovat?");
    smer = Console.ReadLine();
    aktivnilokace = aktivnilokace.provedpresun(smer, aktivnilokace);
    
}
