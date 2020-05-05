using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AppNationsCore
{
	public static class NationMenusConsole
	{
		public static Nation Loader(string file)
		{
			//loader
			Console.WriteLine("loading new nation...");
			NationLoad natLoader = new NationLoad(file);
			Nation newNation = natLoader.Load();
			Console.WriteLine("Nation " + newNation.Name.ToString() + " loaded!");
			return newNation;
		}

		public static int Viewer(Nation viewNation)
		{
			//display selected nation
			NationWiew view = new NationWiew(viewNation);
			view.Viewer();
			//nation's menu
			Console.WriteLine("Nation's menu:");
			Console.WriteLine("1. Edit");
			Console.WriteLine("2. Save");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);

			return choice;
		}

		public static int ListViewer(Nation[] tabNations)
		{
			Console.WriteLine("List of Nations:");
			for (int i = 0; i < tabNations.Length; i++)
			{
				Console.WriteLine(i + ": " + tabNations[i].Name.ToString());
			}
			//selection
			Console.WriteLine("Enter a Nation ID:");

			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);

			return choice;
		}

		public static Nation Editor(Nation editNation)
		{
			NationEdit editor = new NationEdit(editNation);
			editNation = editor.Editor();

			return editNation;
		}

		public static void Saver(Nation saveNation, string file)
		{
			Console.WriteLine("saving nation:" + saveNation.Name.ToString());
			NationSave saver = new NationSave(saveNation, file);
			saver.Save();
			Console.WriteLine("nation saved!");
		}
	}

}
