using System.Windows.Forms;
using System.Data;
using System;
using System.Drawing;
using System.Collections.Generic;
using Yahtzee;

namespace Yatzee_Windows
{
	public partial class frmMainGame : Form
	{
		private Rules _rules;
		private Dice _dice;

		private int _curturn;
		private int _curplayer;
		private bool _gamerunning;
		private int _rollsleft;

		private List<int> _scorablerows;

		private DataGridViewCellStyle previewstyle;
		private DataGridViewCellStyle emptystyle;
		private DataGridViewCellStyle sectionheaderstyle;
		private DataGridViewCellStyle totalstyle;
		private DataGridViewCellStyle winnerstyle;

		private ImageCheckBox[] diceboxes;

		public frmMainGame(Rules rules)
		{
			InitializeComponent();
			CreateDiceControls();

			_rules = rules;
			_dice = new Dice();
			_curturn = 1;
			_curplayer = 1;
			_rollsleft = 3;
			_gamerunning = true;

			_scorablerows = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 11, 12, 13, 14, 15, 16, 17 }); // The rows where scores can be placed

			// Add the columns for the players
			int playercount = _rules.PlayerCount;
			for (int x = 0; x < playercount; x++)
			{
				string playername = _rules.GetPlayer(x).Name;
				AddColumnToTables(playername, tblScores, grdScores);
			}

			// Add the required rows to the table
			string[] categories = { 
											 "Upper Section", "Aces", "Twos", "Threes", "Fours", "Fives", "Sixes", "Total", "Bonus", "Upper Total",
											 "Lower Section", "3 of a kind", "4 of a kind", "Full House", "Sm. Straight", "Lg. Straight", "YAHTZEE", "Chance",
											 "Bonuses", "Bonus Score", "Total (lower)", "Total (upper)", "Grand Total"
										 };
			AddRowsToTable(categories, tblScores);

			// Create the non-default styles
			previewstyle = new DataGridViewCellStyle();
			previewstyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
			previewstyle.ForeColor = Color.Red;

			emptystyle = new DataGridViewCellStyle();
			emptystyle.BackColor = grdScores.BackgroundColor;

			sectionheaderstyle = new DataGridViewCellStyle();
			sectionheaderstyle.BackColor = grdScores.BackgroundColor;
			sectionheaderstyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			sectionheaderstyle.Padding = new Padding(0, 5, 0, 0);

			totalstyle = new DataGridViewCellStyle();
			totalstyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

			winnerstyle = new DataGridViewCellStyle();
			winnerstyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			winnerstyle.ForeColor = Color.Red;

			// First player's first roll
			StartTurn();

