namespace Yahtzee_Mobile
{
	partial class MainGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mainMenu1;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.itemRollDice = new System.Windows.Forms.MenuItem();
			this.lblAces = new System.Windows.Forms.Label();
			this.lblTwos = new System.Windows.Forms.Label();
			this.lblThrees = new System.Windows.Forms.Label();
			this.lblFours = new System.Windows.Forms.Label();
			this.lblFives = new System.Windows.Forms.Label();
			this.lblSixes = new System.Windows.Forms.Label();
			this.lbl3OfAKind = new System.Windows.Forms.Label();
			this.lblSmStraight = new System.Windows.Forms.Label();
			this.lblFullHouse = new System.Windows.Forms.Label();
			this.lblChance = new System.Windows.Forms.Label();
			this.lblYahtzee = new System.Windows.Forms.Label();
			this.lblLgStraight = new System.Windows.Forms.Label();
			this.lbl4OfAKind = new System.Windows.Forms.Label();
			this.btnAces = new System.Windows.Forms.Button();
			this.btnTwos = new System.Windows.Forms.Button();
			this.btnThrees = new System.Windows.Forms.Button();
			this.btn3OfAKind = new System.Windows.Forms.Button();
			this.btnSmStraight = new System.Windows.Forms.Button();
			this.btnFullHouse = new System.Windows.Forms.Button();
			this.btnChance = new System.Windows.Forms.Button();
			this.btnLgStraight = new System.Windows.Forms.Button();
			this.btn4OfAKind = new System.Windows.Forms.Button();
			this.btnSixes = new System.Windows.Forms.Button();
			this.btnFives = new System.Windows.Forms.Button();
			this.btnFours = new System.Windows.Forms.Button();
			this.btnYahtzee = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.itemRollDice);
			// 
			// itemRollDice
			// 
			this.itemRollDice.Text = "Roll";
			this.itemRollDice.Click += new System.EventHandler(this.itemRollDice_Click);
			// 
			// lblAces
			// 
			this.lblAces.Location = new System.Drawing.Point(4, 7);
			this.lblAces.Name = "lblAces";
			this.lblAces.Size = new System.Drawing.Size(77, 20);
			this.lblAces.Text = "Aces";
			// 
			// lblTwos
			// 
			this.lblTwos.Location = new System.Drawing.Point(4, 34);
			this.lblTwos.Name = "lblTwos";
			this.lblTwos.Size = new System.Drawing.Size(77, 20);
			this.lblTwos.Text = "Twos";
			// 
			// lblThrees
			// 
			this.lblThrees.Location = new System.Drawing.Point(4, 61);
			this.lblThrees.Name = "lblThrees";
			this.lblThrees.Size = new System.Drawing.Size(77, 20);
			this.lblThrees.Text = "Threes";
			// 
			// lblFours
			// 
			this.lblFours.Location = new System.Drawing.Point(122, 7);
			this.lblFours.Name = "lblFours";
			this.lblFours.Size = new System.Drawing.Size(77, 20);
			this.lblFours.Text = "Fours";
			// 
			// lblFives
			// 
			this.lblFives.Location = new System.Drawing.Point(122, 34);
			this.lblFives.Name = "lblFives";
			this.lblFives.Size = new System.Drawing.Size(77, 20);
			this.lblFives.Text = "Fives";
			// 
			// lblSixes
			// 
			this.lblSixes.Location = new System.Drawing.Point(122, 61);
			this.lblSixes.Name = "lblSixes";
			this.lblSixes.Size = new System.Drawing.Size(77, 20);
			this.lblSixes.Text = "Sixes";
			// 
			// lbl3OfAKind
			// 
			this.lbl3OfAKind.Location = new System.Drawing.Point(3, 117);
			this.lbl3OfAKind.Name = "lbl3OfAKind";
			this.lbl3OfAKind.Size = new System.Drawing.Size(78, 20);
			this.lbl3OfAKind.Text = "3 of a kind";
			// 
			// lblSmStraight
			// 
			this.lblSmStraight.Location = new System.Drawing.Point(4, 144);
			this.lblSmStraight.Name = "lblSmStraight";
			this.lblSmStraight.Size = new System.Drawing.Size(77, 20);
			this.lblSmStraight.Text = "Sm. Straight";
			// 
			// lblFullHouse
			// 
			this.lblFullHouse.Location = new System.Drawing.Point(4, 171);
			this.lblFullHouse.Name = "lblFullHouse";
			this.lblFullHouse.Size = new System.Drawing.Size(77, 20);
			this.lblFullHouse.Text = "Full House";
			// 
			// lblChance
			// 
			this.lblChance.Location = new System.Drawing.Point(4, 196);
			this.lblChance.Name = "lblChance";
			this.lblChance.Size = new System.Drawing.Size(77, 20);
			this.lblChance.Text = "Chance";
			// 
			// lblYahtzee
			// 
			this.lblYahtzee.Location = new System.Drawing.Point(122, 171);
			this.lblYahtzee.Name = "lblYahtzee";
			this.lblYahtzee.Size = new System.Drawing.Size(77, 20);
			this.lblYahtzee.Text = "Yahtzee";
			// 
			// lblLgStraight
			// 
			this.lblLgStraight.Location = new System.Drawing.Point(122, 144);
			this.lblLgStraight.Name = "lblLgStraight";
			this.lblLgStraight.Size = new System.Drawing.Size(77, 20);
			this.lblLgStraight.Text = "Lg. Straight";
			// 
			// lbl4OfAKind
			// 
			this.lbl4OfAKind.Location = new System.Drawing.Point(122, 117);
			this.lbl4OfAKind.Name = "lbl4OfAKind";
			this.lbl4OfAKind.Size = new System.Drawing.Size(78, 20);
			this.lbl4OfAKind.Text = "4 of a kind";
			// 
			// btnAces
			// 
			this.btnAces.Location = new System.Drawing.Point(83, 7);
			this.btnAces.Name = "btnAces";
			this.btnAces.Size = new System.Drawing.Size(33, 20);
			this.btnAces.TabIndex = 51;
			this.btnAces.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnTwos
			// 
			this.btnTwos.Location = new System.Drawing.Point(83, 34);
			this.btnTwos.Name = "btnTwos";
			this.btnTwos.Size = new System.Drawing.Size(33, 20);
			this.btnTwos.TabIndex = 65;
			this.btnTwos.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnThrees
			// 
			this.btnThrees.Location = new System.Drawing.Point(83, 61);
			this.btnThrees.Name = "btnThrees";
			this.btnThrees.Size = new System.Drawing.Size(33, 20);
			this.btnThrees.TabIndex = 66;
			this.btnThrees.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btn3OfAKind
			// 
			this.btn3OfAKind.Location = new System.Drawing.Point(83, 117);
			this.btn3OfAKind.Name = "btn3OfAKind";
			this.btn3OfAKind.Size = new System.Drawing.Size(33, 20);
			this.btn3OfAKind.TabIndex = 67;
			this.btn3OfAKind.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnSmStraight
			// 
			this.btnSmStraight.Location = new System.Drawing.Point(83, 144);
			this.btnSmStraight.Name = "btnSmStraight";
			this.btnSmStraight.Size = new System.Drawing.Size(33, 20);
			this.btnSmStraight.TabIndex = 68;
			this.btnSmStraight.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnFullHouse
			// 
			this.btnFullHouse.Location = new System.Drawing.Point(83, 171);
			this.btnFullHouse.Name = "btnFullHouse";
			this.btnFullHouse.Size = new System.Drawing.Size(33, 20);
			this.btnFullHouse.TabIndex = 69;
			this.btnFullHouse.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnChance
			// 
			this.btnChance.Location = new System.Drawing.Point(83, 196);
			this.btnChance.Name = "btnChance";
			this.btnChance.Size = new System.Drawing.Size(33, 20);
			this.btnChance.TabIndex = 70;
			this.btnChance.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnLgStraight
			// 
			this.btnLgStraight.Location = new System.Drawing.Point(204, 144);
			this.btnLgStraight.Name = "btnLgStraight";
			this.btnLgStraight.Size = new System.Drawing.Size(33, 20);
			this.btnLgStraight.TabIndex = 71;
			this.btnLgStraight.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btn4OfAKind
			// 
			this.btn4OfAKind.Location = new System.Drawing.Point(204, 117);
			this.btn4OfAKind.Name = "btn4OfAKind";
			this.btn4OfAKind.Size = new System.Drawing.Size(33, 20);
			this.btn4OfAKind.TabIndex = 72;
			this.btn4OfAKind.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnSixes
			// 
			this.btnSixes.Location = new System.Drawing.Point(204, 61);
			this.btnSixes.Name = "btnSixes";
			this.btnSixes.Size = new System.Drawing.Size(33, 20);
			this.btnSixes.TabIndex = 73;
			this.btnSixes.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnFives
			// 
			this.btnFives.Location = new System.Drawing.Point(204, 34);
			this.btnFives.Name = "btnFives";
			this.btnFives.Size = new System.Drawing.Size(33, 20);
			this.btnFives.TabIndex = 74;
			this.btnFives.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnFours
			// 
			this.btnFours.Location = new System.Drawing.Point(204, 7);
			this.btnFours.Name = "btnFours";
			this.btnFours.Size = new System.Drawing.Size(33, 20);
			this.btnFours.TabIndex = 75;
			this.btnFours.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// btnYahtzee
			// 
			this.btnYahtzee.Location = new System.Drawing.Point(204, 171);
			this.btnYahtzee.Name = "btnYahtzee";
			this.btnYahtzee.Size = new System.Drawing.Size(33, 20);
			this.btnYahtzee.TabIndex = 76;
			this.btnYahtzee.Click += new System.EventHandler(this.btnScoreField_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(25, 25);
			this.imageList1.Images.Clear();
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource8"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource9"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource10"))));
			this.imageList1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource11"))));
			// 
			// MainGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.btnYahtzee);
			this.Controls.Add(this.btnFours);
			this.Controls.Add(this.btnFives);
			this.Controls.Add(this.btnSixes);
			this.Controls.Add(this.btn4OfAKind);
			this.Controls.Add(this.btnLgStraight);
			this.Controls.Add(this.btnChance);
			this.Controls.Add(this.btnFullHouse);
			this.Controls.Add(this.btnSmStraight);
			this.Controls.Add(this.btn3OfAKind);
			this.Controls.Add(this.btnThrees);
			this.Controls.Add(this.btnTwos);
			this.Controls.Add(this.btnAces);
			this.Controls.Add(this.lblYahtzee);
			this.Controls.Add(this.lblLgStraight);
			this.Controls.Add(this.lbl4OfAKind);
			this.Controls.Add(this.lblChance);
			this.Controls.Add(this.lblFullHouse);
			this.Controls.Add(this.lblSmStraight);
			this.Controls.Add(this.lbl3OfAKind);
			this.Controls.Add(this.lblSixes);
			this.Controls.Add(this.lblFives);
			this.Controls.Add(this.lblFours);
			this.Controls.Add(this.lblThrees);
			this.Controls.Add(this.lblTwos);
			this.Controls.Add(this.lblAces);
			this.Menu = this.mainMenu1;
			this.Name = "MainGame";
			this.Text = "Yahtzee";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuItem itemRollDice;
		private System.Windows.Forms.Label lblAces;
		private System.Windows.Forms.Label lblTwos;
		private System.Windows.Forms.Label lblThrees;
		private System.Windows.Forms.Label lblFours;
		private System.Windows.Forms.Label lblFives;
		private System.Windows.Forms.Label lblSixes;
		private System.Windows.Forms.Label lbl3OfAKind;
		private System.Windows.Forms.Label lblSmStraight;
		private System.Windows.Forms.Label lblFullHouse;
		private System.Windows.Forms.Label lblChance;
		private System.Windows.Forms.Label lblYahtzee;
		private System.Windows.Forms.Label lblLgStraight;
		private System.Windows.Forms.Label lbl4OfAKind;
		private System.Windows.Forms.Button btnAces;
		private System.Windows.Forms.Button btnTwos;
		private System.Windows.Forms.Button btnThrees;
		private System.Windows.Forms.Button btn3OfAKind;
		private System.Windows.Forms.Button btnSmStraight;
		private System.Windows.Forms.Button btnFullHouse;
		private System.Windows.Forms.Button btnChance;
		private System.Windows.Forms.Button btnLgStraight;
		private System.Windows.Forms.Button btn4OfAKind;
		private System.Windows.Forms.Button btnSixes;
		private System.Windows.Forms.Button btnFives;
		private System.Windows.Forms.Button btnFours;
		private System.Windows.Forms.Button btnYahtzee;
		private System.Windows.Forms.ImageList imageList1;
	}
}

