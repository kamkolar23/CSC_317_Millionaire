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
    public partial class GameForm : Form
    {
        static Random choice = new Random();
        int num;
        int question = 0;
        int timeLeft = 60;
        int questionNum = 1;
        string score = "$0";

        List<int> tier1Choice = new List<int>();
        List<int> tier2Choice = new List<int>();
        List<int> tier3Choice = new List<int>();

        List<Questions> tier1Questions = new List<Questions>();
        List<Questions> tier2Questions = new List<Questions>();
        List<Questions> tier3Questions = new List<Questions>();

        public GameForm()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Tier1Questions.txt");

            for (int i = 0; i < 10; i++)
            {
                tier1Questions.Add(new Questions
                {
                    question = sr.ReadLine(),
                    answer1 = sr.ReadLine(),
                    answer2 = sr.ReadLine(),
                    answer3 = sr.ReadLine(),
                    answer4 = sr.ReadLine(),
                    correctAnswer = sr.ReadLine(),
                    hint = sr.ReadLine()
                });
            }

            sr.Close();

            StreamReader sr2 = new StreamReader("Tier2Questions.txt");

            for (int i = 0; i < 10; i++)
            {
                tier2Questions.Add(new Questions
                {
                    question = sr2.ReadLine(),
                    answer1 = sr2.ReadLine(),
                    answer2 = sr2.ReadLine(),
                    answer3 = sr2.ReadLine(),
                    answer4 = sr2.ReadLine(),
                    correctAnswer = sr2.ReadLine(),
                    hint = sr2.ReadLine()
                });
            }

            sr2.Close();

            StreamReader sr3 = new StreamReader("Tier3Questions.txt");

            for (int i = 0; i < 10; i++)
            {
                tier3Questions.Add(new Questions
                {
                    question = sr3.ReadLine(),
                    answer1 = sr3.ReadLine(),
                    answer2 = sr3.ReadLine(),
                    answer3 = sr3.ReadLine(),
                    answer4 = sr3.ReadLine(),
                    correctAnswer = sr3.ReadLine(),
                    hint = sr3.ReadLine()
                });
            }

            sr3.Close();

            for (int j = 0; j < 6; j++)
            {
                do
                {
                    num = choice.Next(10);
                }
                while (tier1Choice.Contains(num));

                tier1Choice.Add(num);
            }

            for (int j = 0; j < 6; j++)
            {
                do
                {
                    num = choice.Next(10);
                }
                while (tier2Choice.Contains(num));

                tier2Choice.Add(num);
            }

            for (int j = 0; j < 6; j++)
            {
                do
                {
                    num = choice.Next(10);
                }
                while (tier3Choice.Contains(num));

                tier3Choice.Add(num);
            }


            lblQuestionContents.Text = tier1Questions[tier1Choice[question]].question;
            btnAnswer1.Text = tier1Questions[tier1Choice[question]].answer1;
            btnAnswer2.Text = tier1Questions[tier1Choice[question]].answer2;
            btnAnswer3.Text = tier1Questions[tier1Choice[question]].answer3;
            btnAnswer4.Text = tier1Questions[tier1Choice[question]].answer4;

            DialogResult result = MessageBox.Show("Rules:\n" +
                "\n1) There are 15 questions to reach $1,000,000\n" +
                "\n2) Each question has a 60 second time limit\n" +
                "\n3) You can stop playing and keep your money after successfully answering any question\n" +
                "\n4) If you miss a question, your winnings will be reduced to:\n" +
                "\t+ $0 for missing a Tier 1 question ($5,000 and below)\n" +
                "\t+ $5,000 for missing a Tier 2 question ($32,000 and below)\n" +
                "\t+ $32,000 for missing a Tier 3 question ($1,000,000 and below)\n" +
                "\nEnjoy the game, and good luck!", "Rules", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                questionTimer.Start();
            }
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                if (timeLeft < 11)
                {
                    lblTimer.ForeColor = Color.Red;
                }
                timeLeft -= 1;
                lblTimer.Text = timeLeft.ToString();
            }
            else
            {
                questionTimer.Stop();

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(score);
                sw.Close();

                DialogResult result = MessageBox.Show("Times Up! Game Over!", "Game Over", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Form form = new ScoreEntryForm();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHintText.Visible = true;

            if (questionNum > 0 && questionNum < 6)
            {
                lblHintText.Text = tier1Questions[tier1Choice[question]].hint;
            }
            else if (questionNum > 5 && questionNum < 11)
            {
                lblHintText.Text = tier2Questions[tier2Choice[question]].hint;
            }
            else if (questionNum > 10 && questionNum < 16)
            {
                lblHintText.Text = tier3Questions[tier3Choice[question]].hint;
            }

            btnHint.Enabled = false;
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (tier1Questions[tier1Choice[question]].correctAnswer == btnAnswer1.Text ||
                tier2Questions[tier2Choice[question]].correctAnswer == btnAnswer1.Text ||
                tier3Questions[tier3Choice[question]].correctAnswer == btnAnswer1.Text)
            {
                questionTimer.Stop();
                lblHintText.Visible = false;
                btnHint.Visible = false;
                btn5050.Visible = false;
                btnKeepGoing.Visible = true;
                btnTakeMoney.Visible = true;

                switch (questionNum)
                {
                    case 1:
                        score = "$500";
                        break;
                    case 2:
                        score = "$1,000";
                        break;
                    case 3:
                        score = "$2,000";
                        break;
                    case 4:
                        score = "$3,000";
                        break;
                    case 5:
                        score = "$5,000";
                        break;
                    case 6:
                        score = "$7,500";
                        break;
                    case 7:
                        score = "$10,000";
                        break;
                    case 8:
                        score = "$15,000";
                        break;
                    case 9:
                        score = "$25,000";
                        break;
                    case 10:
                        score = "$50,000";
                        break;
                    case 11:
                        score = "$75,000";
                        break;
                    case 12:
                        score = "$150,000";
                        break;
                    case 13:
                        score = "$250,000";
                        break;
                    case 14:
                        score = "$500,000";
                        break;
                    case 15:
                        score = "$1,000,000";
                        break;
                }

                if (questionNum == 15)
                {
                    StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                    sw.WriteLine(score);
                    sw.Close();

                    DialogResult result = MessageBox.Show("You're a Millionaire!!\n\n" +
                        "Press OK to enter your name on the Leaderboard", "You Win!", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Form form = new ScoreEntryForm();
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { this.Show(); };
                        form.Show();
                        this.Hide();
                    }
                }

                lblQuestionNumTitle.Text = "Correct!";
                lblQuestionContents.Text = "Take the money or keep going?";
            }
            else
            {
                questionTimer.Stop();

                if (questionNum > 0 && questionNum < 6)
                {
                    score = "$0";
                }
                else if (questionNum > 5 && questionNum < 11)
                {
                    score = "$5,000";
                }
                else if (questionNum > 10 && questionNum < 16)
                {
                    score = "$32,000";
                }

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(score);
                sw.Close();

                DialogResult result = MessageBox.Show("Wrong Answer! Game Over!", "Game Over", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Form form = new ScoreEntryForm();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (tier1Questions[tier1Choice[question]].correctAnswer == btnAnswer2.Text ||
                tier2Questions[tier2Choice[question]].correctAnswer == btnAnswer2.Text ||
                tier3Questions[tier3Choice[question]].correctAnswer == btnAnswer2.Text)
            {
                questionTimer.Stop();
                lblHintText.Visible = false;
                btnHint.Visible = false;
                btn5050.Visible = false;
                btnKeepGoing.Visible = true;
                btnTakeMoney.Visible = true;
                switch (questionNum)
                {
                    case 1:
                        score = "$500";
                        break;
                    case 2:
                        score = "$1,000";
                        break;
                    case 3:
                        score = "$2,000";
                        break;
                    case 4:
                        score = "$3,000";
                        break;
                    case 5:
                        score = "$5,000";
                        break;
                    case 6:
                        score = "$7,500";
                        break;
                    case 7:
                        score = "$10,000";
                        break;
                    case 8:
                        score = "$15,000";
                        break;
                    case 9:
                        score = "$25,000";
                        break;
                    case 10:
                        score = "$50,000";
                        break;
                    case 11:
                        score = "$75,000";
                        break;
                    case 12:
                        score = "$150,000";
                        break;
                    case 13:
                        score = "$250,000";
                        break;
                    case 14:
                        score = "$500,000";
                        break;
                    case 15:
                        score = "$1,000,000";
                        break;
                }

                if (questionNum == 15)
                {
                    StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                    sw.WriteLine(score);
                    sw.Close();

                    DialogResult result = MessageBox.Show("You're a Millionaire!!\n\n" +
                        "Press OK to enter your name on the Leaderboard", "You Win!", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Form form = new ScoreEntryForm();
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { this.Show(); };
                        form.Show();
                        this.Hide();
                    }
                }

                lblQuestionNumTitle.Text = "Correct!";
                lblQuestionContents.Text = "Take the money or keep going?";
            }
            else
            {
                questionTimer.Stop();

                if (questionNum > 0 && questionNum < 6)
                {
                    score = "$0";
                }
                else if (questionNum > 5 && questionNum < 11)
                {
                    score = "$5,000";
                }
                else if (questionNum > 10 && questionNum < 16)
                {
                    score = "$32,000";
                }

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(score);
                sw.Close();

                DialogResult result = MessageBox.Show("Wrong Answer! Game Over!", "Game Over", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Form form = new ScoreEntryForm();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (tier1Questions[tier1Choice[question]].correctAnswer == btnAnswer3.Text ||
                tier2Questions[tier2Choice[question]].correctAnswer == btnAnswer3.Text ||
                tier3Questions[tier3Choice[question]].correctAnswer == btnAnswer3.Text)
            {
                questionTimer.Stop();
                lblHintText.Visible = false;
                btnHint.Visible = false;
                btn5050.Visible = false;
                btnKeepGoing.Visible = true;
                btnTakeMoney.Visible = true;

                switch (questionNum)
                {
                    case 1:
                        score = "$500";
                        break;
                    case 2:
                        score = "$1,000";
                        break;
                    case 3:
                        score = "$2,000";
                        break;
                    case 4:
                        score = "$3,000";
                        break;
                    case 5:
                        score = "$5,000";
                        break;
                    case 6:
                        score = "$7,500";
                        break;
                    case 7:
                        score = "$10,000";
                        break;
                    case 8:
                        score = "$15,000";
                        break;
                    case 9:
                        score = "$25,000";
                        break;
                    case 10:
                        score = "$50,000";
                        break;
                    case 11:
                        score = "$75,000";
                        break;
                    case 12:
                        score = "$150,000";
                        break;
                    case 13:
                        score = "$250,000";
                        break;
                    case 14:
                        score = "$500,000";
                        break;
                    case 15:
                        score = "$1,000,000";
                        break;
                }

                if (questionNum == 15)
                {
                    StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                    sw.WriteLine(score);
                    sw.Close();

                    DialogResult result = MessageBox.Show("You're a Millionaire!!\n\n" +
                        "Press OK to enter your name on the Leaderboard", "You Win!", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Form form = new ScoreEntryForm();
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { this.Show(); };
                        form.Show();
                        this.Hide();
                    }
                }

                lblQuestionNumTitle.Text = "Correct!";
                lblQuestionContents.Text = "Take the money or keep going?";
            }
            else
            {
                questionTimer.Stop();

                if (questionNum > 0 && questionNum < 6)
                {
                    score = "$0";
                }
                else if (questionNum > 5 && questionNum < 11)
                {
                    score = "$5,000";
                }
                else if (questionNum > 10 && questionNum < 16)
                {
                    score = "$32,000";
                }

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(score);
                sw.Close();

                DialogResult result = MessageBox.Show("Wrong Answer! Game Over!", "Game Over", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Form form = new ScoreEntryForm();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (tier1Questions[tier1Choice[question]].correctAnswer == btnAnswer4.Text ||
                tier2Questions[tier2Choice[question]].correctAnswer == btnAnswer4.Text ||
                tier3Questions[tier3Choice[question]].correctAnswer == btnAnswer4.Text)
            {
                questionTimer.Stop();
                lblHintText.Visible = false;
                btnHint.Visible = false;
                btn5050.Visible = false;
                btnKeepGoing.Visible = true;
                btnTakeMoney.Visible = true;

                switch (questionNum)
                {
                    case 1:
                        score = "$500";
                        break;
                    case 2:
                        score = "$1,000";
                        break;
                    case 3:
                        score = "$2,000";
                        break;
                    case 4:
                        score = "$3,000";
                        break;
                    case 5:
                        score = "$5,000";
                        break;
                    case 6:
                        score = "$7,500";
                        break;
                    case 7:
                        score = "$10,000";
                        break;
                    case 8:
                        score = "$15,000";
                        break;
                    case 9:
                        score = "$25,000";
                        break;
                    case 10:
                        score = "$50,000";
                        break;
                    case 11:
                        score = "$75,000";
                        break;
                    case 12:
                        score = "$150,000";
                        break;
                    case 13:
                        score = "$250,000";
                        break;
                    case 14:
                        score = "$500,000";
                        break;
                    case 15:
                        score = "$1,000,000";
                        break;
                }

                if (questionNum == 15)
                {
                    StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                    sw.WriteLine(score);
                    sw.Close();

                    DialogResult result = MessageBox.Show("You're a Millionaire!!\n\n" +
                        "Press OK to enter your name on the Leaderboard", "You Win!", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Form form = new ScoreEntryForm();
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { this.Show(); };
                        form.Show();
                        this.Hide();
                    }
                }

                lblQuestionNumTitle.Text = "Correct!";
                lblQuestionContents.Text = "Take the money or keep going?";
            }
            else
            {
                questionTimer.Stop();

                if (questionNum > 0 && questionNum < 6)
                {
                    score = "$0";
                }
                else if (questionNum > 5 && questionNum < 11)
                {
                    score = "$5,000";
                }
                else if (questionNum > 10 && questionNum < 16)
                {
                    score = "$32,000";
                }

                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(score);
                sw.Close();

                DialogResult result = MessageBox.Show("Wrong Answer! Game Over!", "Game Over", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Form form = new ScoreEntryForm();
                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.Manual;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnKeepGoing_Click(object sender, EventArgs e)
        {
            question++;

            if (question > 4)
            {
                question = 0;
            }

            timeLeft = 60;
            questionTimer.Start();
            questionNum++;
            btn5050.Visible = true;
            btnHint.Visible = true;
            btnKeepGoing.Visible = false;
            btnTakeMoney.Visible = false;
            btnAnswer1.Visible = true;
            btnAnswer2.Visible = true;
            btnAnswer3.Visible = true;
            btnAnswer4.Visible = true;

            lblQuestionNumTitle.Text = "Question " + questionNum;

            if (questionNum > 0 && questionNum < 6)
            {
                lblQuestionContents.Text = tier1Questions[tier1Choice[question]].question;
                btnAnswer1.Text = tier1Questions[tier1Choice[question]].answer1;
                btnAnswer2.Text = tier1Questions[tier1Choice[question]].answer2;
                btnAnswer3.Text = tier1Questions[tier1Choice[question]].answer3;
                btnAnswer4.Text = tier1Questions[tier1Choice[question]].answer4;
            }
            else if (questionNum > 5 && questionNum < 11)
            {
                lblQuestionContents.Text = tier2Questions[tier2Choice[question]].question;
                btnAnswer1.Text = tier2Questions[tier2Choice[question]].answer1;
                btnAnswer2.Text = tier2Questions[tier2Choice[question]].answer2;
                btnAnswer3.Text = tier2Questions[tier2Choice[question]].answer3;
                btnAnswer4.Text = tier2Questions[tier2Choice[question]].answer4;
            }
            else if (questionNum > 10 && questionNum < 16)
            {
                lblQuestionContents.Text = tier3Questions[tier3Choice[question]].question;
                btnAnswer1.Text = tier3Questions[tier3Choice[question]].answer1;
                btnAnswer2.Text = tier3Questions[tier3Choice[question]].answer2;
                btnAnswer3.Text = tier3Questions[tier3Choice[question]].answer3;
                btnAnswer4.Text = tier3Questions[tier3Choice[question]].answer4;
            }

            switch (questionNum)
            {
                case 2:
                    lbl500.BorderStyle = BorderStyle.None;
                    lbl1000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 3:
                    lbl1000.BorderStyle = BorderStyle.None;
                    lbl2000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 4:
                    lbl2000.BorderStyle = BorderStyle.None;
                    lbl3000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 5:
                    lbl3000.BorderStyle = BorderStyle.None;
                    lbl5000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 6:
                    lbl5000.BorderStyle = BorderStyle.None;
                    lbl7500.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 7:
                    lbl7500.BorderStyle = BorderStyle.None;
                    lbl10000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 8:
                    lbl10000.BorderStyle = BorderStyle.None;
                    lbl15000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 9:
                    lbl15000.BorderStyle = BorderStyle.None;
                    lbl25000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 10:
                    lbl25000.BorderStyle = BorderStyle.None;
                    lbl50000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 11:
                    lbl50000.BorderStyle = BorderStyle.None;
                    lbl75000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 12:
                    lbl75000.BorderStyle = BorderStyle.None;
                    lbl150000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 13:
                    lbl150000.BorderStyle = BorderStyle.None;
                    lbl250000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 14:
                    lbl250000.BorderStyle = BorderStyle.None;
                    lbl500000.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case 15:
                    lbl500000.BorderStyle = BorderStyle.None;
                    lbl1000000.BorderStyle = BorderStyle.Fixed3D;
                    break;

            }
        }

        private void btnTakeMoney_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
            sw.WriteLine(score);
            sw.Close();

            Form form = new ScoreEntryForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            if (questionNum > 0 && questionNum < 6)
            {
                if (tier1Questions[tier1Choice[question]].correctAnswer == "Blue")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer3.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "360")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer3.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Silk")
                {
                    btnAnswer4.Visible = false;
                    btnAnswer3.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Gryffindor")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Brown")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Spinach")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Abraham Lincoln")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Pegasus")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "J.R.R. Tolkien")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier1Questions[tier1Choice[question]].correctAnswer == "Yellowstone")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
            }
            else if (questionNum > 5 && questionNum < 11)
            {
                if (tier2Questions[tier2Choice[question]].correctAnswer == "Book")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "Vatican City")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "4")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "The Lone Star State")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "New York")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "Pacific Ocean")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "Paris")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer1.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "32")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "100")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer1.Visible = false;
                }
                else if (tier2Questions[tier2Choice[question]].correctAnswer == "Michelangelo")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
            }
            else if (questionNum > 10 && questionNum < 16)
            {
                if (tier3Questions[tier3Choice[question]].correctAnswer == "24")
                {
                    btnAnswer4.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Venus")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Red Meat")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Three Gorges Dam")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Coffee")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Beagle")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Aphrodite")
                {
                    btnAnswer2.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Balearic Islands")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer2.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Morocco")
                {
                    btnAnswer3.Visible = false;
                    btnAnswer4.Visible = false;
                }
                else if (tier3Questions[tier3Choice[question]].correctAnswer == "Thistle")
                {
                    btnAnswer1.Visible = false;
                    btnAnswer2.Visible = false;
                }
            }

            btn5050.Enabled = false;
        }
    }
}
