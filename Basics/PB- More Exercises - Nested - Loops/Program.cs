//1
/*int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
for (int i = 1; i <= firstNumber; i++)
{
    for (int j = 1; j <= secondNumber; j++)
    {
        for (int k = 1; k <= thirdNumber; k++)
        {
            if ((i % 2 == 0) &&
                (j == 2 || j == 3 || j == 5 || j == 7) &&
                (k % 2 == 0))
            {
                Console.WriteLine(i + " " + j + " " + k);

            }
        }
    }

}*/

//2
/*char first=char.Parse(Console.ReadLine());
char second=char.Parse(Console.ReadLine());
char third=char.Parse(Console.ReadLine());
int combinations = 0;

for(char i=first; i<=second; i++)
{
    for(char j=first; j<=second; j++)
    {
        for(char k=first; k<=second; k++)
        {
            if(i == third || j == third || k==third)
            {
                continue;
            }
            else
            {
                combinations++;
                Console.Write(i.ToString()+j.ToString() + k.ToString() + " ");
            }
        }
    }
}
Console.Write(combinations);*/

//3
/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for (int l = 1; l <= 9; l++)
            {
                if (i + j == k + l)
                {
                    if(n%(i+j) == 0)
                    {
                        Console.Write(i.ToString()+j.ToString()+k.ToString()+l.ToString()+" ");
                    }
                }
            }
        }
    }
}*/

//4
/*int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j++)
    {
        for (int k = start; k <= end; k++)
        {
            for (int l = start; l <= end; l++)
            {
                if((i%2==0 && l%2!=0) ||(i%2==1 && l % 2 == 0))
                {
                    if (i > l)
                    {
                        if ((k + j) % 2 == 0)
                        {
                            Console.Write(i.ToString()+j.ToString()+k.ToString()+l.ToString()+" ");
                        }
                    }
                }
            }
        }
    }
}
*/

//5
/*int maleCount=int.Parse(Console.ReadLine());
int femaleCount=int.Parse(Console.ReadLine());
int maxTableCount = int.Parse(Console.ReadLine());
int currentTable = 0;
for(int i = 1; i <= maleCount; i++)
{
    for(int j = 1; j <= femaleCount; j++)
    {
        if (currentTable==maxTableCount)
        {
            return;
        }
        Console.Write($"({i} <-> {j}) ");
        currentTable++;
    }
}*/

//6
/*char lastSector = char.Parse(Console.ReadLine());
int countOfPlacesInFirstSector = int.Parse(Console.ReadLine());
int countOfPlacesInOddRow  = int.Parse(Console.ReadLine());
int totalSeats = 0;
int countOfSeatsInNextSector = countOfPlacesInFirstSector;

for(char i= 'A'; i <= lastSector; i++)
{
    for (int j = 1; j <= countOfSeatsInNextSector; j++)
    {
        int currentPlaces = countOfPlacesInOddRow;
        if (j % 2 == 0)
        {
            currentPlaces += 2;
        }
        char currentLetter = (char)('a' + currentPlaces - 1);
        for (char k = 'a'; k <= currentLetter; k++)
        {
            totalSeats++;
            Console.WriteLine(i.ToString()+j+k.ToString());
        }
    }

    countOfSeatsInNextSector++;
}
Console.WriteLine(totalSeats);*/


//7
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int maxCountOfPasswords = int.Parse(Console.ReadLine());

int count = 0;
int A = 35;
int B = 64;

for (int x = 1; x <= a; x++)
{
    for (int y = 1; y <= b; y++)
    {
        if (count >= maxCountOfPasswords)
        {
            return;
        }
        Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A} | ");
        count++; 
        A++;
        B++;
        if (B > 96)
        {
            B = 64;
        }
        if (A > 55)
        {
            A = 35;
        }
    }
}*/

//8
/*int hundreds = int.Parse(Console.ReadLine());
int tens = int.Parse(Console.ReadLine());
int ones = int.Parse(Console.ReadLine());
for (int i = 1; i <= hundreds; i++)
{
    for (int j = 1; j <= tens; j++)
    {
        for (int k = 1; k <= ones; k++)
        {
            if (k % 2 == 0 && i % 2 == 0 &&
                (j == 2 || j == 3 || j == 5 || j == 7))
            {
                Console.WriteLine($"{i} {j} {k}");
            }
        }
    }
}*/

