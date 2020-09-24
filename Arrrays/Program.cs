using System;
using System.ComponentModel.Design;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Arrrays
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            //Guests.GuestList();
            //BankoMat();
            BattleShipsGame();
            Console.ReadKey();
           
        }
        private static void BankoMat()
        {   
            bool menuActive = true;
            int antalKontohändelser = 0;
            int balance = 0;
            string[] kontoHändelser = new string[10];
            
            do
            {
                if(antalKontohändelser == 10)
                {
                    antalKontohändelser = 0;
                }
                Console.WriteLine($"Välkommen till din Noscam bank\n" +
                    $"[I]nsättning\n" +
                    $"[U]ttag\n" +
                    $"[S]aldo\n" +
                    $"[A]vsluta\n");

                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case 'i':
                        Console.Clear();
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        string deposit = Console.ReadLine();
                        balance += int.Parse(deposit);
                        antalKontohändelser++;
                        kontoHändelser[antalKontohändelser % 10] = $"Insättning: {deposit} kr | {DateTime.Now.ToString()}";
                        break;
                    case 'u':
                        Console.Clear();
                        
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        string withdrawal = Console.ReadLine();
                        if(int.Parse(withdrawal) < balance) 
                        { 
                        balance -= int.Parse(withdrawal);
                        antalKontohändelser++;
                        kontoHändelser[antalKontohändelser % 10] = $"Uttag: {withdrawal} kr | {DateTime.Now.ToString()}";
                        }
                        else Console.WriteLine("Not enough funds");

                        break;
                    case 's':
                        Console.Clear();
                        Console.WriteLine($"Ditt saldo är: {balance} kr");
                        Console.WriteLine("Tidigare transaktioner:");
                        /*                        string[] temp = kontoHändelser;
                                                temp.Reverse();
                                                foreach (var t in temp)
                                                {
                                                    Console.WriteLine(t);
                                                }*/
                        for (int i = kontoHändelser.Length-1; i >= 0; i--)
                        {
                            Console.WriteLine(kontoHändelser[i]);
                        }
                        break;
                    case 'a':
                        menuActive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            } while (menuActive);
        }
        public static void BattleShipsGame()
        {
            
            Console.WriteLine("How many rows do you want on your map?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns do you want on your map?");
            int col = int.Parse(Console.ReadLine());
            Random rndY = new Random();
            BattleShipsMapBuilder(rows, col);
        }
        public static void BattleShipsMapBuilder(int a, int b)
        {

           
            int targetX = rnd.Next(0, a);
            int targetY = rnd.Next(0, b);

            bool gameRunning = true;

            string[,] battleShipMap = new string[a,b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    battleShipMap[i, j] = "~";
                }
            }

            do
            {
                Console.Clear();
            for (int x = 0; x < battleShipMap.GetLength(0); x++)
            {                
                for (int y = 0; y < battleShipMap.GetLength(1); y++)
                {
                    Console.Write(battleShipMap[x, y]);
                }
                Console.WriteLine();
            }
                
                Console.WriteLine($"{targetX},{targetY}");
                Console.WriteLine($"Enter a X coordinate from 1 to {a}");
                int playerXGuess = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter a Y coordinate from 1 to {b}");
                int playerYGuess = int.Parse(Console.ReadLine());

                if (targetX == playerXGuess && targetY == playerYGuess)
                {
                    Console.WriteLine("YOU WIN!");
                    gameRunning = false;
                    Console.ReadKey();

                }
                else

                battleShipMap[playerXGuess - 1, playerYGuess - 1] = "*";

            } while (gameRunning);

        }
        public static void BattleShipTargets(string[,] map,int x,int y)
        {
           

            string[,] battleShipMap = map;

        }
    }
    class Guests
    {
        public static void GuestList()
        {
            bool menuActive = true;
            string[] guestList = new string[1];
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Welcome to the Weather Station Reception. How may i help you?\n" +
                    "1. Add visitors. \n" +
                    "2. Remove visitors. \n" +
                    "3. View visitors. \n" +
                    "4. Check median temperatures.\n" +
                    "5. Sort visitor list.\n" +
                    "6. Exit Weather station.");
                    int userInput = int.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("How many names do you want to enter?");
                            int guestsAmount = int.Parse(Console.ReadLine());
                            guestList = GuestListBuilder(guestsAmount);
                            break;
                        case 2:
                            Console.WriteLine("Who do you want to replace? Select by ID number");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the name of the new visitor?");
                            string newVisitor = Console.ReadLine();
                            guestList = ReplaceGuest(guestList, id, newVisitor);
                            break;
                        case 3:
                            GuestListIterator(guestList);
                            break;
                        case 4:
                            Console.WriteLine("How many samples are you entering?");
                            int tempsMeasured = int.Parse(Console.ReadLine());
                            MedianTemps(tempsMeasured);
                            break;
                        case 5:
                            GuestListSorter(guestList);
                            break;
                        case 6:
                            menuActive = false;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Only Provide Valid numbers");
                }

            } while (menuActive);


        }
        public static void GuestListSorter(string[] guestList)
        {

            for (int i = 0; i < guestList.Length; i++)
            {

                for (int j = 0; j < guestList.Length - 1; j++)
                {
                    if (guestList[j].CompareTo(guestList[j + 1]) < 0)
                    {
                        string temp = guestList[j];
                        guestList[j] = guestList[j + 1];
                        guestList[j + 1] = temp;
                    }

                }
            }
            foreach (var g in guestList)
            {
                Console.WriteLine(g);
            }
            Console.ReadKey();

        }
        public static string[] GuestListBuilder(int guestsAmount)
        {


            Console.Clear();
            string[] namesOfGuests = new string[guestsAmount];  //Bygger gästlistan baserad på hur många från användarinput
            for (int i = 0; i < guestsAmount; i++)
            {
                Console.WriteLine($"Enter name of visitor {i + 1}. ");
                string guest = Console.ReadLine();
                namesOfGuests[i] = guest;
            }
            Console.Clear();
            return namesOfGuests;
            //GuestListIterator(namesOfGuests); // skickar namnlistan vidare till Iterator metoden

        }
        public static string[] ReplaceGuest(string[] guestlist, int id, string newVisitor)
        {
            for (int i = 0; i < guestlist.Length; i++)
            {
                if (i == id - 1)
                {
                    guestlist[i] = newVisitor;
                }
            }

            return guestlist;
        }
        public static void GuestListIterator(string[] guestlist)
        {

            for (int i = guestlist.Length - 1; i >= 0; i--) //Loopar igenom gästlistan[] baklänges
            {

                if (guestlist[i] == null) // Kollar om gästlistan är tom
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are no visistors on the list");
                }
                else

                    Console.WriteLine($"Id:{i + 1} {guestlist[i]}");


            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to return to the reception");
            Console.ReadKey();
        }
        public static void MedianTemps(int tempsMeasured)
        {
            int sumOfTemps = 0;
            double median;
            int[] temperatures = new int[tempsMeasured];
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"Enter temperature no.{i + 1}");
                temperatures[i] = int.Parse(Console.ReadLine());

                sumOfTemps += temperatures[i];

            }

            median = sumOfTemps / tempsMeasured;
            Console.WriteLine(sumOfTemps);
            Console.WriteLine($"Median temperature of dataset for Stockholm is: {median} °C.");
            Console.ReadKey();
        }
    }
}
