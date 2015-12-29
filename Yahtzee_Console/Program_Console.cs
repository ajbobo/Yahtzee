using System;
using System.Collections.Generic;
using System.Text;
using Yahtzee;

namespace Yahtzee_Console
{
	class Program_Console
	{
		static private Rules therules;
		static private Dice thedice;
		static private int numplayers;
		static private string[] categories;


		static void Main(string[] args)
		{
			therules = new Rules();
			thedice = new Dice();
			categories = new string[13] {
				"Ones","Twos","Threes","Fours","Fives","Sixes","3OfAKind","4OfAKind","FullHouse",
				"SmStr","LgStr","Yahtzee","Chance"};


			GetPlayers();
			DoTurns();
			Console.Write("Press any key to exit...");
			Console.ReadKey();
		}

		static void GetPlayers()
		{
			bool done = false;
			while (!done)
			{
				try
				{
					Console.Write("Enter number of players: ");
					numplayers = int.Parse(Console.ReadLine());
					done = true;
				}
				catch (Exception e)
				{
					Console.WriteLine("You did not enter a valid number");
				}
			}

			for (int x = 1; x <= numplayers; x++)
			{
				Console.Write("Enter name of player {0}: ", x);
				string playername = Console.ReadLine();
				therules.AddPlayer(playername);
			}
		}

		static void DoTurns()
		{
			for (int turn = 0; turn < 13; turn++)
			{
				for (int player = 0; player < numplayers; player++)
				{
					Player curplayer = therules.GetPlayer(player);
					Console.WriteLine("{0}'s Turn",curplayer.Name);
					PrintCurrentScore(curplayer);
					RollDice(curplayer);
					PlaceScore(curplayer);
					PrintCurrentScore(curplayer);
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey();
				}
			}
			PrintFinalScore();
		}
		
		private static void PlaceScore(Player curplayer)
		{
			bool done = false;
			while (!done)
			{
				int field;
				Console.Write("Select field to place the score: ");
				try
				{
					field = int.Parse(Console.ReadLine());
					field--; // User enters 1-13 convert it to 0-12
					if (curplayer.SetScore(field, thedice))
						done = true;
					else
						Console.WriteLine("Enter a field that does not have a value");
				}
				catch
				{
					Console.WriteLine("You did not enter a valid number");
				}
			}
		}

		private static void RollDice(Player curplayer)
		{
			int roll = 1;
			thedice.RollDice(); 
			while (roll < 3)
			{
				Console.Write("Die Roll {0} : ",roll + 1);
				for (int die = 0; die < 5; die++)
				{
					Console.Write("{0} ", thedice.GetDie(die));
				}
				Console.WriteLine("");
				Console.Write("Enter number of dice to reroll: ");
				bool legalnum = false;
				while (!legalnum)
				{
					try
					{
						int reroll = int.Parse(Console.ReadLine()); // Get number of dice to reroll
						if (reroll >= 0 && reroll <= 5)
						{
							if (reroll == 0)
								roll = 3; // Skip the rest of the rolls
							// Find a better way to enter the dice to reroll - FINISH ME
							// Don't let the user enter the same number more than once
							for (int die = 0; die < reroll; die++)
							{
								Console.Write("Enter die to reroll: ");
								bool legaldie = false;
								while (!legaldie)
								{
									try
									{
										int dienum = int.Parse(Console.ReadLine()); // Get die number to reroll
										dienum--; // User enters 1-5 change it to 0-4
										if (dienum >= 0 && dienum <= 4)
										{
											thedice.RerollDie(dienum);
											legaldie = true;
										}
										else
										{
											Console.Write("Enter die number between 1 and 5: ");
										}
									}
									catch
									{
										Console.WriteLine("You did not enter a valid number");
										Console.Write("Enter die to reroll: ");
									}
								}
							}
							legalnum = true;
						}
						else
						{
							Console.Write("Enter number of dice between 0 and 5: ");
						}
					}
					catch
					{
						Console.WriteLine("You did not enter a valid number");
						Console.Write("Enter number of dice to reroll: ");
					}
				}
				roll++;
			}
			Console.Write("Final Dice: ");
			for (int die = 0; die < 5; die++)
			{
				Console.Write("{0} ", thedice.GetDie(die));
			}
			Console.WriteLine("");
		}

