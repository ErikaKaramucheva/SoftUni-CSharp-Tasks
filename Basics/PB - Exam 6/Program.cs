//01 - Birthday Party
/*double rent = double.Parse(Console.ReadLine());

double cakePrice = 0.2 * rent;
double drinks= cakePrice- (0.45*cakePrice);
double animator = rent / 3;
double total= rent+cakePrice+drinks+animator;
Console.WriteLine(total);*/

//01 - Change Bureau
/*int bitcoinsCount= int.Parse(Console.ReadLine());
double yuanCount = double.Parse(Console.ReadLine());
double commission= double.Parse(Console.ReadLine());

double yuanToDollar = yuanCount * 0.15;
double yuanToLv = yuanToDollar * 1.76;
double lv = (bitcoinsCount * 1168) + yuanToLv;
double euro = lv / 1.95;
euro -= euro * (commission/100);
Console.WriteLine(Math.Round(euro, 2));*/

//02 - Cat Walking
/*int minutes=int.Parse(Console.ReadLine());
int count=int.Parse(Console.ReadLine());
int calories=int.Parse(Console.ReadLine());
int burnedCalories = minutes * count * 5;
if(burnedCalories< (calories / 2))
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}");
}
else
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}");
}*/

//02 - Mountain Run
/*double recordInSeconds= double.Parse(Console.ReadLine());
double distance= double.Parse(Console.ReadLine());
double timeFor1Meter= double.Parse(Console.ReadLine());
double decrease = Math.Floor(distance / 50);
double time = (timeFor1Meter * distance) + (decrease * 30);
if (time >= recordInSeconds)
{
    Console.WriteLine($"No! He was {Math.Round(time-recordInSeconds,2)} seconds slower.");
}
else
{
    Console.WriteLine($"Yes! The new record is {time} seconds.");
}*/

//03 - Energy Booster
/*string fruit = Console.ReadLine();
string dimension = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
double price = 0;
if (dimension.Equals("small"))
{
    count *= 2; // multiply count of cuts by fruits in cuts to find total number.
    switch (fruit)
    {
        case "Watermelon": price = 56; break;
        case "Mango": price = 36.66; break;
        case "Pineapple": price = 42.1; break;
        default: price = 20; break;
    }
}
else
{
    count *= 5;
    switch (fruit)
    {
        case "Watermelon": price = 28.7; break;
        case "Mango": price = 19.6; break;
        case "Pineapple": price = 24.8; break;
        default: price = 15.2; break;
    }
}

price = price * count;
if(price >=400 && price <= 1000)
{
    price -= price * 0.15;
}else if (price > 1000)
{
    price /= 2;
}

Console.WriteLine(Math.Round(price, 2) + " lv.");*/

//03 - Fitness Card
/*double sum = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());
int age= int.Parse(Console.ReadLine());
string sport=Console.ReadLine();
double price = 0;
if (gender.Equals('m'))
{
    switch (sport)
    {
        case "Gym": price = 42; break;
        case "Boxing": price = 41; break;
        case "Yoga": price = 45; break;
        case "Zumba": price = 34; break;
        case "Dances": price = 51; break;
        default: price = 39; break;
    }
}
else
{
    switch (sport)
    {
        case "Gym": price = 35; break;
        case "Boxing": price = 37; break;
        case "Yoga": price = 42; break;
        case "Zumba": price = 31; break;
        case "Dances": price = 53; break;
        default: price = 37; break;
    }
}
if (age <= 19)
{
    price -= price * 0.2;
}
if (sum >= price)
{
    Console.WriteLine("You purchased a 1 month pass for " + sport);
}
else
{
    Console.WriteLine($"You don't have enough money! You need ${Math.Round(price-sum,2)} more.");
}*/

//04 - Food For Pets
/*int days= int.Parse(Console.ReadLine());
double totalFoods= double.Parse(Console.ReadLine());
int eatenFromCat = 0;
int eatenFromDog = 0;
int day = 1;
double biscuits = 0;
for(int i = 0; i < days; i++)
{
    int dog = int.Parse(Console.ReadLine());
    int cat = int.Parse(Console.ReadLine());
    eatenFromCat += cat;
    eatenFromDog += dog;
    if (day == 3)
    {
        biscuits += (cat + dog) * 0.1;
        day = 1;
    }
    else
    {
        day++;
    }
}
Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
Console.WriteLine($"{Math.Round((double)((eatenFromDog + eatenFromCat) / totalFoods) * 100,2)}% of the food has been eaten.");
Console.WriteLine($"{Math.Round(((double)eatenFromDog / (double)(eatenFromDog + eatenFromCat)) * 100,2)}% eaten from the dog.");
Console.WriteLine($"{Math.Round(((double) eatenFromCat/(double)(eatenFromDog + eatenFromCat) ) * 100,2)}% eaten from the cat.");
*/

