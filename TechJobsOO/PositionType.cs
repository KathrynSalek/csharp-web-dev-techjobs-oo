namespace TechJobsOO
{
    public class PositionType : JobField // Class  #2 Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.
    {
        public PositionType(string value) : base(value)
        {
        }
        /* public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()  // Constructor
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()  // Constructor
        {
            Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        
        public override bool Equals(object obj)  // Methods
        {
            return obj is PositionType type &&
                   Id == type.Id;  // Assume that two PositionType objects are equal when their id fields match.
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id); 
        }

        public override string ToString()
        {
            return Value;
        } */
    }
}
