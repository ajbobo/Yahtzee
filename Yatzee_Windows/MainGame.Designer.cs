namespace Yatzee_Windows
{
	partial class frmMainGame
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGame));
			this.grdScores = new System.Windows.Forms.DataGridView();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataSet1 = new System.Data.DataSet();
			this.tblScores = new System.Data.DataTable();
			this.colUpperCategory = new System.Data.DataColumn();
			this.btnRollDice = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.grdScores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblScores)).BeginInit();
			this.SuspendLayout();
			// 
			// grdScores
			// 
			this.grdScores.AllowUserToAddRows = false;
			this.grdScores.AllowUserToDeleteRows = false;
			this.grdScores.AllowUserToResizeColumns = false;
			this.grdScores.AllowUserToResizeRows = false;
			this.grdScores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.grdScores.AutoGenerateColumns = false;
			this.grdScores.BackgroundColor = System.Drawing.SystemColors.Control;
			this.grdScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn});
			this.grdScores.DataMember = "Scores";
			this.grdScores.DataSource = this.dataSet1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdScores.DefaultCellStyle = dataGridViewCellStyle2;
			this.grdScores.Location = new System.Drawing.Point(12, 41);
			this.grdScores.MultiSelect = false;
			this.grdScores.Name = "grdScores";
			this.grdScores.ReadOnly = true;
			this.grdScores.RowHeadersVisible = false;
			this.grdScores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
			this.grdScores.Size = new System.Drawing.Size(468, 570);
			this.grdScores.TabIndex = 0;
			this.grdScores.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScores_CellMouseLeave);
			this.grdScores.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdScores_RowPostPaint);
			this.grdScores.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScores_CellMouseEnter);
			this.grdScores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScores_CellClick);
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.Frozen = true;
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tblScores});
			// 
			// tblScores
			// 
			this.tblScores.Columns.AddRange(new System.Data.DataColumn[] {
            this.colUpperCategory});
			this.tblScores.TableName = "Scores";
			// 
			// colUpperCategory
			// 
			this.colUpperCategory.AllowDBNull = false;
			this.colUpperCategory.Caption = "Category";
			this.colUpperCategory.ColumnName = "Category";
			this.colUpperCategory.ReadOnly = true;
			// 
			// btnRollDice
			// 
			this.btnRollDice.Location = new System.Drawing.Point(12, 12);
			this.btnRollDice.Name = "btnRollDice";
			this.btnRollDice.Size = new System.Drawing.Size(95, 23);
			this.btnRollDice.TabIndex = 1;
			this.btnRollDice.Text = "Roll Dice";
			this.btnRollDice.UseVisualStyleBackColor = true;
			this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			this.imageList1.Images.SetKeyName(0, "Die_1_Unselected.bmp");
			this.imageList1.Images.SetKeyName(1, "Die_2_Unselected.bmp");
			this.imageList1.Images.SetKeyName(2, "Die_3_Unselected.bmp");
			this.imageList1.Images.SetKeyName(3, "Die_4_Unselected.bmp");
			this.imageList1.Images.SetKeyName(4, "Die_5_Unselected.bmp");
			this.imageList1.Images.SetKeyName(5, "Die_6_Unselected.bmp");
			this.imageList1.Images.SetKeyName(6, "Die_1_Selected.bmp");
			this.imageList1.Images.SetKeyName(7, "Die_2_Selected.bmp");
			this.imageList1.Images.SetKeyName(8, "Die_3_Selected.bmp");
			this.imageList1.Images.SetKeyName(9, "Die_4_Selected.bmp");
			this.imageList1.Images.SetKeyName(10, "Die_5_Selected.bmp");
			this.imageList1.Images.SetKeyName(11, "Die_6_Selected.bmp");
			// 
			// frmMainGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 623);
			this.Controls.Add(this.btnRollDice);
			this.Controls.Add(this.grdScores);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMainGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yahtzee";
			((System.ComponentModel.ISupportInitialize)(this.grdScores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblScores)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Data.DataSet dataSet1;
		private System.Windows.Forms.DataGridView grdScores;
		private System.Data.DataTable tblScores;
		private System.Data.DataColumn colUpperCategory;
		private System.Windows.Forms.Button btnRollDice;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.ImageList imageList1;
	}
}