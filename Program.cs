namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter dog's name: ");
            string dogName = Console.ReadLine();
            var dog = new Dog { Name = dogName, Colour = "Black", Age = 10 };
            Console.WriteLine($"Dog properties - Name: {dog.Name}, Colour: {dog.Colour}, Age: {dog.Age}");
            dog.Eat();

            Console.Write("\nEnter cat's name: ");
            string catName = Console.ReadLine();
            var cat = new Cat { Name = catName, Colour = "White", Age = 5 };
            Console.WriteLine($"Cat properties - Name: {cat.Name}, Colour: {cat.Colour}, Age: {cat.Age}");
            cat.Eat();


            Console.Write("Enter dog's name: ");
            string dogName2 = Console.ReadLine();
            var dogInterface = new DogInterface { Name = dogName2, Colour = "White", Height = 30, Age = 5 };
            Console.WriteLine($"Dog properties - Name: {dogInterface.Name}, Colour: {dogInterface.Colour}, Height: {dogInterface.Height}, Age: {dogInterface.Age}");
            dogInterface.Eat();
            Console.WriteLine($"Dog cries: {dogInterface.Cry()}");

            Console.Write("\nEnter cat's name: ");
            string catName2 = Console.ReadLine();
            var catInterface = new CatInterface { Name = catName2, Colour = "Orange", Height = 25, Age = 4 };
            Console.WriteLine($"Cat properties - Name: {catInterface.Name}, Colour: {catInterface.Colour}, Height: {catInterface.Height}, Age: {catInterface.Age}");
            catInterface.Eat();
            Console.WriteLine($"Cat cries: {catInterface.Cry()}");


            List<IAnimal> animals = new List<IAnimal>
            {
            dogInterface ,
            catInterface
            };

            Console.WriteLine("\nList of animal names:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
