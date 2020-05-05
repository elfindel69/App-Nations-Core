using System;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{
    /**
     * Class NationLoad - Nations loading  
	 * @Author : elfindel69
	 * @version: 0.0.1
     * 
     **/
    internal class NationLoad
    {
        private string m_file;

        public NationLoad(string lFile)
        {
            this.m_file = lFile;
        }

        public Nation Load()
        {
            Nation newNation = new Nation();
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(Nation));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(m_file, FileMode.Open);

            // Uses the Deserialize method to restore the object's state
            // with data from the XML document. */
            newNation = (Nation)serializer.Deserialize(fs);
            return newNation;
        }
    }
}