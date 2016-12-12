using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using GATetrisControl;

namespace GATetris
{
	/// <summary>
	/// Summary description for Tetris.
	/// </summary>
	public class Tetris : System.Windows.Forms.Form
	{

		public Tetris()
		{
			InitializeComponent();
		}



		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.gaTetris = new GATetrisControl.GATetris();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem5});
            this.menuItem1.Text = "&Меню";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuItem2.Text = "&Розпочати гру";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.menuItem5.Text = "&Закінчити гру";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // gaTetris
            // 
            this.gaTetris.Location = new System.Drawing.Point(0, 0);
            this.gaTetris.Name = "gaTetris";
            this.gaTetris.Padding = new System.Windows.Forms.Padding(2);
            this.gaTetris.TabIndex = 0;
            // 
            // Tetris
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(344, 386);
            this.Controls.Add(this.gaTetris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Tetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетріс";
            this.ResumeLayout(false);

		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			gaTetris.TetrisGrid.InitNewGame();
		}


		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			gaTetris.TetrisGrid.InitGameOver();
		}


		private void tetrisGrid_Load(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
		}


		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem5;
        private GATetrisControl.GATetris gaTetris;

        private IContainer components;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Tetris());
		}

        private void gaTetris_Load(object sender, EventArgs e)
        {

        }
	}
}
