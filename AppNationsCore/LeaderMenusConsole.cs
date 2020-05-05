using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AppNationsCore
{
	public static class LeaderMenusConsole
	{
		public static Leader Loader(string file)
		{
			//loader
			Console.WriteLine("loading new leader...");
			LeaderLoad leaLoader = new LeaderLoad(file);
			Leader newLeader = leaLoader.Load();
			Console.WriteLine("Leader " + newLeader.Name + " loaded!");
			return newLeader;
		}

		public static int Viewer(Leader viewLeader)
		{

			//display selected leader
			LeaderWiew view = new LeaderWiew(viewLeader);
			view.Viewer();

			//leader's menu
			Console.WriteLine("Leader's menu:");
			Console.WriteLine("1. Edit");
			Console.WriteLine("2. Save");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
			
		}

		public static int ListViewer(Leader[] tabLeaders)
		{
			//display list of leaders
			Console.WriteLine("List of Leaders:");
			for (int i = 0; i < tabLeaders.Length; i++)
			{
				Console.WriteLine(i + ": " + tabLeaders[i].Name);
			}

			//selection
			Console.WriteLine("Enter a Leader ID:");

			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);

			return choice;
		}
		public static Leader Editor(Leader editLeader)
		{
			LeaderEdit editor = new LeaderEdit(editLeader);
			editLeader = editor.Editor();

			return editLeader;
		}

		public static void Saver(Leader saveLeader, string file)
		{
			Console.WriteLine("saving leader:" + saveLeader.Name);
			LeaderSave saver = new LeaderSave(saveLeader, file);
			saver.Save();
			Console.WriteLine("leader saved!");
		}
	}
}
