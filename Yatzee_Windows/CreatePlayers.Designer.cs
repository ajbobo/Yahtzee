namespace Yatzee_Windows
{
	partial class frmCreatePlayers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePlayers));
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumPlayers = new System.Windows.Forms.TextBox();
			this.grdPlayers = new System.Windows.Forms.DataGridView();
			this.coltxtPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataPlayers = new System.Data.DataSet();
			this.tblPlayers = new System.Data.DataTable();
			this.colPlayerName = new System.Data.DataColumn();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPlayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPlayers)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of players";
			// 
			// txtNumPlayers
			// 
			this.txtNumPlayers.Location = new System.Drawing.Point(111, 10);
			this.txtNumPlayers.Name = "txtNumPlayers";
			this.txtNumPlayers.Size = new System.Drawing.Size(169, 20);
			this.txtNumPlayers.TabIndex = 1;
			this.txtNumPlayers.TextChanged += new System.EventHandler(this.txtNumPlayers_TextChanged);
			// 
			// grdPlayers
			// 
			this.grdPlayers.AllowUserToAddRows = false;
			this.grdPlayers.AllowUserToDeleteRows = false;
			this.grdPlayers.AutoGenerateColumns = false;
			this.grdPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coltxtPlayerName});
			this.grdPlayers.DataMember = "Players";
			this.grdPlayers.DataSource = this.dataPlayers;
			this.grdPlayers.Location = new System.Drawing.Point(16, 36);
			this.grdPlayers.Name = "grdPlayers";
			this.grdPlayers.RowHeadersVisible = false;
			this.grdPlayers.Size = new System.Drawing.Size(264, 189);
			this.grdPlayers.TabIndex = 2;
			// 
			// coltxtPlayerName
			// 
			this.coltxtPlayerName.DataPropertyName = "PlayerName";
			this.coltxtPlayerName.HeaderText = "Player Name";
			this.coltxtPlayerName.Name = "coltxtPlayerName";
			this.coltxtPlayerName.Width = 240;
			// 
			// dataPlayers
			// 
			this.dataPlayers.DataSetName = "PlayerDataSet";
			this.dataPlayers.Tables.AddRange(new System.Data.DataTable[] {
            this.tblPlayers});
			// 
			// tblPlayers
			// 
			this.tblPlayers.Columns.AddRange(new System.Data.DataColumn[] {
            this.colPlayerName});
			this.tblPlayers.TableName = "Players";
			// 
			// colPlayerName
			// 
			this.colPlayerName.Caption = "Player Name";
			this.colPlayerName.ColumnName = "PlayerName";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(205, 231);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmCreatePlayers
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.grdPlayers);
			this.Controls.Add(this.txtNumPlayers);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCreatePlayers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yahtzee - Create Players";
			((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataPlayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPlayers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumPlayers;
		private System.Windows.Forms.DataGridView grdPlayers;
		private System.Windows.Forms.Button btnOK;
		private System.Data.DataSet dataPlayers;
		private System.Data.DataTable tblPlayers;
		private System.Data.DataColumn colPlayerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn coltxtPlayerName;
	}
}