		private static void PrintCurrentScore(Player curplayer)
		{
			Console.WriteLine("Current Score for {0}", curplayer.Name);
			Console.WriteLine("-------------------------------------------------------");
			Console.WriteLine("|  {0}  |  {1}  | {2} |  {3} |  {4} |  {5} |  (1 - 6)",
				categories[0],categories[1],categories[2],categories[3],categories[4],categories[5]);
			Console.Write("|");
			for (int field = 0; field < 6; field++)
			{
				int score = curplayer.GetScore(field);
				if (score == -1)
					Console.Write("        |");
				else
					Console.Write("   {0,2}   |",score);
			}
			Console.WriteLine("");
			Console.WriteLine("-------------------------------------------------------");
			Console.WriteLine("|  {0} |  {1} | {2} |  (7 - 9)",categories[6],categories[7],categories[8]);
			Console.Write("|");
			for (int field = 6; field < 9; field++)
			{
				int score = curplayer.GetScore(field);
				if (score == -1)
					Console.Write("           |");
				else
					Console.Write("     {0,2}    |", score);
			}
			Console.WriteLine("");
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("|  {0}  |  {1}  | {2} |  {3} |  (10 - 13)",categories[9],categories[10],categories[11],categories[12]);
			Console.Write("|");
			for (int field = 9; field < 13; field++)
			{
				int score = curplayer.GetScore(field);
				if (score == -1)
					Console.Write("         |");
				else
					Console.Write("    {0,2}   |", score);
			}
			Console.WriteLine("");
			Console.WriteLine("-----------------------------------------");
		}

		private static void DrawLine()
		{
			Console.Write("-------------");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				Console.Write("-----------", therules.GetPlayer(playernum).Name);
			}
			Console.WriteLine("");
		}

		private static void DrawVal(int width, int val)
		{
			string format = "";
			switch (width)
			{
				case 2: format = "    {0,2}    |"; break;
				case 3: format = "   {0,3}    |"; break;
				case 4: format = "  {0,4}    |"; break;
			}
			Console.Write(format,val);
		}

		private static void DrawCategory(string name)
		{
			Console.Write("| {0,9} |", name);
		}

		private static void PrintFinalScore()
		{
			Console.WriteLine("Final Scores:");
			DrawLine();
			Console.Write("            |");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				int len = Math.Min(therules.GetPlayer(playernum).Name.Length,8);
				Console.Write(" {0,8} |", therules.GetPlayer(playernum).Name.Substring(0,len));
			}
			Console.WriteLine("");
			DrawLine();
			// Print the top section of the score card
			for (int field = 0; field < 6; field++)
			{
				DrawCategory(categories[field]);
				for (int playernum = 0; playernum < numplayers; playernum++)
				{
					DrawVal(2, therules.GetPlayer(playernum).GetScore(field));
				}
				Console.WriteLine("");
			}
			// Print the top section bonus and total
			DrawLine();
			DrawCategory("Bonus");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				DrawVal(2, therules.GetPlayer(playernum).TopBonus);
			}
			Console.WriteLine("");
			DrawLine();
			// Print the bottom section of the score card
			for (int field = 6; field < 13; field++)
			{
				DrawCategory(categories[field]);
				for (int playernum = 0; playernum < numplayers; playernum++)
				{
					DrawVal(2, therules.GetPlayer(playernum).GetScore(field));
				}
				Console.WriteLine("");
			}
			DrawCategory("YBonus");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				DrawVal(4, therules.GetPlayer(playernum).YBonus);
			}
			Console.WriteLine("");
			DrawLine();
			DrawCategory("Top Total");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				DrawVal(3, therules.GetPlayer(playernum).TopScore);
			}
			Console.WriteLine("");
			DrawCategory("GameTotal");
			for (int playernum = 0; playernum < numplayers; playernum++)
			{
				DrawVal(4, therules.GetPlayer(playernum).TotalScore);
			}
			Console.WriteLine("");
			DrawLine();
		}
	}
}
