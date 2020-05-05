using System;

namespace AppNationsCore
{
    /**
     * Class LeaderWiew - display of Leaders
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class LeaderWiew
    {
        //leader to display
        private Leader m_leader;

        public LeaderWiew () { }

        public LeaderWiew(Leader lLeader)
        {
            m_leader = lLeader;
        }

        //display
        public void Viewer()
        {
            Console.WriteLine("Leader's view:");
            Console.WriteLine("Name: " + m_leader.Name);
            Console.WriteLine("Date of Birth: " + m_leader.DoB.ToString()) ;
            Console.WriteLine("Species: " + m_leader.Species.ToString()) ;
            Console.WriteLine("Nationality : " + m_leader.NatName.ToString());
            Console.WriteLine("Date of ruling : " + m_leader.DoRule.ToString());
            Console.WriteLine("Localization : " + m_leader.Localization);
        }
    }
}