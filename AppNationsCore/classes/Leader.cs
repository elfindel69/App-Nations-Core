using System.Data;
using System.Diagnostics;

namespace AppNationsCore
{
    /**
     *  Class Leader - gestion des Leaders
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    public class Leader
    {
        private static int sID;

        public int ID { get; }
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

        public Leader() 
        { 
            ID = sID;
            sID++;
        }
        //constructor with parameters
        public Leader(string lname, GTCDate lDoB, NatNames lnatName, Species lspecies, GTCDate lDoRule, string lLoc)
        {
            Name = lname;
            DoB = lDoB;
            NatName = lnatName;
            Species = lspecies;
            DoRule = lDoRule;
            Localization = lLoc;
            ID = sID;
            sID++;
        }

        //returns the leader's name
        public override string ToString()
        {
            return Name;
        }
    }
}