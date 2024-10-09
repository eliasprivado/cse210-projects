using System;

class Program
{
    static void Main(string[] args)
    {
        //Adding Job class to main program
        //First job
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2024;

        //Print
        //job1.Display();

        //Second job
        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Designer";
        job2._startYear = 2018;
        job2._endYear = 2021;

        //Print
        //job2.Display();

        //Adding Resume class to main program
        Resume newResume = new Resume();
        newResume._name = "Elias Gutierrez";

        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.Display();
    }
}