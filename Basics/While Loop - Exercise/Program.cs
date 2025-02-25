//1
/*string bookName = Console.ReadLine();
int bookCount = 0;
string currentBook = "";
while (currentBook != "No More Books")
{
    currentBook = Console.ReadLine();
    if (currentBook.Equals(bookName))
    {
        Console.WriteLine("You checked " + bookCount + " books and found it.");
        Environment.Exit(0);
    }
    bookCount++;
}
Console.WriteLine("The book you search is not here!");
Console.WriteLine("You checked " + (bookCount - 1) + " books.");*/

//2
/*int countOfScores = int.Parse(Console.ReadLine());
string taskName="";
int i = 0;
int failed = 0;
int sumOfGrades = 0;
bool isReady = false;
string lastProblem = "";
do 
{
    taskName = Console.ReadLine();
        if (taskName.Equals("Enough"))
        {
        Console.WriteLine("Average score: "+ (double)(sumOfGrades/i));
        Console.WriteLine("Number of problems: "+ i);
        Console.WriteLine("Last problem: " + lastProblem);
        isReady = true;
            break;
        }
    int currentGrade = int.Parse(Console.ReadLine());
    i++;
    sumOfGrades += currentGrade;
    if (currentGrade <= 4)
    {
        failed++;
    }
    lastProblem = taskName;

} while (failed < countOfScores);

if (!isReady)
{
    Console.WriteLine("You need a break, " + countOfScores + " poor grades.");
}
*/

//3
/*double neededMoney = Double.Parse(Console.ReadLine());
double ownedMoney = Double.Parse(Console.ReadLine());
int days = 0;
int daysOfSpent = 0;

while (daysOfSpent < 5 && (ownedMoney < neededMoney))
{
    string activity = Console.ReadLine();
    double currentMoney = double.Parse(Console.ReadLine());
    days++;
    if (activity.Equals("spend"))
    {
        daysOfSpent++;
        ownedMoney -= currentMoney;
        if (ownedMoney <= 0)
        {
            ownedMoney = 0;
        }
    }
    else
    {
        ownedMoney += currentMoney;
        daysOfSpent = 0;
    }
}
if (ownedMoney >= neededMoney)
{
    Console.WriteLine("You saved the money for " + days + " days.");
}
else
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}*/

//4
/*int steps = 0;
while(steps < 10000)
{
    string curentInput = Console.ReadLine();
    if(curentInput.Equals("Going home"))
    {
        int lastSteps = int.Parse(Console.ReadLine());
        steps += lastSteps;
        break;
    }
    else
    {
        int input = int.Parse(curentInput);
        steps += input;
    }
}

if (steps >= 10000)
{
    Console.WriteLine("Goal reached! Good job! " + (steps - 10000) + " steps over the goal!");
}
else
{
    Console.WriteLine((10000 - steps) + " more steps to reach goal.");
}*/

//5 - first 
/*double input = Double.Parse(Console.ReadLine());
int change= (int)(input * 100);

int coins = 0;

while (change > 0)
{
    if (change % 200 == 0)
    {
        coins++;
        change -= 200;
        Console.WriteLine("2");
    }
    else if (change % 100 == 0)
    {
        coins++;
        change -= 100;
        Console.WriteLine("1");
    }
    else if (change % 50 == 0)
    {
        coins++;
        change -= 50;
        Console.WriteLine("0.5");
    }
    else if (change % 20 == 0)
    {
        coins++;
        change -= 20;
        Console.WriteLine("0.2");
    }
    else if (change % 10 == 0)
    {
        coins++;
        change -= 10;
        Console.WriteLine("0.1");
    }
    else if(change % 5 == 0)
    {
        coins++;
        change -= 5;
        Console.WriteLine("0.05");
    }
    else if(change% 2 == 0)
    {
        coins++;
        change-=2;
        Console.WriteLine("0.02");
    }
    else 
    {
        coins++;
        change -= 1;
        Console.WriteLine("0.01");
    }
}
Console.WriteLine(coins);*/

//5 -second
/*double change=Double.Parse(Console.ReadLine());
int coins = 0;
change *= 100;
int[] availableCoins = { 200, 100, 50, 20, 10, 5, 2, 1 };

foreach(int c in availableCoins)
{
    while (change >= c)
    {
        coins++;
        change-= c;
    }
}
Console.WriteLine(coins);*/

//6
/*int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int size = width * height;
int s = size;
int pieces = 0;
while(s >= 0)
{
    string input = Console.ReadLine();
    if (input.Equals("STOP")){
        Console.WriteLine((size - pieces) + " pieces are left.");
        return;
    }
    else
    {
        int currentInput= int.Parse(input);
        s -= currentInput;
        pieces += currentInput;
    }
}
Console.WriteLine("No more cake left! You need " + (pieces-size) + " pieces more.");
*/

//7
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int area = width * height * length;
string input;
int meters = 0;
while (meters<area)
{
    input = Console.ReadLine();
    if (input.Equals("Done")){
        Console.WriteLine((area - meters) + " Cubic meters left.");
        return;
    }
    else
    {
        int currentMeters = int.Parse(input);
        meters += currentMeters;
    }
}
Console.WriteLine("No more space! You need " + (meters - area) + " Cubic meters more.");
