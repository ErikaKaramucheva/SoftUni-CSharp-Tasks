//01 - Movie Profit
/*string filmName= Console.ReadLine();
int days=int.Parse(Console.ReadLine());
int countOfTickets=int.Parse(Console.ReadLine());
double ticketUnitPrice=double.Parse(Console.ReadLine());
int percentForCinema = int.Parse(Console.ReadLine());

double profit = days*countOfTickets*ticketUnitPrice;
profit=Math.Round(profit-(profit*percentForCinema/100),2);

Console.WriteLine($"The profit from the movie {filmName} is {profit} lv.");*/

//01 - Series Calculator
/*string name = Console.ReadLine();
int seasons=int.Parse(Console.ReadLine());
int episodes = int.Parse(Console.ReadLine());
double timeWithoutAds=double.Parse(Console.ReadLine());
double timeWithAds =timeWithoutAds+( timeWithoutAds * 0.2);
double timeInMinutes=(seasons*episodes*timeWithAds)+(seasons*10);
Console.WriteLine($"Total time needed to watch the {name} series is {Math.Floor(timeInMinutes)} minutes.");*/

//02 - Movie Day
/*int timeForPhotos = int.Parse(Console.ReadLine());
int sceneCount = int.Parse(Console.ReadLine());
int durationOfScene = int.Parse(Console.ReadLine());
double preparation = timeForPhotos * 0.15;
double neededTime = (timeForPhotos - preparation) - (sceneCount * durationOfScene);
if (neededTime < 0)
{
    Console.WriteLine($"Time is up! To complete the movie you need {-Math.Round(neededTime)} minutes.");
}
else
{
    Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(neededTime)} minutes left.");
}*/

//03 - Film Premiere
/*string film = Console.ReadLine();
string pack = Console.ReadLine();
int ticketsCount = int.Parse(Console.ReadLine());
int unitPrice = 0;
double discount = 0;

switch (film) {
    case "John Wick":
        switch (pack)
        {
            case "Drink":  unitPrice = 12; break;
            case "Popcorn":  unitPrice = 15; break;
            default: unitPrice = 19;break;
        }
        break;
    case "Star Wars":
        switch (pack)
        {
            case "Drink": unitPrice = 18; break;
            case "Popcorn": unitPrice = 25; break;
            default: unitPrice = 30; break;
        }
        if (ticketsCount >= 4)
        {
            discount = 0.3;
        }
        break;
    default:
        switch (pack)
        {
            case "Drink": unitPrice = 9; break;
            case "Popcorn": unitPrice = 11; break;
            default: unitPrice = 14; break;
        }
        if (ticketsCount ==2)
        {
            discount = 0.15;
        }
        break;
}
double total = unitPrice * ticketsCount;
if (discount != 0)
{
    total -= total * discount;
}
Console.WriteLine($"Your bill is {Math.Round(total,2)} leva.");*/

//03 - Movie Destination
/*double budget= double.Parse(Console.ReadLine());
string destination=Console.ReadLine();
string season=Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double discount = 0;
int neededMoneyForDay = 0;

switch (destination) {
    case "Dubai":
        switch (season)
        {
            case "Winter": neededMoneyForDay = 45000;break;
            default: neededMoneyForDay = 40000;break;
        }
        discount = 0.3;
        break;
    case "Sofia":
        switch (season)
        {
            case "Winter": neededMoneyForDay = 17000; break;
            default: neededMoneyForDay = 12500; break;
        }
        discount = 0.25;
        break;
    default:
        switch (season)
        {
            case "Winter": neededMoneyForDay = 24000; break;
            default: neededMoneyForDay = 20250; break;
        }
        break;
}

double total = neededMoneyForDay * days;
if (discount != 0)
{
    if (discount == 0.3)
    {
        total -= total * 0.3;
    }
    else
    {
        total += total * 0.25;
    }
}

if (budget >= total)
{
    Console.WriteLine($"The budget for the movie is enough! We have {Math.Round(budget - total, 2)} leva left!");
}
else
{
    Console.WriteLine($"The director needs {Math.Round(total - budget, 2)} leva more!");
}*/

