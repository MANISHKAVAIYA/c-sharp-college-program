// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
Console.Write("Enter your grade: ");
string userGrade =  Console.ReadLine();

switch (userGrade)
{
    case "A+":
    case "A":
        Console.WriteLine("Distinction");
        break;
    case "B":
        Console.WriteLine("B Grade");
        break;
    case "C":
        Console.WriteLine("C Grade");
        break; 
    default:
        Console.WriteLine("Fail");
        break;
}