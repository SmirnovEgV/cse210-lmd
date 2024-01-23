using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Amazone";
        job1._startYear = 2019;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2014;
        job2._endYear = 2022;

        Resume resume01 = new Resume();
        resume01._name = "Egor Smirnov";
        resume01._Jobs.Add(job1);
        resume01._Jobs.Add(job2);

        resume01.DisplayResume();
    }
}