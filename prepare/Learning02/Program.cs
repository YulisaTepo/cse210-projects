using System;

class Program
{
    static void Main(string[] args)
    {
        // With this we can access to the Job.cs class and job1 will be
        // the variable that alows access to each part of the class, such as, job title,
        // company, and so on.
        Job job1 = new Job();

        job1._jobTitle = "Developer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        // Creating a second job:
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Tesla";
        job2._startYear = 2018;
        job2._endYear = 2019;

        // Resume part:
        Resume resume = new Resume();

        resume._name = "Yulisa Tepo";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayDetails();


    }   
}