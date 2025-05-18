//01 - Tennis
/*double priceOfOneRacket = double.Parse(Console.ReadLine());
int countOfRacket = int.Parse(Console.ReadLine());
int countOfSneakers= int.Parse(Console.ReadLine());

double priceForAllRackets = priceOfOneRacket * countOfRacket;
double priceForOneSneakers = priceOfOneRacket/6;
double priceForAllSneakers = priceForOneSneakers * countOfSneakers;
double anotherEquipment = 0.2 * (priceForAllRackets + priceForAllSneakers);
double totalPrice = priceForAllSneakers + anotherEquipment + priceForAllRackets;
double priceToBePaidBySponsors = totalPrice*7/8;
Console.WriteLine($"Price to be paid by Djokovic {Math.Round(totalPrice - priceToBePaidBySponsors)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Round(priceToBePaidBySponsors)}");
*/

//01 - Basketball
/*int yearTax = int.Parse(Console.ReadLine());
double sneakers = yearTax - (yearTax * 0.4);
double equipment = sneakers - (sneakers * 0.2);
double ball = equipment / 4;
double accessory = ball / 5;
double totalPrice = yearTax+sneakers + ball+equipment+accessory;
Console.WriteLine(Math.Round(totalPrice,2));*/

//02 - Football
/*string first = Console.ReadLine();
string second = Console.ReadLine();
string third = Console.ReadLine();
int wonGames = 0;
int lostGames = 0;
int drawnGames = 0;

string[] firstResult = first.Split(":");
string[] secondResult = second.Split(":");
string[] thirdResult = third.Split(":");
int firstFromFirst = int.Parse(firstResult[0]);
int secondFromFirst = int.Parse(firstResult[1]);
if(firstFromFirst>secondFromFirst)
{
    wonGames++;
}else if (firstFromFirst < secondFromFirst)
{
    lostGames++;
}
else
{
    drawnGames++;
}
int firstFromSecond = int.Parse(secondResult[0]);
int secondFromSecond = int.Parse(secondResult[1]);
if (firstFromSecond > secondFromSecond)
{
    wonGames++;
}
else if (firstFromSecond < secondFromSecond)
{
    lostGames++;
}
else
{
    drawnGames++;
}
int firstFromThird = int.Parse(thirdResult[0]);
int secondFromThird = int.Parse(thirdResult[1]);
if (firstFromThird > secondFromThird)
{
    wonGames++;
}
else if (firstFromThird < secondFromThird)
{
    lostGames++;
}
else
{
    drawnGames++;
}

Console.WriteLine($"Team won {wonGames} games.");
Console.WriteLine($"Team lost {lostGames} games.");
Console.WriteLine($"Drawn games: {drawnGames}.");*/

//02 - Skeleton
/*int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());
double lengthInMeters = double.Parse(Console.ReadLine());
int secondsForHundredMeters = int.Parse(Console.ReadLine());
double timeInSeconds = (lengthInMeters/100)* secondsForHundredMeters;
double decreasedTime = (lengthInMeters / 120) * 2.5;
timeInSeconds -= decreasedTime;
double controlsTime = (minutes * 60) + seconds;
if (controlsTime >= timeInSeconds)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine("His time is: "+Math.Round(timeInSeconds ,3));
}
else
{
    Console.WriteLine("No, Marin failed!");
    Console.WriteLine("He was " + Math.Round(timeInSeconds-controlsTime, 3)+" second slower.");

}*/

//03 - Gymnastics
/*string country = Console.ReadLine();
string accessory = Console.ReadLine();

double grade = 0;
if (country.Equals("Bulgaria")){
    if (accessory.Equals("ribbon"))
    {
        grade = 9.6 + 9.4;
    }else if (accessory.Equals("hoop"))
    {
        grade = 9.55 + 9.75;
    }
    else
    {
        grade = 9.5 + 9.4;
    }

}else if (country.Equals("Russia"))
{
    if (accessory.Equals("ribbon"))
    {
        grade = 9.1 + 9.4;
    }
    else if (accessory.Equals("hoop"))
    {
        grade = 9.3 + 9.8;
    }
    else
    {
        grade = 9.6 + 9;
    }
}
else
{
    if (accessory.Equals("ribbon"))
    {
        grade = 9.2 + 9.5;
    }
    else if (accessory.Equals("hoop"))
    {
        grade = 9.45 + 9.35;
    }
    else
    {
        grade = 9.7 + 9.15;
    }
}
double percentage = (20 - grade)/20 * 100;
Console.WriteLine($"The team of {country} get {Math.Round(grade, 3)} on {accessory}.");
Console.WriteLine(Math.Round(percentage,2) + "%");*/

