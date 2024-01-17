using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GROUP.Game
{
	/// <summary>
	/// Summary description for About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Card Game OF Hearts 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(238, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rules";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(283, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(8, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(650, 572);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // About
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Card Game Of Hearts";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void About_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"➔This game required 4 players to play it. So, for that, we have to make 3 bots in our program.

➔In this game, each heart gives 1 penalty point and the queen of spades gives 13 penalty points. Therefore, the main objective of
this game is to get as low a point as possible.

➔In the first match, players have to give any 3 cards to pass to the left side of their opponent then in the second match, they have to
give any 3 cards to their right side of the opponent then in the third match, they pass the card across the table, and in the fourth
match, there is no card passing. After that, the same process starts again with the fifth match.

➔The player cannot start the game with hearts until the hearts have been broken (played on another suit). The player who has the two
of clubs at the start of the game leads in the first hand, and they must lead with the two of clubs.

➔In this game, the turn starts with each player playing a single card which is also called leading. The other player then has to give the
same card of the suit if they have it in their card deck but if they don’t have that card of the suite then they can throw any card.
Once four cards have been played, the player who played the highest-ranking card in the original suite take that four card. In
these four cards, if they have a heart or queen of spades then they will get the penalty points which will count in that player’s
score.

➔In the first round, the player cannot play with any hearts or the queen of spades, not even if the player doesn’t have any card in
the suit of the lead card.

➔When the all cards have been played then the final points can be counted. In that, the player who has the least points than other
players wins the game. The maximum score limit for players is 100 points or more than the entire game is finished, and the player
with the least points wins. If the points are over 100 and there are 2 or more players equal with the least points then play continues
until there’s only one winner.

➔There is one twisted move in this game. If the player gets all 13 hearts and queen of spades then he or she will get 0 points and
the other 3 players get an extra 26 points. This move is called Shooting the Moon.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
