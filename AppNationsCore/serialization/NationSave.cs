using System;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{
    /**
    * Class NationSave - Nations saving 
    * @Author : elfindel69
    * @version: 0.0.1
    * 
    **/
    internal class NationSave
    {
        //saved file
        string m_file;
        //leader to save
        private Nation m_nation;

        public NationSave() { }

        public NationSave(Nation lNation, string lFile)
        {
            m_nation = lNation;
            m_file = lFile;

        }

        //display
        public void Save()
        {
            Console.WriteLine("saving nation:" + m_nation.Name);
            XmlSerializer serializer =
             new XmlSerializer(typeof(Nation));
            TextWriter writer = new StreamWriter(m_file);
            serializer.Serialize(writer, m_nation);
            writer.Close();
            Console.WriteLine("nation saved!");
        }
    }
}