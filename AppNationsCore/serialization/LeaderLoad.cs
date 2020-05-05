using System;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{
    /**
     * Class LeaderLoad - Leaders loading  
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class LeaderLoad
    {
        private string m_file;

        public LeaderLoad(string lFile)
        {
            this.m_file = lFile;
        }

        public Leader Load()
        {
            Leader newLeader = new Leader();
          
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(Leader));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(m_file, FileMode.Open);

            // Uses the Deserialize method to restore the object's state
            // with data from the XML document. */
            newLeader = (Leader)serializer.Deserialize(fs);
            
            return newLeader;
        }
    }
}