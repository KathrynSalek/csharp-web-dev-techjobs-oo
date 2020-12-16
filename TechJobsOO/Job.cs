using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job  // Class  #3 Complete the Job class using what you learned in steps 1 and 2.
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors. DONE below *******************************************************************************************

        public Job()  // Constructor - My Code  Code a constructor to initialize the id field with a unique value. This constructor should take no parameters.
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name) : this()
        {
            Name = name;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()//  Constructor  My Code  Code a second constructor that takes 5 parameters and assigns values to name, employerName, employerLocation, jobType, and jobCoreCompetency. ??? Also, this constructor should call the first in order to initialize the id field. ???
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods. DONE below **********************************************************************************
        public override bool Equals(object obj)  //  Methods  My Equals method
        {
            return obj is Job job &&
                   Id == job.Id && //  Consider two Job objects equal when their id fields match.
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()  // My GetHashCode() method
        {
            return HashCode.Combine(Id);
        }

        public override string ToString() 
        {
            if (Name == "")
            {
                Name = "Data not available"; // If a field is empty, the method should add, “Data not available” after the label.
            }

            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }

            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }

            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            if (Id != null && (Name == "Data not available" && EmployerName.Value == "Data not available" && EmployerLocation.Value == "Data not available" && JobType.Value == "Data not available" && JobCoreCompetency.Value == "Data not available")) //  BONUS :)
            {
                return "OOPS! This job does not seem to exist.";            
            }

            {
                string output = $"ID: {Id}\n Name:  {Name}\n Employer: {EmployerName.Value}\n Location: {EmployerLocation.Value}\n Position Type: {JobType.Value}\n Core Competency: {JobCoreCompetency.Value}\n"; // The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.
                
                return output;
            }
        }
    }
}
