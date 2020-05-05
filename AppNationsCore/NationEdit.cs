using System;

namespace AppNationsCore
{
    /**
     * Class NationEdit - edition of Nations
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class NationEdit
    {
        //nation to display
        private Nation m_nation;

        public NationEdit() { }

        public NationEdit(Nation lNation)
        {
            m_nation = lNation;
        }

        //display
        public Nation Editor()
        {
            Console.WriteLine("Nation's edition:");
            //edit nation's name
            Console.WriteLine("Name: (number 0-31)");
            string sNatName = Console.ReadLine();
            int.TryParse(sNatName, out int nNatName);
            bool test = Enum.IsDefined(typeof(NatNames), nNatName);
            if (test)
            {
                m_nation.Name = (NatNames)nNatName;
            }
            //edit leader - see class LeaderEdit
            Console.WriteLine("Leader: ");
            LeaderEdit editor = new LeaderEdit(m_nation.Leader);
            editor.Editor();
            //edit nb of inhabitants
            Console.WriteLine("Inhabitants: (number)");
            string sInhabs = Console.ReadLine();
            long.TryParse(sInhabs, out long nInhabs);
            m_nation.Inhabs = nInhabs;
            //edit number of regions
            Console.WriteLine("number of regions : ");
            string sNbRegions = Console.ReadLine();
            int.TryParse(sNbRegions, out int nNbRegions);
            m_nation.NbRegions = nNbRegions;
            //edit nb of systems
            Console.WriteLine("\t number of systems : ");
            string sNbSystems = Console.ReadLine();
            int.TryParse(sNbSystems, out int nNbSystems);
            m_nation.NbSystems = nNbSystems;

            return m_nation;
        }
    }
}