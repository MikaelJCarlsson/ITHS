using System;
using System.Collections.Generic;
using System.IO;

namespace Collections
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            
            stringToLeapYear();
            Console.ReadKey();


        }
        static void stringToLeapYear()
        {

            printInfo();
           
            string userString = Console.ReadLine();
            string[] years = userString.Split(' ');

            for (int i = 0; i < years.Length; i++)
            {
                Console.Write($"{isLeapYear(int.Parse(years[i]))} "); 
            }

            
        }
        static bool LeapYearCalc(int year)
        {
            bool leapYear = true;
            
            if (year % 4 == 0 )
            {
                  
                if(year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        leapYear = true;
                    }
                    else leapYear = false;
                }else
                {
                    leapYear = true;
                    
                }
            }
            
            else leapYear = false;
            

            return leapYear;

        }
        static void printInfo()
        {
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Enter a Year:");

        }
        static string isLeapYear(int year)
        {
            LeapYearCalc(year);

            if (LeapYearCalc(year) == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return $"{year}";
            }
            else

                Console.ForegroundColor = ConsoleColor.Blue;
            return $"{year}";
        }
        static void Pandemic()
        {


            int infected = 0;
            int immune = 0;
            int random = rnd.Next(1, 10);
            var disco = new List<Person>();
            int currentTime = 0;


            for (int i = 0; i < 10; i++) //Skapar Discotek med 1 smittad.
            {
                if (i == 0)
                {
                    Person person = new Person();
                    person.infected = true;
                    person.timeOfInfection = currentTime;
                    person.immune = false;
                    infected++;
                    person.id = i;
                    disco.Add(person);
                }
                else
                {
                    Person person = new Person();
                    person.infected = false;
                    person.timeOfInfection = currentTime;
                    person.immune = false;
                    person.id = i;
                    disco.Add(person);

                }

            }

            int numSpread = 0; //Numspread för kontroll av att den itererar igenom personerna
            while (immune < 10) //ska ersättas med while(immune <=50) när jag fattar hur jag smittar andra exponentiellt, utan att få indexOutofBounds
            {
                Console.ReadKey();
                Console.Clear();

                //(infected - immune) *2 formel för smittspridning blir indexOutofBounds





                foreach (Person p in disco)
                {

                    if (p.infected == true && p.timeOfInfection + 5 == currentTime)
                    {
                        p.infected = false;
                        p.immune = true;
                        infected--;
                        immune++;

                    }
                    Console.WriteLine($" Infected: {p.infected} | Immune: {p.immune} |  id: {p.id}");

                }
                if (infected < 0)
                {
                    infected = 0;
                }

                //int randomSpread = rnd.Next(disco.Count); //användsenare när jag kan randomisera utan att den väljer samma
                if (disco[numSpread].immune == false && disco[numSpread].infected == false) //Sprider för tillfället viruset vidare till nästa person i diskot, 1 per timme 
                {                                                                           //vilkoret används mest som kontroll
                    disco[numSpread].infected = true;
                    disco[numSpread].timeOfInfection = currentTime;
                    infected++;
                }

                Console.WriteLine();
                Console.WriteLine($"Infected: {infected} | Hours Elapsed: {currentTime} | Immune: {immune} ");
                currentTime++;
                numSpread++;

            }
        }
        static List<Animals> animalcreator()
        {
            var theForest = new List<Animals>();

            Animals wolf = new Animals();
            wolf.name = "Vargen";
            wolf.nocturnal = true;

            Animals bat = new Animals();
            bat.name = "Fladdermusen";
            bat.nocturnal = true;

            Animals horse = new Animals();
            horse.name = "Hästen";
            horse.nocturnal = false;

            Animals delfin = new Animals();
            delfin.name = "Delfinen";
            delfin.nocturnal = false;

            Animals örn = new Animals();
            örn.name = "Örnen";
            örn.nocturnal = false;

            theForest.Add(wolf);
            theForest.Add(bat);
            theForest.Add(horse);
            theForest.Add(örn);
            theForest.Add(delfin);

            return theForest;
        }
        static void Djuren()
        {
            bool active = true;
            while (active)
            {
                Console.WriteLine();
                List<Animals> forest = animalcreator();
                Console.WriteLine($"Press 'd' for daymode 'n'for nightmode or 'q' to quit");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.KeyChar)
                {
                    case 'n':
                        foreach (var f in forest)
                        {
                            if (f.nocturnal == true && f.name.Equals("Vargen"))
                            {
                                Console.Write($"{f.name} smyger omkring och letar efter sitt byte och ");
                            }
                            else if (f.nocturnal == true && f.name.Equals("Fladdermusen"))
                            {
                                Console.WriteLine($"{f.name} flyger runt bland träden I jakt på mat");
                            }
                            else
                                Console.WriteLine($"{f.name} sover djupt. ");

                        }
                        break;
                    case 'd':

                        foreach (var f in forest)
                        {
                            if (f.nocturnal == false && f.name.Equals("Örnen"))
                            {
                                Console.WriteLine($"{f.name} flyger runt o spejar I jakt på mat");
                            }
                            else if (f.nocturnal == false && f.name.Equals("Hästen"))
                            {
                                Console.WriteLine($"{f.name} går omkring och betar");
                            }
                            else if (f.nocturnal == false && f.name.Equals("Delfinen"))
                            {
                                Console.WriteLine($"{f.name} simmar runt o äter fisk");
                            }
                            else if (f.nocturnal == true)
                            {
                                Console.WriteLine($"{f.name} sover");
                            }
                        }
                        break;
                    case 'q':
                        active = false;
                        break;
                }

            }



        }
        class Person
        {
            public bool infected { get; set; }
            public int timeOfInfection { get; set; }
            public bool immune { get; set; }
            public int id { get; set; }

        }
        class Animals
        {
            public string name { get; set; }
            public bool nocturnal { get; set; }

        }
        
    }
}