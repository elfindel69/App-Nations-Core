using System;
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

		public static void Viewer(Nation viewNation)
		{
			//display selected nation
			NationWiew view = new NationWiew(viewNation);
			view.Viewer();
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
