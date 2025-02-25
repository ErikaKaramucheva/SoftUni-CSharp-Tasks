//1
/*int n = int.Parse(Console.ReadLine());
int temp = 1;
bool isBigger=false;
for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= i; j++)
    {
        if (temp > n)
        {
            isBigger = true;
            break;
        }
        Console.Write(temp + " ");
        temp++;
    }
    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
}*/

//2
int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
for(int i= numberOne; i<= numberTwo; i++)
{
    int sumOfEvenPositions = 0;
    int sumOfOddPositions = 0;
    int position = 6;
    int currentNumber = i;
    while (currentNumber > 0)
    {
        int currentDigit = currentNumber % 10;
        if (position % 2 == 0)
        {
            sumOfEvenPositions+=currentDigit;
        }
        else
        {
            sumOfOddPositions+=currentDigit;
        }

        currentNumber /= 10;
        position--;
    }
    if (sumOfEvenPositions == sumOfOddPositions)
    {
        Console.WriteLine(i);
    }
}

//3
/*int sumOfPrimeNumbers = 0;
int sumOfNonPrimeNumbers = 0;
string input = Console.ReadLine();
while (!input.Equals("stop"))
{
    int currentNumber= int.Parse(input);
    if (currentNumber < 0)
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine();
        continue;
    }

    bool isPrime = true;
    for(int i = 2; i <= Math.Sqrt(currentNumber); i++)
    {
        if (currentNumber % i == 0)
        {
            sumOfNonPrimeNumbers += currentNumber;
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        sumOfPrimeNumbers += currentNumber;
    }

    input = Console.ReadLine();
}
Console.WriteLine("Sum of all prime numbers is: " + sumOfPrimeNumbers);
Console.WriteLine("Sum of all non prime numbers is: " + sumOfNonPrimeNumbers);
*/

//4
/*int trainers = int.Parse(Console.ReadLine());
string presentationName= Console.ReadLine();
double allPresentationGrades = 0;
int presentationCount = 0;
while (!presentationName.Equals("Finish")) {
    double averageGrade = 0;
    presentationCount++;
    for (int n = 0; n < trainers; n++)
    {
        double currentGrade = double.Parse(Console.ReadLine());
        averageGrade += currentGrade;

    }
    averageGrade = averageGrade / trainers;
    Console.WriteLine($"{presentationName} - {Math.Round(averageGrade,2)}");
    presentationName= Console.ReadLine();
    allPresentationGrades+= averageGrade;
}
double averageGradeFromAll = allPresentationGrades / presentationCount;
Console.WriteLine($"Student's final assessment is {Math.Round(averageGradeFromAll, 2)}.");
*/

//5
/*int n= int.Parse(Console.ReadLine());
for (int i = 1111; i < 10000; i++)
{
    int current = i;
    bool isSpecial = true;
    while (current > 0)
    {
        int temp = current % 10;
        // first we check if current digit is 0, because we cannot divide by 0.
        if (temp ==0 || n % temp != 0 )
        {
            isSpecial = false;
            break;
        }
        current /= 10;
    }
    if (isSpecial)
    {
        Console.Write(i + " ");
    }
}*/

//6
/*int totalTickets = 0;
int studentTickets = 0;
int standardTickets = 0;
int childrenTickets = 0;
double fullness = 0;
while (true)
{
    string filmName = Console.ReadLine();
    if (filmName.Equals("Finish"))
    {
        double percentStudentTickets =(double)studentTickets/ (double)totalTickets;
        double percentStandardTickets = (double)standardTickets / (double)totalTickets;
        double percentChildrenTickets = (double)childrenTickets / (double)totalTickets;
        percentChildrenTickets *= 100;
        percentStandardTickets *= 100;
        percentStudentTickets *= 100;
        Console.WriteLine("Total tickets: " + totalTickets);
        Console.WriteLine($"{Math.Round(percentStudentTickets,2)}% student tickets.");
        Console.WriteLine($"{Math.Round(percentStandardTickets,2)}% standard tickets.");
        Console.WriteLine($"{Math.Round(percentChildrenTickets,2)}% kids tickets.");
        return;
    }
    int freeSpace = int.Parse( Console.ReadLine() );
    string currentInput= "";
    int currentTickets = 0;
    while (!currentInput.Equals("End") && currentTickets<freeSpace)
    {
        currentInput = Console.ReadLine();
        if (currentInput.Equals("student"))
        {
            studentTickets++;
            currentTickets++;
        }
        else if (currentInput.Equals("standard"))
        {
            standardTickets++;
            currentTickets++;
        }
        else if(currentInput.Equals("kid"))
        {
            childrenTickets++;
            currentTickets++;
        }
    }
    Console.WriteLine(currentTickets);
    totalTickets += currentTickets;
    fullness = (double)(currentTickets) / (double)freeSpace;
    fullness *= 100;
    Console.WriteLine($"{filmName}-{Math.Round(fullness,2)}% full.");

}
*/
