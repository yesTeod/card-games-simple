using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Coursework
{
    public partial class FormMain : Form
    {
        private List<Player> players = new List<Player>();
        public FormMain()
        {
            InitializeComponent();       
        }
        
        private void timerLabelColors_Tick(object sender, EventArgs e)
        {
            var r = new Random();

            foreach (var lbl in Controls.OfType<Label>().Where(x => x.Text.Contains('♠')))
            {
                lbl.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {           
            foreach(Control c in Controls)
            {
                if (c.Visible == false)
                {
                    c.Enabled = true;
                    c.Visible = true;
                }
            }
            buttonPlay.Enabled = false;
            buttonPlay.Visible = false;
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {         
            var add = new PlayerAdd();
            
            if(add.ShowDialog() == DialogResult.OK) 
            {
                players.Add(add.Player);
                UpdatePlayers();
            }                      
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (IsPlayerSelected() == false)
                return;

            var check = new passPrompt
            {
                Player = players[listBoxPlayers.SelectedIndex]
            };
            if (check.ShowDialog() == DialogResult.OK)
            {
                players.RemoveAt(listBoxPlayers.SelectedIndex);
                listBoxPlayers.Items.RemoveAt(listBoxPlayers.SelectedIndex);
            }            
        }
        private bool IsPlayerSelected()
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show(" Please select a player from the accounts box",
                                "Select",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void UpdatePlayers()
        {
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(
                    players.Select(x => 
                    "Nickname:" + string.Format($"{x.Name,-9}") +  
                    "Balance: " + string.Format($"{x.Balance,-9}") +
                    " Wins:" + string.Format($"{x.Wins,-9}") +
                    "Losses:" + string.Format($"{x.Losses,-9}") +
                    " WinRate:" + string.Format($"{x.WinRate,-9}"))
                    .ToArray());
        }
        private void buttonBlackjack_Click(object sender, EventArgs e)
        {
            if (IsPlayerSelected() == false)
                return;

            var check = new passPrompt()
            {
                Player = players[listBoxPlayers.SelectedIndex]
            };
            if (check.ShowDialog() == DialogResult.OK)
            {
                
                var start = new FormGame()
                {
                    Game = new Blackjack(), 
                };
                start.Game.RegisterAction(new Double());
                start.Game.RegisterAction(new StandBJ());
                start.Game.RegisterAction(new Hit());
                start.Game.Casino = new Casino(check.Player);
                start.Game.Casino.Player.Bet = 0;
                start.Text = "Blackjack";
                start.ShowDialog();
            }
            UpdatePlayers();
        }

        private void buttonPoker3_Click(object sender, EventArgs e)
        {
            if (IsPlayerSelected() == false)
                return;

            var check = new passPrompt()
            {
                Player = players[listBoxPlayers.SelectedIndex]
            };
            if (check.ShowDialog() == DialogResult.OK)
            {
                var start = new FormGame()
                {
                    Game = new ThreeCardPoker(),
                };
                start.Game.RegisterAction(new StandPoker());
                start.Game.RegisterAction(new Play());
                start.Game.Casino = new Casino(check.Player);
                start.Game.Casino.Player.Bet = 0;
                start.Text = "3 Card Poker";
                start.ShowDialog();
            }
            UpdatePlayers();
        }
        private void buttonPoker5_Click(object sender, EventArgs e)
        {
            if (IsPlayerSelected() == false)
                return;

            var check = new passPrompt()
            {
                Player = players[listBoxPlayers.SelectedIndex]
            };
            if (check.ShowDialog() == DialogResult.OK)
            {
                var start = new FormGame()
                {
                    Game = new FiveCardPoker(),
                };
                start.Game.RegisterAction(new StandPoker());
                start.Game.RegisterAction(new Play());
                start.Game.Casino = new Casino(check.Player);
                start.Game.Casino.Player.Bet = 0;
                start.Text = "5 Card Poker";
                start.ShowDialog();
            }
            UpdatePlayers();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("accounts"))
                return;

            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("accounts", FileMode.Open))
                players = (List<Player>)formatter.Deserialize(fs);

            UpdatePlayers();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();

            using (var fs = new FileStream("accounts", FileMode.Create))
                formatter.Serialize(fs, players); 
        }   
    }
}
