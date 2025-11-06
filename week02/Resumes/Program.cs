using System;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "INT Intelligence and Telecome";
        job1._jobTitle = "Telecomunications engineer";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Adrianas insurance";
        job2._jobTitle = "Frontend developer";
        job2._startYear = 2022;
        job2._endYear = 0;

        Resume myResume = new Resume();
        myResume._name = "Irana Aguirre";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}