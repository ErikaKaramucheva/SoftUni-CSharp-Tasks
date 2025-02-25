// See https://aka.ms/new-console-template for more information
//1
/*string type = Console.ReadLine();
int rows=int.Parse(Console.ReadLine());
int columns=int.Parse(Console.ReadLine());
double price = 0;
if (type == "Premiere")
{
    price = 12;
}
else if (type == "Normal")
{
    price = 7.5;
}else if(type == "Discount")
{
    price = 5;
}
double calculation = Math.Round((rows * columns * price),2);
Console.WriteLine(calculation+" leva");*/

//2
/*int degrees = int.Parse(Console.ReadLine());
string time = Console.ReadLine();
string outfit="";
string shoes="";
if (degrees >= 10 && degrees <= 18)
{
    if (time.Equals("Morning"))
    {
        outfit = "Sweathirt";
        shoes = "Sneakers";
    } else if (time.Equals("Afternoon"))
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }else if (time.Equals("Evening"))
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else
    {
        Console.WriteLine("Please, provide correct time.");
        Environment.Exit(1);
    }
}else if(degrees > 18 && degrees <= 24)
{
    if (time.Equals("Morning"))
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time.Equals("Afternoon"))
    {
        outfit = "T- Shirt";
        shoes = "Sandals";
    }
    else if (time.Equals("Evening"))
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else
    {
        Console.WriteLine("Please, provide correct time.");
        Environment.Exit(1);
    }
}else if(degrees >= 25)
{
    if (time.Equals("Morning"))
    {
        outfit = "T- Shirt";
        shoes = "Sandals";
    }
    else if (time.Equals("Afternoon"))
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (time.Equals("Evening"))
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else
    {
        Console.WriteLine("Please, provide correct time.");
        Environment.Exit(1);
    }
}
else
{
    Console.WriteLine("Please, provide correct degrees.");
    Environment.Exit(1);
}
Console.WriteLine("It's " + degrees + " degrees, get your " + outfit + " and " + shoes);
*/

//3
/*int rosePrice = 5;
double dahliaPrice = 3.8;
double tulipPrice = 2.8;
int daffodilPrice = 3;
double gladiolusPrice = 2.5;
string flowerType = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price=0;
if(flowerType == "Roses")
{
    price = flowerCount * rosePrice;
    if (flowerCount > 80)
    {
        price = price - (price * 0.1);
    }
}else if(flowerType == "Dahlias")
{
    price = flowerCount * dahliaPrice;
    if (flowerCount > 90)
    {
        price = price - (price * 0.15);
    }
}
else if(flowerType== "Tulips")
{
    price= flowerCount * tulipPrice;
    if (flowerCount > 80)
    {
        price = price - (price * 0.15);
    }
}
else if(flowerType == "Narcicuss")
{
    price=flowerCount* daffodilPrice;
    if (flowerCount > 120)
    {
        price = price + (price * 0.15);
    }
}
else if (flowerType == "Gladiolus")
{
    price=flowerCount * gladiolusPrice;
    if (flowerCount > 80)
    {
        price = price + (price * 0.2);
    }
}
else{
    Console.WriteLine("Please, provide correct flower name.");
    Environment.Exit(1);
}
if (budget >= price)
{
    Console.WriteLine("Hey, you have a great garden with " + flowerCount + " " + flowerType + " and " + (budget - price) + " leva left.");
}
else
{
    Console.WriteLine("Not enough money, you need" + (price - budget) + " leva more.");

}
*/

//4
/*int budget = int.Parse(Console.ReadLine());
string season=Console.ReadLine();
int fishmanCount=int.Parse(Console.ReadLine());
int rentPrice = 0;
double discount = 0;
if (season == "Spring")
{
    rentPrice = 3000;
}
else if (season == "Summer" || season == "Autumn")
{
    rentPrice = 4200;
}
else if (season == "Winter")
{
    rentPrice = 2600;
}
else
{
    Console.WriteLine("Invalid season data.");
    Environment.Exit(1);
}
if (fishmanCount <= 6)
{
    discount = rentPrice * 0.1;
}else if(fishmanCount >= 7 && fishmanCount <= 11)
{
    discount=rentPrice * 0.15;
}else
{
    discount = rentPrice * 0.25;
}
double finalPrice=rentPrice-discount;
if((fishmanCount%2==0) && (!season.Equals("Autumn")))
{
    finalPrice -= (finalPrice * 0.05);
}
if (budget > finalPrice)
{
    Console.WriteLine("Yes! You have " + (budget - finalPrice) + " leva left");
}
else
{
    Console.WriteLine("Not enough money! You need " + (finalPrice-budget) + " leva.");
}*/

//5
/*double budget = Double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string restType = "";
double amountSpent = 0;
if (budget <= 100)
{
    destination = "Bulgaria";
    if (season == "Summer")
    {
        amountSpent = budget * 0.3;
    }else if(season == "Winter")
    {
        amountSpent = budget * 0.7;
    }
    else
    {
        Console.WriteLine("Invalid season data.");
        Environment.Exit(1);
    }
}else if (budget >100 && budget <= 1000)
{
    destination = "Balkans";
    if (season == "Summer")
    {
        amountSpent = budget * 0.4;
    }
    else if (season == "Winter")
    {
        amountSpent = budget * 0.8;
    }
    else
    {
        Console.WriteLine("Invalid season data.");
        Environment.Exit(1);
    }
}
else
{
    destination = "Europe";
    amountSpent = 0.9 * budget;
}

if(season == "Summer")
{
    restType = "Camp";
}
else
{
    restType = "Hotel";
}
Console.WriteLine("Somewhere in " +  destination);
Console.WriteLine(restType + " - " +  Math.Round(amountSpent,2));
*/

