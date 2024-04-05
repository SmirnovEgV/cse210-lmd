using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> _exercises = new List<Exercise>();
        Exercise exercise1 = new RunningExercise(25,new DateTime(2024,6,25),"Running",15);
        Exercise exercise2 = new BikingExercise(40,new DateTime(2024,6,7),"Biking", 17);
        Exercise exercise3 = new PoolLapsExercise(15,new DateTime(2024,6,10),"Swimming",10);

        _exercises.Add(exercise1);
        _exercises.Add(exercise2);
        _exercises.Add(exercise3);

        foreach (var exercise in _exercises)
        {
            exercise.GetSummary();
        }
    }
}