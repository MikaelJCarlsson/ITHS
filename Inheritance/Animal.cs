using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public bool Nocturnal { get; set; }
        public int Weight { get; set; }
        public string Habitat { get; set; }
        public virtual void Movement(bool night)
        {
            if (night)
            {
                Console.WriteLine("Every animal sleeps somehow");
            }
            else
                Console.WriteLine("Every animal moves somehow");
        }
    }
    class Eagle : Animal
    {
        public int Topspeed { get; set; } //Set limit?
        public Eagle(bool nocturnal, int weight, string habitat, int topspeed)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Topspeed = topspeed;
        }
        public override void Movement(bool night)
        {
            if (night)
            {
                Console.WriteLine("The Eagle is sleeping in it's nest");
            }
            else
                Console.WriteLine("The Eagle flies majesticly above");
        }
    }
    class Wolf : Animal
    {
        public bool Carnivore { get; set; } //Error message if false is added.
        public Wolf(bool nocturnal, int weight, string habitat, bool carnivore)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Carnivore = carnivore;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The wolf is hunting ELK");
            else Console.WriteLine("The wolf sleeps quietly in it's den");
        }
    }
    class Orca : Animal
    {
        public string Intelligence { get; set; } // Low,Medium,High,Extreme
        public Orca(bool nocturnal, int weight, string habitat, string intelligence)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Intelligence = intelligence;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The orca sleeps with one half of its brain active");
            else
                Console.WriteLine("The Orca swims together with its pod");
        }
    }
    class Elk : Animal
    {
        public string Sex { get; set; }
        public Elk(bool nocturnal, int weight, string habitat, string sex)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Sex = sex;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The Elk sleeps lightly incase of predators");
            else
                Console.WriteLine("While eating grass the Elk is unaware of the sneaky wolf");
        }
    }
    class Mouse : Animal
    {
        public string Agility { get; set; }
        public Mouse(bool nocturnal, int weight, string habitat, string agility)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Agility = agility;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The mouse is looking for Cheese");
            else Console.WriteLine("The mouse sleeps quietly dreaming of cheese");
        }
    }
    class Tiger : Animal
    {
        public int Power { get; set; } // from 1-10
        public Tiger(bool nocturnal, int weight, string habitat, int power)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            Power = power;

        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The Tiger is stalking the dark jungle looking for a meal");
            else Console.WriteLine("The Tiger sleeps, dreaming of stripes");
        }
    }
    class Goat : Animal
    {
        public bool WeirdEyes { get; set; }
        public Goat(bool nocturnal, int weight, string habitat, bool weirdEyes)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            WeirdEyes = weirdEyes;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The goat dreams of sheep");
            else
                Console.WriteLine("The goat looks at you with its devilish eyes");
        }
    }
    class GoldFish : Animal
    {
        public int HowManyDownTheToilet { get; set; }
        public GoldFish(bool nocturnal, int weight, string habitat, int howmanydownthetoilet)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            HowManyDownTheToilet = howmanydownthetoilet;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("The Goldfish sleeps behind a pot");
            else
                Console.WriteLine("The Goldfish is swimming around and around in its glass bowl");
        }
    }
    class Bat : Animal
    {
        public string FictionalCharacter { get; set; }
        public Bat(bool nocturnal, int weight, string habitat, string character)
        {
            Nocturnal = nocturnal;
            Weight = weight;
            Habitat = habitat;
            FictionalCharacter = character;
        }
        public override void Movement(bool night)
        {
            if (night)
                Console.WriteLine("Hunting for food or hunting The Joker");
            else Console.WriteLine("Sleeping in it's cave");
        }
    }
}
