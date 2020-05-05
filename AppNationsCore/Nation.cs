namespace AppNationsCore
{
    /**
     *  Class Nation - gestion des nations
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    public class Nation
    {
        //nation's name
        public NatNames Name { get; set; }
        //nation's leader
        public Leader Leader { get; set; }
        //nb of inhabitants
        public long Inhabs { get; set; }
        //nb of regions
        public int NbRegions { get; set; }
        //nb of systems
        public int NbSystems { get; set; }

        public Nation() { }

        public Nation(NatNames lname, Leader lLeader, long lInhabs,int lRegions, int lSystems)
        {
            Name = lname;
            Leader = lLeader;
            Inhabs = lInhabs;
            NbRegions = lRegions;
            NbSystems = lSystems;
        }

        //returns the nation's name
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}