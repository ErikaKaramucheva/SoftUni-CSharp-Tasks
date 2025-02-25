//1
/*for(int i = 0; i < 24; i++)
{
    for(int j = 0; j < 60; j++)
    {
        Console.WriteLine(i + ":" + j);
    }
}*/

//2
/*for(int i = 1; i <= 10; i++)
{
    for(int j=1;j<=10; j++)
    {
        Console.WriteLine(i + "*"+j+ "="+ (i*j) ); 
    }
}*/

//3
/*int n = int.Parse(Console.ReadLine());
int result = 0;
for(int x1=0;x1 <= n; x1++)
{
    for(int x2=0;x2 <= n; x2++)
    {
        for(int x3=0;x3 <= n; x3++)
        {
            int sum = x1 + x2 + x3;
            if (sum == n)
            {
                result++;
            }
        }
    }
}
Console.WriteLine(result);*/

//4
/*int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int counter = 0;

for(int i = start; i <= end; i++)
{
    for(int j=start; j <= end; j++)
    {
        counter++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
            return;
        }
    }
}
Console.WriteLine(counter + " combinations - neither equals " + magicNumber);
*/

//5
/*while (true)
{
    string destination = Console.ReadLine();
    if (destination.Equals("End"))
    {
        return;
    }
    int neededSum = int.Parse(Console.ReadLine());
    int ownedMoney = 0;
    while(ownedMoney < neededSum)
    {
        int currentSum= int.Parse(Console.ReadLine());
        ownedMoney += currentSum;
    }
    if(ownedMoney >= neededSum)
    {
        Console.WriteLine($"Going to {destination}!");
    }
}*/

//6
int floors = int.Parse(Console.ReadLine());
int currentFloor = floors;
int rooms = int.Parse(Console.ReadLine());
while (currentFloor > 0)
{
    if (currentFloor == floors)
    {
        for (int i = 0; i < rooms; i++)
        {
            Console.Write($"L{currentFloor}{i} ");
        }
        currentFloor--;
        Console.WriteLine();
        continue;
    }

    if (currentFloor % 2 == 0)
    {
        for (int i = 0; i < rooms; i++)
        {
            Console.Write($"O{currentFloor}{i} ");
        }
    }
    else
    {
        for (int i = 0; i < rooms; i++)
        {
            Console.Write($"A{currentFloor}{i} ");
        }
    }
    currentFloor--;
    Console.WriteLine();
}

