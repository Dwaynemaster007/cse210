using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";

        // Create the second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        // Create the resume and add the jobs to it
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the whole resume (name + all jobs)
        myResume.Display();
    }
}
