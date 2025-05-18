<<<<<<< HEAD
﻿//1
/*double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

double transportFee = 0;
if (people >= 1 && people <= 4)
{
    transportFee = budget * 0.75;
}
else if (people >= 5 && people <= 9)
{
    transportFee = budget * 0.6;
}
else if (people >= 10 && people <= 24)
{
    transportFee = budget * 0.5;
}
else if (people >= 25 && people <= 49)
{
    transportFee = budget * 0.4;
}
else 
{
    transportFee = budget * 0.25;
}

double budgetAfterTransportFee = budget - transportFee;
Console.WriteLine(budgetAfterTransportFee);
double neededMoneyForTickets = 0;
if (category.Equals("VIP"))
{
    neededMoneyForTickets = people * 499.99;
}
else
{
    neededMoneyForTickets = people * 249.99;
}

Console.WriteLine(neededMoneyForTickets);
if (neededMoneyForTickets >= budgetAfterTransportFee)
{
    Console.WriteLine("Not enough money! you need " +Math.Round(neededMoneyForTickets - budgetAfterTransportFee,2)+" leva.");
}
else
{
    Console.WriteLine($"Yes! You have {Math.Round(budgetAfterTransportFee - neededMoneyForTickets,2)} leva left.");
}*/

//2
/*int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string trace = Console.ReadLine();

double totalFee = 0;
switch (trace)
{
    case "trail":
        totalFee = (juniors * 5.5) + (seniors * 7);
        break;
    case "cross-country":
        totalFee = (juniors * 8) + (seniors * 9.5);
        if (juniors + seniors >= 50)
        {
            totalFee = totalFee - (totalFee * 0.25);
        }
        break;
    case "downhill":
        totalFee = (juniors * 12.25) + (seniors * 13.75);
        break;
    case "road":
        totalFee = (juniors * 20) + (seniors * 21.5);
        break;
}

totalFee = totalFee - (totalFee * 0.05);
Console.WriteLine(Math.Round(totalFee, 2));*/

//3
/*int chrysantemumCount = int.Parse(Console.ReadLine());
int roseCount = int.Parse(Console.ReadLine());
int tulipCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string isHoliday = Console.ReadLine();

double chrysantemumPrice = 0;
double rosePrice = 0;
double tulipPrice = 0;

switch (season) {
    case "Spring":
    case "Summer":
        chrysantemumPrice = 2;
        rosePrice = 4.1;
        tulipPrice = 2.5;
        break;
    case "Autumn":
    case "Winter":
        chrysantemumPrice = 3.75;
        rosePrice = 4.5;
        tulipPrice = 4.15;
        break;
}

double totalPrice = (chrysantemumCount*chrysantemumPrice) + (rosePrice*roseCount)+(tulipPrice*tulipCount);

if (isHoliday.Equals("Y"))
{
    totalPrice += totalPrice * 0.15;
}
if (season.Equals("Spring") && tulipCount > 7)
{
    totalPrice -= totalPrice * 0.05;
}
if(season.Equals("Winter") && roseCount >= 10)
{
    totalPrice -= totalPrice * 0.1;
}
if((tulipCount+roseCount+chrysantemumCount) > 20)
{
    totalPrice -= totalPrice * 0.2;
}

Console.WriteLine(Math.Round(totalPrice+2, 2));*/

//4
/*double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string carClass = "";
string carType = "";
double price = 0;
if (budget <= 100)
{
    carClass = "Economy class";
    if (season.Equals("Summer"))
    {
        carType = "Cabrio";
        price = budget * 0.35;
    }
    else
    {
        carType = "Jeep";
        price = budget * 0.65;
    }
}
else if (budget > 100 && budget <= 500)
{
    carClass = "Compact class";
    if (season.Equals("Summer"))
    {
        carType = "Cabrio";
        price = budget * 0.45;
    }
    else
    {
        carType = "Jeep";
        price = budget * 0.8;
    }
}
else
{
    carClass = "Luxury class";
    carType = "Jeep";
    price = budget * 0.9;

}

Console.WriteLine(carClass);
Console.WriteLine(carType + " - " + Math.Round(price, 2));*/

