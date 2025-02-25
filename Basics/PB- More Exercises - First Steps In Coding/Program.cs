//1
/*double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double area = (b1 + b2) * h / 2;
Console.WriteLine(Math.Round(area,2));*/

//2
/*double a = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double area = a * h / 2;
Console.WriteLine(Math.Round(area, 2));*/

//3
/*double degrees = double.Parse(Console.ReadLine());
double farenheit = (1.8 * degrees) + 32;
Console.WriteLine(Math.Round(farenheit,2));*/

//4
/*double priceForKgVegetables = double.Parse(Console.ReadLine());
double priceForKgFruit = double.Parse(Console.ReadLine());
int kgVegetables = int.Parse(Console.ReadLine());
int kgFruits = int.Parse(Console.ReadLine());

double totalPriceInEuro = (priceForKgFruit*kgFruits) + (priceForKgVegetables*kgVegetables);
double totalPriceInLv = totalPriceInEuro / 1.94;
Console.WriteLine(Math.Round(totalPriceInLv,2));*/

//5
/*double h = double.Parse(Console.ReadLine());
double w = double.Parse(Console.ReadLine());

w *= 100;
h *= 100;
w -= 100;
int deskForRow = (int)(w / 70);
int deskForCol = (int)(h / 120);
int totalDesks=deskForCol*deskForRow;
totalDesks -= 3;
Console.WriteLine(totalDesks);*/

//6
/*double mackerelPrice = double.Parse(Console.ReadLine());
double spratPrice = double.Parse(Console.ReadLine());
double bonitoKg = double.Parse(Console.ReadLine());
double horseMackerelKg = double.Parse(Console.ReadLine());
int musselsKg = int.Parse(Console.ReadLine());

double bonitoTotalPrice = bonitoKg * (mackerelPrice+(0.6 * mackerelPrice));
double horseMackerelTotalPrice = horseMackerelKg * (spratPrice + (0.8 * spratPrice) );
double musselsTotalPrice = musselsKg * 7.5;

double totalPrice = bonitoTotalPrice + horseMackerelTotalPrice + musselsTotalPrice;
Console.WriteLine(Math.Round(totalPrice, 2));*/

//7
/*double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double litersOfGreenPaint = 0;
double litersOfRedPaint = 0;

double frontWall = x*x;
double doorArea = 1.2 * 2;
double frontWallWithoutDoor = frontWall- doorArea;
double backWall = x * x;
double windowArea = 1.5 * 1.5;
double sideWall = (x * y) -windowArea;
double wallArea = frontWallWithoutDoor + backWall + (sideWall * 2);
litersOfGreenPaint = wallArea/3.4;

double roofArea = (2 * (x * y)) +(2* (x * h / 2));
litersOfRedPaint = roofArea / 4.3;

Console.WriteLine(Math.Round(litersOfGreenPaint,2));
Console.WriteLine(Math.Round(litersOfRedPaint,2));*/

//8
/*double r = double.Parse(Console.ReadLine());
double parameter = Math.PI * 2 * r;
double area = Math.PI * r * r;
Console.WriteLine("Calculated area: " + Math.Round(area,2));
Console.WriteLine("Calculated parameter: " + Math.Round(parameter,2));*/

//9
/*string weather = Console.ReadLine();
if (weather.ToLower().Equals("sunny"))
{
    Console.WriteLine("It's warm outside!");
}
else
{
    Console.WriteLine("It's cold outside!");
}*/

//10
double degrees = double.Parse(Console.ReadLine());
if(degrees>=5 && degrees <= 11.9)
{
    Console.WriteLine("Cold");
} else if (degrees>=12 && degrees <= 14.9)
{
    Console.WriteLine("Cool");
}else if(degrees>=15 && degrees <= 20)
{
    Console.WriteLine("Mild");
}else if(degrees>=20.1  && degrees <= 25.9)
{
    Console.WriteLine("Warm");
}else if(degrees>=26 && degrees <= 35)
{
    Console.WriteLine("Hot");
}
else
{
    Console.WriteLine("unknown");
}



