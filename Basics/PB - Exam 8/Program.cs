public class Program
{
    public static void Main(string[] args)
    {
        //01
        /*double strawberryPrice=double.Parse(Console.ReadLine());
        double kgBananas=double.Parse(Console.ReadLine());
        double kgOranges=double.Parse(Console.ReadLine());
        double kgRedberries = double.Parse(Console.ReadLine());
        double kgStrawberries=double.Parse(Console.ReadLine());

        double redberriesPrice = strawberryPrice / 2;
        double orangesPrice=redberriesPrice-(0.4*redberriesPrice);
        double bananasPrice = redberriesPrice - (0.8 * redberriesPrice);

        double strawberrySum = strawberryPrice * kgStrawberries;
        double bananasSum = bananasPrice * kgBananas;
        double orangesSum= orangesPrice * kgOranges;
        double redberriesSum = redberriesPrice * kgRedberries;
        double totalSum=strawberrySum+ bananasSum+orangesSum+redberriesSum;
        Console.WriteLine(Math.Round(totalSum,2));*/

        //02
        /*double budget = double.Parse(Console.ReadLine());
        double neededFuel = double.Parse(Console.ReadLine());
        string day= Console.ReadLine();
        double sumForFuel = neededFuel * 2.1;
        double totalSum = sumForFuel + 100;
        if (day.Equals("Saturday"))
        {
            totalSum -= 0.1 * totalSum;
        }
        else
        {
            totalSum -= 0.2 * totalSum;
        }
        if (budget >= totalSum)
        {
            Console.WriteLine($"Safari time! Money left {Math.Round((budget - totalSum), 2)} lv.");
        }
        else
        {
            Console.WriteLine($"Not enough money! Money needed: {Math.Round(totalSum - budget, 2)} lv.");
        }*/

        //03
        /*string duration = Console.ReadLine();
        string type = Console.ReadLine();
        string internet = Console.ReadLine();
        int months = int.Parse(Console.ReadLine());
        double sum = 0;
        if (duration.Equals("one")) {
            switch (type)
            {
                case "Small": sum = 9.98; break;
                case "Middle": sum = 18.99; break;
                case "Large": sum = 25.98; break;
                default: sum = 35.99; break;
            }
        }
        else
        {
            switch (type)
            {
                case "Small": sum = 8.58; break;
                case "Middle": sum = 17.09; break;
                case "Large": sum = 23.59; break;
                default: sum = 31.79; break;
            }
        }

        if (internet.Equals("yes"))
        {
            if (sum <= 10)
            {
                sum += 5.5;
            }else if(sum>10 && sum <= 30)
            {
                sum += 4.35;
            }else if (sum > 30)
            {
                sum += 3.85;
            }
        }

        sum = sum * months;
        if (duration.Equals("two"))
        {
            sum -= sum * 0.0375;
        }
        Console.WriteLine(Math.Round(sum, 2) + " lv.");*/

        //04
        /*double budget= double.Parse(Console.ReadLine());
        string command=Console.ReadLine();
        double price;
        double sum = 0;
        int items = 0;
        int count = 0;
        while (!command.Equals("Stop"))
        {
            price= double.Parse(Console.ReadLine());
            count++;
            if (count == 3)
            {
                price = price / 2;
            }
            if (price+sum > budget)
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {(price+sum)-budget} leva!");
                return;
            }
            sum+= price;
            items++;
            command = Console.ReadLine();
        }
        Console.WriteLine($"You bought {items} products for {sum} leva.");*/

        //06
        int days = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        double currentSum = 0;
        double sum = 0;
        for (int i = 1; i <= days; i++)
        {
            currentSum = 0;
            for (int j = 1; j <= hours; j++)
            {
                if(i%2==0 && j % 2 == 1)
                {
                    currentSum += 2.5;
                }else if( i%2==1 & j % 2 == 0)
                {
                    currentSum += 1.25;
                }
                else
                {
                    currentSum += 1;
                }
            }
            Console.WriteLine($"Day: {i} - {currentSum} leva");
            sum += currentSum;
        }
        Console.WriteLine($"Total - {sum} leva");

    }
}