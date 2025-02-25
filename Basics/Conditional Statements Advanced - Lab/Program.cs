//1
/*int day = int.Parse(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Error");
        break;
}*/

//2
/*string day=Console.ReadLine();
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        Console.WriteLine("Working day");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Error");
        break;
}*/

//3
/*string animalName=Console.ReadLine();
switch (animalName)
{
    case "dog":
        Console.WriteLine("mammal");
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}*/

//4
/*double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());
switch (gender)
{
    case 'm':
        if(age >= 16)
        {
            Console.WriteLine("Mr.");
        }
        else
        {
            Console.WriteLine("Master");
        }
        break;
    case 'f':
        if(age >= 16)
        {
            Console.WriteLine("Ms.");
        }
        else
        {
            Console.WriteLine("Miss");
        }
        break;
    default:
        Console.WriteLine("Error");
        break;
}*/

//5
/*string productName = Console.ReadLine();
string townName = Console.ReadLine();
double quantity = Double.Parse(Console.ReadLine());
double unitPrice = 0;
if (townName == "Sofia")
{
    switch (productName)
    {
        case "coffee":
            unitPrice = 0.5; break;
        case "water": unitPrice = 0.8; break;
        case "beer": unitPrice = 1.2; break;
        case "sweets": unitPrice = 1.45; break;
        case "peanuts": unitPrice = 1.6; break;
        default: Console.WriteLine("Error!"); break;
    }
}
else if (townName == "Plovdiv")
{
    switch (productName)
    {
        case "coffee":
            unitPrice = 0.4; break;
        case "water": unitPrice = 0.7; break;
        case "beer": unitPrice = 1.15; break;
        case "sweets": unitPrice = 1.35; break;
        case "peanuts": unitPrice = 1.5; break;
        default: Console.WriteLine("Error!"); break;
    }
}
else if ( townName == "Varna")
{
    switch (productName)
    {
        case "coffee": unitPrice = 0.45; break;
        case "water": unitPrice = 0.7; break;
        case "beer": unitPrice = 1.1; break;
        case "sweets": unitPrice = 1.35; break;
        case "peanuts": unitPrice = 1.55; break;
        default: Console.WriteLine("Error!"); break;
    }
}
else
{
    Console.WriteLine("Invalid town name!");
}
double totalPrice = unitPrice * quantity;
Console.WriteLine(Math.Round(totalPrice,2));*/

//6
/*int number = int.Parse(Console.ReadLine());
if(number > 100 || number< -100 || number == 0)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine("Yes");
}*/

//7
/*int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
if( hour>=10 && hour < 19)
{
    switch (day)
    {
        case "Monday":
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
        case "Saturday":
            Console.WriteLine("Open");
            break;
       //case "Sunday":
       //     Console.WriteLine("closed");
       //     break;
    }
}
else
{
    Console.WriteLine("closed");
}*/

//8
/*string day = Console.ReadLine();
int price = 0;
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        price = 12;
        break;
    case "Wednesday":
    case "Thursday":
        price = 14;
        break;
    case "Saturday":
    case "Sunday":
        price = 16;
        break;
}
Console.WriteLine(price);*/

//9
/*string productName = Console.ReadLine();
switch (productName)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
    case "grapes":
        Console.WriteLine("fruit");
        break;
    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}*/

//10
/*int number = int.Parse(Console.ReadLine());
if(number == 0 || (number >= 100 && number <= 200))
{
   // Console.WriteLine("");
}
else
{
    Console.WriteLine("invalid");
}*/

//11
/*string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = Double.Parse(Console.ReadLine());
double unitFruitPrice = 0;
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                unitFruitPrice = 2.5;
                break;
            case "apple":
                unitFruitPrice = 1.2;
                break;
            case "orange":
                unitFruitPrice = 0.85;
                break;
            case "grapefruit":
                unitFruitPrice = 1.45;
                break;
            case "kiwi":
                unitFruitPrice = 2.7;
                break;
            case "pineapple":
                unitFruitPrice = 5.5;
                break;
            case "grapes":
                unitFruitPrice = 3.85;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        Console.WriteLine(Math.Round((quantity * unitFruitPrice), 2));
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                unitFruitPrice = 2.7;
                break;
            case "apple":
                unitFruitPrice = 1.25;
                break;
            case "orange":
                unitFruitPrice = 0.90;
                break;
            case "grapefruit":
                unitFruitPrice = 1.6;
                break;
            case "kiwi":
                unitFruitPrice = 3;
                break;
            case "pineapple":
                unitFruitPrice = 5.6;
                break;
            case "grapes":
                unitFruitPrice = 4.2;
                break;
            default:
                Console.WriteLine("error");
                break;
        }
        Console.WriteLine(Math.Round((quantity * unitFruitPrice), 2));
        break;
    default:
        Console.WriteLine("error");
        break;
}*/

//12
string town= Console.ReadLine();
double sale=double.Parse(Console.ReadLine());
if(town == "Sofia")
{
    if(sale>=0 && sale <= 500)
    {
        sale = sale * 0.05;
        Console.WriteLine(Math.Round(sale, 2));
    }else if(sale>500 && sale <= 1000)
    {
        sale = sale * 0.07;
        Console.WriteLine(Math.Round(sale, 2));
    }else if(sale>1000 && sale <= 10000)
    {
        sale = sale * 0.08;
        Console.WriteLine(Math.Round(sale, 2));
    }else if (sale > 10000)
    {
        sale = sale * 0.12;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else
    {
        Console.WriteLine("error");
    }
}else if(town == "Varna")
{
    if (sale >= 0 && sale <= 500)
    {
        sale = sale * 0.045;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else if (sale > 500 && sale <= 1000)
    {
        sale = sale * 0.075;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else if (sale > 1000 && sale <= 10000)
    {
        sale = sale * 0.10;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else if (sale > 10000)
    {
        sale = sale * 0.13;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if(town == "Plovdiv")
{
    if (sale >= 0 && sale <= 500)
    {
        sale = sale * 0.055;
        Console.WriteLine(Math.Round(sale,2));
    }
    else if (sale > 500 && sale <= 1000)
    {
        sale = sale * 0.08;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else if (sale > 1000 && sale <= 10000)
    {
        sale = sale * 0.12;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else if (sale > 10000)
    {
        sale = sale * 0.145;
        Console.WriteLine(Math.Round(sale, 2));
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("Error");
}