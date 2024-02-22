using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment1 = new Assignment("Ma_man Joe_Mama","Division");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignmetn assignment2 = new MathAssignmetn("Ma_man Joe_Mama","Division","Section 1478", "Problems 11.9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        
        WritingAssignment assignment3 = new WritingAssignment("Ma_man Joe_Mama","Nameless World", "Terorism is bad but not for everyone;");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}