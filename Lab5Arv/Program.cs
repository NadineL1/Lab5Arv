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
            animal.HaveKids();
            Console.WriteLine($"The animal is a/n , has the colour {animal.colour} and its skin has {animal.skinType}");
            
            Bird bird = new Bird();
            Flamingo flamingo = new Flamingo();
            Cat cat = new Cat();
            Lion lion = new Lion();
            Leopard leopard = new Leopard();
            Horse horse = new Horse();
            Donkey donkey = new Donkey();
            Zebra zebra = new Zebra();
        }
    }
    // basklass Animal, 
    class Animal
    {
        // minst 5 fields och tre Metoder() alla djur ska dela
        //skapa minst tre olika djur som ärver från Animal
        //dessa ska ha minst en ny field och en ny Metod()
        
        public string colour;
        public string food;
        public bool hasWings;
        public string name;
        public string skinType;
        public string sound;
        public string pattern;

        public Animal()
        {
            colour = "brown";
            food = "food";
            hasWings = false;
            name = "unknown";
            skinType = "fur";
            sound = "speaks";
            pattern = "plain";
        }

        public void Eat()
        { 
            Console.WriteLine("The animal is eating .");
        }
        public void MakeSound()
        {
            Console.WriteLine($"The animal {sound}.");
        }
        public void HaveKids()
        {
            Console.WriteLine("The animal is having kids.");
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
        public void MakeSound(string[] sound)
        {
            Random rand = new Random();
            int birdSound = rand.Next(sound.Length);
            Console.WriteLine($"The bird goes {sound[birdSound]}");
        }
        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }

    }
    class Flamingo : Bird
    {
        public Flamingo()
        {
            colour = "pink";
            food = "crustasceans";
        }
        public void Eat(string food)
        {   
            Console.WriteLine($"The flamingo is eating {food}.");
        }
    }
    class Cat : Animal
    {
        public Cat()
        {
            food = "meat";
            hasWings = false;
            string[] sound = { "meaw", "roar", "growl", "purr" };
            string[] move = { "running", "jumping", "climbing" };
            skinType = "fur";
        }
        public void MakeSound(string[] sound)
        {
            Random rand = new Random();
            int catSound = rand.Next(sound.Length);
            Console.WriteLine($"The cat goes {sound[catSound]}");
        }
        public void Move(string[] move)
        {
            Random rand = new Random();
            int catMove = rand.Next(move.Length);
            Console.WriteLine($"The cat is {move[catMove]}");
        }
        public void Scratch()
        {
            Console.WriteLine("The cat is scratching.");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}.");
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
        bool isKicking = true;
        
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
