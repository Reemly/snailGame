using System;

string place = "start";

while (place != "exit")
{
    if (place == "start")
    {
        Console.WriteLine("You are currently in the docking station, there is a door ahead of you leading to the wheelhouse");
        Console.WriteLine("If you want to enter say the password, Sesameseed, and if you do not want to enter be quiet.(sesameseed or you stay.)");
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
        Console.WriteLine("You are in the Wheelhouse.");
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








