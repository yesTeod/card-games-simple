namespace Coursework
{
    partial class FormGame
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
            this.statusStripGame = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCash = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBet = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWin = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChip500 = new System.Windows.Forms.Button();
            this.buttonChip100 = new System.Windows.Forms.Button();
            this.buttonChip50 = new System.Windows.Forms.Button();
            this.buttonChip10 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPanel = new System.Windows.Forms.Label();
            this.labelPlayerHandValue = new System.Windows.Forms.Label();
            this.labelDealerHandValue = new System.Windows.Forms.Label();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.buttonNewBet = new System.Windows.Forms.Button();
            this.buttonReBet = new System.Windows.Forms.Button();
            this.statusStripGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripGame
            // 
            this.statusStripGame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStripGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEmpty,
            this.toolStripStatusLabelCash,
            this.toolStripStatusLabelBet,
            this.toolStripStatusLabelWin});
            this.statusStripGame.Location = new System.Drawing.Point(0, 428);
            this.statusStripGame.Name = "statusStripGame";
            this.statusStripGame.Size = new System.Drawing.Size(800, 22);
            this.statusStripGame.TabIndex = 0;
            this.statusStripGame.Text = "statusStrip1";
            // 
            // toolStripStatusLabelEmpty
            // 
            this.toolStripStatusLabelEmpty.Name = "toolStripStatusLabelEmpty";
            this.toolStripStatusLabelEmpty.Size = new System.Drawing.Size(322, 17);
            this.toolStripStatusLabelEmpty.Text = "                                                                                 " +
    "                        ";
            this.toolStripStatusLabelEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelEmpty.ToolTipText = "            ";
            // 
            // toolStripStatusLabelCash
            // 
            this.toolStripStatusLabelCash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripStatusLabelCash.Name = "toolStripStatusLabelCash";
            this.toolStripStatusLabelCash.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelCash.Text = "Cash: ";
            // 
            // toolStripStatusLabelBet
            // 
            this.toolStripStatusLabelBet.Name = "toolStripStatusLabelBet";
            this.toolStripStatusLabelBet.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabelBet.Text = "Bet: ";
            // 
            // toolStripStatusLabelWin
            // 
            this.toolStripStatusLabelWin.Name = "toolStripStatusLabelWin";
            this.toolStripStatusLabelWin.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelWin.Text = "Win: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "____________________";
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonRight.BackgroundImage = global::Coursework.Properties.Resources.arrow_right1;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Location = new System.Drawing.Point(538, 389);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(32, 30);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLeft.BackgroundImage = global::Coursework.Properties.Resources.arrow_left1;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(234, 388);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 31);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAX BET : 500";
            // 
            // buttonChip500
            // 
            this.buttonChip500.BackColor = System.Drawing.Color.Transparent;
            this.buttonChip500.BackgroundImage = global::Coursework.Properties.Resources.chip500;
            this.buttonChip500.Enabled = false;
            this.buttonChip500.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonChip500.FlatAppearance.BorderSize = 0;
            this.buttonChip500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChip500.Location = new System.Drawing.Point(361, 299);
            this.buttonChip500.Name = "buttonChip500";
            this.buttonChip500.Size = new System.Drawing.Size(73, 75);
            this.buttonChip500.TabIndex = 2;
            this.buttonChip500.UseVisualStyleBackColor = false;
            this.buttonChip500.Visible = false;
            this.buttonChip500.Click += new System.EventHandler(this.buttonChip500_Click);
            // 
            // buttonChip100
            // 
            this.buttonChip100.BackColor = System.Drawing.Color.Transparent;
            this.buttonChip100.BackgroundImage = global::Coursework.Properties.Resources.chip100;
            this.buttonChip100.Enabled = false;
            this.buttonChip100.FlatAppearance.BorderSize = 0;
            this.buttonChip100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChip100.Location = new System.Drawing.Point(361, 300);
            this.buttonChip100.Name = "buttonChip100";
            this.buttonChip100.Size = new System.Drawing.Size(73, 74);
            this.buttonChip100.TabIndex = 3;
            this.buttonChip100.UseVisualStyleBackColor = false;
            this.buttonChip100.Visible = false;
            this.buttonChip100.Click += new System.EventHandler(this.buttonChip100_Click);
            // 
            // buttonChip50
            // 
            this.buttonChip50.BackColor = System.Drawing.Color.Transparent;
            this.buttonChip50.BackgroundImage = global::Coursework.Properties.Resources.chip50;
            this.buttonChip50.Enabled = false;
            this.buttonChip50.FlatAppearance.BorderSize = 0;
            this.buttonChip50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChip50.Location = new System.Drawing.Point(372, 322);
            this.buttonChip50.Name = "buttonChip50";
            this.buttonChip50.Size = new System.Drawing.Size(51, 54);
            this.buttonChip50.TabIndex = 4;
            this.buttonChip50.UseVisualStyleBackColor = false;
            this.buttonChip50.Visible = false;
            this.buttonChip50.Click += new System.EventHandler(this.buttonChip50_Click);
            // 
            // buttonChip10
            // 
            this.buttonChip10.BackColor = System.Drawing.Color.Transparent;
            this.buttonChip10.BackgroundImage = global::Coursework.Properties.Resources.chip10;
            this.buttonChip10.FlatAppearance.BorderSize = 0;
            this.buttonChip10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChip10.Location = new System.Drawing.Point(375, 323);
            this.buttonChip10.Name = "buttonChip10";
            this.buttonChip10.Size = new System.Drawing.Size(48, 53);
            this.buttonChip10.TabIndex = 5;
            this.buttonChip10.UseVisualStyleBackColor = false;
            this.buttonChip10.Click += new System.EventHandler(this.buttonChip10_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.BackgroundImage = global::Coursework.Properties.Resources.clear_bet;
            this.buttonClear.Enabled = false;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(459, 283);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 54);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Visible = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanel.Location = new System.Drawing.Point(0, 377);
            this.labelPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(914, 54);
            this.labelPanel.TabIndex = 7;
            this.labelPanel.Text = "                                                                                 " +
    "                                                                     \r\n\r\n";
            // 
            // labelPlayerHandValue
            // 
            this.labelPlayerHandValue.AutoSize = true;
            this.labelPlayerHandValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerHandValue.ForeColor = System.Drawing.Color.White;
            this.labelPlayerHandValue.Location = new System.Drawing.Point(139, 261);
            this.labelPlayerHandValue.Name = "labelPlayerHandValue";
            this.labelPlayerHandValue.Size = new System.Drawing.Size(0, 20);
            this.labelPlayerHandValue.TabIndex = 8;
            // 
            // labelDealerHandValue
            // 
            this.labelDealerHandValue.AutoSize = true;
            this.labelDealerHandValue.BackColor = System.Drawing.Color.Transparent;
            this.labelDealerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerHandValue.ForeColor = System.Drawing.Color.White;
            this.labelDealerHandValue.Location = new System.Drawing.Point(139, 72);
            this.labelDealerHandValue.Name = "labelDealerHandValue";
            this.labelDealerHandValue.Size = new System.Drawing.Size(0, 20);
            this.labelDealerHandValue.TabIndex = 9;
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.BackColor = System.Drawing.Color.Transparent;
            this.buttonInitialize.BackgroundImage = global::Coursework.Properties.Resources.deal;
            this.buttonInitialize.FlatAppearance.BorderSize = 0;
            this.buttonInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInitialize.Location = new System.Drawing.Point(375, 107);
            this.buttonInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(48, 52);
            this.buttonInitialize.TabIndex = 10;
            this.buttonInitialize.UseVisualStyleBackColor = false;
            this.buttonInitialize.Click += new System.EventHandler(this.buttonInitialize_Click);
            // 
            // buttonNewBet
            // 
            this.buttonNewBet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNewBet.BackgroundImage = global::Coursework.Properties.Resources.New_bet;
            this.buttonNewBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNewBet.Enabled = false;
            this.buttonNewBet.FlatAppearance.BorderSize = 0;
            this.buttonNewBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewBet.Location = new System.Drawing.Point(332, 379);
            this.buttonNewBet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewBet.Name = "buttonNewBet";
            this.buttonNewBet.Size = new System.Drawing.Size(49, 42);
            this.buttonNewBet.TabIndex = 14;
            this.buttonNewBet.UseVisualStyleBackColor = false;
            this.buttonNewBet.Visible = false;
            this.buttonNewBet.Click += new System.EventHandler(this.buttonNewBet_Click);
            // 
            // buttonReBet
            // 
            this.buttonReBet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReBet.BackgroundImage = global::Coursework.Properties.Resources.Re_bet;
            this.buttonReBet.Enabled = false;
            this.buttonReBet.FlatAppearance.BorderSize = 0;
            this.buttonReBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReBet.Location = new System.Drawing.Point(415, 379);
            this.buttonReBet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReBet.Name = "buttonReBet";
            this.buttonReBet.Size = new System.Drawing.Size(50, 42);
            this.buttonReBet.TabIndex = 15;
            this.buttonReBet.UseVisualStyleBackColor = false;
            this.buttonReBet.Visible = false;
            this.buttonReBet.Click += new System.EventHandler(this.buttonReBet_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.table;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewBet);
            this.Controls.Add(this.buttonReBet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonInitialize);
            this.Controls.Add(this.labelDealerHandValue);
            this.Controls.Add(this.labelPlayerHandValue);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonChip10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonChip50);
            this.Controls.Add(this.buttonChip100);
            this.Controls.Add(this.buttonChip500);
            this.Controls.Add(this.statusStripGame);
            this.Controls.Add(this.labelPanel);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";
            this.statusStripGame.ResumeLayout(false);
            this.statusStripGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripGame;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEmpty;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCash;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChip500;
        private System.Windows.Forms.Button buttonChip100;
        private System.Windows.Forms.Button buttonChip50;
        private System.Windows.Forms.Button buttonChip10;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPanel;
        private System.Windows.Forms.Label labelPlayerHandValue;
        private System.Windows.Forms.Label labelDealerHandValue;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Button buttonNewBet;
        private System.Windows.Forms.Button buttonReBet;
    }
}