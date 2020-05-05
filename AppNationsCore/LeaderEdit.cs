using System;

namespace AppNationsCore
{
    /**
     * Class LeaderEdit - edition of Leaders
     * @Author : elfindel69
     * @version: 0.0.1
     * 
     **/
    internal class LeaderEdit
    {
    
       
            //leader to display
            private Leader m_leader;

            public LeaderEdit() { }

            public LeaderEdit(Leader lLeader)
            {
                m_leader = lLeader;
            }

            //display
            public Leader Editor()
            {
                Console.WriteLine("Leader's editor:");
                //edit name
                Console.WriteLine("Name: ");
                string lName = Console.ReadLine();
                m_leader.Name = lName;
                //edit DoB
                Console.WriteLine("Date of Birth: (format yyyy-mm-dd) " );
                string lDoB = Console.ReadLine();
                 m_leader.DoB = new GTCDate(lDoB);
                //edit species
                Console.WriteLine("Species: (number 0-13)");
                string sSpecies = Console.ReadLine();
                int.TryParse(sSpecies, out int nSpecies);
                bool test = Enum.IsDefined(typeof(Species), nSpecies);
                if (test)
                {
                  m_leader.Species = (Species)nSpecies;
                }
                //edit nationality
                Console.WriteLine("Nationality : (number 0-31)" );
                string sNatName = Console.ReadLine();
                int.TryParse(sNatName, out int nNatName);
                bool test2 = Enum.IsDefined(typeof(NatNames), nNatName);
                if (test2)
                {
                    m_leader.NatName = (NatNames)nNatName;
                }
                //edit date of ruling
                Console.WriteLine("Date of ruling : (format yyyy-mm-dd)");
                string lDoRuling = Console.ReadLine();
                m_leader.DoRule = new GTCDate(lDoRuling);
                //edit localization
                Console.WriteLine("Localization : ");
                string lLoc = Console.ReadLine();
                m_leader.Localization = lLoc;

                return m_leader;
        }
    }
}