using System;
using System.IO;

string place = "start";

int Money = 0;
bool isAlive = true;
bool fightHappened = false;
while (place != "exit" && isAlive)
{
    Console.WriteLine($"Your balance is: {Money} valuables");
    if (place == "start")
    {
        Console.WriteLine("Your name is Sesameseed and you are currently in the docking station of the allied forces ship, there is a door ahead of you leading to the wheelhouse.");
        Console.WriteLine("You hear a robotic voice say: If you want to enter state your Name out loud soldier.");
        string go = Console.ReadLine();
        go = go.ToLower();

        if (go == "sesameseed")
        {
            place = "wheelhouse";
        }

        else
        {
            place = "start";
        }
    }

    if (place == "wheelhouse")
    {
        Console.WriteLine("You enter the Wheelhouse.");
        Console.WriteLine("Door, Back, Hallway");
        string choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "door")
        {
            place = "escapepod";
        }

        else if (choice == "back")
        {
            place = "start";
        }

        else
        {
            place = "wheelhouse";
        }


        if (choice == "hallway")
        {
            place = "hallway";



            Random generator = new Random();


            isAlive = Fight();
            fightHappened = true;





        }



    }
    if (fightHappened && place == "hallway")
    {
        string choice2 = Console.ReadLine();
        choice2 = choice2.ToLower();
        Console.WriteLine("You defeated the enemy. Go to the next are? Y/N");
        Console.ReadLine();
        if (choice2 == "yes")
        {
            place = "vendingRoom";
        }
        else if (choice2 == "no")
        {
            place = "hallway";
        }

    }
    if (place == "vendingRoom")
    {
        string choice3 = Console.ReadLine();
        choice3 = choice3.ToLower();
        Console.WriteLine("You are met with an ominous vending machine,  ");
        Console.ReadLine();
    }



    if (place == "escapepod")
    {
        Console.WriteLine("You are in the escape room, there is a spare pod left over from the crew leaving.");
        Console.WriteLine("Say 'Exit' to leave.(exit or back)");
        string leave = Console.ReadLine();
        leave = leave.ToLower();

        if (leave == "exit")
        {
            place = "exit";
        }

        else if (leave == "back")
        {
            place = "wheelhouse";
        }

        else
        {
            place = "escapepod";
        }




    }





}





// när man vinner så visas inte loss/win art. //klarat//

// använd kanske en affär för att få in en algoritm/array och för att få med typkonvertering. //jobbas på//

// hallway ska leda till en Merchant eller vending machine, ta användning av den nya Money variabeln som du la till, kolla på dokumentation. //jobbas på//

// om en av fighters kommer till precis 0 health så fastnar spelet

// fixa som sagt en lista av affärs grejor och sälj dem, kanske ge spelaren 100 money efter varje fight?

static bool Fight()
{
    Random generator = new Random();
    int health = 100;
    int fighter1Health = health;
    int fighter2Health = health;
    string art0 = File.ReadAllText("artworkenemyenter.txt");
    string art = File.ReadAllText("artwork.txt");
    string art1 = File.ReadAllText("artworkwin.txt");
    string art2 = File.ReadAllText("artworklose.txt");

    while (fighter1Health > 0 && fighter2Health > 0)
    {



        System.Console.WriteLine(art);

        Console.ReadLine();

        int damage = generator.Next(1, 20);
        fighter1Health -= damage;

        damage = generator.Next(1, 20);
        fighter2Health -= damage;

        System.Console.WriteLine($"Fighter 1 health {fighter1Health}");
        System.Console.WriteLine($"Fighter 2 health {fighter2Health}");
        Console.ReadLine();




        if (fighter1Health < 0)
        {
            System.Console.WriteLine("Fighter 2 wins");
            Console.ReadLine();
            System.Console.WriteLine(art2);

            Console.ReadLine();


            return false;
        }


        else if (fighter2Health < 0)
        {
            System.Console.WriteLine("fighter 1 wins");
            Console.ReadLine();
            System.Console.WriteLine(art1);

            Console.ReadLine();
            return true;

        }




    }

    return true;
}





