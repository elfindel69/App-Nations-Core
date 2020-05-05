using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AppNationsCore
{
	public class ListFilesSave
	{
		//saved file
		string m_file;
		List<string> m_files;
		public ListFilesSave()
		{
		}

		public ListFilesSave(List<string> lFiles, string lFile)
		{
			m_files = lFiles;
			m_file = lFile;

		}

		public void Save()
		{
			XmlSerializer serializer =
			 new XmlSerializer(typeof(List<string>));
			TextWriter writer = new StreamWriter(m_file);
			serializer.Serialize(writer, m_files);
			writer.Close();
		}



	}
}
