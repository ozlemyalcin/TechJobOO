using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Job jobTest = new Job("Producter Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Console.WriteLine(jobTest.EmployerName);
            Console.WriteLine(jobTest.EmployerLocation);

            Job jobTest1 = new Job("Producter Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Console.WriteLine(jobTest1.Id);
            Console.WriteLine(jobTest.Id);
            */
            
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            Job job4 = new Job();

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            jobs.Add(job4);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }

        }
    }
}

