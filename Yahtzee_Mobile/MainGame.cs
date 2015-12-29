using System;
using System.Drawing;
using System.Windows.Forms;
using Yahtzee;

namespace Yahtzee_Mobile
{
	public partial class MainGame : Form
	{
		private Rules _rules;
		private Dice _dice;

		private int _rollsleft;
		private Player _player;
		private int _turnsleft;

		private ImageCheckBox[] diceboxes;
		//private CheckBox[] diceboxes;

		public MainGame(Rules rules)
		{
			InitializeComponent();
			CreateDiceControls();

			_rules = rules;
			_dice = new Dice();
			_player = rules.GetPlayer(0);

			InitializeGame();
		}

		private void CreateDiceControls()
		{
			diceboxes = new ImageCheckBox[5];

			int boxwidth = 25;
			int buffer = 10;
			int totalwidth = boxwidth * 5 + buffer * 4; // The total width of the 5 dice boxes plus the space between them
			int leftside = (this.Width - totalwidth) / 2;

			for (int x = 0; x < 5; x++)
			{
				diceboxes[x] = new ImageCheckBox();
				diceboxes[x].Location = new Point((boxwidth + buffer) * x + leftside, 230);
				diceboxes[x].Size = new Size(boxwidth, 25);
				this.Controls.Add(diceboxes[x]);
			}
		}

		private void InitializeGame()
		{
			_turnsleft = 13;
			_rollsleft = 3;
			_player.ClearScores();
			foreach (Control control in Controls)
			{
				if (control.Name.StartsWith("btn"))
					control.Text = "";
			}
			foreach (ImageCheckBox box in diceboxes)
			{
				box.Checked = false;
			}
			StartTurn();
		}

		private void StartTurn()
		{
			_rollsleft--;

			// Reroll all dice
			_dice.RollDice();
			for (int x = 0; x < 5; x++)
			{
				int dievalue = _dice.GetDie(x);
				diceboxes[x].Checked = false;
				diceboxes[x].Text = dievalue.ToString();
				diceboxes[x].SetImages(imageList1.Images[dievalue + 5], imageList1.Images[dievalue - 1]);
				diceboxes[x].Invalidate();
			}

			// Update the button
			SetRollDiceButton();
		}

		private void itemRollDice_Click(object sender, EventArgs e)
		{
			// Reroll non-checked dice
			for (int x = 0; x < 5; x++)
			{
				if (!diceboxes[x].Checked)
				{
					_dice.RerollDie(x);
					int dievalue = _dice.GetDie(x);
					diceboxes[x].Text = dievalue.ToString();
					diceboxes[x].SetImages(imageList1.Images[dievalue + 5], imageList1.Images[dievalue - 1]);
				}
			}

			// One roll used up
			_rollsleft--;

			// Update the button
			SetRollDiceButton();
		}

		private void SetRollDiceButton()
		{
			if (_rollsleft <= 0)
				itemRollDice.Enabled = false;
			else
				itemRollDice.Enabled = true;

			string text = String.Format("Roll Dice ({0})", _rollsleft);
			itemRollDice.Text = text;
		}

		private void ScoreField(Button sender, int field)
		{
			if (_player.SetScore(field, _dice))
			{
				sender.Text = String.Format("{0}", _player.GetScore(field));
				_turnsleft--;
				if (_turnsleft > 0)
				{
					_rollsleft = 3;
					StartTurn();
				}
				else
				{
					EndGame();
				}
			}
			else
			{
				MessageBox.Show("You have a score in that field.\r\nPick another", "Yahtzee");
			}
		}

		private void EndGame()
		{
			int upperscore = _player.TopScore;
			int upperbonus = _player.TopBonus;
			int ybonus = _player.YBonus;
			int totalscore = _player.TotalScore;

			string message = String.Format("Upper Score: {0}\r\nUpper Bonus: {1}\r\nYahtzee Bonus: {2}\t\n\t\nTotal Score: {3}",
										upperscore, upperbonus, ybonus, totalscore);
			DialogResult res = MessageBox.Show(message, "Game Over - Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if (res == DialogResult.Yes)
			{
				InitializeGame();
			}
			else
			{
				this.Close();
			}
		}

		private void btnScoreField_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string name = button.Name;
			int fieldnum = -1;
			switch (name)
			{
				case "btnAces":			fieldnum = 0;	break;
				case "btnTwos":			fieldnum = 1;	break;
				case "btnThrees":			fieldnum = 2;	break;
				case "btnFours":			fieldnum = 3;	break;
				case "btnFives":			fieldnum = 4;	break;
				case "btnSixes":			fieldnum = 5;	break;
				case "btn3OfAKind":		fieldnum = 6;	break;
				case "btn4OfAKind":		fieldnum = 7;	break;
				case "btnFullHouse":		fieldnum = 8;	break;
				case "btnSmStraight":	fieldnum = 9;	break;
				case "btnLgStraight":	fieldnum = 10;	break;
				case "btnYahtzee":		fieldnum = 11; break;
				case "btnChance":			fieldnum = 12; break;
			}

			if (fieldnum != -1) // Something valid happened - ignore anything weird
				ScoreField(button, fieldnum);
		}
	}
}