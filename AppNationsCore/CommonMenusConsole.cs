using System;
using System.Collections.Generic;

namespace AppNationsCore
{
	public static class CommonMenusConsole
	{
		public static int FirstMenu()
		{
			Console.WriteLine("Welcome to AppNations!");
			Console.WriteLine("Menu:");
			Console.WriteLine("1. Load...");
			Console.WriteLine("2. View...");
			Console.WriteLine("3. New...");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static int LoadMenu()
		{
			Console.WriteLine("Loading menu: ");
			Console.WriteLine("1. Nations");
			Console.WriteLine("2. Leaders");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}
		public static int NewMenu()
		{
			Console.WriteLine("New item menu: ");
			Console.WriteLine("1. Nations");
			Console.WriteLine("2. Leaders");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}


		public static int FileMenu(List<string> listFiles)
		{
			Console.WriteLine("File List: ");
			int i = 0;
			foreach (string file in listFiles)
			{
				Console.WriteLine("file: " + i + " " + file);
				i++;
			}

			//selection
			Console.WriteLine("Enter a file ID:");

			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);
			return choice;
		}

		public static int ViewMenu()
		{
			Console.WriteLine("Viewer menu: ");
			Console.WriteLine("1. Nations");
			Console.WriteLine("2. Leaders");
			string strChoice = Console.ReadLine();
			int.TryParse(strChoice, out int choice);

			return choice;
		}

		public static void FilesSaver(List<string> lfiles, string file)
		{
			Console.WriteLine("saving files...");
			ListFilesSave saver = new ListFilesSave(lfiles, file);
			saver.Save();
			Console.WriteLine("files saved!");
		}

		public static List<string> FilesLoader(string file)
		{
			Console.WriteLine("loading files...");
			ListFilesLoad loader = new ListFilesLoad( file);
			List<string> files = loader.Load();
			Console.WriteLine("files loaded!");
			return files;
		}
	}
}
