using System;
using System.IO;
using System.Collections.Generic;

string place = "start";

int Money = 0; // Den här kommer ihåg hur mycket pengar som spelaren har samlat på sig det här livet.
bool isAlive = true;
bool fightHappened = false;
//bool playerPurchased = false;

List<string> inventory = new List<string>();


while (place != "exit" && isAlive)
{
    Console.WriteLine($"Your balance is: {Money} valuables");

    if (inventory.Contains("trash"))
    {
        System.Console.WriteLine("You stink of filth.");
    }

    if (place == "start")
    {
        Console.WriteLine("Your name is XF344 and you are currently in the docking station of the allied forces ship, there is a door ahead of you leading to the wheelhouse.");
        Console.WriteLine("You hear a robotic voice say: If you want to enter, state your ID out loud, Robot.");
        Console.WriteLine("{Btw when you enter prompts later on you will want to enter them when the terminal says your current valuables.}");
        Console.WriteLine("Go full screen for best experience.");
        string go = Console.ReadLine();
        go = go.ToLower();

        if (go == "xf344")
        {
            place = "wheelhouse";
        }

        else if (go != "xf344")
        {
            place = "start";
            Console.WriteLine("That isn't a registered ID, Who are you? The robot voice exclaims.");
            Console.ReadLine();

        }

    }

    if (place == "wheelhouse")
    {
        Console.WriteLine("You enter the Wheelhouse.");
        Console.WriteLine("Your choices are: Door, Hallway, Back");
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

        else if (choice == "hallway")
        {
            place = "hallway";



            Random generator = new Random();


            isAlive = Fight();
            fightHappened = true;





        }

        else
        {
            place = "wheelhouse";
        }





    }
    if (fightHappened && place == "hallway")
    {
        if (isAlive == true){
        Console.WriteLine("You defeated the enemy. Go to the next are? Choices: Yes, No, Back");
        }
        string choice2 = Console.ReadLine();
        choice2 = choice2.ToLower();

        if (choice2 == "yes")
        {
            place = "vendingRoom";
            Money += 100; // det här gör så att man får 100 varje gång man går till vendingRummet, vilket kan utnyttjas..
        }
        else if (choice2 == "no")
        {
            place = "hallway";
        }

        else if (choice2 == "back")
        {
            place = "wheelhouse";
        }


    }
    if (place == "vendingRoom")
    {
        Console.WriteLine("You are met with an ominous vending machine, do you want to buy something? Choices: Yes, Back, Continue");
        string choice3 = Console.ReadLine();
        choice3 = choice3.ToLower();

        if (choice3 == "yes")
        {
            (inventory, Money) = Store(inventory, Money);

        }

        else if (choice3 == "back")
        {
            place = "hallway";
        }

        else if (choice3 == "continue")
        {
            place = "garbageDisposal";
        }
    }

    if (place == "garbageDisposal")
    {
        Console.WriteLine("The garbage disposal is a long narrow room with different trash chutes along it's walls.");
        Console.WriteLine("Do you want to go down into one of the chutes? Choices: Enter, Ignore, Back");
        string choice4 = Console.ReadLine();
        choice4 = choice4.ToLower();
        
        if (choice4 == "enter" && (inventory.Contains("trash"))) {
            Console.WriteLine("'Trash detected' A robotic voice exclaims.");
            Console.ReadLine();
            Console.WriteLine("Suddenly four robotic arms shoot out of different sockets and grab all of your limbs, you get violently stuffed into the chute and die.");
            Console.ReadLine();
            place = "exit";
        }

        else if (choice4 == "enter" !& (inventory.Contains("trash"))) { //funkar inte, !&.

            Console.WriteLine("No trash detected.");
            place = "garbageDisposal";
        }

        else if (choice4 == "ignore") {
            Console.WriteLine("You ignore the trash chutes and continue walking.");
            Console.ReadLine();
            place = "finalRoom";
        }

        else if (choice4 == "back"){
            place = "vendingRoom";
        }

        else {
        place = "garbageDisposal";
        }


    }

if (place == "finalRoom") {
Console.WriteLine("nuh uh");
Console.WriteLine("This isn't finished, type 'back'.");
string choice5 = Console.ReadLine();
choice5 = choice5.ToLower();

if (choice5 == "back"){
    place = "garbageDisposal";
}

else if (choice5 != "back") {
    Console.WriteLine("Like i said this isnt finished yet, type 'back' to go back to the last room.");
    Console.ReadLine();
    
}

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



static (List<string>, int) Store(List<string> inv, int money)
{
    inv.Add("trash");
    money -= 100;

    return (inv, money);
}

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

        damage = generator.Next(1, 200);
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





// när man vinner så visas inte loss/win art. //klarat//

// använd kanske en affär för att få in en algoritm/array och för att få med typkonvertering. //jobbas på//

// hallway ska leda till en Merchant eller vending machine, ta användning av den nya Money variabeln som du la till, kolla på dokumentation. //klarat//

// om en av fighters kommer till precis 0 health så fastnar spelet

// fixa som sagt en lista av affärs grejor och sälj dem, kanske ge spelaren 100 money efter varje fight?//klart på annat sätt än stipulerat//

// lägg till ett item i store som kallas filth eller trash, gör så att det sägs varje gång man trycker på enter som med hur mycket pengar du har just nu, och få spelet att säga "you stink of flith/trash". Detta kan leda till ett hemligt ending. //klarat//
// Gör så att filth/trash kostar 1000 så att man blir tvungen att utnyttja en funktion för att ha råd.

// fråga gärna micke om hur man gör så att spelaren får val att välja mellan, och hur man gör så att spelet kommer ihåg att du faktiskt köpt någonting, och på så sätt förlorar pengar.//klarat//

//fortsätt försöka fråga Micke hur du ska göra med affären. Du förstår inte hur den fungerar. Jobba med finalRoom och garageDisposal stageana. //klarat//

// 