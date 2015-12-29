// Note: Cheating only works for 1-player games
//#define CHEATING

using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
	public class Dice
	{
		private int[] _dice;
		private Random _rand;
#if CHEATING
		private int _counter;
#endif

		public Dice()
		{
			_rand = new Random();
			_dice = new int[5];
#if CHEATING
			_counter = 13;
#endif
		}

		public void RollDice()
		{
#if !CHEATING
			for (int x = 0; x < 5; x++)
			{
				_dice[x] = _rand.Next(1, 7);
			}
#else
			for (int x = 0; x < 5; x++)
			{
				_dice[x] = (_counter > 6 ? 6 : _counter);
			}
			_counter--;
#endif
		}

		public void RerollDie(int die)
		{
			_dice[die] = _rand.Next(1, 7);
		}

		public int GetDie(int die)
		{
			return _dice[die];
		}
	}
}
