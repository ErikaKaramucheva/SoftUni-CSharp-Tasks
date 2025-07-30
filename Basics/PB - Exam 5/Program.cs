//01 - Pool Day
/*int people = int.Parse(Console.ReadLine());
double tax = double.Parse(Console.ReadLine());
double deckchairPrice= double.Parse(Console.ReadLine());
double umbrellaPrice = double.Parse(Console.ReadLine());
int peopleForUmbrella = (int) Math.Ceiling((double)people / 2);
Console.WriteLine(peopleForUmbrella);
int totalDeckchair=(int)Math.Round(people* 0.75);
Console.WriteLine(totalDeckchair);
double totalPrice = (people * tax) + (peopleForUmbrella*umbrellaPrice) +( totalDeckchair*deckchairPrice);
Console.WriteLine(Math.Round(totalPrice,2)+" lv."); */

//02 - Family Trip
/*double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double unitPricePerNight = double.Parse(Console.ReadLine());
int percentForOtherCosts = int.Parse(Console.ReadLine());
if (nights > 7)
{
    unitPricePerNight -= unitPricePerNight * 0.05;
}
double neededMoney = (unitPricePerNight*nights)+(budget*percentForOtherCosts/100); ;
if(neededMoney > budget)
{
    Console.WriteLine(Math.Round((neededMoney - budget), 2)+" leva needed.");
}
else
{
    Console.WriteLine($"Ivanovi will be left with {Math.Round(budget - neededMoney, 2)} leva after vacation.");
}*/

//03 - Coffee Machine
/*string drink = Console.ReadLine();
string sugar = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
double priceForOne = 0;
bool isWithoutSugar = false;
bool isEspressoAbove5 = false;
switch (drink)
{
    case "Espresso":
        switch (sugar)
        {
            case "Without": priceForOne = 0.9; isWithoutSugar = true; break;
            case "Normal": priceForOne = 1; break;
            default: priceForOne = 1.2;break;
        }
        if (count >= 5)
        {
            isEspressoAbove5 = true;
        }
        break;
    case "Cappuccino":
        switch (sugar)
        {
            case "Without": priceForOne = 1; isWithoutSugar = true; break;
            case "Normal": priceForOne = 1.2; break;
            default: priceForOne = 1.6; break;
        }
        break;
    default:
        switch (sugar)
        {
            case "Without": priceForOne = 0.5; isWithoutSugar = true; break;
            case "Normal": priceForOne = 0.6; break;
            default: priceForOne = 0.7; break;
        }
        break;

}
double price = priceForOne * count;
if (isWithoutSugar)
{
    price -= price * 0.35;
}
if (isEspressoAbove5)
{
    price -= price * 0.25;
}
if (price > 15)
{
    price -= price * 0.2;
}
Console.WriteLine($"You bought {count} cups of {drink} for {Math.Round(price, 2)} lv.");*/

//03 - Travel Agency
/*string city = Console.ReadLine();
string type = Console.ReadLine();
string vipDiscount = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
if (days < 1)
{
    Console.WriteLine("Days must be positive number!");
    return;
}
if ((!city.Equals("Bansko") && !city.Equals("Borovets")
    && !city.Equals("Varna") && !city.Equals("Burgas"))
    ||( !type.Equals("noEquipment") && !type.Equals("withEquipment")
    && !type.Equals("noBreakfast") && !type.Equals("withBreakfast")))
{
    Console.WriteLine("Invalid input"); return;
}
int pricePerDay = 0;
double percent = 0;
switch (city)
{
    case "Bansko":
    case "Borovets":
        if (type.Equals("withEquipment"))
        {
            pricePerDay = 100;
            percent = 10; break;
        }
        else if (type.Equals("noEquipment"))
        {
            pricePerDay = 80;
            percent = 5; break;
        }
        break;
    case "Varna":
    case "Burgas":
        if (type.Equals("withBreakfast"))
        {
            pricePerDay = 130;
            percent = 12; break;
        }
        else if (type.Equals("noBreakfast"))
        {
            pricePerDay = 100;
            percent = 7; break;
        }
        break;
}
if (days > 7)
{
    days--;
}
double totalPrice = days * pricePerDay;
if (vipDiscount.Equals("yes"))
{
    totalPrice -= totalPrice * (percent / 100);
}
Console.WriteLine($"The price is {Math.Round(totalPrice, 2)}lv! Have a nice time!");*/

