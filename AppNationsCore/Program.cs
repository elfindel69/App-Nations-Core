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
				int choice = CommonMenusConsole.FirstMenu();

				//Loader
				if (choice == 1)
				{
					int loadChoice = CommonMenusConsole.LoadMenu();

					//Nations
					if(loadChoice == 1)
					{
					
						int natChoice = CommonMenusConsole.FileMenu(tabNatSaved);
						//loader
						Nation newNation = NationMenusConsole.Loader(tabNatSaved[natChoice]);

						tabLeaders[natChoice] = newNation.Leader;
						tabNations[natChoice] = newNation;
					}
					//Leaders
					if (loadChoice == 1)
					{
						int leaChoice = CommonMenusConsole.FileMenu(tabNatSaved);

						tabLeaders[leaChoice] = LeaderMenusConsole.Loader(tabLeaSaved[leaChoice]);
					}
				}
				//Viewer
				if (choice == 2)
				{
					int viewChoice = CommonMenusConsole.ViewMenu();

					//nations
					if (viewChoice == 1)
					{
						//display list of nations
						int natChoice = NationMenusConsole.ListViewer(tabNations);
						//selected nation's display
						int menuChoice = NationMenusConsole.Viewer(tabNations[natChoice]);

						//edit
						if (menuChoice == 1)
						{
							
							Nation newNation = NationMenusConsole.Editor(tabNations[natChoice]);

							tabLeaders[natChoice] = newNation.Leader;
							tabNations[natChoice] = newNation;

						}
						//save
						if (menuChoice == 2)
						{
							NationMenusConsole.Saver(tabNations[natChoice], tabNatSaved[natChoice]);
						}


					}
					//leaders
					else if (viewChoice == 2)
					{
						int leaChoice = LeaderMenusConsole.ListViewer(tabLeaders);

						//display selected leader
						int menuChoice = LeaderMenusConsole.Viewer(tabLeaders[leaChoice]);
						
						//edit
						if (menuChoice == 1)
						{
							tabLeaders[leaChoice] = LeaderMenusConsole.Editor(tabLeaders[leaChoice]);
						}
						//save
						if (menuChoice == 2)
						{
							LeaderMenusConsole.Saver(tabLeaders[leaChoice], tabLeaSaved[leaChoice]);
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
