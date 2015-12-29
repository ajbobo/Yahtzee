using System;

using System.Collections.Generic;
using System.Windows.Forms;
using Yahtzee;

namespace Yahtzee_Mobile
{
	static class Program
	{
		[MTAThread]
		static void Main()
		{
			// Create rules object and add the player to it
			Rules therules = new Rules();
			therules.AddPlayer("Player");
			

			Application.Run(new MainGame(therules));
		}
	}
}