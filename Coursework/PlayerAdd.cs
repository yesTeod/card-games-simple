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
    public partial class PlayerAdd : Form
    {
        public Player Player { get; set; } = new Player();
        public PlayerAdd()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length < 3)
            {
                MessageBox.Show("Name is too short", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Player.Name = textBoxName.Text;
            if (textBoxPassword.Text.Length <= 3)
            {
                MessageBox.Show("Password is too short", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Player.Password = textBoxPassword.Text;
            if (comboBoxBalance.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a starting balance from the drop down list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Player.Balance = int.Parse((string)comboBoxBalance.SelectedItem);                       

            DialogResult = DialogResult.OK;
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