//5
/*double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string location = "";
string place = "";
double neededMoney = 0;
if (budget <= 1000)
{
    place = "Camp";
    if (season.Equals("summer"))
    {
        location = "Alaska";
        neededMoney = budget * 0.65;
    }
    else
    {
        location = "Morocco";
        neededMoney = budget * 0.45;
    }
}else if(budget>=1000 && budget <= 3000)
{
    place = "Hut";
    if (season.Equals("summer"))
    {
        location = "Alaska";
        neededMoney = budget * 0.8;
    }
    else
    {
        location = "Morocco";
        neededMoney = budget * 0.6;
    }
}
else
{
    place = "Hotel";
    if (season.Equals("summer"))
    {
        location = "Alaska";
    }
    else
    {
        location = "Morocco";
    }

    neededMoney = budget * 0.9;
}

Console.WriteLine($"{location} - {place} - {Math.Round(neededMoney,2)}");*/

//6
/*string season = Console.ReadLine();
double kilometersPerMonth = double.Parse(Console.ReadLine());

double pricePerKm = 0;
if (kilometersPerMonth <= 5000)
{
    switch (season) {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.75; break;
        case "Summer":
            pricePerKm = 0.9; break;
        case "Winter":
            pricePerKm = 1.05; break;
    }

}
else if(kilometersPerMonth >5000 && kilometersPerMonth <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.95; break;
        case "Summer":
            pricePerKm = 1.1; break;
        case "Winter":
            pricePerKm = 1.25; break;
    }
}
else if(kilometersPerMonth >10000 && kilometersPerMonth <= 20000)
{
    pricePerKm = 1.45;
}


double salary = (pricePerKm * kilometersPerMonth) * 4;
salary -= salary * 0.1;
Console.WriteLine(Math.Round(salary,2));*/

//7
/*string season = Console.ReadLine();
string groupType = Console.ReadLine();
int studentsCount = int.Parse(Console.ReadLine());
int nightCount = int.Parse(Console.ReadLine());
string sport = "";
double pricePerNight = 0;
if (season.Equals("Winter"))
{
    switch (groupType)
    {
        case "boys":
            sport = "Judo";
            pricePerNight = 9.6; break;
        case "girls":
            sport = "Gymnastics";
            pricePerNight = 9.6; break;
        case "mixed":
            sport = "Ski";
            pricePerNight = 10; break;
    }
}else if (season.Equals("Spring"))
{
    switch (groupType)
    {
        case "boys":
            sport = "Tennis";
            pricePerNight = 7.2; break;
        case "girls":
            sport = "Athletics"; 
            pricePerNight = 7.2; break;
        case "mixed":
            sport = "Cycling";
            pricePerNight = 9.5; break;
    }
}
else
{
    switch (groupType)
    {
        case "boys":
            sport = "Football";
            pricePerNight = 15; break;
        case "girls":
            sport = "Volleyball";
            pricePerNight = 15; break;
        case "mixed":
            sport = "Swimming";
            pricePerNight = 20; break;
    }
}
double totalPrice = pricePerNight*nightCount*studentsCount;
if(studentsCount>=10 && studentsCount < 20)
{
    totalPrice -= totalPrice * 0.05;
}else if(studentsCount>=20 && studentsCount < 50)
{
    totalPrice -= totalPrice * 0.15;
}else if(studentsCount >= 50)
{
    totalPrice -= totalPrice * 0.5;
}

Console.WriteLine($"{sport} {Math.Round(totalPrice, 2)} lv.");*/

//8
/*double x1 =double.Parse(Console.ReadLine());
double y1 =double.Parse(Console.ReadLine());
double x2 =double.Parse(Console.ReadLine());
double y2 =double.Parse(Console.ReadLine());
double x =double.Parse(Console.ReadLine());
double y =double.Parse(Console.ReadLine());
if(((x==x1 || x==x2) && (y==y1 || y == y2)) ||
    ((x == x1 || x == x2) && (y > y1 && y < y2)) ||
    ((x > x1 && x < x2) && (y == y1 || y == y2))
    )
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside/Outside");
}*/

//9
/*int i = 1;
do
{
    Console.WriteLine(i);
    i++;

} while (i < 11);*/

//10
double number =double.Parse(Console.ReadLine());
while (number > 0)
{
   Console.WriteLine("Result: " + Math.Round((number*2),2));
    number = double.Parse(Console.ReadLine());
}
Console.WriteLine("Negative number!");

