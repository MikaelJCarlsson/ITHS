using Inheritance;
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {
            programSelector();
        }
        public static void programSelector()
        {
            bool active = true;
            while (active) 
            {
                Console.Clear();
            Console.WriteLine("Hello! What would you like to do?\n" +
                "[L]ibrary\n" +
                "[Z]oo\n" +
                "[Q]uit");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'l':
                        libraryMenu();
                        break;
                    case 'z':
                        RandomAnimals();
                        break;
                    case 'q':
                        active = false;
                        break;
                        
                }
            }

        }
        public static void libraryMenu()
        {
            List<Book> allBooks = libraryCreator();
            bool menu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the shittiest library in the world! \n" +
                    "Please select between the following\n" +
                    "[1] List all books in library\n" +
                    "[2] List Factbooks\n" +
                    "[3] List Kidsbooks\n" +
                    "[4] List Entertainmentbooks\n" +
                    "[5] Exit Shitty Library");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        libraryList(userInput);
                        break;
                    case 2:
                        Console.Clear();
                        libraryList(userInput);
                        break;

                    case 3:
                        Console.Clear();
                        libraryList(userInput);
                        break;
                    case 4:
                        Console.Clear();
                        libraryList(userInput);
                        break;
                    case 5:
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option retard\n" +
                            "Press any key to return to menu");
                        break;
                }

            } while (menu);
        }
        public static void libraryList(int i)
        {

            List<Book> library = libraryCreator();

            foreach (var book in library)
            {
                if (i == 1 || i == 2)
                {
                    if (book is FactBook)
                    {
                        Console.WriteLine($"Title: {book.title} | Author: {book.author} | Pages: {book.pages} | Subject:{((FactBook)book).subject} | Difficulty: {((FactBook)book).difficulty} ");
                    }
                }
                if (i == 1 || i == 3)
                {
                    if (book is KidsBook)
                    {
                        Console.WriteLine($"Title: {book.title} | Author: {book.author} | Pages: {book.pages} | Suitable for:{((KidsBook)book).readerGroup} | Has pictures: {(((KidsBook)book).pictures ? "Yes" : "No")} ");
                    }
                }
                if (i == 1 || i == 4)
                {
                    if (book is Entertainment)
                    {
                        Console.WriteLine($"Title: {book.title} | Author: {book.author} | Pages: {book.pages} | Genre:{((Entertainment)book).genre} | What type of book: {((Entertainment)book).standAloneOrseries} ");
                    }
                }
            }
            Console.ReadLine();
        }
        public static List<Book> libraryCreator()
        {
            List<Book> library = new List<Book>();

            library.Add(new FactBook("Guiness Book of World Records!", "Mikael Carlsson", 300, "Assorted Facts", "Easy"));
            library.Add(new FactBook("Vetenskapens Värld!", "Tove Tapani", 199, "Science", "Medium"));
            library.Add(new KidsBook("Lilla Loppan", "Kim Jong Il", 12, "Small Children", true));
            library.Add(new Entertainment("Karate Kid", "Pat Morita", 583, "Action", "Series"));
            library.Add(new Entertainment("Karate Kid 2 \"Kids Revenge\"", "Big Pat", 2003, "Action-Romance", "Series"));
            library.Add(new KidsBook("Electric Boogaloo", "John", 190, "Teen", false));
            library.Add(new FactBook("Sport Rekord 2020", "Steffe L", 150, "Sport", "Easy"));
            library.Add(new Entertainment("HackerZ", "Edgy Stereotype", 2, "Sci-Fi", "Roman"));
            library.Add(new Entertainment("Sheriffens sagor", "Tove T.", 40000, "Biografi", "Serie"));

            return library;
        }
        public static void RandomAnimals()

        {
            bool active = true;
            bool night = true;

            
            do
            {
                Console.Clear();
                Console.WriteLine("Press [N] To see what the nighttime animals are up to \n" +
                    "Press [D] to see what the daytime animals are doing. \n" +
                    "Press [Q] to quit this shitty program");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {   
                    case 'n':
                        night = true;
                        AnimalIterator(night);
                        break;
                    case 'd':
                        night = false;
                        AnimalIterator(night);
                        break;
                    case 'q':
                        active = false;
                        break;
                    default:
                        break;
                }


            } while (active);
        }
        public static void AnimalIterator(bool night)
        {
            Console.Clear();
            List<Animal> listOfAnimals = animalListCreator();
            if (night) { 
                Console.WriteLine("NIGHT TIME");
            Console.WriteLine();
            }
            else Console.WriteLine("DAY TIME");
            Console.WriteLine();
          
           
            foreach (var a in listOfAnimals)
            {
                a.Movement(night);
                
                if (a is Eagle)
                {
                    Console.WriteLine($"Top speed: {((Eagle)a).Topspeed}");
                }
                if( a is Wolf)
                {
                    Console.WriteLine($"Carnivore: {(((Wolf)a).Carnivore ? "Yes":"No")}");
                }

                if(a is Orca)
                {
                    Console.WriteLine($"Intelligence: {((Orca)a).Intelligence}");
                }
                if (a is Elk)
                {
                    Console.WriteLine($"Sex: {((Elk)a).Sex}");
                }
                if(a is Mouse)
                {
                    Console.WriteLine($"Agility: {((Mouse)a).Agility}");
                }
                if(a is Tiger)
                {
                    Console.WriteLine($"Power 1-10: {((Tiger)a).Power}");
                }
                if(a is Goat)
                {
                    Console.WriteLine($"Weird eyes: {((Goat)a).WeirdEyes}");
                }
                if(a is GoldFish)
                {
                    Console.WriteLine($"How many have you lost?: {((GoldFish)a).HowManyDownTheToilet}");
                }
                if(a is Bat)
                {
                    Console.WriteLine($"A Fictional character: {((Bat)a).FictionalCharacter}");
                }

                Console.WriteLine("Weight: " + a.Weight + " kg");
                Console.WriteLine("Nocturnal: " + (a.Nocturnal ? "Yes" : "No"));
                Console.WriteLine("Habitat: " + a.Habitat);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static List<Animal> animalListCreator()
        {
            List<Animal> listOfAnimals = new List<Animal>();
            listOfAnimals.Add(new Eagle(false, 12, "Mountains", 86));
            listOfAnimals.Add(new Wolf(true, 42, "Forests and Tundras", true));
            listOfAnimals.Add(new Orca(false, 1400, "Deep Oceans", "Extremely High"));
            listOfAnimals.Add(new Elk(false, 300, "Plains and Tundras", "Male"));
            listOfAnimals.Add(new Mouse(true, 1, "Cities and Forests", "Very high"));
            listOfAnimals.Add(new Tiger(true, 400, "Jungle Forests, Siberia", 10));
            listOfAnimals.Add(new Goat(false, 50, "Hills and Mountains", true));
            listOfAnimals.Add(new GoldFish(false, 1, "Aquariums", 4));
            listOfAnimals.Add(new Bat(true, 1, "Caves and Mansions", "Batman"));
            return listOfAnimals;
        }
    }

}
