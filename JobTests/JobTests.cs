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
            Job jobTest = new Job("Poducter Tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual("Producter Tester", jobTest.Name);
            Assert.AreEqual("ACME", jobTest.EmployerName);
            Assert.AreEqual("Desert", jobTest.EmployerLocation);
            Assert.AreEqual("Quality control", jobTest.JobType);
            Assert.AreEqual("Persistence", jobTest.JobCoreCompetency);

        }


    }
}
