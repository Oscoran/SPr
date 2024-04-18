using ConsoleApp2;
// vytvorit instanci tridy kalkulacka
Calculator calculator = new Calculator();

int a = 4;
int b = 1;
int c = 3;
Console.WriteLine("the roots are:");
foreach (double item in calculator.ResKvardRci(a,b,c))
{
	
    
    
        Console.WriteLine(item);
    
    
}
Console.ReadKey();