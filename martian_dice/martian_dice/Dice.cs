using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martian_dice
{
    internal class Dice
    {
        public int[] hod(int dicecount)
        {
            int[] result = new int[5];
            Random rnd = new Random();
            int onedice = 0;
            for (int i = 0; i < dicecount; i++)
            {
                onedice =rnd.Next(6);
                switch (onedice)
                {
                    case 0:
                        result[onedice]++;
                        break;
                    case 1:
                        result[onedice]++;
                        break;
                    case 2:
                        result[onedice]++;
                        break;
                    case 3:
                        result[onedice]++;
                        break;
                    default:
                        result[4]++;
                        break;
                }
            
            }
            return result;
        }
    }
}
