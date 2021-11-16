using System;

string place = "start";

while (place != "exit" ) 
{
if (place == "start")
{
Console.WriteLine("You are currently in the docking station, there is a door ahead of you leading to the wheelhouse");
Console.WriteLine("If you want to enter say the password, Sesameseed and if you do not want to enter say nothing.");
string where = Console.ReadLine();
where = where.ToLower();

if (where == "yes")
{
    place = "wheelhouse";
}

else {
 place = "start";
}


}










}