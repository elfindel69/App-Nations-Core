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

		public static void Viewer(Leader viewLeader)
		{

			//display selected leader
			LeaderWiew view = new LeaderWiew(viewLeader);
			view.Viewer();
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
