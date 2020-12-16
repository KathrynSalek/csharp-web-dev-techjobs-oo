using System;

namespace TechJobsOO
{
    public abstract class JobField //Create a Base Class 
     {
         public int Id { get; } // Auto-implemented property
         private static int nextId = 1; 
         // private string value;
         public string Value { get; set; } // Auto-implemented property

         // TODO: Change the fields to auto-implemented properties.  DONE above

        public JobField() // Constructor
        {
             Id = nextId;
             nextId++;
        }

        public JobField(string value) : this()  // Methods
        {
             Value = value;
        }

        public override bool Equals(object obj)
        {
             return obj is JobField job &&
                           Id == job.Id;
        }

        public override int GetHashCode()
        {
             return HashCode.Combine(Id);
        }

        public override string ToString() // Added
        {
            if (Value != null || Value != "")
            {
                return Value;
            }
            else
            {
                return "Data not available";
            }
        }
    }
}
