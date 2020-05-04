namespace AppNationsCore
{
    /**
     *  Class Leader - gestion des Leaders
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class Leader
    {
        //fullname
        public string Name { get; set; }
        //date of birth
        public GTCDate DoB { get; set; }
        //nationality
        public NatNames NatName { get; set; }
        //species
        public Species Species { get; set; }
        //date of ruling
        public GTCDate DoRule { get; set; }
        //current localization
        public string Localization { get; set; }

        public Leader() { }
        //constructor with parameters
        public Leader(string lname, GTCDate lDoB, NatNames lnatName, Species lspecies, GTCDate lDoRule, string lLoc)
        {
            Name = lname;
            DoB = lDoB;
            NatName = lnatName;
            Species = lspecies;
            DoRule = lDoRule;
            Localization = lLoc;
        }

        //returns the leader's name
        public override string ToString()
        {
            return Name;
        }
    }
}