//04 - Trekking Mania
/*int groups = int.Parse(Console.ReadLine());
int peopleForMussala = 0;
int peopleForMonblan = 0;
int peopleForKilimandzharo = 0;
int peopleForK2 = 0;
int peopleForEverest = 0;
int total = 0;
for (int i = 0; i < groups; i++)
{
    int count = int.Parse(Console.ReadLine());
    total += count;
    if (count <= 5)
    {
        peopleForMussala += count;
    }
    else if (count > 5 && count <= 12)
    {
        peopleForMonblan += count;
    }
    else if (count > 12 && count <= 25)
    {
        peopleForKilimandzharo += count;
    }
    else if (count > 25 && count <= 40)
    {
        peopleForK2 += count;
    }
    else
    {
        peopleForEverest+= count;
    }
}
Console.WriteLine(Math.Round(((double)peopleForMussala / total) * 100, 2) + "%");
Console.WriteLine(Math.Round(((double)peopleForMonblan / total) * 100, 2) + "%");
Console.WriteLine(Math.Round(((double)peopleForKilimandzharo / total) * 100, 2) + "%");
Console.WriteLine(Math.Round(((double)peopleForK2 / total) * 100, 2) + "%");
Console.WriteLine(Math.Round(((double)peopleForEverest / total) * 100, 2) + "%");*/

//05 - Puppy Care
/*int foodInKg = int.Parse(Console.ReadLine());
int foodInGrams = foodInKg * 1000;
string command = Console.ReadLine();
int eaten = 0;
while (!command.Equals("Adopted"))
{
    eaten += int.Parse(command);
    command = Console.ReadLine();
}
if (eaten <= foodInGrams)
{
    Console.WriteLine($"Food is enough! Leftovers: {foodInGrams- eaten} grams.");
}
else
{
    Console.WriteLine($"Food is not enough. You need {eaten - foodInGrams} grams more.");
}*/

//05 - Suitcase Load
/*double capacity = double.Parse(Console.ReadLine());
string command=Console.ReadLine();
double busySpace = 0;
int total = 0;
while (!command.Equals("End"))
{
    double currentVolume=double.Parse(command);
    if (total % 3 == 0)
    {
        currentVolume += currentVolume * 0.1;
    }
    if(busySpace+currentVolume > capacity)
    {
        Console.WriteLine("No more space!");
        Console.WriteLine("Statistics: " + total + " suitcases loaded.");
        return;
    }
    busySpace += currentVolume;
    total++;
    command=Console.ReadLine();
}
Console.WriteLine("Congratulations! All suitcases are loaded!");
Console.WriteLine("Statistics: " + total + " suitcases loaded.");*/

//06 - Tournament Of Christmas
int days= int.Parse(Console.ReadLine());
double sum = 0;
int totalGames = 0;
int wonGames = 0;
for(int i = 0; i < days; i++)
{
    string sport=Console.ReadLine();
    int currentDayWin = 0;
    int currentDayLost = 0;
    double currentSum = 0;
    while (!sport.Equals("Finish"))
    {
        string result=Console.ReadLine() ;
        if (result.Equals("win"))
        {
            currentDayWin++;
            currentSum += 20;
        }
        else
        {
            currentDayLost++;
        }
        
        sport= Console.ReadLine();
    }
    if (currentDayWin > currentDayLost)
    {
        currentSum += currentSum * 0.1;
        wonGames++;

    }
    sum += currentSum;
    totalGames++;
}
if (wonGames > (totalGames - wonGames))
{
    sum += sum * 0.2;
    Console.WriteLine("You won the tournament! Total raised money: " + Math.Round(sum, 2));
}
else
{
    Console.WriteLine("You lost the tournament! Total raised money: " + Math.Round(sum, 2));
}
