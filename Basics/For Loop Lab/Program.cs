//1
/*for(int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}*/

//2
/*int n = int.Parse(Console.ReadLine());
for (; n >= 1; n--)
{
    Console.WriteLine(n);
}*/

//3
/*int n=int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i += 3)
{
    Console.WriteLine(i);
}*/

//4
/*int n=int.Parse(Console.ReadLine());
int result=1;
for(int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(result);
    }
    result *= 2;
}*/

//5
/*string input = Console.ReadLine();
for(int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i]);
}*/

//6
/*string input = Console.ReadLine();
int sum = 0;
for(int i = 0; i < input.Length; i++)
{
    if (input[i].Equals('a'))
    {
        sum += 1;
    }else if (input[i].Equals('e'))
    {
        sum += 2;
    }else if (input[i].Equals('i'))
    {
        sum += 3;
    }else if (input[i].Equals('o'))
    {
        sum += 4;
    }else if (input[i].Equals('u'))
    {
        sum += 5;
    }
}
Console.WriteLine(sum);
*/

//7
/*int number= int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0;i<number; i++)
{
    int n=int.Parse(Console.ReadLine());
    sum += n;
}
Console.WriteLine(sum);
*/

//8
/*int numbers = int.Parse(Console.ReadLine());
int min = int.MaxValue;
int max = int.MinValue;
for  (int i = 0; i < numbers; i++)
{
    int n=int.Parse(Console.ReadLine());
    if(n<min) min = n;
    if(n>max) max = n;
}
Console.WriteLine("Max number: " + max);
Console.WriteLine("Min number: " + min);*/

//9
int n=int.Parse(Console.ReadLine());
int firstSum = 0;
int secondSum = 0;
for (int i=0; i<n*n; i++)
{
    int current=int.Parse((Console.ReadLine()));
    if (i < n)
    {
        firstSum += current;
    }
    else
    {
        secondSum += current;
    }
}
if (firstSum == secondSum)
{
    Console.WriteLine("Yes, sum = " + firstSum);
}
else
{
    Console.WriteLine("No, diff = "+ (Math.Max(firstSum, secondSum)-Math.Min(firstSum,secondSum)));
}

//10
/*int numbers = int.Parse(Console.ReadLine());
int evenSum = 0;
int oddSum = 0;
for (int i = 0; i < numbers; i++)
{
    int n=int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenSum += n;
    }
    else
    {
        oddSum += n;
    }
}
if(evenSum == oddSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = "+evenSum);
}
else
{
    Console.WriteLine("No");
    Console.WriteLine("Dif = " + (Math.Max(evenSum,oddSum)-Math.Min(evenSum,oddSum)));
}
*/