//03 - World Snooker Champion
/*string stage = Console.ReadLine();
string ticketType = Console.ReadLine();
int ticketCount = int.Parse(Console.ReadLine());
char wantPhoto = char.Parse(Console.ReadLine());

double totalPrice = 0;
double ticketPrice = 0;
switch (stage)
{
    case "Quarter final":
        if (ticketType.Equals("Standard"))
        {
            ticketPrice = 55.5;
        }else if (ticketType.Equals("Premium"))
        {
            ticketPrice = 105.2;
        }
        else
        {
            ticketPrice = 118.9;
        }
        break;
    case "Semi final":
        if (ticketType.Equals("Standard"))
        {
            ticketPrice = 75.88;
        }
        else if (ticketType.Equals("Premium"))
        {
            ticketPrice = 125.22;
        }
        else
        {
            ticketPrice = 300.4;
        }
        break;
    default:
        if (ticketType.Equals("Standard"))
        {
            ticketPrice = 110.1;
        }
        else if (ticketType.Equals("Premium"))
        {
            ticketPrice = 160.66;
        }
        else
        {
            ticketPrice = 400;
        }
        break;
}
totalPrice = ticketPrice * ticketCount;
if (totalPrice > 4000)
{
    totalPrice = totalPrice - (totalPrice * 0.25);
}else if (totalPrice > 2500)
{
    totalPrice = totalPrice - (totalPrice * 0.1);
    if (wantPhoto.Equals('Y'))
    {
        totalPrice += (ticketCount * 40);
    }
}
else
{
    if (wantPhoto.Equals('Y'))
    {
        totalPrice += (ticketCount * 40);
    }
}

Console.WriteLine(Math.Round(totalPrice, 2));*/

//04 - Darts
/*string name = Console.ReadLine();
string command = Console.ReadLine();
int currentPoints = 0;
int points = 301;
int successfulShots = 0;
int unsuccessfulShots = 0;
while (!command.Equals("Retire"))
{
    currentPoints = int.Parse(Console.ReadLine());
    if (command.Equals("Single"))
    {
        if (currentPoints <= points)
        {
            points -= currentPoints;
            successfulShots++;
        }
        else
        {
            unsuccessfulShots++;
        }
    }else if (command.Equals("Double"))
    {
        if ((currentPoints*2) <= points)
        {
            points -= (currentPoints*2);
            successfulShots++;
        }
        else
        {
            unsuccessfulShots++;
        }
    }
    else
    {
        if ((currentPoints * 3) <= points)
        {
            points -= (currentPoints * 3);
            successfulShots++;
        }
        else
        {
            unsuccessfulShots++;
        }
    }

    if (points == 0)
    {
        Console.WriteLine($"{name} won the leg with {successfulShots} shots.");
        return;
    }

    command = Console.ReadLine();
}
Console.WriteLine($"{name} retired after {unsuccessfulShots} unsuccessful shots.");*/

//04 - Game Number Wars
/*string firstGamer = Console.ReadLine();
string secondGamer = Console.ReadLine();
string command1=Console.ReadLine();
string command2;
int pointsOfFirst = 0;
int pointsOfSecond = 0;
while(!command1.Equals("End of game"))
{
    command2 = Console.ReadLine();
    int first = int.Parse(command1);
    int second = int.Parse(command2);
    if (first > second)
    {
        pointsOfFirst += first - second;
    }
    else if (second > first)
    {
        pointsOfSecond += second - first;
    }
    else
    {
        first = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        Console.WriteLine("Number wars!");
        if (first > second)
        {
            Console.WriteLine($"{firstGamer} is winner with {pointsOfFirst} points.");
        }
        else 
        {
            Console.WriteLine($"{secondGamer} is winner with {pointsOfSecond} points.");
        }
        return;

    }
    command1 = Console.ReadLine();
}
Console.WriteLine($"{firstGamer} has {pointsOfFirst} points.");
Console.WriteLine($"{secondGamer} has {pointsOfSecond} points.");*/

