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
    public partial class passPrompt : Form
    {
        public Player Player { get; set; }
        public passPrompt()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(Player.Password == textBoxPassword.Text)
            {
                DialogResult = DialogResult.OK;
            }
            textBoxPassword.BorderStyle = BorderStyle.None;
            panelPass.Visible = true;
            panelPass.SendToBack();
            labelIncorrect.Visible = true;            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void labelEye_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
