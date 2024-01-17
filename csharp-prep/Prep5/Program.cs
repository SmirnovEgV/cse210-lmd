using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        displayWelcomeMsg();

        string userName = promptUserForName();

        int userNumber = promptUserForNumber();

        int userNumberSquared = squareANumber(userNumber);
        
        displayResults(userName, userNumberSquared);
    }

    static void displayWelcomeMsg(){
        Console.WriteLine("Welcome to the program with functions");
    }

    static string promptUserForName(){
        Console.WriteLine("Please input your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int promptUserForNumber(){
        Console.WriteLine("Please input some number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareANumber(int number){

        int numberSquared = number * number;

        return numberSquared;
    }

    static void displayResults(string result1, int result2){
        Console.WriteLine($"Your name is {result1} and the number you entered squared is {result2}.");
    }
}