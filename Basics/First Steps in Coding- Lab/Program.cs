using System;

namespace First_Steps_in_Coding__Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
             Console.WriteLine("Hello SoftUni");

             //2
             Console.WriteLine("1");
             Console.WriteLine("2");
             Console.WriteLine("3");
             Console.WriteLine("4");
             Console.WriteLine("5");
             Console.WriteLine("6");
             Console.WriteLine("7");
             Console.WriteLine("8");
             Console.WriteLine("9");
             Console.WriteLine("10");

             //2- second way
             for(int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);
             }

             //3
             int sideA = int.Parse(Console.ReadLine());
             int sideB = int.Parse(Console.ReadLine());
             int area = sideA * sideB;
             Console.WriteLine(area);

             //4
             double inches = Double.Parse(Console.ReadLine());
             double cm = inches * 2.54;
             Console.WriteLine(cm);

            //5
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!", name);

            //6
            string lName = Console.ReadLine();
            string fName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are "+lName+" "+fName+",a "+age+"-years old person from "+town+".");

            //7
            string architectName = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());
            int totalTime = projectNumber * 3;
            Console.WriteLine("The architect "+ architectName+" will need "+totalTime+" hours to complete "+projectNumber+" project/s.");
            
            //8
            int count_dog = int.Parse(Console.ReadLine());
            int count_cat = int.Parse(Console.ReadLine());
            double dog_sum = count_dog * 2.5;
            int cat_sum = count_cat * 4;
            double total = cat_sum + dog_sum;
            Console.WriteLine(total + " lv.");

            //9
            double meters = Double.Parse(Console.ReadLine());
            double priceBeforeDiscount = meters*7.61;
            double discount = priceBeforeDiscount * 0.18;
            double priceAfterDiscount = priceBeforeDiscount - discount;
            Console.WriteLine("The final price is: " + priceAfterDiscount + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
            
            }
    }
}
