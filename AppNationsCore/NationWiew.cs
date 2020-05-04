using System;

namespace AppNationsCore
{
    /**
     * Class NationWiew - display of Nations
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class NationWiew
    {
        //nation to display
        private Nation m_nation;

        public NationWiew() { }

        public NationWiew (Nation lNation)
        {
            m_nation = lNation;
        }

        //display
       public void Viewer() {
            Console.WriteLine("Nation's view:");
            Console.WriteLine("Name: "+m_nation.Name.ToString());
            Console.WriteLine("Leader: " + m_nation.Leader.Name);
            Console.WriteLine("Inhabitants: " + m_nation.Inhabs);
            Console.WriteLine("number of regions : " + m_nation.NbRegions);
            Console.WriteLine("\t number of systems : " + m_nation.NbSystems);
        }
    }
}