//1
/*string studentName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double averageGrade = double.Parse(Console.ReadLine());
Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade}");*/

//2
/*double grade= double.Parse(Console.ReadLine());
if (grade >= 3)
{
    Console.WriteLine("Passed!");
}*/

//3
/*double grade = double.Parse(Console.ReadLine());
if (grade >= 3)
{
    Console.WriteLine("Passed!");
}
else
{
    Console.WriteLine("Failed!");
}*/

//4
/*int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
minute += 30;

if (minute > 59)
{
    hour++;
    minute -= 60;
    if (hour > 23)
    {
        hour -= 24;
    }
}
Console.Write(hour + ":");
if (minute < 10)
{
    Console.WriteLine("0"+minute);
}
else
{
    Console.WriteLine(minute);
}*/

//5
/*int monthNumber = int.Parse(Console.ReadLine());
switch (monthNumber) {
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Error!");
        break;
}*/

//6
/*string countryName = Console.ReadLine();
switch (countryName) {
    case "England":
    case "USA":
        Console.WriteLine("English");
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}*/

//7
/*string dayType = Console.ReadLine();

while(!dayType.Equals("Weekday") && 
    !dayType.Equals("Weekend") && 
    !dayType.Equals("Holiday"))
{
    Console.WriteLine("Invalid day. Please, choose between Weekday, Weekend, Holiday!");
    dayType = Console.ReadLine();
}

int age = int.Parse(Console.ReadLine());
while(age<-1000 || age > 1000)
{
    Console.WriteLine("Invalid age. Please, provide number between -1000 and 1000.");
    age = int.Parse(Console.ReadLine());
}

if (dayType.Equals("Weekday"))
{
    if(age>=0 && age <= 18)
    {
        Console.WriteLine("12$");
    }else if (age>18 && age <= 64)
    {
        Console.WriteLine("18$");
    }else if ( age>64 && age <= 122)
    {
        Console.WriteLine("12$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}else if (dayType.Equals("Weekend"))
{
    if (age >= 0 && age <= 18)
    {
        Console.WriteLine("15$");
    }
    else if (age > 18 && age <= 64)
    {
        Console.WriteLine("20$");
    }
    else if (age > 64 && age <= 122)
    {
        Console.WriteLine("15$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else
{
    if (age >= 0 && age <= 18)
    {
        Console.WriteLine("5$");
    }
    else if (age > 18 && age <= 64)
    {
        Console.WriteLine("12$");
    }
    else if (age > 64 && age <= 122)
    {
        Console.WriteLine("10$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}*/

//8 - variant 1
/*for(int i = 3; i <= 100; i += 3)
{
    Console.WriteLine(i);
}*/

//8 - variant 2
/*for(int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}*/

//9
/*int n= int.Parse(Console.ReadLine());
int sum = 0;
int i = 1;
int oddNumbers = 0;
while(oddNumbers < n)
{
    if (i % 2 != 0)
    {
        sum += i;
        Console.WriteLine(i);
        oddNumbers++;
    }
    i++;

}
Console.WriteLine("Sum: "+sum);*/

//10
/*int number = int.Parse(Console.ReadLine());
for(int i = 0; i <=10; i++)
{
    Console.WriteLine(number + " X "+ i+" = "+(number*i));
}*/

//11
/*int number = int.Parse(Console.ReadLine());
int multiplier = int.Parse(Console.ReadLine());

if (multiplier < 10)
{
    for(int i = multiplier; i <= 10; i++)
    {
        Console.WriteLine(number + " X " + i + " = " + (number * i));
    }
}
else
{
    Console.WriteLine(number +" X "+multiplier+" = "+(number*multiplier));
}*/

//12
/*int number = int.Parse(Console.ReadLine());
while (number % 2 != 0)
{
    Console.WriteLine("Please write an even number.");
    number=int.Parse(Console.ReadLine());
}
Console.WriteLine("The number is: " + Math.Abs(number));*/

//13
using System.Globalization;

//MM instead of mm - (mm is for minutes, MM- for months)
//dd.mm.yyyy instead of dd.m.yyyy- because there are months with two digits
var startDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.MM.yyyy", CultureInfo.InvariantCulture);
var endDate = DateTime.ParseExact(Console.ReadLine(),
    "dd.MM.yyyy", CultureInfo.InvariantCulture);
var holidaysCount = 0;
//date=date.AddDays(1) instead of date.AddDays(1)- the second one not increase the day
//add brackets for readability
//change && with ||, because date cannot be Sunday and Saturday at the same time
for (var date = startDate; date <= endDate; date=date.AddDays(1)) {
    if (date.DayOfWeek == DayOfWeek.Saturday ||
        date.DayOfWeek==DayOfWeek.Sunday) { holidaysCount++; }
}
Console.WriteLine(holidaysCount);


