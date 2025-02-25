// See https://aka.ms/new-console-template for more information
//1
/*int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());
int sum_time = first + second + third;
int minutes =sum_time/60;
int seconds = sum_time%60;
if (seconds < 10)
{
    Console.WriteLine(minutes + ":0" + seconds);
}
else
{
    Console.WriteLine(minutes + ":" + seconds);
}

//2
int init = int.Parse(Console.ReadLine());
double bonus = 0.0;
if (init <= 100)
{
    bonus += 5;
}else if (init > 100 && init<1000)
{
    bonus += init * 0.2;
}else if (init > 1000)
{
    bonus += init * 0.1;
}
if (init % 2 == 0)
{
    bonus += 1;
}
if (init % 10 == 5)
{
    bonus += 2;
}
Console.WriteLine(bonus);
Console.WriteLine(bonus+init);

//3
int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
//with while for  correct results
if (hour > 24 || hour < 0)
{
    Console.WriteLine("Invalid data! The hour must be between 0 and 23!");
    hour = int.Parse(Console.ReadLine());
}
if(minute<0 || minute > 59)
{
    Console.WriteLine("Invalid data! The minutes must be between 0 and 59!");
    minute = int.Parse(Console.ReadLine());
}
minute += 15;
if (minute >= 60)
{
    hour += 1;
    minute -= 60;
    if (hour == 24)
    {
        hour = 0;
    }
}

if (minute < 10)
{
    Console.WriteLine(hour + ":0" + minute);
}
else {
    Console.WriteLine(hour + ":" + minute); }

//4
double puzzel_price = 2.6;
double doll_price = 3;
double bear = 4.1;
double minion = 8.2;
double truck = 2;

double trip_price = Double.Parse(Console.ReadLine());
int puzzels_count = int.Parse(Console.ReadLine());
int dolls_count = int.Parse(Console.ReadLine());
int bears_count = int.Parse(Console.ReadLine());
int minions_count = int.Parse(Console.ReadLine());
int trucks_count = int.Parse(Console.ReadLine());

double sum= (puzzel_price * puzzels_count) + (dolls_count * doll_price) + (bear*bears_count)+(minion*minions_count)+(truck*trucks_count);
int toys_count = puzzels_count + dolls_count + bears_count + minions_count + trucks_count;
if (toys_count >= 50)
{
    sum -= (sum * 0.25);
}
sum -= sum * 0.1;
if (sum >= trip_price)
{
    Console.WriteLine("Yes! " +(sum - trip_price) + " lv left.");
}
else
{
    Console.WriteLine("Not enough money! " + (trip_price - sum) + " lv needed.");
}*/

//5
/*double budget = Double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double equipmentPriceForOne = double.Parse(Console.ReadLine());
double decor = budget * 0.1;
double equipmentPriceForAll = equipmentPriceForOne * statists;
if (statists > 150)
{
    equipmentPriceForAll -= equipmentPriceForAll * 0.1;
}
double neededMoney=decor+equipmentPriceForAll;
if(neededMoney > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine("Wingard needs " + Math.Round(neededMoney - budget,2) + " leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine("Wingard starts filming with " + Math.Round(budget - neededMoney,2) + " leva left.");
}*/

//6
/*double recordInSec = Double.Parse(Console.ReadLine());
double distanceInMeters = Double.Parse(Console.ReadLine());
double timeForOneMeterInSeconds = Double.Parse(Console.ReadLine());
double caluclateBeforeDelay = timeForOneMeterInSeconds * distanceInMeters;
Console.WriteLine("Before delay: " + caluclateBeforeDelay);
double delay = Math.Floor((distanceInMeters / 15) * 12.5);
Console.WriteLine("Delay: " + delay);
double calculation = caluclateBeforeDelay+delay;
//double difWithWorldRecord = Math.Max(recordInSec, caluclation) - Math.Min(recordInSec, caluclation);
if (calculation < recordInSec)
{
    Console.WriteLine("Yes, he succeeded! The new world record is " + Math.Round(calculation) + " seconds.");
    Console.WriteLine("Difference between world record and Ivan's record: " + Math.Round((recordInSec - calculation), 2)+" seconds.");
}
else
{
    Console.WriteLine("No, he failed! He was " + Math.Round((calculation - recordInSec), 2) + " seconds slower.");
}*/

//7
/*double budget = Double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramMemoryCount = int.Parse(Console.ReadLine());

int videoCardsPricePerOne = 250;
int totalVideoCardsPrice = videoCardsPricePerOne * videoCardsCount;
Console.WriteLine(totalVideoCardsPrice);
double processorsPrice = 0.35 * totalVideoCardsPrice;
double totalProcessorsPrice =processorsCount*processorsPrice;
Console.WriteLine(totalProcessorsPrice);
double memoryPrice = 0.10 * totalVideoCardsPrice;
double totalMemoryPrice = memoryPrice*ramMemoryCount;
Console.WriteLine(totalMemoryPrice);
double totalPrice = totalVideoCardsPrice + totalProcessorsPrice + totalMemoryPrice;
Console.WriteLine(totalPrice);
if(videoCardsCount > processorsCount)
{
    totalPrice -= totalPrice * 0.15;
    Console.WriteLine("We have discount. The new total price is: " + totalPrice);
}

if(budget > totalPrice)
{
    Console.WriteLine(" You have " + Math.Round((budget - totalPrice), 2) + " leva left!");
}
else
{
    Console.WriteLine(" Not enough money! You need " + Math.Round((totalPrice - budget), 2) + " leva more!");
}*/

//8
string title = Console.ReadLine();
int episodDuration = int.Parse(Console.ReadLine());
int restDuration = int.Parse(Console.ReadLine());
double lunchTime = (double)restDuration / 8;
Console.WriteLine(lunchTime);
double recreationTime = (double)restDuration / 4;
Console.WriteLine(recreationTime);
double timeForWatching = restDuration - (lunchTime + recreationTime);
Console.WriteLine(timeForWatching);
if(timeForWatching >= episodDuration)
{
    Console.WriteLine("You have enough time to watch " + title + " and left " + Math.Ceiling(timeForWatching - episodDuration) + " minutes free time.");
}
else
{
    Console.WriteLine("You don't have enough time to watch " + title + ", you need " + Math.Ceiling(episodDuration - timeForWatching) + " more minutes.");
}



