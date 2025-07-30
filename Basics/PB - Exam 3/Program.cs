//01. Easter Bakery
/*double flourPricePerKg = double.Parse(Console.ReadLine());
double flourKg = double.Parse(Console.ReadLine());
double sugarKg= double.Parse(Console.ReadLine());
int eggs=int.Parse(Console.ReadLine());
int yeast=int.Parse(Console.ReadLine());

double sugarPricePerKg = flourPricePerKg - (flourPricePerKg * 0.25);
double eggsPrice = flourPricePerKg + (flourPricePerKg * 0.1);
double yeastPrice = sugarPricePerKg - (sugarPricePerKg * 0.8);

double totalPrice = (flourPricePerKg * flourKg) + (sugarPricePerKg * sugarKg) + (eggs * eggsPrice) + (yeastPrice * yeast);
Console.WriteLine(Math.Round(totalPrice,2));*/

//01. Easter Lunch
/*double easterCakePrice = 3.2;
double eggsPrice = 4.35;
double biscuitsPrice = 5.4;
double eggDyePrice = 0.15;

int easterCakeCounts= int.Parse(Console.ReadLine());
int eggs = int.Parse(Console.ReadLine());
int biscuitsInKg= int.Parse(Console.ReadLine());

double total = (easterCakeCounts * easterCakePrice) + (eggs * eggsPrice) + (biscuitsInKg * biscuitsPrice) + (eggs * 12 * eggDyePrice);
Console.WriteLine(Math.Round(total, 2));*/

//02. Easter Party
/*int guestsCount = int.Parse(Console.ReadLine());
double couvert = double.Parse(Console.ReadLine());
double budget= double.Parse(Console.ReadLine());
double cake = 0.1 * budget;
if(guestsCount>=10 && guestsCount <= 15)
{
   couvert=couvert-(couvert* 0.15);
}else if (guestsCount>15 && guestsCount<=20)
{
    couvert-=(couvert* 0.2);
}else if (guestsCount > 20)
{
   couvert-=(couvert*0.25);
}

double total = cake + (guestsCount * couvert);
if (budget >= total)
{
    Console.WriteLine($"It is party time! {Math.Round((budget - total), 2)} leva left.");
}
else
{
    Console.WriteLine($"No party! {Math.Round((total - budget), 2)} leva needed.");
}*/

//02. Easter Guests
/*int priceForOneEasterCake = 4;
double oneEggPrice = 0.45;

int guestsCount=int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

int neededEasterCake = (int)Math.Ceiling((double)guestsCount / 3);
int neededEggs = guestsCount * 2;

double neededMoney = (neededEasterCake * priceForOneEasterCake) + (neededEggs * oneEggPrice);
if (neededMoney <= budget)
{
    Console.WriteLine($"Lyubo bought {neededEasterCake} Easter bread and {neededEggs} eggs.");
    Console.WriteLine($"He has {Math.Round(budget-neededMoney,2)} lv. left.");
}
else
{
    Console.WriteLine("Lyubo doesn't have enough money.");
    Console.WriteLine($"He needs {Math.Round(neededMoney - budget, 2)} lv. more.");
}*/

//03. Easter Trip
/*string destination = Console.ReadLine();
string date = Console.ReadLine();
int nightCount=int.Parse(Console.ReadLine());
int priceForOneNight = 0;
if (destination.Equals("France"))
{
    if (date.Equals("21-23"))
    {
        priceForOneNight = 30;
    }
    else if (date.Equals("24-27"))
    {
        priceForOneNight = 35;
    }
    else{
        priceForOneNight = 40;
    }
}else if (destination.Equals("Italy"))
{
    if (date.Equals("21-23"))
    {
        priceForOneNight = 28;
    }
    else if (date.Equals("24-27"))
    {
        priceForOneNight = 32;
    }
    else
    {
        priceForOneNight = 39;
    }
}
else
{
    if (date.Equals("21-23"))
    {
        priceForOneNight = 32;
    }
    else if (date.Equals("24-27"))
    {
        priceForOneNight = 37;
    }
    else
    {
        priceForOneNight = 43;
    }
}

double total = priceForOneNight * nightCount;
Console.WriteLine($"Easter trip to {destination} : {Math.Round(total, 2)} leva.");*/

//03. Painting Eggs
/*string eggSize = Console.ReadLine();
string eggColor = Console.ReadLine();
int batch = int.Parse(Console.ReadLine());
int price = 0;

switch (eggSize)
{
    case "Large":
        switch (eggColor)
        {
            case "Red": price = 16; break;
            case "Green": price = 12; break;
            default: price = 9;break;
        }
        break;
    case "Medium":
        switch (eggColor)
        {
            case "Red": price = 13; break;
            case "Green": price = 9; break;
            default: price = 7; break;
        }
        break;
    default:
        switch (eggColor)
        {
            case "Red": price = 9; break;
            case "Green": price = 8; break;
            default: price = 5; break;
        }
        break;
}
double sum=batch*price;
double total = sum - (0.35 * sum);
Console.WriteLine($"{Math.Round(total, 2)} leva.");*/

