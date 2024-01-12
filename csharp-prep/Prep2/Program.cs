using System;

class Program
{
    static void Main(string[] args)
    {
        string percGrade;
        string message;

        while (true)
        {
            Console.WriteLine("Enter your % of a grade. Just numbers, no need for % sign");
            percGrade = Console.ReadLine();

            if (int.TryParse(percGrade, out int numGrade))
            {
                if (numGrade > 100){
                    message = $"Are you sure you've got {percGrade}%? I doubt that";
                    break;
                }
                else if (numGrade >= 90)
                {
                    message = $"You've got an A, you've got {percGrade}%";
                    break;
                }
                else if (numGrade >= 80)
                {
                    message = $"You've got a B, you've got {percGrade}%";
                    break;
                }
                else if (numGrade >= 70)
                {
                    message = $"You've got a C, you've got {percGrade}%";
                    break;
                }
                
                else
                {
                    message = $"Bruh, you've failed, you've got {percGrade}%";
                    break;
                };
            }
            else
            {
                Console.WriteLine("You entered something other than a number. Try again");
            }
        }
        Console.WriteLine(message);
    }
}
