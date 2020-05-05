using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{
	public class ListFilesLoad
	{
		public ListFilesLoad()
		{
		}

        private string m_file;

        public ListFilesLoad(string lFile)
        {
            this.m_file = lFile;
        }

        //load a list of files
        public List<string> Load()
        {
            List<string> files = new List<string>();

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(m_file, FileMode.Open);

            // Uses the Deserialize method to restore the object's state
            // with data from the XML document. */
            files = (List<string>)serializer.Deserialize(fs);
            fs.Close();
            return files;
        }
    }
}
