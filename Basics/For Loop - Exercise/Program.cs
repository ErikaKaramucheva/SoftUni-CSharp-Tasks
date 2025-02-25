//1
/*for(int i = 0; i < 1000; i++)
{
    if (i % 10 == 7)
    {
        Console.WriteLine(i);
    }
}*/

//2
/*int numbers = int.Parse(Console.ReadLine());
int sum = 0;
int maxNumber = int.MinValue;
for(int i=0;i < numbers; i++)
{
    int currentNumber = int.Parse(Console.ReadLine()) ;
    sum += currentNumber ;
    if(currentNumber > maxNumber)
    {
        maxNumber = currentNumber ;
    }
}
if((sum-maxNumber) == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = "+maxNumber);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Dif = " + Math.Abs(maxNumber -(sum-maxNumber)));
}
*/

//3
/*int n=int.Parse(Console.ReadLine());
int p1Count = 0;
int p2Count = 0;
int p3Count = 0;
int p4Count = 0;
int p5Count = 0;
for(int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if( currentNumber < 200)
    {
        p1Count++;
    } else if( currentNumber >=200 && currentNumber <= 399)
    {
        p2Count++;
    }else if(currentNumber >=400 && currentNumber <= 599)
    {
        p3Count++;
    }else if (currentNumber >=600 && currentNumber <= 799)
    {
        p4Count++;
    }
    else
    {
        p5Count++;
    }
}
Console.WriteLine(Math.Round((double)((double)p1Count / n * 100), 2)+ "%");
Console.WriteLine(Math.Round((double)((double)p2Count / n * 100), 2) + "%");
Console.WriteLine(Math.Round((double)((double)p3Count / n * 100), 2) + "%");
Console.WriteLine(Math.Round((double)((double)p4Count / n * 100), 2) + "%");
Console.WriteLine(Math.Round((double)((double)p5Count / n * 100), 2) + "%");
*/

//4
/*int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyUnitPrice = int.Parse(Console.ReadLine());
double sum = 0;
double cash = 0;
int toysCount = 0;
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        sum += (cash + 10);
        cash += 10;
        Console.WriteLine(sum);
        sum -= 1;
    }
    else
    {
        toysCount++;
    }
}
Console.WriteLine(sum);
sum = sum + (toysCount * toyUnitPrice);
Console.WriteLine(sum);
if (sum >= washingMachinePrice)
{
    Console.WriteLine("Yes! " + (sum - washingMachinePrice));
}
else
{
    Console.WriteLine("No! " + (washingMachinePrice - sum));
}
*/

//5
/*int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());
int fee = 0;
for (int i = 0; i < tabs; i++)
{
    string website=Console.ReadLine();
    if(website == "Facebook")
    {
        fee += 150;
    }else if (website == "Instagram")
    {
        fee += 100;
    }else if (website == "Reddit")
    {
        fee += 50;
    }
    else
    {
        Console.WriteLine("Invalid data");
    }
    salary -= fee;
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary");
        Environment.Exit(0);
    }
}
Console.WriteLine(salary);
*/

//6
/*string actorName = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int estimators = int.Parse(Console.ReadLine());

for (int i = 0; i < estimators; i++)
{
    string currentEstimator = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());
    pointsFromAcademy += ((currentEstimator.Length * points) / 2);
    if (pointsFromAcademy > 1250.5)
    {
        Console.WriteLine("Congratulations, " + actorName + " got a nominee for leading role with " + pointsFromAcademy);
        Environment.Exit(0);
    }
}
Console.WriteLine("Sorry, " + actorName + " you need " + (1250.5 - pointsFromAcademy) + " more!");
*/

//7
/*int groups = int.Parse(Console.ReadLine());
int firstGroup = 0;
int secondGroup = 0;
int thirdGroup = 0;
int fourthGroup = 0;
int fifthGroup = 0;
int totalCount = 0;
for (int i = 0; i < groups; i++)
{
    int count = int.Parse(Console.ReadLine());
    totalCount += count;
    if(count <= 5)
    {
        firstGroup += count;
    } else if(count>=6 && count <= 12)
    {
        secondGroup += count;
    }else if (count>=13 && count <= 25)
    {
        thirdGroup += count;
    }else if(count>=26 && count <= 40)
    {
        fourthGroup += count;
    }
    else
    {
        fifthGroup += count;
    }
}
Console.WriteLine(Math.Round((double)(firstGroup / (double)totalCount)*100,2) + "%");
Console.WriteLine(Math.Round((double)(secondGroup / (double)totalCount) * 100, 2) + "%");
Console.WriteLine(Math.Round((double)(thirdGroup / (double)totalCount) * 100, 2) + "%");
Console.WriteLine(Math.Round((double)(fourthGroup / (double)totalCount) * 100, 2) + "%");
Console.WriteLine(Math.Round((double)(fifthGroup / (double)totalCount) * 100, 2) + "%");
*/

//8
int tournamentsCount = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());
int pointsFromTournament = startPoints;
int w = 0;
for (int i = 0; i < tournamentsCount; i++)
{
    string stage = Console.ReadLine();
    if(stage == "W")
    {
        pointsFromTournament += 2000;
        w++;
    }else if(stage == "F")
    {
        pointsFromTournament += 1200;
    }else if(stage == "SF")
    {
        pointsFromTournament += 720;
    }
    else
    {
        Console.WriteLine("Incorrect input");
    }
}

Console.WriteLine("Final points: "+ pointsFromTournament);
Console.WriteLine("Average points: "+ Math.Floor((double)(pointsFromTournament-startPoints)/(double)tournamentsCount));
Console.WriteLine( Math.Round(((double)w/(double)tournamentsCount)*100,2)+"%");


