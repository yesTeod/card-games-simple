namespace Coursework
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.timerLabelColors = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonPoker3 = new System.Windows.Forms.Button();
            this.buttonBlackjack = new System.Windows.Forms.Button();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.buttonPoker5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(175, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(314, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(455, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(267, 272);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(139, 28);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(267, 197);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(139, 30);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // timerLabelColors
            // 
            this.timerLabelColors.Enabled = true;
            this.timerLabelColors.Interval = 500;
            this.timerLabelColors.Tick += new System.EventHandler(this.timerLabelColors_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(455, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(314, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(175, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Magenta;
            this.label8.Location = new System.Drawing.Point(34, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣ ♠ ♥ ♦ ♣";
            // 
            // buttonPoker3
            // 
            this.buttonPoker3.Enabled = false;
            this.buttonPoker3.Location = new System.Drawing.Point(267, 79);
            this.buttonPoker3.Name = "buttonPoker3";
            this.buttonPoker3.Size = new System.Drawing.Size(139, 30);
            this.buttonPoker3.TabIndex = 11;
            this.buttonPoker3.Text = "3 Card Poker";
            this.buttonPoker3.UseVisualStyleBackColor = true;
            this.buttonPoker3.Visible = false;
            this.buttonPoker3.Click += new System.EventHandler(this.buttonPoker3_Click);
            // 
            // buttonBlackjack
            // 
            this.buttonBlackjack.Enabled = false;
            this.buttonBlackjack.Location = new System.Drawing.Point(458, 79);
            this.buttonBlackjack.Name = "buttonBlackjack";
            this.buttonBlackjack.Size = new System.Drawing.Size(139, 30);
            this.buttonBlackjack.TabIndex = 12;
            this.buttonBlackjack.Text = "Blackjack";
            this.buttonBlackjack.UseVisualStyleBackColor = true;
            this.buttonBlackjack.Visible = false;
            this.buttonBlackjack.Click += new System.EventHandler(this.buttonBlackjack_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(37, 141);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(599, 84);
            this.listBoxPlayers.TabIndex = 14;
            this.listBoxPlayers.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(37, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Accounts";
            this.label9.Visible = false;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Enabled = false;
            this.buttonAddPlayer.Location = new System.Drawing.Point(40, 249);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 16;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Visible = false;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.Enabled = false;
            this.buttonRemovePlayer.Location = new System.Drawing.Point(121, 249);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePlayer.TabIndex = 17;
            this.buttonRemovePlayer.Text = "Remove";
            this.buttonRemovePlayer.UseVisualStyleBackColor = true;
            this.buttonRemovePlayer.Visible = false;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // buttonPoker5
            // 
            this.buttonPoker5.Enabled = false;
            this.buttonPoker5.Location = new System.Drawing.Point(76, 79);
            this.buttonPoker5.Name = "buttonPoker5";
            this.buttonPoker5.Size = new System.Drawing.Size(139, 30);
            this.buttonPoker5.TabIndex = 18;
            this.buttonPoker5.Text = "5 Card Poker";
            this.buttonPoker5.UseVisualStyleBackColor = true;
            this.buttonPoker5.Visible = false;
            this.buttonPoker5.Click += new System.EventHandler(this.buttonPoker5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(659, 341);
            this.Controls.Add(this.buttonPoker5);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.buttonBlackjack);
            this.Controls.Add(this.buttonPoker3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer timerLabelColors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonPoker3;
        private System.Windows.Forms.Button buttonBlackjack;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonRemovePlayer;
        private System.Windows.Forms.Button buttonPoker5;
    }
}

