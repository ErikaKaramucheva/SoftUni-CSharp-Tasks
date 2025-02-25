//1
/*while (true)
{
    string input = Console.ReadLine();
    if (input == "Stop")
    {
        break;
    }
    Console.WriteLine(input);
}*/

//2
/*string username = Console.ReadLine();
string password = Console.ReadLine();
string currentPass = Console.ReadLine();
while (currentPass != password)
{
    currentPass = Console.ReadLine();
}
Console.WriteLine($"Welcome {username}!");
*/

//3
/*int startNumber = int.Parse(Console.ReadLine());
int sum = 0;
while(sum< startNumber)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;
}
Console.WriteLine(sum);*/

//4
/*int n = int.Parse(Console.ReadLine());
int current = 1;
while (current <= n)
{
    Console.WriteLine(current);
    current = (current * 2) + 1;
}*/

//5
/*double totalSum = 0;
while (true)
{
    string input = Console.ReadLine();
    if(input== "NoMoreMoney")
    {
        break;
    }
    else
    {
        double currentSum = double.Parse(input);
        if (currentSum < 0)
        {
            Console.WriteLine("Invalid operation!");
            break;
        }
        else
        {
            totalSum+= currentSum;
            Console.WriteLine("Increase: "+currentSum);
        }
    }
}
Console.WriteLine("Total: " + totalSum);
*/

//6
/*string input;
int maxNumber=int.MinValue;
while (true)
{
    input=Console.ReadLine();
    if(input == "Stop")
    {
        Console.WriteLine(maxNumber); break;
    }
    else
    {
        int current = int.Parse(input);
        if (current > maxNumber)
        {
            maxNumber = current;
        }
    }
}*/

//7
/*string input;
int minNumber = int.MaxValue;
while (true)
{
    input = Console.ReadLine();
    if (input == "Stop")
    {
        Console.WriteLine(minNumber); break;
    }
    else
    {
        int current = int.Parse(input);
        if (current < minNumber)
        {
            minNumber = current;
        }
    }
}*/

//8
string name = Console.ReadLine();
int ex = 0;
int year = 0;
double sumOfGrades = 0;
while (year<12)
{
    double grade = double.Parse(Console.ReadLine());
    sumOfGrades += grade;
    year++;
    if (grade < 4)
    {
        ex++;
        if (ex == 2)
        {
            break;
        }
    }
    
}
if (ex != 2)
{
    Console.WriteLine($"{name} graduated. Average grade: " + Math.Round((sumOfGrades / year), 2));
}
else
{
    Console.WriteLine($"{name} has been excluded at {year-1} grade ");

}

