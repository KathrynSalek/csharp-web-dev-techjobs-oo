namespace TechJobsOO
{
    public class CoreCompetency : JobField // Class  #2 Add properties and custom methods as needed to the Location, CoreCompetency, and PositionType classes.  DONE - code below
    {
        // private int id;
        public CoreCompetency(string value) : base(value)
        {
        }

        /*public int id { get; set; } // Auto-implemented property
        private static int nextId = 1; 
        // private string value;
        private string value { get; set; } // Auto-implemented property

        // TODO: Change the fields to auto-implemented properties.  DONE above

        public CoreCompetency() // Constructor
        {
            id = nextId;
            nextId++;

        }

        public CoreCompetency(string v) : this() // Methods
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }*/
    }
}
//}
