namespace TechJobsOO
{
    public class Location : JobField // Class  #2 Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.  DONE - code below
    {
        public Location(string value) : base(value)
        {
        }
        /* public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()  // Constructor 
        {
            Id = nextId;
            nextId++;
        }

        public Location(string Value) // My code - second constructor sets the value of the value field
        {
            bool v = this.Value == Value;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.  DONE - code above

        public override bool Equals(object obj)  // Methods
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }

        public override string ToString()
        {
            return Value;
        } */
    }
}
