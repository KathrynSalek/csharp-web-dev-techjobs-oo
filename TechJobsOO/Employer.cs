namespace TechJobsOO
{
    public class Employer : JobField // Class
    {
        public Employer(string value) : base(value)
        {
        }
        
        /* public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Employer()  // Constructor
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this()  // Constructor
        {
            Value = value;
        }

        public override bool Equals(object obj) // Methods
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode() //  #1 Review Sally’s code in the Employer class to learn how to assign a unique ID
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        } */
    }
}
