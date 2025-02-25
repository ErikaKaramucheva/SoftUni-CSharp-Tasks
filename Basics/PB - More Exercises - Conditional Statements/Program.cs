//1
/*int v = int.Parse(Console.ReadLine());
int p1 = int.Parse(Console.ReadLine());
int p2 = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double fullFromFirstPipe = p1 * h;
double fullFromSecondPipe = p2 * h;
double poolFullness = fullFromFirstPipe + fullFromSecondPipe;
if (poolFullness > v)
{
    Console.WriteLine($"For {h} hours the pool overflows with {poolFullness-v} liters.");
}
else
{
    double percentFullness = (poolFullness / v) * 100;
    Console.WriteLine($"The pool is {percentFullness}% full. Pipe 1: {Math.Round((fullFromFirstPipe/poolFullness)*100,2)}%. Pipe 2: {Math.Round((fullFromSecondPipe/poolFullness)*100,2)}%.");
}*/

//2
/*int restDays = int.Parse(Console.ReadLine());

int minutesFromRestDays = restDays * 127;
int minutesFromWorkingDays = (365 - restDays) * 63;
int totalMinutes = minutesFromRestDays+minutesFromWorkingDays;
if(totalMinutes >= 30000)
{
    Console.WriteLine("Tom will run away");
    int moreMinutes = totalMinutes - 30000;
    int hours = moreMinutes / 60;
    int min = moreMinutes % 60;
    Console.WriteLine($"{hours} hours and {min} minutes more for play");
}
else
{
    Console.WriteLine("Tom sleeps well");
    int moreMinutes = 30000-totalMinutes;
    int hours = moreMinutes / 60;
    int min = moreMinutes % 60;
    Console.WriteLine($"{hours} hours and {min} minutes less for play");
}*/

//3
/*int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());

double totalGrapes = x * y;
double wine = totalGrapes * 0.4;
double wineLiters = wine / 2.5;
if (wineLiters < z)
{
    Console.WriteLine("It will be a tough winter! More " + Math.Floor(z - wineLiters) + " liters wine needed.");
}
else
{
    Console.WriteLine("Good harvest this year! Total wine: " + Math.Floor(wineLiters) + " liters.");
    double litersPerPerson = (wineLiters-z) / workers;
    Console.WriteLine($"{(Math.Round(wineLiters - z))} liters left -> {(Math.Round(litersPerPerson))} liters per person.");
}*/

//4
/*int n = int.Parse(Console.ReadLine());
string dateTime = Console.ReadLine();

double priceWithTaxi = 0.7;
double priceWithBus = 0;
double priceWithTrain = 0;

//calculate price with taxi
if (dateTime.Equals("day"))
{
    priceWithTaxi += n * 0.79;
}
else
{
    priceWithTaxi += n * 0.9;
}

//calculate price with bus
priceWithBus= n*0.09;

//calculate price with train
priceWithTrain = n * 0.06;

if (n < 20)
{
    Console.WriteLine("With taxi: " + Math.Round(priceWithTaxi,2));
}else if (n > 20 && n < 100)
{
    if(priceWithTaxi > priceWithBus)
    {
        Console.WriteLine("With bus: " + Math.Round(priceWithBus,2));
    }
    else
    {
        Console.WriteLine("With taxi: "+ Math.Round(priceWithTaxi,2));
    }
}
else
{
    if(priceWithTaxi<priceWithBus && priceWithTaxi < priceWithTrain)
    {
        Console.WriteLine("With taxi:" + Math.Round(priceWithTaxi,2));
    }else if(priceWithBus<priceWithTaxi && priceWithBus < priceWithTrain)
    {
        Console.WriteLine("With bus: " + Math.Round(priceWithBus, 2));
    }
    else
    {
        Console.WriteLine("With train: " + Math.Round(priceWithTrain,2));
    }
}*/

//5
/*int days = int.Parse(Console.ReadLine());
int foodInKg = int.Parse(Console.ReadLine());
double dogFoodPerDay = double.Parse(Console.ReadLine());
double catFoodPerDay = double.Parse(Console.ReadLine());
double turtleFoodPerDay = double.Parse(Console.ReadLine());
turtleFoodPerDay /= 1000;
double neededFoodForDog = days* dogFoodPerDay;
double neededFoodForTurtle = days* turtleFoodPerDay;
double neededFoodForCat = days* catFoodPerDay;

double totalNeededFood = neededFoodForCat + neededFoodForDog + neededFoodForTurtle;
if (totalNeededFood < foodInKg)
{
    Console.WriteLine($"{Math.Floor(foodInKg - totalNeededFood)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(totalNeededFood - foodInKg)} more kilos of food are needed.");
}*/

//6
/*int magnolias = int.Parse(Console.ReadLine());
int hyacinths = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int cactuses = int.Parse(Console.ReadLine());
double priceForPresent = double.Parse(Console.ReadLine());
double totalPrices = (3.25*magnolias)+(4*hyacinths)+(3.5*roses)+(8*cactuses);
totalPrices -= totalPrices * 0.05;
if (totalPrices >= priceForPresent)
{
    Console.WriteLine($"She is left with {Math.Floor(totalPrices-priceForPresent)} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling( priceForPresent- totalPrices)} leva.");
}*/

//7
/*string fuelType = Console.ReadLine();
int liters = int.Parse(Console.ReadLine());
switch (fuelType)
{
    case "Diesel":
    case "Gasoline":
    case "Gas":
        if (liters >= 25)
        {
            Console.WriteLine("You have enough " + fuelType+".");
        }
        else
        {
            Console.WriteLine("Fill your tank with " + fuelType+"!");
        }
        break;
    default:
        Console.WriteLine("Invalid fuel!");
        break;
}*/

//8
string fuelType= Console.ReadLine();
double liters = double.Parse(Console.ReadLine());
string hasCard = Console.ReadLine();

double gasolinePricePerLiter = 2.22;
double dieselPricePerLiter = 2.33;
double gasPricePerLiter = 0.93;

double totalPrice = 0;
switch (fuelType)
{
    case "Gas":
        totalPrice += gasPricePerLiter * liters;
        if (hasCard.Equals("Yes"))
        {
            totalPrice -= liters * 0.08;
        }
        break;
    case "Gasoline":
        totalPrice += gasolinePricePerLiter * liters;
        if (hasCard.Equals("Yes"))
        {
            totalPrice -= liters * 0.18;
        }
        break;
    case "Diesel":
        totalPrice += dieselPricePerLiter * liters;
        if (hasCard.Equals("Yes"))
        {
            totalPrice -= liters * 0.12;
        }
        break;
    default: break;
}
if (liters>=20 && liters<=25)
{
    totalPrice -=totalPrice * 0.08;
}else if (liters > 25)
{
    totalPrice -= totalPrice * 0.1;
}
Console.WriteLine(Math.Round(totalPrice, 2) + " lv.");