//9
/*int start= int.Parse(Console.ReadLine());
int end= int.Parse(Console.ReadLine());
int magicNumber= int.Parse(Console.ReadLine());
int count = 0;
for(int i=start; i<=end; i++)
{
    for(int j=start; j<=end; j++)
    {
        count++;
        if (i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{count} ({i}+{j}={i+j})");
            return;
        }
    }
}
Console.WriteLine($"{count} combinations - neither equals {magicNumber}");*/

//10
/*int countOf1= int.Parse(Console.ReadLine());
int countOf2= int.Parse(Console.ReadLine());
int countOf5= int.Parse(Console.ReadLine());
int sum=int.Parse(Console.ReadLine());

for(int i=0; i<=countOf1; i++)
{
    for(int j=0; j<=countOf2; j++)
    {
        for(int k=0; k<=countOf5; k++)
        {
            if (i * 1 + j * 2 + k * 5 == sum)
            {
                Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv = {sum} lv.");
            }
        }
    }
}*/

//11
/*int days=int.Parse(Console.ReadLine());
int hours=int.Parse(Console.ReadLine());
double currentSum = 0;
double totalSum = 0;
for(int i = 1; i <= days; i++)
{
    for(int j = 1; j <= hours; j++)
    {
        if (i % 2 == 0 && j % 2 != 0)
        {
            currentSum += 2.5;
        }
        else if (i % 2 !=0 && j % 2 == 0)
        {
            currentSum += 1.25;
        }
        else
        {
            currentSum += 1;
        }
    }
    totalSum += currentSum;
    Console.WriteLine($"Day: {i+1} - {Math.Round(currentSum,2)} leva.");
    currentSum = 0;
}
Console.WriteLine($"Total: {Math.Round(totalSum, 2)} leva");*/

//12
/*int m = int.Parse(Console.ReadLine());
string result = "No!";
int counter = 0;
for (int a = 0; a <= 9; a++)
{
    for (int b = a + 1; b <= 9; b++)
    {
        for (int c = 9; c > 0; c--)
        {
            for (int d = 0; d < c; d++)
            {
                if ((a * b) + (c * d) == m)
                {
                    counter++;
                    Console.WriteLine(a.ToString() + b.ToString() + c.ToString() + d.ToString());

                    if (counter == 4)
                    {
                        result = "Password: " + a.ToString() + b.ToString() + c.ToString() + d.ToString();
                    }
                }
            }
        }
    }
}
Console.WriteLine(result);*/

//13
/*int firstPair = int.Parse(Console.ReadLine());
int secondPair = int.Parse(Console.ReadLine());
int diffFirst=int.Parse(Console.ReadLine());
int diffSecond=int.Parse(Console.ReadLine());
for(int i=firstPair; i<=firstPair+diffFirst; i++)
{
    for (int j = secondPair; j <= secondPair + diffSecond; j++)
    {
        bool iIsPrime = true;
        for (int k = 2; k <= Math.Sqrt(i); k++)
        {
            if(i%k == 0)
            {
                iIsPrime = false;
                break;
            }
        }
        if (!iIsPrime)
        {
            break;
        }
        else {
            bool jIsPrime = true;
            for (int k = 2; k <= Math.Sqrt(j); k++)
            {
                if (j % k == 0)
                {
                    jIsPrime = false;
                    break;
                }
            }
            if (jIsPrime)
            {
                Console.WriteLine(i.ToString() + j.ToString());
            }
        }
    }
}*/

//14
/*int n = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

string password = "";
for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        for (char c = 'a'; c < (char)('a'+l); c++)
        {
            for (char k = 'a'; k < (char)('a'+l); k++)
            {
                for (int t = 1; t <= n; t++)
                {
                    if (t > i && t > j)
                    {
                        password = i.ToString() + j.ToString() + c + k + t.ToString();
                        Console.Write(password + " ");
                    }
                }
            }
        }
    }
    
}*/


