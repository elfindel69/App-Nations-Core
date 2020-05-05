using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

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
			//init - loading files
			List<string> listNatSaved = new List<string>();
			
			List<string> listLeaSaved = new List<string>();

			ListFilesLoad fLoader1 = new ListFilesLoad("nations.xml");
			listNatSaved = fLoader1.Load();
			
			ListFilesLoad fLoader2 = new ListFilesLoad("leaders.xml");
			listLeaSaved = fLoader2.Load();
	
			//list of leaders
			List<Leader> listLeaders = new List<Leader>();
			//list of nations
			List<Nation> listNations = new List<Nation>();


			//init nations
			foreach (string file in listNatSaved)
			{
				NationLoad loader = new NationLoad(file);
				Nation n = loader.Load();
				listNations.Add(n);
			}
			//init leaders
			foreach (string file in listLeaSaved)
			{
				LeaderLoad loader = new LeaderLoad(file);
				Leader lead = loader.Load();
				listLeaders.Add(lead);
			}

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
					
						int natChoice = CommonMenusConsole.FileMenu(listNatSaved);
						//loader
						Nation newNation = NationMenusConsole.Loader(listNatSaved[natChoice]);

						listLeaders[natChoice] = newNation.Leader;
						listNations[natChoice] = newNation;
					}
					//Leaders
					if (loadChoice == 2)
					{
						int leaChoice = CommonMenusConsole.FileMenu(listLeaSaved);

						listLeaders[leaChoice] = LeaderMenusConsole.Loader(listLeaSaved[leaChoice]);
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
						int natChoice = NationMenusConsole.ListViewer(listNations);
						//selected nation's display
						int menuChoice = NationMenusConsole.Viewer(listNations[natChoice]);

						//edit
						if (menuChoice == 1)
						{

							Nation newNation = NationMenusConsole.Editor(listNations[natChoice]);

							listLeaders[natChoice] = newNation.Leader;
							listNations[natChoice] = newNation;

						}
						//save
						if (menuChoice == 2)
						{
							Nation nat = listNations[natChoice];
							string file = "nation_" + nat.ID + ".xml";
							listNatSaved.Add(file);
							NationMenusConsole.Saver(nat, file);
						}


					}
					//leaders
					else if (viewChoice == 2)
					{
						int leaChoice = LeaderMenusConsole.ListViewer(listLeaders);

						//display selected leader
						int menuChoice = LeaderMenusConsole.Viewer(listLeaders[leaChoice]);

						//edit
						if (menuChoice == 1)
						{
							listLeaders[leaChoice] = LeaderMenusConsole.Editor(listLeaders[leaChoice]);
						}
						//save
						if (menuChoice == 2)
						{
							Leader lead = listLeaders[leaChoice];
							string file = "leader_" + lead.ID + ".xml";
							listLeaSaved.Add(file);
							LeaderMenusConsole.Saver(lead, file);
						}
					}
					else
					{
						Console.WriteLine("wrong answer :( ");
					}
				}
				else if (choice == 3)
				{
					int newChoice = CommonMenusConsole.NewMenu();
					if (newChoice == 1)
					{
						Nation newNation = NationMenusConsole.NewNation();

						bool newLeader = true;
						int i = 0;
						foreach( Leader lead in listLeaders)
						{
							if (lead.Equals(newNation.Leader))
							{
								newLeader = false;
								listLeaders[i] = newNation.Leader;
								string file = "leader_" + newNation.Leader.ID + ".xml";
								listLeaSaved[i] = file;
								break;
							}
							i++;
						}
						if (newLeader)
						{
							listLeaders.Add(newNation.Leader);
							string file = "leader_" + newNation.Leader.ID + ".xml";
							listLeaSaved.Add(file);
						}

						bool bNewNation = true;
						int j = 0;
						foreach (Nation nat in listNations)
						{
							if (nat.Equals(newNation))
							{
								bNewNation = false;
								listNations[j] = newNation;
								string file = "nation_" + newNation.ID + ".xml";
								listNatSaved[i] = file;
								break;
							}
						}
						if (bNewNation)
						{
							listNations.Add(newNation);
							string file = "nation_" + newNation.ID + ".xml";
							listNatSaved.Add(file);
						}
						int saveChoice = NationMenusConsole.NewMenu();
						if (saveChoice == 1)
						{
							string file = "nation_" + newNation.ID + ".xml";
							NationMenusConsole.Saver(newNation, file);
						}
						else
						{
							Console.WriteLine("wrong answer :( ");
						}

					}
					else if (newChoice == 2)
					{
						Leader newLeader = LeaderMenusConsole.NewLeader();

						bool bnewLeader = true;
						int i = 0;
						foreach (Leader lead in listLeaders)
						{
							if (lead.Equals(newLeader))
							{
								bnewLeader = false;
								listLeaders[i] = newLeader;
								string file = "leader_" + newLeader.ID + ".xml";
								listLeaSaved[i] = file;
								break;
							}
							i++;
						}
						if (bnewLeader)
						{
							listLeaders.Add(newLeader);
							string file = "leader_" + newLeader.ID + ".xml";
							listLeaSaved.Add(file);
						}
						
						int saveChoice = LeaderMenusConsole.NewMenu();
						if (saveChoice == 1)
						{
							string file = "leader_" + newLeader.ID + ".xml";
							LeaderMenusConsole.Saver(newLeader, file);
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
				}
				else
				{
					Console.WriteLine("wrong answer :( ");
				}

				Console.WriteLine("exit? y/n ");
					saisie = Console.ReadKey(true);

				
			} while (saisie.Key != ConsoleKey.Y);
           if (listLeaSaved.Count > 0)
			{
				string file = "leaders.xml";
				CommonMenusConsole.FilesSaver(listLeaSaved, file);
			}
			if (listNatSaved.Count > 0)
			{
				string file = "nations.xml";
				CommonMenusConsole.FilesSaver(listNatSaved, file);
			}
		}
    }
}