//04 - Club
/*double profit = double.Parse(Console.ReadLine());
double currentProfit = 0;
string command;
int currentCocktail = 0;
while (true)
{
    command = Console.ReadLine();
    if (command.Equals("Party!"))
    {
        Console.WriteLine($"We need {Math.Round(profit - currentProfit, 2)} leva more.");
        break;
    }
    currentCocktail=int.Parse(Console.ReadLine());
    double currentPrice = command.Length * currentCocktail;
    if (currentPrice % 2 == 1)
    {
        currentPrice -= currentPrice * 0.25;
    }
    currentProfit += currentPrice;
    if (currentProfit >= profit)
    {
        Console.WriteLine("Target acquired.");
        break;
    }



}
Console.WriteLine($"Club income - {Math.Round(currentProfit, 2)} leva.");
*/

//04 - Renovation
/*int high = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int percentNoPaint = int.Parse(Console.ReadLine());

double volume = high * width * 4;
volume -= volume * ((double)percentNoPaint / 100);
volume=Math.Round(volume);
string command=Console.ReadLine();
while (!command.Equals("Tired!"))
{
    int litters=int.Parse(command);
    volume -= litters;
    if (volume == 0)
    {
        Console.WriteLine("All walls are painted! Great job, Pesho!");
    } else if(volume < 0)
    {
        Console.WriteLine($"All walls are painted and you have {-volume} l paint left!");
    }

    command=Console.ReadLine();
}
Console.WriteLine(volume + " quadratic m left.");*/

//05 - Football Tournament
/*string teamName = Console.ReadLine();
int tournaments = int.Parse(Console.ReadLine());
if(tournaments == 0)
{
    Console.WriteLine(teamName + " hasn't played any games during this season.");
    return;
}
int points = 0;
int winGames = 0;
int withoutWinnerGames = 0;
int loseGames = 0;
for (int i = 0; i < tournaments; i++)
{
    char result = char.Parse(Console.ReadLine());
    switch (result)
    {
        case 'W': points += 3; winGames++; break;
        case 'D': points += 1; withoutWinnerGames++; break;
        default: loseGames++; break;
    }
}
Console.WriteLine(teamName + " has won " + points + " points during this season");
Console.WriteLine("Total stats:");
Console.WriteLine($"## W: {winGames}");
Console.WriteLine($"## D: {withoutWinnerGames}");
Console.WriteLine($"## L: {loseGames}");
Console.WriteLine($"Win rate: {Math.Round(((double)winGames / tournaments)*100, 2)}%");*/

//05 - PC Game Shop
/*int n= int.Parse(Console.ReadLine());
int hearthstone = 0;
int fornite = 0;
int overwatch = 0;
int others = 0;
for(int i=0; i<n; i++)
{
    string game= Console.ReadLine();
    switch (game)
    {
        case "Hearthstone": hearthstone++;break;
        case "Fornite": fornite++;break;
        case "Overwatch": overwatch++;break;
            default: others++; break;
    }
}
Console.WriteLine("Hearthstone - " + Math.Round(((double)hearthstone / n )*100, 2) + "%");
Console.WriteLine("Fornite - " + Math.Round(((double)fornite / n)*100, 2) + "%");
Console.WriteLine("Overwatch - " + Math.Round(((double)overwatch / n)*100, 2) + "%");
Console.WriteLine("Others - " + Math.Round(((double)others / n)*100, 2) + "%");*/

//06 - Name Game
/*int winnerPoints = int.MinValue;
string winnerName = "";
string name=Console.ReadLine();
while (!name.Equals("Stop"))
{
    int currentPoints = 0;
    for(int i = 0; i < name.Length; i++)
    {
        int currentNumber=int.Parse(Console.ReadLine());
        if(currentNumber == (char)name[i])
        {
            currentPoints += 10;
        }
        else
        {
            currentPoints += 2;
        }
    }
    if (winnerPoints <= currentPoints)
    {
        winnerPoints = currentPoints;
        winnerName = name;
    }

    name = Console.ReadLine();
}
Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");*/

//06 - The Most Powerful Word
string word=Console.ReadLine();
string mostPowerfulWord = "";
int powerOfWord = int.MinValue;
while(!word.Equals("End of words"))
{
    int currentWordLength = 0;
    for(int i = 0; i < word.Length; i++)
    {
        currentWordLength += word[i];
    }
    if(word.StartsWith('a') || word.StartsWith('A') 
        || word.StartsWith('e') || word.StartsWith('E')
        || word.StartsWith('i')|| word.StartsWith('I')
        || word.StartsWith('o') || word.StartsWith('O')
        ||word.StartsWith('u')|| word.StartsWith('U')
        ||word.StartsWith('y')|| word.StartsWith('Y')
        )
    {
        currentWordLength*= word.Length;
    }
    else
    {
        Math.Floor((double)currentWordLength / 2);
    }

    if (currentWordLength >= powerOfWord)
    {
        powerOfWord=currentWordLength;
        mostPowerfulWord = word;
    }
    word=Console.ReadLine() ;
}
Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {powerOfWord}");