=======
﻿//1
/*double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int people = int.Parse(Console.ReadLine());

double transportFee = 0;
if (people >= 1 && people <= 4)
{
    transportFee = budget * 0.75;
}
else if (people >= 5 && people <= 9)
{
    transportFee = budget * 0.6;
}
else if (people >= 10 && people <= 24)
{
    transportFee = budget * 0.5;
}
else if (people >= 25 && people <= 49)
{
    transportFee = budget * 0.4;
}
else 
{
    transportFee = budget * 0.25;
}

double budgetAfterTransportFee = budget - transportFee;
Console.WriteLine(budgetAfterTransportFee);
double neededMoneyForTickets = 0;
if (category.Equals("VIP"))
{
    neededMoneyForTickets = people * 499.99;
}
else
{
    neededMoneyForTickets = people * 249.99;
}

Console.WriteLine(neededMoneyForTickets);
if (neededMoneyForTickets >= budgetAfterTransportFee)
{
    Console.WriteLine("Not enough money! you need " +Math.Round(neededMoneyForTickets - budgetAfterTransportFee,2)+" leva.");
}
else
{
    Console.WriteLine($"Yes! You have {Math.Round(budgetAfterTransportFee - neededMoneyForTickets,2)} leva left.");
}*/

//2
/*int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string trace = Console.ReadLine();

double totalFee = 0;
switch (trace)
{
    case "trail":
        totalFee = (juniors * 5.5) + (seniors * 7);
        break;
    case "cross-country":
        totalFee = (juniors * 8) + (seniors * 9.5);
        if (juniors + seniors >= 50)
        {
            totalFee = totalFee - (totalFee * 0.25);
        }
        break;
    case "downhill":
        totalFee = (juniors * 12.25) + (seniors * 13.75);
        break;
    case "road":
        totalFee = (juniors * 20) + (seniors * 21.5);
        break;
}

totalFee = totalFee - (totalFee * 0.05);
Console.WriteLine(Math.Round(totalFee, 2));*/

//3
/*int chrysantemumCount = int.Parse(Console.ReadLine());
int roseCount = int.Parse(Console.ReadLine());
int tulipCount = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string isHoliday = Console.ReadLine();

double chrysantemumPrice = 0;
double rosePrice = 0;
double tulipPrice = 0;

switch (season) {
    case "Spring":
    case "Summer":
        chrysantemumPrice = 2;
        rosePrice = 4.1;
        tulipPrice = 2.5;
        break;
    case "Autumn":
    case "Winter":
        chrysantemumPrice = 3.75;
        rosePrice = 4.5;
        tulipPrice = 4.15;
        break;
}

double totalPrice = (chrysantemumCount*chrysantemumPrice) + (rosePrice*roseCount)+(tulipPrice*tulipCount);

if (isHoliday.Equals("Y"))
{
    totalPrice += totalPrice * 0.15;
}
if (season.Equals("Spring") && tulipCount > 7)
{
    totalPrice -= totalPrice * 0.05;
}
if(season.Equals("Winter") && roseCount >= 10)
{
    totalPrice -= totalPrice * 0.1;
}
if((tulipCount+roseCount+chrysantemumCount) > 20)
{
    totalPrice -= totalPrice * 0.2;
}

Console.WriteLine(Math.Round(totalPrice+2, 2));*/

//4
/*double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string carClass = "";
string carType = "";
double price = 0;
if (budget <= 100)
{
    carClass = "Economy class";
    if (season.Equals("Summer"))
    {
        carType = "Cabrio";
        price = budget * 0.35;
    }
    else
    {
        carType = "Jeep";
        price = budget * 0.65;
    }
}
else if (budget > 100 && budget <= 500)
{
    carClass = "Compact class";
    if (season.Equals("Summer"))
    {
        carType = "Cabrio";
        price = budget * 0.45;
    }
    else
    {
        carType = "Jeep";
        price = budget * 0.8;
    }
}
else
{
    carClass = "Luxury class";
    carType = "Jeep";
    price = budget * 0.9;

}

Console.WriteLine(carClass);
Console.WriteLine(carType + " - " + Math.Round(price, 2));*/

