using System;

namespace AppNationsCore
{
    class Program
    {
		/**
		* Class Program - main display
		* @Author : elfindel69
		* @version: 0.0.1
		* 
		**/
		static void Main(string[] args)
        {
			ConsoleKeyInfo saisie;
			do
			{
				Console.WriteLine("Welcome to AppNations!");
				Console.WriteLine("Menu:");
				Console.WriteLine("1. Nations");
				Console.WriteLine("2. Leaders");
				string strChoice = Console.ReadLine();
				int.TryParse(strChoice, out int choice);

				Leader l1 = new Leader("Mikhail Stensov", new GTCDate(9575, 04, 14, 12, 00, 00), NatNames.Ossarion, Species.Ossars, new GTCDate(9792, 03, 30, 12, 00, 00), "Ossarion, ID, OI");
				Leader l2 = new Leader("Alma Halama", new GTCDate(9929, 09, 28, 12, 00, 00), NatNames.Keitheas, Species.Ethels, new GTCDate(10193, 02, 20, 12, 00, 00), "Keitheas, FD, KE");
				Leader[] tabLeaders = { l1, l2 };

				Nation n1 = new Nation(NatNames.Ossarion, l1, 530000000000L, 6, 50000);
				Nation n2 = new Nation(NatNames.Keitheas, l2, 350000000000L, 5, 30000);
				Nation[] tabNations = { n1, n2 };

				//nations
				if (choice == 1)
				{
					Console.WriteLine("List of Nations:");
					for(int i = 0; i < tabNations.Length; i++)
					{
						Console.WriteLine(i+": "+tabNations[i].Name.ToString());
					}

					Console.WriteLine("Enter a Nation ID:");

					strChoice = Console.ReadLine();
					int.TryParse(strChoice, out int natChoice);
					NationWiew view = new NationWiew(tabNations[natChoice]);
					view.Viewer();
				}
				//leaders
				else if (choice == 2)
				{
					Console.WriteLine("List of Leaders:");
					for (int i = 0; i < tabLeaders.Length; i++)
					{
						Console.WriteLine(i + ": " + tabLeaders[i].Name);
					}

					Console.WriteLine("Enter a Leader ID:");

					strChoice = Console.ReadLine();
					int.TryParse(strChoice, out int leaChoice);
					LeaderWiew view = new LeaderWiew(tabLeaders[leaChoice]);
					view.Viewer();
				}
				else
				{
					Console.WriteLine("wrong answer :( ");
				}
				Console.WriteLine("exit? y/n ");
				saisie = Console.ReadKey(true);
			} while (saisie.Key != ConsoleKey.Y);
           
		}
    }
}
