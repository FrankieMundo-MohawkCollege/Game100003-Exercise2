// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hi player! Welcome to the Weapons Shop. What is your name?");
string plrName = Console.ReadLine();
Console.WriteLine("Hello, " + plrName + "! I have a Bronze Sword for 15 Gold which I think might suit your needs. NEXT");
Console.ReadLine();
Console.WriteLine("How much gold do you have? ENTER NUMBER");
string goldInit = Console.ReadLine();
int gold = int.Parse(goldInit);

if (gold >= 14)
{
    Console.WriteLine("would you like to purchase this item? Y/N");
    string purchase = Console.ReadLine();
    if (purchase == "yes")
    {
        gold = gold - 15;
        //gold -= 15;
        Console.WriteLine("HAH. thanks loser free money muahahahaha. NEXT");
        Console.ReadLine();
        Console.WriteLine("* The dealer runs away, and you lost 15 gold. You now have " + gold + "gold. NEXT");
        Console.ReadLine();
        Console.WriteLine("* Damn. Atleast he left behind a pretty nice sword when running away. You inspect closer and.. NEXT");
        Console.ReadLine();
        Console.WriteLine("* It's a cardboard cutout.");
    }
    else if (purchase == "no")
    {
        gold = 0;
        Console.WriteLine("HAH. thanks loser free money muahahahaha, you took too long. NEXT");
        Console.ReadLine();
        Console.WriteLine("* The dealer runs away.. with all of your money. You now have 0 gold.");
    }
}
else
Console.WriteLine("Come back when you're a litle mmm... Richer.");