//6
/*int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
char op = Char.Parse(Console.ReadLine());
double result = 0;
switch (op)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.Write(firstNumber +" + "+secondNumber+" = "+result);
        checkIfEven(result);
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.Write(firstNumber + " - " + secondNumber + " = " + result);
        checkIfEven(result);
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.Write(firstNumber + " * " + secondNumber + " = " + result);
        checkIfEven(result);
        break;
    case '/':
        if(secondNumber == 0)
        {
            Console.WriteLine("Cannot divide " + firstNumber + " by zero");
        }
        else
        {
            result=(double)firstNumber/(double)secondNumber;
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + Math.Round(result,2));
        }
        break;
    case '%':
        if (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide " + firstNumber + " by zero");
        }
        else
        {
            result = firstNumber % secondNumber;
            Console.WriteLine(firstNumber + " % " + secondNumber + " = " + result);
        }
        break;
}

static void checkIfEven (double num)
{
    if (num % 2 == 0)
    {
        Console.Write(" - even");
    }
    else
    {
        Console.Write(" - odd");
    }
}
*/

//7
/*string month = Console.ReadLine();
int num = int.Parse(Console.ReadLine());
double totalPriceForApartment = 0;
double totalPriceForStudio = 0;
if(month == "May" ||  month == "October")
{
    totalPriceForApartment = num * 65;
    totalPriceForStudio = num * 50;
    if(num > 7 && num<=14)
    {
        totalPriceForStudio -= (0.05 * totalPriceForStudio);
    }else if(num > 14)
    {
        totalPriceForStudio-=(0.3* totalPriceForStudio);
        totalPriceForApartment -= (0.1 * totalPriceForApartment);
    }
}else if( month == "June" || month == "September")
{
    totalPriceForApartment = num * 68.7;
    totalPriceForStudio = num * 75.2;
    if (num > 14)
    {
        totalPriceForStudio -= (0.2 * totalPriceForStudio);
        totalPriceForApartment -= (0.1 * totalPriceForApartment);
    }
}
else if( month == "July" || month== "August")
{
    totalPriceForApartment = num * 77;
    totalPriceForStudio = num * 76;
    if (num > 14)
    {
        totalPriceForApartment -= (0.1 * totalPriceForApartment);
    }
}
else
{
    Console.WriteLine("Invalid month.");
    Environment.Exit(0);
}
Console.WriteLine("Apartment: " + Math.Round(totalPriceForApartment,2) + " lv.");
Console.WriteLine("Studio: " + Math.Round(totalPriceForStudio,2) + " lv.");
*/

//8 -недовършена
int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinute = int.Parse(Console.ReadLine());
while ((examHour<0 || examHour>23) ||(examMinute<0 || examMinute>59)
    || (arrivalHour<0 || arrivalHour>23) || (arrivalMinute<0 || arrivalMinute > 59))
{
    Console.WriteLine("Invalid data. Please, provide correct time.");
    examHour = int.Parse(Console.ReadLine());
    examMinute = int.Parse(Console.ReadLine());
    arrivalHour = int.Parse(Console.ReadLine());
    arrivalMinute = int.Parse(Console.ReadLine());
}

if((arrivalHour>examHour) && (arrivalMinute > examMinute))
{
    Console.WriteLine("Late");
    int minuteDif = arrivalMinute - examMinute;
    if (arrivalHour > examHour)
    {
        int hourDif = (arrivalHour - examHour);
        if (minuteDif < 10)
        {
            Console.WriteLine(hourDif + ":0" + minuteDif + " hours after the start");
        }
        else
        {
            Console.WriteLine(hourDif + ":" + minuteDif + " hours after the start");
        }
    }
    else
    {
        Console.WriteLine(minuteDif + " minutes after the start");
    }
}else if((arrivalHour == examHour)  && (arrivalMinute == examMinute) )
{
    Console.WriteLine("On time");
}else if ((examMinute - arrivalMinute < 0) && ((examHour+1) == arrivalHour))
{
    Console.WriteLine("On time");
}
else
{
    Console.WriteLine("Early");
    int minuteDif = arrivalMinute - examMinute;
    if (examHour > arrivalHour)
    {
        int hourDif = (examHour - arrivalHour);
        if (minuteDif < 10)
        {
            Console.WriteLine(hourDif + ":0" + minuteDif + " hours before the start");
        }
        else
        {
            Console.WriteLine(hourDif + ":" + minuteDif + " hours before the start");
        }
    }
    else
    {
        Console.WriteLine(minuteDif + " minutes before the start");
    }
}


//9
/*int days = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string review = Console.ReadLine();
double price = 0;
days -= 1;
if(type == "room for one person")
{
    price = days * 18;
}else if( type == "apartment")
{
    price = days * 25;
    if (days < 10){
        price -= (0.3 * price);
    }else if(days>=10 && days < 15)
    {
        price -= (0.35 * price);
    }
    else
    {
        price-=(0.5*price);
    }
}else if(type == "president apartment")
{
    price = days * 35;
    if (days < 10)
    {
        price -= (0.1 * price);
    }
    else if (days >= 10 && days < 15)
    {
        price -= (0.15 * price);
    }
    else
    {
        price -= (0.2 * price);
    }
}
else
{
    Console.WriteLine("Invalid room type");
    Environment.Exit(0);
}
if(review == "positive")
{
    price += (0.25 * price);
}else if(review == "negative")
{
    price -= (0.1 * price);
}
else
{
    Console.WriteLine("Invalid review.");
    Environment.Exit(0);
}
Console.WriteLine(Math.Round(price, 2));*/