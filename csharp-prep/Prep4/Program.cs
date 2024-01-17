using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0){
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
        

            if(userNumber != 0 ){
                numbers.Add(userNumber);
            }
        }
        
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of numbers is: {sum}");


        
        float results = (float)sum / numbers.Count;
        

        Console.WriteLine($"The sum of numbers is: {results}");


        int max = numbers[0];

        foreach(int number in numbers){

            if (max < number){

                max = number;
            }

        }
        
        Console.WriteLine($"The highest number is: {max}");
    }

    
}