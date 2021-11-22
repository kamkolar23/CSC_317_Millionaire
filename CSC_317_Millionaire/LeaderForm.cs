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
    public partial class LeaderForm : Form
    {
        public LeaderForm()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("Leaderboard.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
            File.WriteAllLines("Leaderboard.txt", lines);

            List<string> scores = new List<string>();
            List<string> names = new List<string>();

            StreamReader sr = new StreamReader("Leaderboard.txt");

            while (!sr.EndOfStream)
            {
                scores.Add(sr.ReadLine());
                names.Add(sr.ReadLine());
            }

            sr.Close();

            for (int i = 0; i < scores.Count; i++)
            {
                if (String.Equals(scores[i], lblScore5.Text))
                {
                    lblScore5.Text = scores[i];
                    lblScore5Name.Text = names[i];
                }
                else if (String.Equals(scores[i], lblScore4.Text))
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = scores[i];
                    lblScore4Name.Text = names[i];
                }
                else if (String.Equals(scores[i], lblScore3.Text))
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = scores[i];
                    lblScore3Name.Text = names[i];
                }
                else if (String.Equals(scores[i], lblScore2.Text))
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = lblScore2.Text;
                    lblScore3Name.Text = lblScore2Name.Text;
                    lblScore2.Text = scores[i];
                    lblScore2Name.Text = names[i];
                }
                else if (String.Equals(scores[i], lblHighScore.Text))
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = lblScore2.Text;
                    lblScore3Name.Text = lblScore2Name.Text;
                    lblScore2.Text = lblHighScore.Text;
                    lblScore2Name.Text = lblHighScoreName.Text;
                    lblHighScore.Text = scores[i];
                    lblHighScoreName.Text = names[i];
                }

                if (String.Compare(scores[i], lblScore5.Text) > 0 &&
                    String.Compare(scores[i], lblScore4.Text) < 0)
                {
                    lblScore5.Text = scores[i];
                    lblScore5Name.Text = names[i];
                }
                else if (String.Compare(scores[i], lblScore4.Text) > 0 &&
                    String.Compare(scores[i], lblScore3.Text) < 0)
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = scores[i];
                    lblScore4Name.Text = names[i];
                }
                else if (String.Compare(scores[i], lblScore3.Text) > 0 &&
                    String.Compare(scores[i], lblScore2.Text) < 0)
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = scores[i];
                    lblScore3Name.Text = names[i];
                }
                else if (String.Compare(scores[i], lblScore2.Text) > 0 &&
                    String.Compare(scores[i], lblHighScore.Text) < 0)
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = lblScore2.Text;
                    lblScore3Name.Text = lblScore2Name.Text;
                    lblScore2.Text = scores[i];
                    lblScore2Name.Text = names[i];
                }
                else if (String.Compare(scores[i], lblHighScore.Text) > 0)
                {
                    lblScore5.Text = lblScore4.Text;
                    lblScore5Name.Text = lblScore4Name.Text;
                    lblScore4.Text = lblScore3.Text;
                    lblScore4Name.Text = lblScore3Name.Text;
                    lblScore3.Text = lblScore2.Text;
                    lblScore3Name.Text = lblScore2Name.Text;
                    lblScore2.Text = lblHighScore.Text;
                    lblScore2Name.Text = lblHighScoreName.Text;
                    lblHighScore.Text = scores[i];
                    lblHighScoreName.Text = names[i];
                }
            }

            /*
             * const int currentPlayerLines = 2;
            var lines = new List<String>();

            foreach (var line in File.ReadLines("Leaderboard.txt"))
            {
                lines.Add(line);
                if (lines.Count > currentPlayerLines)
                {
                    lines.RemoveAt(0);
                }
            }

            if (String.Equals(lines[0], lblScore4.Text))
            {
                lblScore5.Text = lines[0];
                lblScore5Name.Text = lines[1];
            }
            else if (String.Equals(lines[0], lblScore3.Text))
            {
                lblScore4.Text = lines[0];
                lblScore4Name.Text = lines[1];
            }
            else if (String.Equals(lines[0], lblScore2.Text))
            {
                lblScore3.Text = lines[0];
                lblScore3Name.Text = lines[1];
            }
            else if (String.Equals(lines[0], lblHighScore.Text))
            {
                lblScore2.Text = lines[0];
                lblScore2Name.Text = lines[1];
            }

            if (String.Compare(lines[0], lblScore5.Text) > 0 &&
                String.Compare(lines[0], lblScore4.Text) < 0)
            {
                lblScore5.Text = lines[0];
                lblScore5Name.Text = lines[1];
            }
            else if (String.Compare(lines[0], lblScore4.Text) > 0 &&
                String.Compare(lines[0], lblScore3.Text) < 0)
            {
                lblScore4.Text = lines[0];
                lblScore4Name.Text = lines[1];
            }
            else if (String.Compare(lines[0], lblScore3.Text) > 0 &&
                String.Compare(lines[0], lblScore2.Text) < 0)
            {
                lblScore3.Text = lines[0];
                lblScore3Name.Text = lines[1];
            }
            else if (String.Compare(lines[0], lblScore2.Text) > 0 &&
                String.Compare(lines[0], lblHighScore.Text) < 0 )
            {
                lblScore2.Text = lines[0];
                lblScore2Name.Text = lines[1];
            }
            else if (String.Compare(lines[0], lblHighScore.Text) > 0)
            {
                lblHighScore.Text = lines[0];
                lblHighScoreName.Text = lines[1];
            }
            */
        }

        private void btnLeaderMainMenu_Click(object sender, EventArgs e)
        {
            Form form = new MenuForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void btnLeaderExitGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
