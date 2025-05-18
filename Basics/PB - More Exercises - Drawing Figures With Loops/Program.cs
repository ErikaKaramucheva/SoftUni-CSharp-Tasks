//1
/*for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

//2
/*int n = int.Parse(Console.ReadLine());
for(int i=0;i<n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

//3
/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}*/

//4
/*int n=int.Parse(Console.ReadLine());
for (int i=1; i<=n; i++)
{
    for (int j=0; j<i; j++)
    {
        Console.Write("$ ");
    }
    Console.WriteLine();
}*/

//5
/*int n=int.Parse(Console.ReadLine());
for (int i=0; i<n; i++)
{
    if (i == 0 || i == n - 1)
    {
        Console.Write("+ ");
    }
    else
    {
        Console.Write("| ");
    }
    for (int j=1; j<n-1; j++)
    {
        Console.Write("- ");
    }
    if (i == 0 || i == n - 1)
    {
        Console.Write("+ ");
    }
    else
    {
        Console.Write("| ");
    }
    Console.WriteLine();
}*/

//6
/*int n=int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    for(int j = 0; j <=i; j++)
    {
        Console.Write("* ");

    }
    Console.WriteLine();

}
for(int i = n - 1; i >= 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("* ");

    }
    Console.WriteLine();
}*/

//7
/*int n= int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    for (int j = n; j >0; j--)
    {
        if (j <=i)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.Write("|");
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/

//8
/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{

    if (i == 0 || i == n - 1)
    {
        for (int k = 0; k < (2 * n); k++)
        {
            Console.Write("*");
        }
        for (int k = 0; k < n; k++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < (2 * n); k++)
        {
            Console.Write("*");
        }
    }
    else
    {
        Console.Write("*");
        for (int k = 1; k < (2 * n) - 1; k++)
        {
            Console.Write("/");
        }
        Console.Write("*");
        if (i == ((n - 1) / 2))
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write("|");
            }
        }
        else
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write(" ");
            }
        }
        Console.Write("*");
        for (int k = 0; k < (2 * n) - 1; k++)
        {
            Console.Write("/");
        }
        Console.Write("*");
    }

    Console.WriteLine();
}*/

//9
/*int n = int.Parse(Console.ReadLine());
int currentStars = 1;
if (n % 2 == 0)
{
    currentStars++;
}
for (int i = 0; i < (n + 1) / 2; i++)
{
    int sideDashes = (n-currentStars) / 2;
    for(int j = 0; j < sideDashes; j++)
    {
        Console.Write("_");
    }
    for(int k=0; k < currentStars; k++)
    {
        Console.Write("*");
    }
    for(int j = 0;j < sideDashes; j++)
    {
        Console.Write("_");
    }
    currentStars += 2;

    Console.WriteLine();
}
for (int i = 0; i < (n / 2); i++)
{
    for (int k = 0; k < n; k++)
    {
        if (k == 0 || k == n - 1)
        {
            Console.Write("|");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}*/

//10
int n = int.Parse(Console.ReadLine());
int stars = (n % 2 == 0) ? n - 1 : n;
int leftRight = (n - 1) / 2;
int mid = n - 2 * leftRight - 2;
for (int i = 0; i < stars; i++)
{
    leftRight = Math.Abs((n - 1) / 2 - i);
    mid = n - 2 * leftRight - 2;
    for (int j = 0; j < leftRight; j++)
    {
        Console.Write("_");
    }
    Console.Write("*");
    if (mid >= 0)
    {
        for (int j = 0; j < mid; j++)
        {
            Console.Write("_");
        }
        Console.Write("*");
    }

    for (int j = 0; j < leftRight; j++)
    {
        Console.Write("_");
    }
    Console.WriteLine();
}
