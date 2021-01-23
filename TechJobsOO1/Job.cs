using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; set; }
        private static int nextId { get; set; } = 1; 

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {

           Id = nextId;
           nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
            this.Id = nextId++;
            
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }


    }
}
