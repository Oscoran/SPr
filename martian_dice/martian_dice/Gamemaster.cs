using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martian_dice
{
    internal class Gamemaster
    {
        Random rnd = new Random();
        private Dictionary<int, string> map = new Dictionary<int, string>();
        private int dicecount = 13;
        List<string> namelist = new List<string>();
        List<int> pointlist = new List<int>();
        private int activeplayer;
        int firstplayer = 0;

        public void gamestart()
        {
            //Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.WriteLine("welcome in Martian dice");
            // Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
            Console.WriteLine("how many of you are playing? ");
            int input = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                //Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

                Console.Write($"Insert name {i + 1}. player: ");
                string name = Console.ReadLine();
                namelist.Add(name);
                pointlist.Add(0);
            }


            activeplayer = rnd.Next(namelist.Count-1);
            firstplayer = activeplayer;
            map.Add(0, "tank");
            map.Add(1, "hen");
            map.Add(2, "cow");
            map.Add(3, "human");
            map.Add(4, "ufo");
        }
        public void turnofplayer()
        {
            int points = 0;
            int[,] game = new int[5, namelist.Count];
            Console.WriteLine($"players {namelist[activeplayer]} turn");
            while (dicecount != 0) 
            {
                Console.WriteLine($"dices left {dicecount}");
                Dice dice = new Dice();
                int[] result = new int[5];
                //0=tank, 1=slepice, 2=kr8va, 3= clovek, 4 ufo
                result = dice.hod(dicecount);
                
                for (int i = 0; i < 5; i++)
                {
                    //Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                    Console.WriteLine($"({i}){map[i]}: {result[i]}");
                }
                game[0, activeplayer] += result[0];
                dicecount -= result[0];
                Console.WriteLine("chose");
                int input = Convert.ToInt32(Console.ReadLine());
                bool done = true;
                while (done)
                {
                    
                    if (input <= 5 && input >= 1)
                    {
                        switch (input)
                        {
                            case 1:
                                if (game[1, activeplayer] == 0 && result[1] != 0)
                                {
                                    game[1, activeplayer] += result[1];
                                    dicecount -= result[1];
                                    done = false;
                                }
                                else
                                {
                                    Console.WriteLine("ne");
                                }
                                break;
                            case 2:
                                if (game[2, activeplayer] == 0 && result[2] != 0)
                                {
                                    game[2, activeplayer] += result[2];
                                    dicecount -= result[2];
                                    done = false;
                                }
                                else
                                {
                                    Console.WriteLine("ne");
                                    input = Convert.ToInt32(Console.ReadLine());
                                }
                                break;
                            case 3:
                                if (game[3, activeplayer] == 0 && result[3] != 0)
                                {
                                    game[3, activeplayer] += result[3];
                                    dicecount -= result[3];
                                    done = false;
                                }
                                else
                                {
                                    Console.WriteLine("ne");
                                    input = Convert.ToInt32(Console.ReadLine());
                                }
                                break;
                            case 4:
                                if (result[4] != 0)
                                {
                                    game[4, activeplayer] += result[4];
                                    dicecount -= result[4];
                                    done = false;
                                }
                                else
                                {
                                    Console.WriteLine("ne");
                                    input = Convert.ToInt32(Console.ReadLine());
                                }

                                break;
                            case 5:
                                done= false;
                                dicecount = 0;
                                break;
                            default:
                                done = false;
                                break;

                        }
                       
                        
                    }
                    if (input > 6)
                    {
                        Console.WriteLine("ne");
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input<=5)
                        {
                            done = false;
                        }
                    }

                }
                Console.WriteLine("you have:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{map[i]} {game[i,activeplayer]}");
                }
                done = true;
                Console.WriteLine();
                if (dicecount!=0)
                {
                    while (done)
                    {
                        Console.WriteLine("do you wish to end turn y/n");
                        string input2 = Console.ReadLine();
                        if (input2 == "y")
                        {
                            done = false;
                            dicecount = 0;
                        }
                        if (input2 == "n")
                        {
                            done = false;
                        }
                        else
                        {
                            Console.WriteLine("dont understand");
                        }
                    }
                }
                
              
                Console.WriteLine("----------------------------------------------------------------");

            }
            Console.WriteLine();
            if (game[4, activeplayer] - game[0, activeplayer] >= 0)
            {
                points += game[1, activeplayer] + game[2, activeplayer] + game[3, activeplayer];
                if ((game[2, activeplayer] > 0) && (game[3, activeplayer]) > 0 && (game[1, activeplayer] > 0))
                {
                    points += 3;
                }
            }
            else
            {
                Console.WriteLine("no points");
                points = 0;
            }
            Console.WriteLine(points);
            pointlist[activeplayer] += points;
            Console.WriteLine($"player {namelist[activeplayer]} has {pointlist[activeplayer]} points ");
            if (activeplayer+1< namelist.Count)
            {
                activeplayer++;
            }
            else
            {
                activeplayer = 0;
            }
            dicecount = 13;

        }
        
           
        
        public bool Gameover()
        {
            foreach (int item in pointlist)
            {
                if (item >= 25)
                {
                    Console.WriteLine($"player {namelist[activeplayer-1]} has{pointlist[activeplayer]-1} and is close to winning");
                    return false;
                }
            }
            return true;
        }
        public int Gamefinisher()
        {
            return namelist.Count-firstplayer;
        }
        public string Winner()
        {
            int max = 0;
            for (int i = 1; i <pointlist.Count; i++)
            {
                if (pointlist[i - 1] < pointlist[i])
                {
                    max = i;
                }
            }
            return $"the winner is {namelist[max]} with {pointlist[max]}";
        }
    }
}
