using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martiandice
{
    internal class Dice
    {
        Random rnd = new Random();
        public int[] roll (int dicecount)
        {
            int[] rollar = new int[5]{0,0,0,0,0};
            int roll;
            for (int i = 0; i < dicecount; i++)
            {
                roll = rnd.Next(6);
                
                if(roll==5) roll= 4;
                rollar[roll]++; 
            }
            return rollar;
        }
    }
}
