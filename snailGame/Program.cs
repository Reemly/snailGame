using System;

string place = "start";
string [] Passwords = {"Sesameseed","Cornflower","Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum."};




while (place != "exit")
{
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
        Console.WriteLine("This is the where they control the ship from, there is another door, and of course the door you just entered through. Where do you go?(door or back)");
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




// använd kanske en affär för att få in en algoritm/array och för att få med typkonvertering.



