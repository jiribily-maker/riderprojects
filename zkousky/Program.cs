// See https://aka.ms/new-console-template for more information
/*
Console.Clear();
Console.Write("enter q to quit:");
string slovo = Console.ReadLine();

if (slovo == "q")
{
    Console.WriteLine("user wants to quit");
}
else
{ 
    Console.WriteLine("Program is running");
}
*/

Console.Clear();
Console.Write("Enter age:");
string agestring = Console.ReadLine();
int age =  int.Parse(agestring);

if (age < 18 && age >= 0)
{
    Console.WriteLine("jsi nezletily");
}
else
{
    Console.WriteLine("nejsi narozeny");
}
if (age < 150 && age > 65)
{
    Console.WriteLine("jsi senior");
}
else if (age > 150)
{
    Console.WriteLine("jsi mrtvy");
}
else
{
    Console.WriteLine("jsi zletily");
}