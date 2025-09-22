using System.Xml.Schema;

namespace Lab5Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Tänka ut en struktur för arv och att implementera den i kod*/
            Animal animal = new Animal();
            // i main ska jag initiera flera olika djur och make sound i konsollen
            animal.MakeSound();
            animal.Eat();
            animal.Move();
            Console.WriteLine($"The animal is {animal.age}years old, has the colour {animal.colour} and its skin has {animal.skinType}");
            
            Bird bird = new Bird();
            Console.WriteLine($"The bird is {bird.age}years old, has the colour {bird.colour} and it's skin has {bird.skinType}");

            Cat cat = new Cat();
        }
    }
    // basklass Animal, 
    class Animal
    {
        // minst 5 fields och tre Metoder() alla djur ska dela
        //skapa minst tre olika djur som ärver från Animal
        //dessa ska ha minst en ny field och en ny Metod()
        public int age;
        public string colour;
        public string food;
        public bool hasWings;
        public string name;
        public string skinType;
        public string pattern;

        public Animal()
        {
            age = 5;
            colour = "brown";
            food = "food";
            hasWings = false;
            name = "unknown";
            skinType = "fur";
            pattern = "plain";
        }

        public void Eat()
        { 
            Console.WriteLine("The animal is eating.");
        }
        public void MakeSound()
        {
            Console.WriteLine("The animal is making noice.");
        }
        public void Move()
        {
            Console.WriteLine("The animal is moving.");
        }

    }
    class Bird : Animal
    {
        public Bird()
        {
            string[]sound = { "chirp", "tweet", "squawk", "caw" };
            colour = "varied";
            hasWings = true;
            skinType = "feathers";
        }

    }
    class Flamingo : Bird
    {
        public Flamingo()
        {
            colour = "pink";
            name = "Flamingo";
        }
        public void Eat()
        {   
            Console.WriteLine("The flamingo is eating fish.");
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            string food = "meat";
            hasWings = false;
            string[] sound = { "meaw", "roar", "growl", "purr" };
            string[] move = { "run", "jump", "climb" };
            skinType = "fur";
        }
        public void Scratch()
        {
            Console.WriteLine("The cat is scratching.");
        }
    }
    class Lion : Cat
    {
        public Lion()
        {
            colour = "yellow";
            name = "Lion";
            pattern = "striped";
        }
    }
    class Leopard : Cat
    {
        public Leopard()
        {
            colour = "spotted";
            name = "Leopard";
        }
    }
    class Horse : Animal
    {
        // Donkey;
        // Zebra;

    }
    class Donkey : Horse
    {
        public Donkey()
        {
            colour = "grey"; 
        }
    }
    class Zebra : Horse
    {
        public Zebra()
        {
            colour = "black and white";
            
        }
    }   
}
