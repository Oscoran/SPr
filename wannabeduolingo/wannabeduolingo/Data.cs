using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wannabeduolingo
{
    internal class Data
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        Random rnd = new Random();
        List<string> elements;
        List<string> lkey;
        public Data()
        {
            using StreamReader sr = new StreamReader(@"pojmy.txt");
            string pivo;
            string[] splitstream = new string[2];
            while ((pivo = sr.ReadLine()) != null)
            {
                splitstream = pivo.Split("*");
                dictionary.Add(splitstream[0], splitstream[1]);
            }
            update();
        }
       

        public void addthing(string key, string date)
        {
            using StreamWriter sw = new StreamWriter(@"pojmy.txt", true);
            {
                sw.WriteLine($"{key}*{date}");
                dictionary.Add(key, date);
                update();
            }
        }
        public void update()
        {
            elements = new(dictionary.Values);
            lkey = new(dictionary.Keys);
        }
        public string giveKey()
        {
            List<string> lkey = new(dictionary.Keys);
            return lkey[rnd.Next(dictionary.Count)];
        }
        public string giveValue(string key)
        {
            
            return dictionary[key];
        }
    }
}
