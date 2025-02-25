using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string typeOfAnimal = Console.ReadLine();
            string animalInfo = "";
            while (!typeOfAnimal.Equals("Beast!"))
            {
                
                animalInfo = Console.ReadLine();
                string[] animal = animalInfo.Split(" ");
                string animalName = animal[0];
                int animalAge = int.Parse(animal[1]);
                string gender = animal[2];

                if(animalName== null || animalAge <= 0 || (gender != "Male" && gender != "Female"))
                {
                    Console.WriteLine("Invalid input!");
                    typeOfAnimal = Console.ReadLine();
                    continue;
                }
                Animal currentAnimal = null ;
                if(typeOfAnimal.Equals("Cat"))
                {
                    currentAnimal = new Cat(animalName, animalAge, gender);
                   
                }else if (typeOfAnimal.Equals("Dog"))
                {
                    currentAnimal = new Dog(animalName,animalAge, gender);
                }else if (typeOfAnimal.Equals("Frog"))
                {
                    currentAnimal = new Frog (animalName,animalAge,gender);
                }
                else if (typeOfAnimal.Equals("Kittens"))
                {
                    currentAnimal = new Kittens(animalName, animalAge, gender);
                }
                else
                {
                    currentAnimal = new Tomcat(animalName, animalAge, gender);
                }
                Console.WriteLine(typeOfAnimal);
                Console.WriteLine($"{currentAnimal.Name} {currentAnimal.Age} {currentAnimal.Gender}");
                Console.WriteLine(currentAnimal.ProduceSound());
                typeOfAnimal = Console.ReadLine();
               
            }
        }
    }
}
