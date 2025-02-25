//1 - reverse a string
/*string input = Console.ReadLine();
for(int i = input.Length -1; i >= 0; i--)
{
    Console.Write(input[i]);
}*/

//2 - reverse a string with char array
/*string input = Console.ReadLine();
char[] reversedString = new char[input.Length];
int i = 0;
for (int j = input.Length - 1; j >= 0; j--)
{
    reversedString[i] = input[j];
    i++;
}

Console.WriteLine(reversedString);*/

//3 - palindrome
/*string input = Console.ReadLine();
int j = input.Length - 1;
for(int i = 0; i <= input.Length / 2; i++)
{
    if (input[i] != input[j])
    {
        Console.WriteLine("Not Palindrome");
        return;
    }
    j--;
}
Console.WriteLine("Palindrome");*/

//4 - reverse word order in given sentence
/*string input = Console.ReadLine();
string[] splittedInput = input.Split(" ");
for(int i= splittedInput.Length-1; i>=0; i--)
{
    Console.Write(splittedInput[i] +" ");
}*/

//5 - reverse each word in a given string
/*string input = Console.ReadLine();
string[] splittedString = input.Split(" ");
string result = "";
for(int i = 0; i <= splittedString.Length-1; i++)
{
    string currentWord = splittedString[i];
    string currentResult="";
    for(int j=currentWord.Length-1;j >=0; j--)
    {
        currentResult+=currentWord[j];
    }
    result += currentResult;
    result += " ";
}
Console.WriteLine(result);*/