using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_16_Prog_120_F22
{
    internal class Program
    {
        // Standard Arry
        int[] numbers = new int[10];
        // 0 1
        // 2d Array, or a matrix
        static int[,] moreNumbers = new int[1000, 1000];
        static ConsoleColor[,] colors = new ConsoleColor[5, 5];
        static int[,,] coords = new int[100, 100, 100];


        // 0,0 0,1
        // 1,0 0,1
        // 1,0 0,1
        // 1,0 0,1
        // 1,0 0,1
        // 1,0 0,1
        // 1,0 0,1
        // 1,0 0,1

        static int[][] jaggedArrays = new int[10][];
        // 1 2 3 4 5 6 7
        // 7 5 3 1
        // 9 5 7 3 2 1 4 7 8 9  8 5 4 3 2
        // 9 4 2 6 
        // 0 8 3 2 7 9 0 7 5 4 3 2

        static void Main(string[] args)
        {
            Random rand = new Random();
            jaggedArrays[0] = new int[5];
            jaggedArrays[1] = new int[9];
            jaggedArrays[3] = new int[3];

            for (int i = 0; i < jaggedArrays.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArrays.GetLength(1); j++)
                {
                    Console.WriteLine(jaggedArrays[i][j] + " ");
                }
            }

            //// Rows
            //for (int i = 0; i < moreNumbers.GetLength(0); i++)
            //{
            //    // Columns
            //    for (int j = 0; j < moreNumbers.GetLength(1); j++)
            //    {
            //        //colors[i, j] = (ConsoleColor)rand.Next(15);

            //        //Console.ForegroundColor = colors[i, i=j];
            //        moreNumbers[i, j] = rand.Next(1,50);
            //        Console.Write($"{i},{j}: " + moreNumbers[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        } // Main

        static ConsoleColor[] consoleColors =
{
            ConsoleColor.Red,
            ConsoleColor.Magenta,
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
            ConsoleColor.White,
        };

        // 5 / 8
        public static void NestedLoops()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {              
                Console.WriteLine(rand.Next(1, 100));
            }
        }

        public static void ChangeConsoleColor()
        {
            Random rand = new Random();

            // Nested Loops
            for (int row = 0; row < 10; row++)
            {
                // Internal for loop
                for (int col = 0; col < 10; col++)
                {
                    //Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                    int chosenColor = rand.Next(consoleColors.Length);
                    Console.ForegroundColor = consoleColors[chosenColor];
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

        public static void ParseQuestion()
        {

            // Divide by 3 = Fizz
            // Divide by 5 = Buzz
            // Divide by 3 and 5 = Fizz Buzz
            // Prints

            //if (true)
            //{

            //}
            //else if(true)
            //{

            //}
            //else
            //{

            //}

          

            

        }

        public static void FizzBuzz()
        {
            for (int i = 0; i < 30; i++)
            {
                bool div3 = i % 3 == 0; // Checks 1
                bool div5 = i % 5 == 0; // Checks for 1
                bool both = div3 && div5; // Checks for 2 conditions
                // |------------|
                // |------------------------|
                if (both)
                {
                    Console.WriteLine("Fizz");
                }
                else if (div5)
                {
                    Console.WriteLine("Buzz");

                }
                else if (div3)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Specificity in if statements


        public static double ReturnAValue()
        {

            try
            {
                int.Parse("c");
                return 0;
            }
            catch
            {
                return -1;
            }
        }

    } // class

    // Nested For Loops
    // Multi Dimentional Arrays
    // Discuss try parse and expand on try catch

    // Try Parse returning a double


  


} // namespace
