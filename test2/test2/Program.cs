using System.Text.RegularExpressions;

StreamReader sr = new StreamReader("zadani.txt");
string input = sr.ReadLine();
string nej = input;
int pocet = input.Length;
int delka = 0;
int cholik = 0;
List <string> pole = new List<string>();
while (input != null)
{
	delka++;
	if (pocet < input.Length)
	{
		nej = input;
		pocet = input.Length;

	}
	if (input.Contains("ch"))
	{
		cholik++;
	}
	if (input.Contains('z'))
	{
		input = input.Replace('z', 'ř') ;
	}
    pole.Add(input);
    input = sr.ReadLine();
}
foreach (string p in pole) { Console.WriteLine(	p); }
Console.WriteLine(delka);
Console.WriteLine(nej	);
Console.WriteLine(cholik);