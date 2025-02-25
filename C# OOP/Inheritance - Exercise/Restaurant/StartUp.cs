using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Product tea = new Tea("Tea", 2.5m, 100);
            Console.WriteLine(tea.Name.ToString());

            Fish fish = new Fish("Fish",5.6m,200);
            Console.WriteLine(fish.Grams);

            Cake cake = new Cake("cake", 4.3m, 100, 0);
            Console.WriteLine(cake.Calories);
        }
    }
}