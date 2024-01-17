using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();

       int magicNum = randomGenerator.Next(1,101);

       int guess = -1;

       while (guess != magicNum){

        Console.WriteLine("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

       
            if (magicNum > guess){

                Console.WriteLine("Try bigger!");
            }
            else if (magicNum < guess){

                Console.WriteLine("Try lower!");
            }
            else{

                Console.WriteLine("You guessed it right");
            }

       }

    }
}