using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_317_Millionaire
{
    public partial class ScoreEntryForm : Form
    {
        public ScoreEntryForm()
        {
            InitializeComponent();

            lblPlayerScore.Text = File.ReadLines("Leaderboard.txt").Last();
        }

        private void btnScoreEntryMainMenu_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                string playerName = "anonymous";

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(playerName);
                sw.Close();
            }

            Form form = new MenuForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void btnScoreEntryExitGame_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                string playerName = "anonymous";

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(playerName);
                sw.Close();
            }

            System.Windows.Forms.Application.Exit();
        }

        private void btnEnterPlayerName_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                string playerName = "anonymous";

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(playerName);
                sw.Close();
            }
            else
            {
                string playerName = txtPlayerName.Text;
                txtPlayerName.Text = "";

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(playerName);
                sw.Close();
            }
        }
    }
}
