//1
/*int currentAge = 18;
double inheritance = double.Parse(Console.ReadLine());
int endYear = int.Parse(Console.ReadLine());

for(int i = 1800; i <= endYear; i++)
{
    if (i % 2 == 0)
    {
        inheritance -= 12000;
    }
    else
    {
        inheritance -= (12000 + (50 * currentAge));
    }
    currentAge++;

}

if (inheritance >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Round(inheritance,2)} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Round(-inheritance,2)} dollars to survive.");
}*/

//2
/*int period = int.Parse(Console.ReadLine());
int doctors = 7;
int treatedPatient = 0;
int untreatedPatient = 0;
for (int i = 0; i < period; i++)
{
    if ((i+1) % 3 == 0)
    {
        if (treatedPatient < untreatedPatient)
        {
            doctors++;
        }
    }
    int patient = int.Parse(Console.ReadLine());
    if (patient >= doctors)
    {
        treatedPatient += doctors;
        untreatedPatient += (patient-doctors);
    }
    else
    {
        treatedPatient += patient;
    }
}
Console.WriteLine($"Treated patients: {treatedPatient}");
Console.WriteLine($"Untreated patients: {untreatedPatient}");*/

//3
/*int countOfLoads = int.Parse(Console.ReadLine());
int tons = 0;
double percentWithBus = 0;
double percentWithTruck = 0;
double percentWithTrain = 0;

for (int i = 0; i < countOfLoads; i++)
{
  int currentTonsOfLoads= int.Parse(Console.ReadLine());
    tons += currentTonsOfLoads;
    if (currentTonsOfLoads <= 3)
    {
        percentWithBus += currentTonsOfLoads;
    }
    else if (currentTonsOfLoads >= 4 && currentTonsOfLoads <= 11)
    {
        percentWithTruck+=currentTonsOfLoads;
    }
    else
    {
        percentWithTrain+= currentTonsOfLoads;
    }

}
double averagePricePerTon = ((percentWithBus * 200) + (percentWithTruck * 175) + (percentWithTrain * 120) )/tons;

percentWithBus = (percentWithBus/tons)*100;
percentWithTruck= (percentWithTruck/tons)*100;
percentWithTrain= (percentWithTrain/tons)*100;

Console.WriteLine(Math.Round(averagePricePerTon, 2));
Console.WriteLine(Math.Round(percentWithBus, 2) +"%");
Console.WriteLine(Math.Round(percentWithTruck, 2) +"%");
Console.WriteLine(Math.Round(percentWithTrain, 2) +"%");*/

//4
/*int countOfStudents = int.Parse(Console.ReadLine());
int countOfFailedStudents = 0;
int countOfStudentsWithGrade3 = 0;
int countOfStudentsWithGrade4 = 0;
int countOfTopStudents = 0;
double sumOfGrades = 0;
for(int i = 0; i < countOfStudents; i++)
{
    double currentGrade = double.Parse(Console.ReadLine());
    sumOfGrades += currentGrade;
    if (currentGrade <= 2.99)
    {
        countOfFailedStudents++;
    }
    else if (currentGrade >= 3 && currentGrade < 4)
    {
        countOfStudentsWithGrade3++;
    }
    else if (currentGrade >= 4 && currentGrade < 5)
    {
        countOfStudentsWithGrade4++;
    }
    else
    {
        countOfTopStudents++;
    }
}

double averageGrade= sumOfGrades/countOfStudents;
double topStudentsPercent = ((double)countOfTopStudents / (double)countOfStudents )* 100;
double studentsWith3Percent = ((double)countOfStudentsWithGrade3 / (double)countOfStudents) * 100;
double studentsWith4Percent = ((double)countOfStudentsWithGrade4 / (double)countOfStudents) * 100;
double failedStudentsPercent = ((double)countOfFailedStudents / (double)countOfStudents) * 100;

Console.WriteLine($"Top students: {Math.Round(topStudentsPercent,2)}%");
Console.WriteLine($"Between 4.00 an 4.99: {Math.Round(studentsWith4Percent,2)}%");
Console.WriteLine($"Between 3.00 an 3.99: {Math.Round(studentsWith3Percent,2)}%");
Console.WriteLine($"Fail: {Math.Round(failedStudentsPercent, 2)}%");
Console.WriteLine($"Average: {Math.Round(averageGrade,2)}");*/

//5
/*int turns = int.Parse(Console.ReadLine());

double finalResult = 0;
int numbersToNine = 0;
int numbersToNineteen = 0;
int numbersToTwentyNine = 0;
int numbersToThirtyNine = 0;
int numbersToFifty = 0;
int invalidNumbers = 0;

for(int i = 0; i < turns; i++)
{
    int currentNumber=int.Parse(Console.ReadLine());
    if(currentNumber < 0 || currentNumber>50)
    {
        invalidNumbers++;
        finalResult /= 2;
    }else if(currentNumber >= 0 && currentNumber <= 9)
    {
        numbersToNine++;
        finalResult += (currentNumber * 0.2);
    }
    else if (currentNumber >= 10 && currentNumber <= 19)
    {
        numbersToNineteen++;
        finalResult += (currentNumber * 0.3);
    }
    else if (currentNumber >= 20 && currentNumber <= 29)
    {
        numbersToTwentyNine++;
        finalResult += (currentNumber * 0.4);
    }
    else if (currentNumber >= 30 && currentNumber <= 39)
    {
        numbersToThirtyNine++;
        finalResult += 50;
    }else if (currentNumber >= 40 && currentNumber <= 50)
    {
        numbersToFifty++;
        finalResult += 100;
    }
}

Console.WriteLine(Math.Round(finalResult, 2));
Console.WriteLine($"From 0 to 9: {Math.Round(((double)numbersToNine/turns*100),2)}%");
Console.WriteLine($"From 10 to 19: {Math.Round(((double)numbersToNineteen/turns*100),2)}%");
Console.WriteLine($"From 20 to 29: {Math.Round(((double)numbersToTwentyNine/turns*100),2)}%");
Console.WriteLine($"From 30 to 39: {Math.Round(((double)numbersToThirtyNine/turns*100),2)}%");
Console.WriteLine($"From 40 to 50: {Math.Round(((double)numbersToFifty/turns*100),2)}%");
Console.WriteLine($"Invalid numbers: {Math.Round(((double)invalidNumbers/turns*100),2)}%");
*/

