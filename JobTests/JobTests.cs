using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            int job1Id = job1.Id;
            int job2Id = job2.Id;
            Assert.IsTrue(job2Id == job1Id + 1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobTest = new Job("Producter Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),new CoreCompetency( "Persistence"));
            Assert.AreEqual("Producter Tester", jobTest.Name);
            Assert.AreEqual("ACME", jobTest.EmployerName.Value);
            Assert.AreEqual("Desert", jobTest.EmployerLocation.Value);
            Assert.AreEqual("Quality control", jobTest.JobType.Value);
            Assert.AreEqual("Persistence", jobTest.JobCoreCompetency.Value);
            
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobTest1 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job jobTest2= new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(jobTest1.Equals(jobTest2.Id));


        }


    }
}
