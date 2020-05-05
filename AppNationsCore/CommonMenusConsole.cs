using System;
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

		public static int FileMenu(string[] tabFiles)
		{
			Console.WriteLine("File List: ");
			for (int i = 0; i < tabFiles.Length; i++)
			{
				Console.WriteLine("file: " + tabFiles[i]);
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
	}
}