//6
/*int months = int.Parse(Console.ReadLine());
double price = 0;
double lvForElectricity = 0;
double lvForWater = months*20;
double lvForInternet = months*15;
double lvForOther = 0;
for(int i = 0; i < months; i++)
{
    double currentPriceForElectricity= double.Parse(Console.ReadLine());
    lvForElectricity += currentPriceForElectricity;
    double currentLvForOther = (35 + currentPriceForElectricity);
    lvForOther += currentLvForOther + (0.2 * currentLvForOther);
}
price = (lvForElectricity+lvForInternet + lvForWater+lvForOther)/months;
Console.WriteLine($"Electricity: {Math.Round(lvForElectricity,2)} lv");
Console.WriteLine($"Water: {Math.Round(lvForWater,2)} lv");
Console.WriteLine($"Internet: {Math.Round(lvForInternet,2)} lv");
Console.WriteLine($"Other: {Math.Round(lvForOther,2)} lv");
Console.WriteLine($"Average: {Math.Round(price,2)} lv");*/

//7
/*int capacity = int.Parse(Console.ReadLine());
int countOfFans = int.Parse(Console.ReadLine());
int countOfA = 0;
int countOfB = 0;
int countOfV = 0;
int countOfG = 0;
for(int i=0;i<countOfFans;i++)
{
    string sector=Console.ReadLine();
    if (sector.Equals("A"))
    {
        countOfA++;
    }else if(sector.Equals("B")) { countOfB++; }
    else if(sector.Equals("V")) {countOfV++; }
    else {countOfG++; }
}
Console.WriteLine(Math.Round(((double)countOfA/countOfFans*100),2) +"%");
Console.WriteLine(Math.Round(((double)countOfB/countOfFans*100),2) + "%");
Console.WriteLine(Math.Round(((double)countOfV/countOfFans*100),2) + "%");
Console.WriteLine(Math.Round(((double)countOfG/countOfFans*100),2) + "%");
Console.WriteLine(Math.Round(((double)countOfFans/capacity*100),2) + "%");*/

//8
/*int n = int.Parse(Console.ReadLine());
int maxValue = int.MinValue;
int previous = 0;
bool isFirst = true;
int num1;
int num2;
for (int i = 0; i < n; i++)
{
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());
    int currentSum = num1 + num2;

    if (isFirst)
    {
        previous = currentSum;
        isFirst = false;
    }
    else
    {
        if (currentSum != previous)
        {
            if (currentSum > maxValue)
            {
                maxValue = currentSum;
            }
        }
        previous = currentSum;
    }
}
if (maxValue == int.MinValue)
{
    Console.WriteLine("Yes, value = " + previous);
}
else
{
    Console.WriteLine("No, max diff = " + maxValue);
}*/

//9
/*for(int i = 0; i < 24; i++)
{
    for(int j = 0; j < 60; j++)
    {
        Console.WriteLine(i + ":" + j);
    }
}*/

//10
/*for(int i = 0; i < 24; i++)
{
    for(int j = 0; j < 60; j++)
    {
        for(int k=0;k< 60; k++)
        {
            Console.WriteLine(i+":"+j+":"+k);
        }
    }
}*/

//11
int n = int.Parse(Console.ReadLine());
double oddSum = 0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;
double evenSum = 0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;
for (int i = 1; i <= n; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        evenSum += currentNumber;
        if (evenMin > currentNumber)
        {
            evenMin = currentNumber;
        }
        if (evenMax < currentNumber)
        {
            evenMax = currentNumber;
        }
    }
    else
    {
        oddSum += currentNumber;
        if (oddMin > currentNumber)
        {
            oddMin = currentNumber;
        }
        if (oddMax < currentNumber)
        {
            oddMax = currentNumber;
        }
    }
}
Console.WriteLine("OddSum = " + oddSum);
if (oddMin != double.MaxValue)
{
    Console.WriteLine("OddMin = " + oddMin);
}
else
{
    Console.WriteLine("No");
}
if (oddMax != double.MinValue)
{
    Console.WriteLine("OddMax = " + oddMax);
}
else
{
    Console.WriteLine("No");
}
Console.WriteLine("EvenSum = " + evenSum);
if (evenMin != double.MaxValue)
{
    Console.WriteLine("EvenMin = " + evenMin);
}
else
{
    Console.WriteLine("No");
}
if (evenMax != double.MinValue)
{
    Console.WriteLine("EvenMax = " + evenMax);
}
else
{
    Console.WriteLine("No");
}
