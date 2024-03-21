using System;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("jmena.txt");

            string[] lidi = new string[17];
            int[] cisla = new int[17];
            for (int i = 0; i < 17; i++)
            {
                string pocet = sr.ReadLine();
                string[] substrings = pocet.Split(' ');

                lidi[i] = substrings[0];
                cisla[i] = Int32.Parse(substrings[1]);

            }
            int pivo = 0;
            string malinovka = "";
            for (int i = 0; i < 16; i++)
            {
                for (int a = 0; a < 17 - i - 1; a++)
                {
                    if ((cisla[a + 1]) < (cisla[a]))
                    {
                        pivo = cisla[a + 1];
                        cisla[a + 1] = cisla[a];
                        cisla[a] = pivo;

                        malinovka = lidi[a + 1];
                        lidi[a + 1] = lidi[a];
                        lidi[a] = malinovka;

                    }
                }

            }
            foreach (string item in lidi)
            {
                Console.WriteLine(item);
            }





        }
    }
}
