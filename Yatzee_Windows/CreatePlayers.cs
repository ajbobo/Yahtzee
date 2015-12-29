using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Yatzee_Windows
{
	public partial class frmCreatePlayers : Form
	{
		private string[] _players;

		public frmCreatePlayers()
		{
			InitializeComponent();

			txtNumPlayers.Text = "1";
		}

		private void txtNumPlayers_TextChanged(object sender, EventArgs e)
		{
			int numplayers = 0;
			bool isvalid = true;
			try
			{
				numplayers = int.Parse(txtNumPlayers.Text);
			}
			catch (Exception ex) 
			{
				string temp = ex.Message;
				if (txtNumPlayers.Text.Length > 0)
					isvalid = false;
			}
			if (txtNumPlayers.Text == null || txtNumPlayers.Text.Length == 0)
				numplayers = 0;

			if (numplayers < 0 || !isvalid)
			{
				MessageBox.Show("Please enter a single, positive number", "Invalid number");
				return; 
			}

			int numrows = tblPlayers.Rows.Count;
			if (numplayers > numrows) // Add players
			{
				for (int x = numrows + 1; x <= numplayers; x++)
				{
					DataRow PlayerRow = tblPlayers.NewRow();
					PlayerRow["PlayerName"] = "Player_" + x;
					tblPlayers.Rows.Add(PlayerRow);
				}
			}
			else if (numplayers < numrows) // Remove rows
			{
				for (int x = 0; x < numrows - numplayers; x++)
					tblPlayers.Rows.RemoveAt(tblPlayers.Rows.Count - 1);
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			// Save the names entered in the table
			int numplayers = tblPlayers.Rows.Count;
			_players = new string[numplayers];
			for (int x = 0; x < numplayers; x++)
			{
				_players[x] = (string)tblPlayers.Rows[x][0];
			}

			this.DialogResult = DialogResult.OK;
		}

		public string[] Players
		{
			get
			{
				return _players;
			}
		}
	}
}