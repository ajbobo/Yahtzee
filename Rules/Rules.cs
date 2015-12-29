using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Yahtzee
{
	public class Rules
	{
		private List<Player> _players;

		public Rules()
		{
			_players = new List<Player>();
		}

		public void AddPlayer(string name)
		{
			_players.Add(new Player(name,this));
		}

		public Player GetPlayer(int playernum)
		{
			return _players[playernum];
		}

		public int PlayerCount
		{
			get
			{
				return _players.Count;
			}
		}

		public int GetScore(int field, Dice thedice, Player curplayer, bool addbonuses)
		{
			// Check to see if the user is filling in a space with a Yahtzee bonus
			bool joker = false;
			if (FullYahtzee(thedice) != 0) // Did the player roll a Yahtzee?
			{
				int yahtzeescore = curplayer.GetScore(11);
				int dienum = thedice.GetDie(0);
				// Bonuses are only awarded if a Yahtzee has already been scored
				if (yahtzeescore == 50 && addbonuses) 
					curplayer.YBonus++;
				// Can the dice be used as a lower-section joker?
				if (yahtzeescore > -1 && curplayer.GetScore(dienum - 1) > -1) // The matching upper-section and Yahtzee box have been used
					joker = true;
			}

			// Determine the score
			switch (field)
			{
				case 0: return TopFields(thedice, 1); 
				case 1: return TopFields(thedice, 2); 
				case 2: return TopFields(thedice, 3); 
				case 3: return TopFields(thedice, 4); 
				case 4: return TopFields(thedice, 5); 
				case 5: return TopFields(thedice, 6); 
				case 6: return ThreeOfAKind(thedice, joker); 
				case 7: return FourOfAKind(thedice, joker);
				case 8: return FullHouse(thedice, joker); 
				case 9: return SmStraight(thedice, joker); 
				case 10: return LgStraight(thedice, joker); 
				case 11: return FullYahtzee(thedice); 
				case 12: return Chance(thedice); 
			}
			return 0;
		}

		private int TopFields(Dice thedice, int dienum)
		{
			int score = 0;
			for (int x = 0; x < 5; x++)
			{
				if (thedice.GetDie(x) == dienum)
					score += dienum;
			}
			return score;
		}

		private int ThreeOfAKind(Dice thedice, bool joker)
		{
			int score = 0;
			int[] cnt = new int[6] { 0, 0, 0, 0, 0, 0 };
			for (int die = 0; die < 5; die++)
			{
				int dienum = thedice.GetDie(die);
				score += dienum;
				cnt[dienum - 1]++;
			}
			for (int val = 0; val < 6; val++)
			{
				if (cnt[val] >= 3 || joker)
					return score;
			}
			return 0;
		}

		private int FourOfAKind(Dice thedice, bool joker)
		{
			int score = 0;
			int[] cnt = new int[6] { 0, 0, 0, 0, 0, 0 };
			for (int die = 0; die < 5; die++)
			{
				int dienum = thedice.GetDie(die);
				score += dienum;
				cnt[dienum - 1]++;
			}
			for (int val = 0; val < 6; val++)
			{
				if (cnt[val] >= 4 || joker)
					return score;
			}
			return 0;
		}

		private int FullHouse(Dice thedice, bool joker)
		{
			int[] cnt = new int[6] { 0, 0, 0, 0, 0, 0 };
			for (int die = 0; die < 5; die++)
			{
				int dienum = thedice.GetDie(die);
				cnt[dienum - 1]++;
			}
			bool havetwo = false;
			bool havethree = false;
			for (int val = 0; val < 6; val++)
			{
				if (cnt[val] == 2)
					havetwo = true;
				else if (cnt[val] == 3)
					havethree = true;
			}
			if ((havetwo && havethree) || joker)
				return 25;

			return 0;
		}

		private int SmStraight(Dice thedice, bool joker)
		{
			bool one = false, two = false, three = false, four = false, five = false, six = false;
			for (int die = 0; die < 5; die++)
			{
				switch (thedice.GetDie(die))
				{
					case 1: one = true; break;
					case 2: two = true; break;
					case 3: three = true; break;
					case 4: four = true; break;
					case 5: five = true; break;
					case 6: six = true; break;
				}
			}
			if ((one && two && three && four) ||
				 (two && three && four && five) ||
				 (three && four && five && six) ||
				 (joker))
			{
				return 30;
			}
			return 0;
		}

		private int LgStraight(Dice thedice, bool joker)
		{
			bool one = false, two = false, three = false, four = false, five = false, six = false;
			for (int die = 0; die < 5; die++)
			{
				switch (thedice.GetDie(die))
				{
					case 1: one = true; break;
					case 2: two = true; break;
					case 3: three = true; break;
					case 4: four = true; break;
					case 5: five = true; break;
					case 6: six = true; break;
				}
			}
			if ((one && two && three && four && five) ||
				 (two && three && four && five && six) ||
				 (joker))
			{
				return 40;
			}
			return 0;
		}

		private int FullYahtzee(Dice thedice)
		{
			int firstval = thedice.GetDie(0);
			bool isyahtzee = true;
			for (int die = 1; die < 5; die++)
				if (thedice.GetDie(die) != firstval)
					isyahtzee = false;
			if (isyahtzee)
				return 50;
			return 0;
		}

		private int Chance(Dice thedice)
		{
			int score = 0;
			for (int die = 0; die < 5; die++)
				score += thedice.GetDie(die);
			return score;
		}
	}
}
