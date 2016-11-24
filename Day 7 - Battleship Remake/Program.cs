using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7___Battleship_Remake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[8, 8];
            int newgrid = 0;

            //Making the grid
            Random rnd = new Random();

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {

                    grid[j, i] = 0;
                }
            }

            grid[0, 3] = 1;
            grid[2, 1] = 1;
            grid[4, 7] = 1;
            grid[3, 2] = 1;

            bool looping = true;
            while (looping)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        //Console.Write(grid[j, i]);
                        if (grid[i, j] == 1)
                        {
                            Console.Write("O");
                        }
                        else if (grid[i, j] == 0)
                        {
                            Console.Write("O");
                        }
                        else if (grid[i, j] == 2)
                        {
                            Console.Write("X");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Hey, enter your x input");
                string answer1 = Console.ReadLine();
                int Xinput = Convert.ToInt16(answer1);

                Console.WriteLine("Hey, enter your y input");
                string answer2 = Console.ReadLine();
                int Yinput = Convert.ToInt16(answer2);

                if (Xinput == 1 && Yinput == 1)
                {
                    Console.WriteLine("You hit a ship!");
                    grid[Yinput, Xinput] = 2;
                }
                
                else
                {
                    Console.WriteLine("You missed!");
                }

                //check if there are any more 1s left
                looping = false;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if(grid[i,j] == 1)
                        {
                            looping = true;
                        }
                    }
                }
            }

            Console.ReadLine();
        } //end of pre-written code
    }
}
