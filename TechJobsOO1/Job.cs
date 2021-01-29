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

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
            //this.Id = nextId++;

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

        public override string ToString()
        {

            if (Name == ""  && EmployerName.Value == ""  && EmployerLocation.Value == ""  && JobType.Value == ""  && JobCoreCompetency.Value == "" )
            {
                return "OOPS! This job does not seem to exist.";
            }
            if (Name == null && EmployerName==null && EmployerLocation==null && JobType==null && JobCoreCompetency==null)
            {
               return "OOPS! This job does not seem to exist.";
            }
            if (Name == "" )
            {
                Name= "No data found";
            }
            if (EmployerName.Value == "")
            {
                EmployerName.Value= "No data found";
            }
            if (EmployerLocation.Value == "" )
            {
                EmployerLocation.Value= "No data found";
            }
            if (JobType.Value == "" )
            {
                JobType.Value= "No data found";
            }
            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value= "No data found";
            }

            string s ="\n"+
                "ID: "+this.Id+"\n"+
                "Name: "+this.Name+"\n" +
                "Employer: "+this.EmployerName.Value+"\n" +
                "Location: "+this.EmployerLocation.Value+"\n" +
                "Position Type: "+this.JobType.Value+"\n"+
                "Core Competency: "+this.JobCoreCompetency.Value+"\n";
            return s;

        }


    }
}