			// Update the GUI
			SetWindowTitle();
			SetRollDiceButton();
		}

		private void CreateDiceControls()
		{
			diceboxes = new ImageCheckBox[5];

			for (int x = 0; x < 5; x++)
			{
				diceboxes[x] = new ImageCheckBox();
				diceboxes[x].Location = new Point(125 + 40 * x, 11);
				diceboxes[x].Size = new Size(25, 25);
			}

			this.Controls.AddRange(diceboxes);
		}

		private void AddRowsToTable(string[] categories, DataTable table)
		{
			foreach (string category in categories)
			{
				DataRow datarow = table.NewRow();
				datarow[0] = category;
				table.Rows.Add(datarow);
			}
		}

		private void AddColumnToTables(string playername, DataTable table, DataGridView grid)
		{
			// The DataTable holds the actual data   NOTE: this is different from the Settings dialog
			DataColumn col = new DataColumn();
			col.Caption = playername;
			col.ColumnName = playername;
			col.ReadOnly = false;
			col.DefaultValue = "";
			table.Columns.Add(col);

			// The DataGrid holds the view definition
			DataGridViewTextBoxColumn colview = new DataGridViewTextBoxColumn();
			colview.DataPropertyName = playername;
			colview.HeaderText = playername;
			colview.Name = playername;
			colview.SortMode = DataGridViewColumnSortMode.NotSortable;
			colview.Resizable = DataGridViewTriState.True;
			colview.Width = 75;
			grid.Columns.Add(colview);
		}
		
		private void SetWindowTitle()
		{
			string title = "Yahtzee - ";

			if (_gamerunning)
			{
				string playername = _rules.GetPlayer(_curplayer - 1).Name;
				title += playername + "'s turn - " + " Turn " + _curturn.ToString();
			}
			else
			{
				title += "Game Over";
			}

			this.Text = title;
		}

		private void SetRollDiceButton()
		{
			if (_rollsleft <= 0 || !_gamerunning)
				btnRollDice.Enabled = false;
			else
				btnRollDice.Enabled = true;

			foreach (CheckBox btn in diceboxes)
				btn.Enabled = _gamerunning;

			string text = String.Format("Roll Dice ({0})", _rollsleft);
			btnRollDice.Text = text;
		}

		private int GetFieldFromRow(int row)
		{
			int selectedfield;
			if (row >= 1 && row <= 6)
				selectedfield = row - 1;
			else
				selectedfield = row - 5;

			return selectedfield;
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
			}

			// Update the button
			SetRollDiceButton();
		}

		private void EndGame()
		{
			// Update the displays of the totals
			int highscore = 0;
			for (int x = 0; x < _rules.PlayerCount; x++)
			{
				Player player = _rules.GetPlayer(x);
				int col = x + 1;
				int upperscore = player.TopScore;
				int totalscore = player.TotalScore;
				int ybonus = player.YBonus;
				
				tblScores.Rows[7][col] = player.TempTopScore; // Upper total
				tblScores.Rows[8][col] = player.TopBonus; // Upper bonus
				tblScores.Rows[9][col] = upperscore; // Upper score
				tblScores.Rows[18][col] = ybonus / 100; // Number of Yahtzee bonuses
				tblScores.Rows[19][col] = ybonus; // Yahtzee bonus
				tblScores.Rows[20][col] = totalscore - upperscore; // Lower Score
				tblScores.Rows[21][col] = upperscore; // Upper score (shown in lower section)
				tblScores.Rows[22][col] = totalscore; // Total score

				if (totalscore > highscore)
					highscore = totalscore;
			}

			// Mark the column(s) with the highest totals
			for (int x = 0; x < _rules.PlayerCount; x++)
			{
				if (_rules.GetPlayer(x).TotalScore == highscore)
					grdScores.Rows[22].Cells[x + 1].Style = winnerstyle;
			}

			_curturn = 0;
			_gamerunning = false;
		}

		private void grdScores_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (!_gamerunning)
				return;

			int row = e.RowIndex;
			int col = e.ColumnIndex;

			// Place the score
			if (_scorablerows.Contains(row) && col == _curplayer)
			{
				Player player = _rules.GetPlayer(_curplayer - 1);

				// Record the score for the selected field
				int selectedfield = GetFieldFromRow(row);
				player.SetScore(selectedfield, _dice);

				// Display the score for the selected field
				grdScores.Rows[row].Cells[col].Style = grdScores.DefaultCellStyle;
				tblScores.Rows[row][col] = player.GetScore(selectedfield);

				// Advance the player and the turn
				_curplayer++;
				_rollsleft = 3;
				if (_curplayer > _rules.PlayerCount)
				{
					_curplayer = 1;
					_curturn++;
				}

				// Check for the end of the game
				if (_curturn > 13)
					EndGame();
				else
					StartTurn();
			}

			SetRollDiceButton();
			SetWindowTitle();
		}

		private void grdScores_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (!_gamerunning || diceboxes[0].Text == "")
				return;

			int row = e.RowIndex;
			int col = e.ColumnIndex;

			// Show the score preview
			if (_scorablerows.Contains(row) && col == _curplayer)
			{
				string current = (string)tblScores.Rows[row][col];
				if (current.Length == 0) // Make sure nothing has been recorded yet
				{
					// Find the Rules field that the user is pointing at
					int selectedfield = GetFieldFromRow(row);

					// Find the score the user would put in the selected field
					int curscore = _rules.GetScore(selectedfield, _dice, _rules.GetPlayer(_curplayer - 1), false);

					// Display the score (temporarily)
					grdScores.Rows[row].Cells[col].Style = previewstyle;
					tblScores.Rows[row][col] = curscore.ToString();
				}
			}
		}

		private void grdScores_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
		{
			if (!_gamerunning)
				return;

			int row = e.RowIndex;
			int col = e.ColumnIndex;

			// Hide the score preview
			if (_scorablerows.Contains(row) && col == _curplayer)
			{
				// If the style is not the default, then a preview is being shown - hide it
				if (grdScores.Rows[row].Cells[col].Style != grdScores.DefaultCellStyle)
				{
					grdScores.Rows[row].Cells[col].Style = grdScores.DefaultCellStyle;
					tblScores.Rows[row][col] = "";
				}
			}
		}

		private void grdScores_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			int row = e.RowIndex;
			DataGridViewRow currow = grdScores.Rows[row];

			SetRowStyle(row, currow);
			PaintRow(row, e);
		}

		private void PaintRow(int row, DataGridViewRowPostPaintEventArgs e)
		{
			// Paint the row
			switch (row)
			{
				case 0: // "Upper Section"
				case 10: // "Lower Section"
					// The "hidden" rows need to show the line under the previous row
					using (Pen pen = new Pen(grdScores.GridColor, 1))
					{
						e.Graphics.DrawLine(pen, e.RowBounds.X, e.RowBounds.Y, grdScores.Columns.GetColumnsWidth(DataGridViewElementStates.Visible), e.RowBounds.Y);
					}
					break;
				default:
					// This draws the lines around the cells
					using (Pen pen = new Pen(grdScores.GridColor, 1))
					{
						int colstart = e.RowBounds.Left;
						foreach (DataGridViewColumn col in grdScores.Columns)
						{
							e.Graphics.DrawRectangle(pen, colstart - grdScores.HorizontalScrollingOffset, e.RowBounds.Top, col.Width, e.RowBounds.Height);
							colstart += col.Width;
						}
					}
					break;
			}
		}

		private void SetRowStyle(int row, DataGridViewRow currow)
		{
			// Set the cell style for the row
			switch (row)
			{
				case 0: // "Upper Section"
				case 10: // "Lower Section"
					// This will basically hide the cells in the row
					currow.Height = grdScores.Rows[row + 1].Height + 5;
					currow.Cells[0].Style = sectionheaderstyle;
					for (int col = 1; col < grdScores.Columns.Count; col++)
					{
						currow.Cells[col].Style = emptystyle;
					}
					break;
				case 7: // Upper total
				case 8: // Upper Bonus
				case 9: // Upper Total (with bonus)
				case 20: // Lower Total
				case 21: // Upper Total
				case 22: // Grand Total
					// Make the row header stand out
					currow.Cells[0].Style = totalstyle;
					break;

			}
		}

		private void btnRollDice_Click(object sender, EventArgs e)
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
	}
}
