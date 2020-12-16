using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]  //  Test the Empty Constructor
        public void TestSettingJobId()  //  Define a test called TestSettingJobId
        {
            Job testId1 = new Job();  // Create two Job objects using the empty constructor
            Job testId2 = new Job();

            Assert.IsTrue(testId2.Id-testId1.Id == 1); //  Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1
        }

        [TestMethod]  // Test the Full Constructor
        public void TestJobConstructorSetsAllFields()  //  Define a test called TestJobConstructorSetsAllFields
        {
            Job testJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality"), new CoreCompetency("Persistence"));  // Declare and initialize a new Job object with the following data: "Product tester" for Name, "ACME" for EmployerName, "Desert" for JobLocation, "Quality control" for JobType, and "Persistence" for JobCoreCompetency

            Assert.IsTrue(testJob.Name == "Product Tester"); // Use Assert statements to test that the constructor correctly assigns the value of each field.
            Assert.IsTrue(testJob.EmployerName.ToString() == "ACME");
            Assert.IsTrue(testJob.EmployerLocation.ToString() == "Desert");
            Assert.IsTrue(testJob.JobType.ToString() == "Quality");
            Assert.IsTrue(testJob.JobCoreCompetency.ToString() == "Persistence");
        }

        [TestMethod]  // Test the Equals() Method
        public void TestJobsForEquality()  //  Define a test called TestJobsForEquality
        {
            Job testJob1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality"), new CoreCompetency("Persistence")); // Generate two Job objects that have identical field values EXCEPT for id
            Job testJob2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]  // Test the ToString() Method
        public void TestJobsForToString()  //  Define a test called TestJobsToString
        {
            Job testJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality"), new CoreCompetency("Persistence")); // Generate two Job objects that have identical field values EXCEPT for id
            string output = $"ID: {testJob.Id}\n Name:  {testJob.Name}\n Employer: {testJob.EmployerName}\n Location: {testJob.EmployerLocation}\n Position Type: {testJob.JobType}\n Core Competency: {testJob.JobCoreCompetency}\n"; 

            Assert.AreEqual(testJob.ToString(), output);
        }

        [TestMethod]  // Test the ToString() Bonus Method
        public void TestJobsForToStringBonus()  //  Define a test called TestJobsToString
        {
            Job testJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency("")); // Generate two Job objects that have identical field values EXCEPT for id
            string output = "OOPS! This job does not seem to exist.";

            Assert.AreEqual(testJob.ToString(), output);
        }
    }
}
