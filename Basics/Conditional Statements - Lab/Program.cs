using System;

namespace Conditional_Statements___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            double grade = Double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }

            //2
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("Първото: " + first);
            }else if (second > first)
            {
                Console.WriteLine("Второто: " + second);
            }
            else
            {
                Console.WriteLine("Числата са равни!");
            }

            //3
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            //4
            string password = Console.ReadLine();
            if (password.Equals("s3cr3t!P@ssw0rd"))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

            //5
            int number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }else if(number>100 && number < 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }

            //6
            double speed = Double.Parse(Console.ReadLine());
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }else if(speed>10 && speed <= 50)
            {
                Console.WriteLine("average");
            }else if(speed>50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }

            //7
            string figure = Console.ReadLine();
            double area=0;
            if (figure.Equals("square"))
            {
                double a = Double.Parse(Console.ReadLine());
                area = a * a;
            }else if (figure.Equals("rectangle"))
            {
                double a = Double.Parse(Console.ReadLine());
                double b = Double.Parse(Console.ReadLine());
                area = a * b;
            }else if (figure.Equals("circle"))
            {
                double r = Double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else
            {
                double a = Double.Parse(Console.ReadLine());
                double h = Double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            
            Console.WriteLine(string.Format("{0:0.000}",area));
                }
    }
}
