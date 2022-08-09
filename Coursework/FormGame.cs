using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormGame : Form
    {
        private Game game;
        public Game Game 
        {
            get => game;
            set => game = value;
        }
        
        List<PictureBox> PlayerHandVis = new List<PictureBox>();
        List<PictureBox> DealerHandVis = new List<PictureBox>();
        List<PictureBox> HiddenHandVis = new List<PictureBox>();
        List<Button> GameButtons = new List<Button>();
              
        public FormGame()
        {
            InitializeComponent();
        }        
        private void buttonRight_Click(object sender, EventArgs e)
        {
            var btn = Controls.OfType<Button>().Where(x => x.Name.Contains("Chip")).ToList();
            
            for(int i = 0; i < btn.Count(); i++)
            {
                if (btn.Last().Name == btn[i].Name)
                    break;
                if(btn[i].Visible == true && btn[i].Enabled == true)
                {
                    btn[i].Enabled = false;
                    btn[i].Visible = false;                                      
                    btn[i + 1].Enabled = true;
                    btn[i + 1].Visible = true;
                    break;
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            var btn = Controls.OfType<Button>().Where(x => x.Name.Contains("Chip")).ToList();
            
            for (int i = btn.Count() - 1; i > 0; --i)
            {
                if (btn.First().Name == btn[i].Name)
                    break;
                if (btn[i].Visible == true && btn[i].Enabled == true)
                {
                    btn[i].Enabled = false;
                    btn[i].Visible = false;
                    btn[i - 1].Enabled = true;
                    btn[i - 1].Visible = true;
                    break;
                }
            }
        }

        private void buttonChip10_Click(object sender, EventArgs e)
        {
            Game.Casino.AddBet(10);
        }

        private void buttonChip50_Click(object sender, EventArgs e)
        {
            Game.Casino.AddBet(50);
        }

        private void buttonChip100_Click(object sender, EventArgs e)
        {
            Game.Casino.AddBet(100);
        }

        private void buttonChip500_Click(object sender, EventArgs e)
        {
            Game.Casino.AddBet(500);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (Game.Casino.Player.Bet < 10)
                return;
            Game.Casino.ReturnBet();
            buttonClear.Enabled = false;
            buttonClear.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Game.Casino.Player.Bet >= 10 && buttonLeft.Visible == true)
            {
                buttonClear.Enabled = true;
                buttonClear.Visible = true;
            }
            else
            {
                buttonClear.Enabled = false;
                buttonClear.Visible = false;
            }            
            toolStripStatusLabelCash.Text = "Cash: " + Game.Casino.Player.Balance.ToString();
            toolStripStatusLabelBet.Text = "Bet: " + Game.Casino.Player.Bet.ToString();
            toolStripStatusLabelWin.Text = "Result: " + Game.Casino.Player.LastWin.ToString();
            
        }
        private void DisplayPlayerCard(Game game)
        {
            PlayerHandVis.Add(new PictureBox
            {
                Width = 71,
                Height = 96,
                Location = new Point(275 + PlayerHandVis.Count * 80, 225),
                ImageLocation = game.Hands.PlayerHand[PlayerHandVis.Count].Image,
                SizeMode = PictureBoxSizeMode.AutoSize,
            });
            Controls.Add(PlayerHandVis.Last());

            labelPlayerHandValue.Text = game.GetHandName(game.Hands.PlayerHand).ToString();
        }
        private void DisplayDealerCard(Game game)
        {
            DealerHandVis.Add(new PictureBox
            {
                Width = 71,
                Height = 96,
                Location = new Point(275 + DealerHandVis.Count * 80 + HiddenHandVis.Count * 80, 40),
                ImageLocation = game.Hands.RevealedCards[DealerHandVis.Count].Image,
                SizeMode = PictureBoxSizeMode.AutoSize,
            });
            Controls.Add(DealerHandVis.Last());

            labelDealerHandValue.Text = game.GetHandName(game.Hands.RevealedCards).ToString();
        }
        private void DisplayHiddenCard()
        {           
            HiddenHandVis.Add(new PictureBox
            {
                Width = 71,
                Height = 96,
                Location = new Point(275 + DealerHandVis.Count * 80 + HiddenHandVis.Count * 80, 40),
                ImageLocation = "back.png",
                SizeMode = PictureBoxSizeMode.AutoSize,
            });
            Controls.Add(HiddenHandVis.Last());

            if (DealerHandVis.Count == 0)
                labelDealerHandValue.Text = "DEALER HAND";
        }
        private void DisplayCards(Game game)
        {
            for (int i = 0; i < game.Hands.PlayerHand.Count; i++)
            {
                DisplayPlayerCard(game);
            }
            for (int i = 0; i < game.Hands.RevealedCards.Count; i++)
            {
                DisplayDealerCard(game);
            }
            for (int i = 0; i < game.Hands.HiddenCards.Count; i++)
            {
                DisplayHiddenCard();
            }
            

           
        }
        private void RemoveDisplayedCards()
        {
            if (PlayerHandVis.Count > 0)
            {
                foreach (PictureBox pb in PlayerHandVis)
                {
                    Controls.Remove(pb);
                }
                foreach (PictureBox pb in DealerHandVis)
                {
                    Controls.Remove(pb);
                }
                foreach (PictureBox pb in HiddenHandVis)
                {
                    Controls.Remove(pb);
                }
            }
            PlayerHandVis = new List<PictureBox>();
            DealerHandVis = new List<PictureBox>();
            HiddenHandVis = new List<PictureBox>();
        }
        private void DisplayGameButton(Game game)
        {
            GameButtons.Add(new Button
            {
                Name = $"buttonAction{game.actions[GameButtons.Count].SetName(Game)}",
                Location = new Point(325 + GameButtons.Count * 60, 377),
                Size = new Size(49, 45),
                Text = "",
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Tile,
                BackgroundImage = new Bitmap(game.actions[GameButtons.Count].Image),
                TabIndex = GameButtons.Count,
                BackColor = Color.DarkGray
            });
            GameButtons.Last().Click += new EventHandler(Action_Click);
            Controls.Add(GameButtons.Last());            
        }      
        private void Action_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Name = $"buttonAction{Game.actions[btn.TabIndex].SetName(Game)}";

            RemoveDisplayedCards();
            DisplayCards(Game);

            Game.actions[btn.TabIndex].DoAction(Game);      

            btn.Name = $"buttonAction{Game.actions[btn.TabIndex].SetName(Game)}";

            RemoveDisplayedCards();
            DisplayCards(Game);

            if (!btn.Name.Contains("Continue"))
                FinalizeGame(Game);
        }
        private void RemoveDisplayedActions()
        {
            if (GameButtons.Count > 0)
            {
                foreach (Button btn in GameButtons)
                {
                    Controls.Remove(btn);
                }
            }
            GameButtons = new List<Button>();
        }
        private void buttonInitialize_Click(object sender, EventArgs e)
        {           
            InitializeGame(Game);
            
            buttonInitialize.Visible = false;
        }
        private void InitializeGame(Game game)
        {
            RemoveDisplayedCards();
                       
            game.Casino.StartRound();
            game.InitializeRound();
           
            DisplayCards(game);

            for (int i = 0; i < game.actions.Count; i++)
            {
                DisplayGameButton(game);
            }

            foreach (Control c in Controls)
            {
                label3.SendToBack();
                labelPanel.SendToBack();
                if (c.Name.Contains("Bet") || c.Name.Contains("Chip") || c.Name.Contains("Left") || c.Name.Contains("Right"))
                {
                    c.Enabled = false;
                    c.Visible = false;
                }       
            }
        }
        private void FinalizeGame(Game game)
        {            
            RemoveDisplayedCards();
            DisplayCards(game);
            RemoveDisplayedActions();
            buttonNewBet.Visible = true;
            buttonNewBet.Enabled = true;
            buttonReBet.Visible = true;
            buttonReBet.Enabled = true;
        }

        private void buttonNewBet_Click(object sender, EventArgs e)
        {
            RemoveDisplayedCards();
            labelPlayerHandValue.Text = "";
            labelDealerHandValue.Text = "";
            foreach (Control c in Controls)
            {
                if (c.Name.Equals("buttonChip10") || c.Name.Contains("Left") || c.Name.Contains("Right") || c.Equals(buttonInitialize))
                {
                    c.Enabled = true;
                    c.Visible = true;
                }
                else if (c.Name.Contains("Bet"))
                {
                    c.Enabled = false;
                    c.Visible = false;
                }
            }
        }

        private void buttonReBet_Click(object sender, EventArgs e)
        {
            if (Game.Casino.Player.LastBet > Game.Casino.Player.Balance)
            {
                buttonNewBet_Click(sender, e);
                return;
            }
            Game.Casino.AddBet(Game.Casino.Player.LastBet);
            Game.Casino.Player.LastBet = Game.Casino.Player.Bet;
            InitializeGame(Game);
        }
    }
}