//04 - Cinema
/*int hallCapacity = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
int tryingToEnter = 0;
double income = 0;
while(command != "Movie time!")
{
    int currentPeople= int.Parse(command);
    if (currentPeople + tryingToEnter > hallCapacity)
    {
        Console.WriteLine("The cinema is full!");
        Console.WriteLine($"Cinema income - {Math.Round(income,2)} lv.");
        return;
    }
    int currentSum = currentPeople * 5;
    if (currentPeople % 3 == 0)
    {
        currentSum -= 5;
    }
    income += currentSum;
    tryingToEnter += currentPeople;
    command = Console.ReadLine();
}
Console.WriteLine($"There are {hallCapacity - tryingToEnter} seats left in the cinema.");
Console.WriteLine($"Cinema income - {Math.Round(income,2)} lv.");
*/

//04 - Movie Stars
/*double budget = double.Parse(Console.ReadLine());
string command = Console.ReadLine();
double currentBudget;
while (!command.Equals("ACTION"))
{
    if (command.Length <= 15)
    {
        currentBudget = double.Parse(Console.ReadLine());
    }
    else
    {
        currentBudget = 0.2 * budget;
    }

    budget -= currentBudget;
    if (budget <= 0)
    {
        Console.WriteLine($"We need {Math.Round(-budget, 2)} leva for our actors.");
        return;
    }

    command = Console.ReadLine();
}
Console.WriteLine($"We are left with {Math.Round(budget, 2)} leva.");*/

//05 - Oscars
/*string actorName = Console.ReadLine();
double startPoint = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    string currentName = Console.ReadLine();
    double currentPoints= double.Parse(Console.ReadLine());

    double point = (currentName.Length * currentPoints) / 2;
    startPoint += point;
    if (startPoint > 1250.5)
    {
        Console.WriteLine($"Congratulation, {actorName} got nominee for leading role with {Math.Round(startPoint, 1)}!");
        return;
    }
}
Console.WriteLine($"Sorry, {actorName} you need {Math.Round((1250.5-startPoint),1)}");
*/

//05 - Series
/*double budget = double.Parse(Console.ReadLine());
int n= int.Parse(Console.ReadLine());
double discount = 0;
double total = 0;
for(int i = 0; i < n; i++)
{
    string title=Console.ReadLine();
    double price=double.Parse(Console.ReadLine());
    discount = 0;
    switch (title) {
        case "Thrones":discount = 0.5;break;
        case "Lucifer":discount = 0.4;break;
        case "Protector":discount = 0.3;break;
        case "TotalDrama":discount = 0.2;break;
        case "Area":discount = 0.1;break;
    }
    total += price - (price * discount);

}
if (budget >= total)
{
    Console.WriteLine($"You bought all the series and left with {Math.Round(budget - total, 2)} lv.");
}
else
{
    Console.WriteLine($"You need {Math.Round(total - budget, 2)} lv. more to buy the series!");
}*/

//06 - Favorite Movie
/*string bestTitle = Console.ReadLine();
int bestSum = int.MinValue;
string currentTitle = Console.ReadLine();
int i = 1;
while(!currentTitle.Equals("STOP")){
    int currentSum= 0;
    foreach(var c in currentTitle)
    {
        currentSum+= c;
        if(c>=97 && c < 122)
        {
            currentSum-=(2*currentTitle.Length);
        }
        else if(c>=65 && c<=90)
        {
            currentSum-=currentTitle.Length;
        }
    }
    if (currentSum > bestSum)
    {
        bestSum = currentSum;
        bestTitle= currentTitle;
    }
        i++;
    if (i == 7)
    {
        Console.WriteLine("The limit is reached.");
        break;
    }
    currentTitle = Console.ReadLine();
}
Console.WriteLine($"The best movie for you is {bestTitle} with {bestSum} ASCII sum.");
*/

//06 - Movie Tickets
int a1= int.Parse(Console.ReadLine());
int a2= int.Parse(Console.ReadLine());
int n= int.Parse(Console.ReadLine());
for(int i = a1; i <= a2 - 1; i++)
{
    if (i % 2 != 0)
    {
        for(int j = 1; j <= n - 1; j++)
        {
            for (int k = 1;  k <= n / 2 - 1; k++)
            {
                if ((j + k + i) % 2 != 0)
                {
                    Console.WriteLine((char)i+"-"+j+ k + i);
                }
            }
        }
    }

}