//5
/*double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string location = "";
string place = "";
double neededMoney = 0;
if (budget <= 1000)
{
    place = "Camp";
    if (season.Equals("summer"))
    {
        location = "Alaska";
        neededMoney = budget * 0.65;
    }
    else
    {
        location = "Morocco";
        neededMoney = budget * 0.45;
    }
}else if(budget>=1000 && budget <= 3000)
{
    place = "Hut";
    if (season.Equals("summer"))
    {
        location = "Alaska";
        neededMoney = budget * 0.8;
    }
    else
    {
        location = "Morocco";
        neededMoney = budget * 0.6;
    }
}
else
{
    place = "Hotel";
    if (season.Equals("summer"))
    {
        location = "Alaska";
    }
    else
    {
        location = "Morocco";
    }

    neededMoney = budget * 0.9;
}

Console.WriteLine($"{location} - {place} - {Math.Round(neededMoney,2)}");*/

//6
/*string season = Console.ReadLine();
double kilometersPerMonth = double.Parse(Console.ReadLine());

double pricePerKm = 0;
if (kilometersPerMonth <= 5000)
{
    switch (season) {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.75; break;
        case "Summer":
            pricePerKm = 0.9; break;
        case "Winter":
            pricePerKm = 1.05; break;
    }

}
else if(kilometersPerMonth >5000 && kilometersPerMonth <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            pricePerKm = 0.95; break;
        case "Summer":
            pricePerKm = 1.1; break;
        case "Winter":
            pricePerKm = 1.25; break;
    }
}
else if(kilometersPerMonth >10000 && kilometersPerMonth <= 20000)
{
    pricePerKm = 1.45;
}


double salary = (pricePerKm * kilometersPerMonth) * 4;
salary -= salary * 0.1;
Console.WriteLine(Math.Round(salary,2));*/

//7
/*string season = Console.ReadLine();
string groupType = Console.ReadLine();
int studentsCount = int.Parse(Console.ReadLine());
int nightCount = int.Parse(Console.ReadLine());
string sport = "";
double pricePerNight = 0;
if (season.Equals("Winter"))
{
    switch (groupType)
    {
        case "boys":
            sport = "Judo";
            pricePerNight = 9.6; break;
        case "girls":
            sport = "Gymnastics";
            pricePerNight = 9.6; break;
        case "mixed":
            sport = "Ski";
            pricePerNight = 10; break;
    }
}else if (season.Equals("Spring"))
{
    switch (groupType)
    {
        case "boys":
            sport = "Tennis";
            pricePerNight = 7.2; break;
        case "girls":
            sport = "Athletics"; 
            pricePerNight = 7.2; break;
        case "mixed":
            sport = "Cycling";
            pricePerNight = 9.5; break;
    }
}
else
{
    switch (groupType)
    {
        case "boys":
            sport = "Football";
            pricePerNight = 15; break;
        case "girls":
            sport = "Volleyball";
            pricePerNight = 15; break;
        case "mixed":
            sport = "Swimming";
            pricePerNight = 20; break;
    }
}
double totalPrice = pricePerNight*nightCount*studentsCount;
if(studentsCount>=10 && studentsCount < 20)
{
    totalPrice -= totalPrice * 0.05;
}else if(studentsCount>=20 && studentsCount < 50)
{
    totalPrice -= totalPrice * 0.15;
}else if(studentsCount >= 50)
{
    totalPrice -= totalPrice * 0.5;
}

Console.WriteLine($"{sport} {Math.Round(totalPrice, 2)} lv.");*/

//8
/*double x1 =double.Parse(Console.ReadLine());
double y1 =double.Parse(Console.ReadLine());
double x2 =double.Parse(Console.ReadLine());
double y2 =double.Parse(Console.ReadLine());
double x =double.Parse(Console.ReadLine());
double y =double.Parse(Console.ReadLine());
if(((x==x1 || x==x2) && (y==y1 || y == y2)) ||
    ((x == x1 || x == x2) && (y > y1 && y < y2)) ||
    ((x > x1 && x < x2) && (y == y1 || y == y2))
    )
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside/Outside");
}*/

//9
/*int i = 1;
do
{
    Console.WriteLine(i);
    i++;

} while (i < 11);*/

//10
double number =double.Parse(Console.ReadLine());
while (number > 0)
{
   Console.WriteLine("Result: " + Math.Round((number*2),2));
    number = double.Parse(Console.ReadLine());
}
Console.WriteLine("Negative number!");

>>>>>>> 13545cc (Add solutions for "PB More Exercises" module)