//05 - Fitness Center
/*int count=int.Parse(Console.ReadLine());
int trainees = 0;
int buyers = 0;
int backTrainees = 0;
int chestTrainees = 0;
int legsTrainees = 0;
int absTrainees = 0;
int proteinShakes = 0;
int proteinBars = 0;
string activity = "";
for(int i=0; i<count; i++)
{
    activity = Console.ReadLine();
    switch (activity) {
        case "Back":
            trainees++;
            backTrainees++;
                break;
        case "Chest":
            trainees++;
            chestTrainees++; break;
        case "Legs": trainees++; legsTrainees++; break;
        case "Abs": trainees++;absTrainees++; break;
        case "Protein shake": buyers++; proteinShakes++;break;
        default: buyers++; proteinBars++;break;

    }

}
Console.WriteLine(backTrainees + " - back");
Console.WriteLine(chestTrainees + " - chest");
Console.WriteLine(legsTrainees + " - legs");
Console.WriteLine(absTrainees + " - abs");
Console.WriteLine(proteinShakes + " - protein shake");
Console.WriteLine(proteinBars + " - protein bar");
Console.WriteLine(Math.Round(((double)trainees / (double)count)*100,2) + "% - work out");
Console.WriteLine(Math.Round(((double)buyers/ (double)count)*100,2) + "% - protein");
*/

//05 - Tennis Ranklist
/*int countOfTours= int.Parse(Console.ReadLine());
int startPoints= int.Parse(Console.ReadLine());
int points = 0;
int win = 0;
for(int i = 0; i < countOfTours; i++)
{
    string stage= Console.ReadLine();
    if (stage.Equals("W"))
    {
        points += 2000;
        win++;
    }
    else if(stage.Equals("F"))
    {
        points += 1200;
    }
    else
    {
        points += 720;
    }
}
Console.WriteLine("Final points: "+ (startPoints+points));
double averagePoints = (double)points / (double)countOfTours;
Console.WriteLine("Average points: "+ Math.Floor(averagePoints));
Console.WriteLine(Math.Round((double)win / countOfTours * 100, 2)+"%");*/

//06 - Basketball Tournaments
/*string command = Console.ReadLine();
int win = 0;
int lost = 0;
int total = 0;
while (!command.Equals("End of tournaments")){
    int n=int.Parse(Console.ReadLine());
    total += n;
    for (int i = 0; i < n; i++)
    {
        int pointsFromDesiTeam = int.Parse(Console.ReadLine());
        int pointsFromOtherTeam = int.Parse(Console.ReadLine());
        if (pointsFromDesiTeam > pointsFromOtherTeam)
        {
            Console.WriteLine($"Game {i+1} of tournament {command}: win with {pointsFromDesiTeam-pointsFromOtherTeam} points.");
            win++;
        }
        else {
            Console.WriteLine($"Game {i+1} of tournament {command}: lost with {pointsFromOtherTeam - pointsFromDesiTeam} points.");

            lost++;
        }
    
    }

    command = Console.ReadLine();
}
Console.WriteLine(Math.Round((double)win/total*100,2)+"% matches win");
Console.WriteLine(Math.Round((double)lost/total*100,2)+"% matches lost");*/

//06 - High Jump
int desiredHight = int.Parse(Console.ReadLine());
int failedAttempts = 0;
int currentHight = desiredHight - 30;
int jumps = 1;
int temp=int.Parse((Console.ReadLine())); ;
while(temp<desiredHight )
{
    if (temp > currentHight)
    {
        currentHight += 5;
        failedAttempts = 0;
    }
    else
    {
        failedAttempts++;
        if (failedAttempts == 3)
        {
            Console.WriteLine($"Tihomir failed at {currentHight}cm after {jumps} jumps.");
            return;
        }
    }
     temp = int.Parse((Console.ReadLine()));
    jumps++;
}
Console.WriteLine($"Tihomir succeeded, he jumped over {currentHight}cm after {jumps} jumps.");

