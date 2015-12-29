using System;
using System.Windows.Forms;
using Yahtzee;

namespace Yatzee_Windows
{
	static class Program_Windows
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			// Get the players
			frmCreatePlayers frmPlayers = new frmCreatePlayers();
			frmPlayers.ShowDialog();
			if (frmPlayers.DialogResult != DialogResult.OK)
				return;

			// Create rules object and add the players to it
			Rules therules = new Rules();
			foreach (string playername in frmPlayers.Players)
			{
				therules.AddPlayer(playername);
			}

			if (therules.PlayerCount == 0)
				return;

			// Pass the Rules to the main game form
			Application.Run(new frmMainGame(therules));
		}
	}
}