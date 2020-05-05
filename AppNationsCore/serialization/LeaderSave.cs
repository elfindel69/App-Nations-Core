using System;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{ 
    /**
     * Class LeaderSave - Leaders saving 
     * @Author : elfindel69
     * @version: 0.0.1
     * 
     **/
    internal class LeaderSave
    {
        //saved file
        string m_file;
        //leader to save
        private Leader m_leader;

        public LeaderSave() { }

        public LeaderSave(Leader lLeader, string lFile)
        {
            m_leader = lLeader;
            m_file = lFile;

        }

        //display
        public void Save()
        {
            
            XmlSerializer serializer =
             new XmlSerializer(typeof(Leader));
            TextWriter writer = new StreamWriter(m_file);
            serializer.Serialize(writer, m_leader);
            writer.Close();
            
        }
    }
}