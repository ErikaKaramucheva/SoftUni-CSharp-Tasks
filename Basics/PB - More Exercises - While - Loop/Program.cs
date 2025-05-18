//1
/*int bottlesOfDetergent = int.Parse(Console.ReadLine());
int detergent = 750 * bottlesOfDetergent;
string command=Console.ReadLine();
int i = 1;
int plates = 0;
int pots = 0;
while (!command.Equals( "End"))
{
    int countOfVessels = int.Parse(command);
    int ml = 5;
    if (i % 3 == 0)
    {
        ml = 15;
        pots += countOfVessels;
    }
    else
    {
        plates += countOfVessels;
    }
    int neededMl = ml * countOfVessels;

    if (neededMl > detergent)
    {
        Console.WriteLine("Not enough detergent, " + (neededMl - detergent) + " ml. more necessary!");
        return;
    }


    command =Console.ReadLine();
    i++;
    detergent-=neededMl;
}
Console.WriteLine("Detergent was enough!");
Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
Console.WriteLine($"Leftover detergent {detergent} ml.");*/

//2
/*int sum=int.Parse(Console.ReadLine());
string command=Console.ReadLine();
int i = 1;
int byCash = 0;
int byCard = 0;
while (!command.Equals("End"))
{
    int current = int.Parse(command);
    if (i%2==0)
    {
        if (current > 10)
        {
            byCard+= current;
            Console.WriteLine("Product sold!");
        }
        else
        {
            Console.WriteLine("Error in transaction!");
        }
    }
    else
    {
        if (current<100)
        {
            byCash+= current;
            Console.WriteLine("Product sold!");
        }
        else
        {
            Console.WriteLine("Error in transaction!");
        }
    }
    if ((byCard+byCash) >= sum)
    {
        double averageCs = (double)byCash/2;
        double averageCc = (double)byCard/2;
        Console.WriteLine("Average CS: " + Math.Round(averageCs,2));
        Console.WriteLine("Average CC: " + Math.Round(averageCc,2));
        return;
    }
    command = Console.ReadLine();
    i++;
}
Console.WriteLine("Failed to collect required money for charity.");*/

//3
/*string result = "";
string current = Console.ReadLine(); ;
List<string> unsupportedLetters = ["c", "o", "n"];
do
{
    if (unsupportedLetters.Contains(current))
    {
        unsupportedLetters.Remove(current);
    }
    else
    {
        char c = char.Parse(current);
        if ((c >= 'a' && c <= 'z')||(c>='A'&& c<='Z'))
        {
            result += current;
        }
    }
    if (unsupportedLetters.Count == 0)
    {
        unsupportedLetters = ["c", "o", "n"];
        Console.Write(result+" \n");
        result = "";
    }
    current = Console.ReadLine();

} while (!current.Equals("End"));*/

//4 - 1
/*for(int i = 0; i < 100; i++)
{
    if(i%3== 0)
    {
        Console.WriteLine(i);
    }
}*/

//4 - 2
/*for(int i = 3; i < 100; i += 3)
{
    Console.WriteLine(i);
}*/

//5
int n=int.Parse(Console.ReadLine());
double sum = 0;
for(int i=0;i<n; i++)
{
    sum += int.Parse(Console.ReadLine());
}
double average = sum / n;
Console.WriteLine(Math.Round(average,2));
