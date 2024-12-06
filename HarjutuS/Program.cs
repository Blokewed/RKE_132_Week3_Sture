
using System.Diagnostics;

Console.WriteLine("Mis sa hindeks said?");
char grade;

grade = Convert.ToChar(Console.ReadLine().ToLower());


if (grade == 'a')
{
    Console.WriteLine("Suurepärane!");
}
else if (grade == 'b')
{
    Console.WriteLine("Väga hea!!");
}
else if (grade == 'c')
{
    Console.WriteLine("Hea!");
}
else if (grade == 'd')
{
    Console.WriteLine("Rahuldav");
}
else if (grade == 'e')
{
    Console.WriteLine("Kasin");
}
else if (grade == 'f')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("Vale väärtus!");
}





