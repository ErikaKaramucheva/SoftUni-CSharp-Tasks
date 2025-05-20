public class Program
{
    public static void Main(string[] args)
    {
        //01
        /*string airline = Console.ReadLine();
        int countOfTicketsForAdults =int.Parse(Console.ReadLine());
        int countOfTicketsForKids =int.Parse(Console.ReadLine());
        double unitPriceForTicketForAdults= double.Parse(Console.ReadLine());
        double tax=double.Parse(Console.ReadLine());

        double unitPriceForTicketForKids = unitPriceForTicketForAdults - (unitPriceForTicketForAdults * 0.7);
        double total =((unitPriceForTicketForAdults+tax)*countOfTicketsForAdults)+
            ((unitPriceForTicketForKids+tax)*countOfTicketsForKids);
        double profit = 0.2 * total;
        Console.WriteLine($"The profit of your agency from {airline} tickets is {Math.Round(profit,2)} lv.");*/

        //02
        /*double priceOfLuggageAbove20Kg = double.Parse(Console.ReadLine());
        double kgLuggage = double.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        int luggageCount = int.Parse(Console.ReadLine());

        double total = 0;
        if (kgLuggage < 10)
        {
            total = priceOfLuggageAbove20Kg * 0.2;
        }
        else if (kgLuggage >= 10 && kgLuggage <= 20)
        {
            total = priceOfLuggageAbove20Kg / 2;
        }
        else
        {
            total = double.Parse(Console.ReadLine());
        }

        if (days > 30)
        {
            total += total * 0.1;
        }else if(days<=30 && days >= 7)
        {
            total += total * 0.15;
        }
        else
        {
            total += total * 0.4;
        }
        total = total * luggageCount;
        Console.WriteLine($"The total price of bags is {Math.Round(total, 2)} lv.");*/

        //03
        /*int count = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string delivery= Console.ReadLine();
        if (count < 10)
        {
            Console.WriteLine("Invalid order!");
            return;
        }
        int unitPrice = 0;
        double discount = 0;
        switch (type)
        {
            case "90X130":
                unitPrice = 110;
                if(count>=30 && count <= 60)
                {
                    discount = 0.05; 
                }else if (count > 60)
                {
                    discount = 0.08;
                }
                break;
            case "100X150":
                unitPrice = 140;
                if (count >= 40 && count <= 80)
                {
                    discount = 0.06;
                }
                else if (count > 80)
                {
                    discount = 0.1;
                }
                break;
            case "130X180":
                unitPrice = 190;
                if (count >= 20 && count <= 50)
                {
                    discount = 0.07;
                }
                else if (count > 50)
                {
                    discount = 0.12;
                }
                break;
            default:
                unitPrice = 250;
                if (count >= 25 && count <= 50)
                {
                    discount = 0.09;
                }
                else if (count > 50)
                {
                    discount = 0.14;
                }
                break;
        }

        double totalPrice = unitPrice * count;
        totalPrice = totalPrice - (totalPrice * discount);
        if(delivery.Equals("With delivery"))
        {
            totalPrice += 60;
        }
        if (count > 99)
        {
            totalPrice -= totalPrice * 0.04;
        }
        Console.WriteLine(Math.Round(totalPrice, 2) + " BGN");*/

        //04
        /*int n= int.Parse(Console.ReadLine());
        int points = 0;
        string ball = "";
        int redBalls = 0;
        int orangeBalls = 0;
        int yellowBalls = 0;
        int whiteBalls = 0;
        int otherColorBalls = 0;
        int blackBalls = 0;
        for (int i = 0; i < n; i++)
        {
            ball=Console.ReadLine();
            if (ball.Equals("red"))
            {
                points += 5;
                redBalls++;
            }else if(ball.Equals("orange"))
            {
                points += 10;
                orangeBalls++;
            }else if (ball.Equals("yellow"))
            {
                points += 15;
                yellowBalls++;
            }else if (ball.Equals("white"))
            {
                points += 20;
                whiteBalls++;
            }else if (ball.Equals("black"))
            {
                points =points/2;
                blackBalls++;
            }
            else
            {
                otherColorBalls++;
            }

        }

        Console.WriteLine("Total points: " + points);
        Console.WriteLine("Red balls: " + redBalls);
        Console.WriteLine("Orange balls: " + orangeBalls);
        Console.WriteLine("Yellow balls: " + yellowBalls);
        Console.WriteLine("White balls: " + whiteBalls);
        Console.WriteLine("Other colors balls: " + otherColorBalls);
        Console.WriteLine("Divides from black balls: " + blackBalls);*/

        //05
        /*string name = Console.ReadLine();
        int count = 0;
        int maxGoals = int.MinValue;
        string maxGoalGamerName = "";
        while (!name.Equals("END"))
        {
            count = int.Parse(Console.ReadLine());
            if (count > maxGoals)
            {
                maxGoals = count;
                maxGoalGamerName = name;
            }
            if (count >= 10)
            {
                break;
            }

            name = Console.ReadLine();
        }
        Console.WriteLine(maxGoalGamerName + " is the best player!");
        if (maxGoals >= 3)
        {
            Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
        }
        else
        {
            Console.WriteLine($"He has scored {maxGoals} goals.");
        }*/

        //06
       /* int firstNumber=int.Parse(Console.ReadLine());
        int secondNumber=int.Parse(Console.ReadLine());
        bool isEven = false;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            isEven = false;
            for(int j = i; j > 0; j /= 10)
            {
                int temp = j % 10;
                if (temp % 2 == 0)
                {
                    isEven = true;
                    break;
                }
            }
            if (!isEven)
            {
                Console.Write(i + " ");
            }        
        }*/
    }

}