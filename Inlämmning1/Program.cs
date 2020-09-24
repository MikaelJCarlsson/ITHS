using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Inlämmning1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintCity();
            Console.ReadKey();
        }
        public static int[,] CitizenBuilderTwo()
        {


            int[,] citizen = new int[10, 10];

            return citizen;
        }
        public static List<Person> CitizenBuilder()
        {
            List<Person> citizens = new List<Person>();
            citizens.Add(new Polis(1, 1));
            citizens.Add(new Polis(2, 2));
            citizens.Add(new Polis(3, 3));
            citizens.Add(new Polis(4, 4));
            citizens.Add(new Medborgare(2, 1));
            citizens.Add(new Medborgare(0, 2));
            citizens.Add(new Tjuv(0, 3));
            citizens.Add(new Tjuv(0, 4));
            citizens.Add(new Medborgare(5, 1));
            citizens.Add(new Medborgare(3, 0));
            citizens.Add(new Medborgare(2, 0));
            citizens.Add(new Medborgare(1, 0));
            return citizens;
        }

        public static void PrintCity()
        {

            List<Person> citizens = CitizenBuilder();

            int[,] array = CitizenBuilderTwo();

            int z = array.GetLength(1);
                Console.WriteLine(z);

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    foreach (var c in citizens)
                    {
                        if (c is Polis && c.Ypos == y && c.Xpos == x)
                        {
                            array[y, x] = 1;

                        }
                        if (c is Medborgare && c.Ypos == y && c.Xpos == x)
                        {
                            array[y, x] = 2;

                        }
                    }

                    if (array[x, y] == 1)
                    {
                        Console.Write("P");
                    }
                    if( array[x,y] == 2)
                    {
                        Console.Write("M");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
