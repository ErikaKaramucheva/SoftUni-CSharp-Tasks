//1 - Oscars Ceremony
/*int rent= int.Parse(Console.ReadLine());
double statuettes = rent - (0.3 * rent);
double catering = statuettes-(0.15*statuettes);
double sound = catering / 2;
double cost = rent + statuettes + catering + sound;
Console.WriteLine(Math.Round(cost,2));*/

//2 - Godzilla vs Kong
/*double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double priceClothesForOneStatist = double.Parse(Console.ReadLine());
double priceForAllClothes = priceClothesForOneStatist * statists;
double decor = 0.1 * budget;
if (statists > 150)
{
    priceForAllClothes-=0.1*priceForAllClothes;
}
double totalPrice= decor+priceForAllClothes;
if(totalPrice > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Round((totalPrice-budget),2)} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {Math.Round((budget-totalPrice),2)} leva left.");
}*/

//3 - Oscars week in cinema
/*string name = Console.ReadLine();
string hallType = Console.ReadLine();
int tickets = int.Parse(Console.ReadLine());
double price = 0;
switch (name) {
    case "A Star Is Born":
        if (hallType.Equals("normal"))
        {
            price = 7.5;
        }else if (hallType.Equals("luxury"))
        {
            price = 10.5;
        }
        else
        {
            price = 13.5;
        }
        break;
    case "Bohemian Rhapsody":
        if (hallType.Equals("normal"))
        {
            price = 7.35;
        }
        else if (hallType.Equals("luxury"))
        {
            price = 9.45;
        }
        else
        {
            price = 12.75;
        }
        break;
    case "Green Book":
        if (hallType.Equals("normal"))
        {
            price = 8.15;
        }
        else if (hallType.Equals("luxury"))
        {
            price = 10.25;
        }
        else
        {
            price = 13.25;
        }
        break;
    default:
        if (hallType.Equals("normal"))
        {
            price = 8.75;
        }
        else if (hallType.Equals("luxury"))
        {
            price = 11.55;
        }
        else
        {
            price = 13.95;
        }
        break;
}
double total = tickets * price;
Console.WriteLine($"{name} -> {Math.Round(total,2)} lv.");*/

//4 - Cinema voucher
/*int voucher = int.Parse(Console.ReadLine());
int tickets = 0;
int otherItems = 0;
string command = Console.ReadLine(); ;
while (!command.Equals("End"))
{
    int price = 0;
    bool isTicket = true;
    if (command.Length > 8)
    {
        tickets++;
       price= command[0] + command[1];
    }
    else
    {
        otherItems++;
        price= command[0];
        isTicket = false;
    }
    if (price <= voucher)
    {
        voucher -= price;
    }
    else
    {
        if (isTicket)
        {
            tickets--;
        }
        else
        {
            otherItems--;
        }
        break;
    }
    command = Console.ReadLine();
}
Console.WriteLine(tickets);
Console.WriteLine(otherItems);*/

//5 - Movie Ratings
/*int filmsCount = int.Parse(Console.ReadLine());
double highestRating = double.MinValue;
double lowestRating = double.MaxValue;
string lowestRatingName = "";
string highestRatingName = "";
double average = 0;
for(int i=0;i<filmsCount; i++)
{
    string name=Console.ReadLine();
    double rating=double.Parse(Console.ReadLine());
    average += rating;
    if (highestRating < rating)
    {
        highestRating = rating;
        highestRatingName=name;
    }else if (lowestRating > rating)
    {
       lowestRating = rating;
        lowestRatingName = name;
    }

}
Console.WriteLine($"{highestRatingName} is with highest rating: {Math.Round(highestRating,1)}");
Console.WriteLine($"{lowestRatingName} is with lowest rating: {Math.Round(lowestRating,1)}");
Console.WriteLine($"Average rating: {Math.Round(average/filmsCount,1)}");*/

//6 - Cinema Tickets
string name = Console.ReadLine();
int freeSlots;
int totalTickets = 0;
int studentsTickets = 0;
int standardTickets = 0;
int kidsTickets = 0;
while (!name.Equals("Finish"))
{
    freeSlots = int.Parse(Console.ReadLine());
    string command=Console.ReadLine();
    int fullSlots = 0;
    while (!command.Equals("End"))
    {
        fullSlots++;
        totalTickets++;
        switch (command)
        {
            case "student":
                studentsTickets++;
                break;
            case "standard":
                standardTickets++;
                break;
            default:
                kidsTickets++;
                break;
        }
        if (fullSlots == freeSlots)
        {
            break;
        }
        command = Console.ReadLine();
    }
    double fullnessPercent = (double)fullSlots / freeSlots * 100;
    Console.WriteLine($"{name} - {Math.Round(fullnessPercent,2)}% full.");

    name = Console.ReadLine();
}
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine(Math.Round((double)studentsTickets / totalTickets * 100, 2) + "% student tickets.");
Console.WriteLine(Math.Round((double)standardTickets / totalTickets * 100, 2) + "% standard tickets.");
Console.WriteLine(Math.Round((double)kidsTickets / totalTickets * 100, 2) + "% kids tickets.");