//04. Easter Eggs Battle
/*int firstEggs=int.Parse(Console.ReadLine());
int secondEggs= int.Parse(Console.ReadLine());
string command=Console.ReadLine();
while (!command.Equals("End"))
{
    if (command.Equals("one"))
    {
        secondEggs--;
    }
    else
    {
        firstEggs--;
    }

    if (firstEggs == 0)
    {
        Console.WriteLine($"Player one is out of eggs. Player two has {secondEggs} eggs left.");
        return;
    }
    else if (secondEggs == 0)
    {
        Console.WriteLine($"Player two is out of eggs. Player one has {firstEggs} eggs left.");
        return;

    }


    command = Console.ReadLine();
}
Console.WriteLine($"Player one has {firstEggs} eggs left.");
Console.WriteLine($"Player two has {secondEggs} eggs left.");*/

//04. Easter Shop
/*int initialEggsCount=int.Parse(Console.ReadLine());
string command=Console.ReadLine();
int currentCount;
int sold = 0;
while (!command.Equals("Close"))
{
    currentCount=int.Parse(Console.ReadLine());
    if (command.Equals("Buy"))
    {
        if (currentCount > initialEggsCount)
        {
            Console.WriteLine("Not enough eggs in store!");
            Console.WriteLine($"You can buy only {initialEggsCount}.");
            return;
        }
        initialEggsCount -= currentCount;
        sold += currentCount;
    }
    else
    {
        initialEggsCount += currentCount;
    }
    command = Console.ReadLine();
}
Console.WriteLine("Store is closed!");
Console.WriteLine($"{sold} eggs sold.");*/

//05. Easter Bake
/*int count=int.Parse(Console.ReadLine());
int neededSugar = 0;
int neededFlour = 0;
int maxSugar=int.MinValue;
int maxFlour=int.MinValue;
for(int i=0; i<count; i++)
{
    int currentNeededSugar= int.Parse(Console.ReadLine());
    int currentNeededFlour= int.Parse(Console.ReadLine());
    neededFlour += currentNeededFlour;
    neededSugar += currentNeededSugar;
    if(currentNeededSugar > maxSugar)
    {
        maxSugar = currentNeededSugar;
    }
    if (currentNeededFlour > maxFlour)
    {
        maxFlour = currentNeededFlour;
    }
}
int sugarPackages =(int) Math.Ceiling((double)neededSugar / 950);
int flourPackages = (int)Math.Ceiling((double)neededFlour / 750);
Console.WriteLine($"Sugar: {sugarPackages}");
Console.WriteLine($"Flour: {flourPackages}");
Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");*/

//05. Easter Eggs
/*int eggsCount=int.Parse(Console.ReadLine());
int redEggsCount = 0;
int orangeEggsCount = 0;
int blueEggsCount = 0;
int greenEggsCount = 0;
for(int i = 0; i < eggsCount; i++)
{
    string color=Console.ReadLine();
    switch (color)
    {
        case "red": redEggsCount++; break;
        case "orange": orangeEggsCount++; break;
        case "blue": blueEggsCount++; break;
            default: greenEggsCount++; break;
    }
}
Console.WriteLine($"Red eggs: {redEggsCount}");
Console.WriteLine($"Orange eggs: {orangeEggsCount}");
Console.WriteLine($"Blue eggs: {blueEggsCount}");
Console.WriteLine($"Green eggs: {greenEggsCount}");
if(redEggsCount>orangeEggsCount && redEggsCount>blueEggsCount && redEggsCount > greenEggsCount)
{
    Console.WriteLine($"Max eggs: {redEggsCount} -> red");
} else if( orangeEggsCount>redEggsCount && orangeEggsCount > blueEggsCount && orangeEggsCount > greenEggsCount)
{
    Console.WriteLine($"Max eggs: {orangeEggsCount} -> orange");
} else if(blueEggsCount>redEggsCount&& blueEggsCount>orangeEggsCount && blueEggsCount > greenEggsCount)
{
    Console.WriteLine($"Max eggs: {blueEggsCount} -> blue");
}
else
{
    Console.WriteLine($"Max eggs: {greenEggsCount} -> green");
}*/

//06. Easter Competition
/*int cakeCount=int.Parse(Console.ReadLine());
string bestBaker = "";
int maxPoints=int.MinValue;
for(int i = 0; i < cakeCount; i++)
{
    string baker=Console.ReadLine();
    string command=Console.ReadLine();
    int totalPoints = 0;
    while (!command.Equals("Stop"))
    {
        totalPoints += int.Parse(command);
        command = Console.ReadLine();
    }
    Console.WriteLine(baker+" has "+totalPoints+" points.");
    if (totalPoints > maxPoints)
    {
        bestBaker = baker;
        maxPoints = totalPoints;
        Console.WriteLine($"{baker} is the new number 1!");
    }
}

Console.WriteLine($"{bestBaker} won competition with {maxPoints} points!");*/

//06. Easter Decoration
int clients= int.Parse(Console.ReadLine());
int purchases = 0;
double total = 0;
for (int i = 0; i < clients; i++)
{
    int currentPurchasesCount = 0;
    double currentBill = 0;
    string command = Console.ReadLine();
    while (!command.Equals("Finish"))
    {
        currentPurchasesCount++;
        if (command.Equals("basket"))
        {
            currentBill += 1.5;
        }else if (command.Equals("wreath"))
        {
            currentBill += 3.8;
        }
        else
        {
            currentBill += 7;
        }
        command = Console.ReadLine();
    }
    if (currentPurchasesCount % 2 == 0)
    {
        currentBill = currentBill - (currentBill * 0.2);
    }
    Console.WriteLine($"You purchased {currentPurchasesCount} items for {Math.Round(currentBill, 2)} leva.");
    total += currentBill;

}
Console.WriteLine($"Average bill per client is: {Math.Round(total / clients, 2)} leva.");


