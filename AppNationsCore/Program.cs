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
			//list of leaders
			Leader l1 = new Leader("Mikhail Stensov", new GTCDate(9575, 04, 14), NatNames.Ossarion, Species.Ossars, new GTCDate(9792, 03, 30), "Ossarion, ID, OI");
			Leader l2 = new Leader("Alma Halama", new GTCDate(9929, 09, 28), NatNames.Keitheas, Species.Ethels, new GTCDate(10193, 02, 20), "Keitheas, FD, KE");
			Leader[] tabLeaders = { l1, l2 };
			//list of nations
			Nation n1 = new Nation(NatNames.Ossarion, l1, 530000000000L, 6, 50000);
			Nation n2 = new Nation(NatNames.Keitheas, l2, 350000000000L, 5, 30000);
			Nation[] tabNations = { n1, n2 };

			string[] tabLeaSaved = { "leader_0.xml", "leader_1.xml" };
			string[] tabNatSaved = { "nation_0.xml", "nation_1.xml"};
			do 
			{
				//first menu
				Console.WriteLine("Welcome to AppNations!");
				Console.WriteLine("Menu:");
				Console.WriteLine("1. Load...");
				Console.WriteLine("2. View...");
				string strChoice = Console.ReadLine();
				int.TryParse(strChoice, out int choice);

				//Loader
				if (choice == 1)
				{
					Console.WriteLine("Loading menu: ");
					Console.WriteLine("1. Nations");
					Console.WriteLine("2. Leaders");
					string strViewChoice = Console.ReadLine();
					int.TryParse(strViewChoice, out int loadChoice);

					//Nations
					if(loadChoice == 1)
					{
						Console.WriteLine("File List: ");
						for(int i=0; i<tabNatSaved.Length; i++)
						{
							Console.WriteLine("file: " + tabNatSaved[i]);
						}

						//selection
						Console.WriteLine("Enter a file ID:");

						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int natChoice);

						//loader
						NationLoad natLoader = new NationLoad(tabNatSaved[natChoice]);
						Nation newNation = natLoader.Load();
						tabLeaders[natChoice] = newNation.Leader;
						tabNations[natChoice] = newNation;
					}
					//Leaders
					if (loadChoice == 2)
					{
						Console.WriteLine("File List: ");
						for (int i = 0; i < tabLeaSaved.Length; i++)
						{
							Console.WriteLine("file: " + tabLeaSaved[i]);
						}

						//selection
						Console.WriteLine("Enter a file ID:");

						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int leaChoice);

						//loader
						LeaderLoad leaLoader = new LeaderLoad(tabLeaSaved[leaChoice]);
						tabLeaders[leaChoice] = leaLoader.Load();
						 
						
					}
				}
				//Viewer
				if (choice == 2)
				{
					Console.WriteLine("Viewer menu: ");
					Console.WriteLine("1. Nations");
					Console.WriteLine("2. Leaders");
					string strViewChoice = Console.ReadLine();
					int.TryParse(strViewChoice, out int viewChoice);

					//nations
					if (viewChoice == 1)
					{
						//display list of nations
						Console.WriteLine("List of Nations:");
						for (int i = 0; i < tabNations.Length; i++)
						{
							Console.WriteLine(i + ": " + tabNations[i].Name.ToString());
						}
						//selection
						Console.WriteLine("Enter a Nation ID:");

						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int natChoice);

						//selected nation's display
						NationWiew view = new NationWiew(tabNations[natChoice]);
						view.Viewer();

						//nation's menu
						Console.WriteLine("Nation's menu:");
						Console.WriteLine("1. Edit");
						Console.WriteLine("2. Save");
						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int menuChoice);

						//edit
						if (menuChoice == 1)
						{
							NationEdit editor = new NationEdit(tabNations[natChoice]);

							Nation newNation = editor.Editor();
							tabLeaders[natChoice] = newNation.Leader;
							tabNations[natChoice] = newNation;

						}
						//save
						if (menuChoice == 2)
						{
							NationSave saver = new NationSave(tabNations[natChoice], tabNatSaved[natChoice]);
							saver.Save();
						}


					}
					//leaders
					else if (viewChoice == 2)
					{
						//display list of leaders
						Console.WriteLine("List of Leaders:");
						for (int i = 0; i < tabLeaders.Length; i++)
						{
							Console.WriteLine(i + ": " + tabLeaders[i].Name);
						}

						//selection
						Console.WriteLine("Enter a Leader ID:");

						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int leaChoice);

						//display selected leader
						LeaderWiew view = new LeaderWiew(tabLeaders[leaChoice]);
						view.Viewer();

						//leader's menu
						Console.WriteLine("Leader's menu:");
						Console.WriteLine("1. Edit");
						Console.WriteLine("2. Save");
						strChoice = Console.ReadLine();
						int.TryParse(strChoice, out int menuChoice);

						//edit
						if (menuChoice == 1)
						{
							LeaderEdit editor = new LeaderEdit(tabLeaders[leaChoice]);
							tabLeaders[leaChoice] = editor.Editor();
						}
						//save
						if (menuChoice == 2)
						{
							LeaderSave saver = new LeaderSave(tabLeaders[leaChoice], tabLeaSaved[leaChoice]);
							saver.Save();
						}

					}
					else
					{
						Console.WriteLine("wrong answer :( ");
					}
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
