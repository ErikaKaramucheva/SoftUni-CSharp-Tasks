
using System;

namespace First_Steps_in_Coding___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            double dollars = Double.Parse(Console.ReadLine());
            double lv = dollars * 1.79549;
            Console.WriteLine(lv);

            //2
            double rad = Double.Parse(Console.ReadLine());
            double degree = rad * 180 / Math.PI;
            Console.WriteLine(degree);

            //3
            double deposit = Double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percent = (Double.Parse(Console.ReadLine()))/100;
            double sum = deposit + (term * ((deposit * percent) / 12));
            Console.WriteLine(sum);

            //4
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalTime = pages / pagesPerHour;
            int hoursPerDay = totalTime / days;
            Console.WriteLine(hoursPerDay);

            //5
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            double discount = (Double.Parse(Console.ReadLine()))/100;
            double pensSum = pens * 5.80;
            double markersSum = markers * 7.20;
            double litersSum = liters * 1.20;
            double totalSum = pensSum + markersSum + litersSum;
            double priceAfterDiscount = totalSum-(totalSum * discount);
            Console.WriteLine(priceAfterDiscount);

            //6
            double nylonPrice = 1.5;
            double paintPrice = 14.5;
            double thinnerPrice = 5;
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double paintAfterAdding = paint + (paint * 0.1);
            nylon += 2;
            double sumForMaterials = (nylon * nylonPrice) + (paintAfterAdding * paintPrice) + (thinner * thinnerPrice)+0.4;
            double employeePerHour = sumForMaterials * 0.3;
            double total_Sum = sumForMaterials + (hours * employeePerHour);
            Console.WriteLine(total_Sum);

            //7
            int count_chicken_menues=int.Parse(Console.ReadLine());
            double price_chicken_menues=10.35;
            double price_fish_menues=12.40;
            double price_vegetarian_menues=8.15;
            int count_fish_menues=int.Parse(Console.ReadLine());
            int count_veg_menues=int.Parse(Console.ReadLine());
            double sum_without_dessert=(count_chicken_menues*price_chicken_menues)+(count_fish_menues*price_fish_menues)+(count_veg_menues*price_vegetarian_menues);
            double dessert=0.20*sum_without_dessert;
            double total_sum=sum_without_dessert+dessert+2.5;
            Console.WriteLine(total_sum);

            //8
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax - (tax * 0.4);
            double suit = shoes - (shoes * 0.2);
            double ball = suit / 4;
            double accessories = ball / 5;
            double total_sum_basketball = tax + shoes + suit + ball + accessories;
            Console.WriteLine(total_sum_basketball);

            //9
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percentage = Double.Parse(Console.ReadLine());
            int b = width * length;
            int v = b * h;
            double l_liters = (v - (v * (percentage/100)))/1000;
            Console.WriteLine(l_liters);



        }
    }
}
