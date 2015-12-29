using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
	public class Player
	{
		private string _name;
		private int[] _scores;
		private int _ybonus;
		private Rules _therules;

		public Player(string name,Rules rules)
		{
			_name = name;
			_scores = new int[13];
			for (int x = 0; x < 13; x++)
				_scores[x] = -1;
			_ybonus = 0;
			_therules = rules;
		}

		public string Name
		{
			get { return _name; }
		}

		public int GetScore(int field)
		{
			return _scores[field];
		}

		public bool SetScore(int field, Dice thedice)
		{
			if (_scores[field] != -1)
				return false;
			
			int value = _therules.GetScore(field, thedice, this, true);
			_scores[field] = value;
			return true;
		}

		public void ClearScores()
		{
			for (int field = 0; field < 13; field++)
				_scores[field] = -1;
		}

		public int YBonus
		{
			get { return _ybonus; }
			set { _ybonus += 100; }
		}

		public int TempTopScore
		{
			get
			{
				int sum = 0;
				for (int field = 0; field < 6; field++)
					sum += _scores[field];
				return sum;
			}
		}

		public int TopBonus
		{
			get
			{
				int sum = TempTopScore;
				if (sum >= 63)
					return 35;
				else
					return 0;
			}
		}

		public int TopScore
		{
			get
			{
				return TempTopScore + TopBonus;
			}
		}

		public int TotalScore
		{
			get
			{
				int sum = 0;
				for (int field = 0; field < 13; field++)
					sum += _scores[field];
				sum += TopBonus;
				sum += YBonus;
				return sum;
			}
		}
	}
}
