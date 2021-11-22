
namespace CSC_317_Millionaire
{
    partial class LeaderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLeaderboardTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHighScoreTitle = new System.Windows.Forms.Label();
            this.lblScore2Title = new System.Windows.Forms.Label();
            this.lblScore3Title = new System.Windows.Forms.Label();
            this.lblScore4Title = new System.Windows.Forms.Label();
            this.lblScore5Title = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblScore4 = new System.Windows.Forms.Label();
            this.lblScore5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHighScoreName = new System.Windows.Forms.Label();
            this.lblScore2Name = new System.Windows.Forms.Label();
            this.lblScore3Name = new System.Windows.Forms.Label();
            this.lblScore4Name = new System.Windows.Forms.Label();
            this.lblScore5Name = new System.Windows.Forms.Label();
            this.btnLeaderMainMenu = new System.Windows.Forms.Button();
            this.btnLeaderExitGame = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblLeaderboardTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLeaderboardTitle
            // 
            this.lblLeaderboardTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeaderboardTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblLeaderboardTitle, 3);
            this.lblLeaderboardTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLeaderboardTitle.Location = new System.Drawing.Point(206, 44);
            this.lblLeaderboardTitle.Name = "lblLeaderboardTitle";
            this.lblLeaderboardTitle.Size = new System.Drawing.Size(386, 53);
            this.lblLeaderboardTitle.TabIndex = 0;
            this.lblLeaderboardTitle.Text = "Leaderboard";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblHighScoreTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblScore2Title, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblScore3Title, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblScore4Title, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblScore5Title, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnLeaderMainMenu, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 301);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblHighScore, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblScore2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblScore3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblScore4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblScore5, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(276, 125);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 301);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblHighScoreTitle
            // 
            this.lblHighScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHighScoreTitle.AutoSize = true;
            this.lblHighScoreTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreTitle.Location = new System.Drawing.Point(44, 10);
            this.lblHighScoreTitle.Name = "lblHighScoreTitle";
            this.lblHighScoreTitle.Size = new System.Drawing.Size(200, 31);
            this.lblHighScoreTitle.TabIndex = 0;
            this.lblHighScoreTitle.Text = "High Score:";
            // 
            // lblScore2Title
            // 
            this.lblScore2Title.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScore2Title.AutoSize = true;
            this.lblScore2Title.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2Title.Location = new System.Drawing.Point(94, 62);
            this.lblScore2Title.Name = "lblScore2Title";
            this.lblScore2Title.Size = new System.Drawing.Size(150, 31);
            this.lblScore2Title.TabIndex = 1;
            this.lblScore2Title.Text = "Score 2:";
            // 
            // lblScore3Title
            // 
            this.lblScore3Title.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScore3Title.AutoSize = true;
            this.lblScore3Title.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore3Title.Location = new System.Drawing.Point(94, 114);
            this.lblScore3Title.Name = "lblScore3Title";
            this.lblScore3Title.Size = new System.Drawing.Size(150, 31);
            this.lblScore3Title.TabIndex = 2;
            this.lblScore3Title.Text = "Score 3:";
            // 
            // lblScore4Title
            // 
            this.lblScore4Title.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScore4Title.AutoSize = true;
            this.lblScore4Title.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore4Title.Location = new System.Drawing.Point(94, 166);
            this.lblScore4Title.Name = "lblScore4Title";
            this.lblScore4Title.Size = new System.Drawing.Size(150, 31);
            this.lblScore4Title.TabIndex = 3;
            this.lblScore4Title.Text = "Score 4:";
            // 
            // lblScore5Title
            // 
            this.lblScore5Title.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblScore5Title.AutoSize = true;
            this.lblScore5Title.Font = new System.Drawing.Font("Copperplate Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore5Title.Location = new System.Drawing.Point(94, 218);
            this.lblScore5Title.Name = "lblScore5Title";
            this.lblScore5Title.Size = new System.Drawing.Size(150, 31);
            this.lblScore5Title.TabIndex = 4;
            this.lblScore5Title.Text = "Score 5:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHighScore.Location = new System.Drawing.Point(53, 8);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(140, 35);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "$5,000";
            // 
            // lblScore2
            // 
            this.lblScore2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScore2.Location = new System.Drawing.Point(53, 60);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(140, 35);
            this.lblScore2.TabIndex = 1;
            this.lblScore2.Text = "$3,000";
            // 
            // lblScore3
            // 
            this.lblScore3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore3.AutoSize = true;
            this.lblScore3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScore3.Location = new System.Drawing.Point(53, 112);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(140, 35);
            this.lblScore3.TabIndex = 2;
            this.lblScore3.Text = "$2,000";
            // 
            // lblScore4
            // 
            this.lblScore4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore4.AutoSize = true;
            this.lblScore4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScore4.Location = new System.Drawing.Point(53, 164);
            this.lblScore4.Name = "lblScore4";
            this.lblScore4.Size = new System.Drawing.Size(140, 35);
            this.lblScore4.TabIndex = 3;
            this.lblScore4.Text = "$1,000";
            // 
            // lblScore5
            // 
            this.lblScore5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore5.AutoSize = true;
            this.lblScore5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScore5.Location = new System.Drawing.Point(70, 216);
            this.lblScore5.Name = "lblScore5";
            this.lblScore5.Size = new System.Drawing.Size(107, 35);
            this.lblScore5.TabIndex = 4;
            this.lblScore5.Text = "$500";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblHighScoreName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblScore2Name, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblScore3Name, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblScore4Name, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblScore5Name, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnLeaderExitGame, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(529, 125);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 301);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblHighScoreName
            // 
            this.lblHighScoreName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHighScoreName.AutoSize = true;
            this.lblHighScoreName.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreName.Location = new System.Drawing.Point(3, 13);
            this.lblHighScoreName.Name = "lblHighScoreName";
            this.lblHighScoreName.Size = new System.Drawing.Size(182, 26);
            this.lblHighScoreName.TabIndex = 0;
            this.lblHighScoreName.Text = "Susan Bones";
            // 
            // lblScore2Name
            // 
            this.lblScore2Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore2Name.AutoSize = true;
            this.lblScore2Name.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2Name.Location = new System.Drawing.Point(3, 65);
            this.lblScore2Name.Name = "lblScore2Name";
            this.lblScore2Name.Size = new System.Drawing.Size(121, 26);
            this.lblScore2Name.TabIndex = 1;
            this.lblScore2Name.Text = "Henry E.";
            // 
            // lblScore3Name
            // 
            this.lblScore3Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore3Name.AutoSize = true;
            this.lblScore3Name.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore3Name.Location = new System.Drawing.Point(3, 117);
            this.lblScore3Name.Name = "lblScore3Name";
            this.lblScore3Name.Size = new System.Drawing.Size(77, 26);
            this.lblScore3Name.TabIndex = 2;
            this.lblScore3Name.Text = "Mary";
            // 
            // lblScore4Name
            // 
            this.lblScore4Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore4Name.AutoSize = true;
            this.lblScore4Name.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore4Name.Location = new System.Drawing.Point(3, 169);
            this.lblScore4Name.Name = "lblScore4Name";
            this.lblScore4Name.Size = new System.Drawing.Size(160, 26);
            this.lblScore4Name.TabIndex = 3;
            this.lblScore4Name.Text = "l4meg4m3r";
            // 
            // lblScore5Name
            // 
            this.lblScore5Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore5Name.AutoSize = true;
            this.lblScore5Name.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore5Name.Location = new System.Drawing.Point(3, 221);
            this.lblScore5Name.Name = "lblScore5Name";
            this.lblScore5Name.Size = new System.Drawing.Size(155, 26);
            this.lblScore5Name.TabIndex = 4;
            this.lblScore5Name.Text = "John Smith";
            // 
            // btnLeaderMainMenu
            // 
            this.btnLeaderMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLeaderMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaderMainMenu.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderMainMenu.Location = new System.Drawing.Point(3, 263);
            this.btnLeaderMainMenu.Name = "btnLeaderMainMenu";
            this.btnLeaderMainMenu.Size = new System.Drawing.Size(241, 35);
            this.btnLeaderMainMenu.TabIndex = 5;
            this.btnLeaderMainMenu.Text = "Main Menu";
            this.btnLeaderMainMenu.UseVisualStyleBackColor = false;
            this.btnLeaderMainMenu.Click += new System.EventHandler(this.btnLeaderMainMenu_Click);
            // 
            // btnLeaderExitGame
            // 
            this.btnLeaderExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLeaderExitGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeaderExitGame.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderExitGame.Location = new System.Drawing.Point(3, 263);
            this.btnLeaderExitGame.Name = "btnLeaderExitGame";
            this.btnLeaderExitGame.Size = new System.Drawing.Size(241, 35);
            this.btnLeaderExitGame.TabIndex = 5;
            this.btnLeaderExitGame.Text = "Exit Game";
            this.btnLeaderExitGame.UseVisualStyleBackColor = false;
            this.btnLeaderExitGame.Click += new System.EventHandler(this.btnLeaderExitGame_Click);
            // 
            // LeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LeaderForm";
            this.Text = "Leaderboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLeaderboardTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblHighScoreTitle;
        private System.Windows.Forms.Label lblScore2Title;
        private System.Windows.Forms.Label lblScore3Title;
        private System.Windows.Forms.Label lblScore4Title;
        private System.Windows.Forms.Label lblScore5Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblScore4;
        private System.Windows.Forms.Label lblScore5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblHighScoreName;
        private System.Windows.Forms.Label lblScore2Name;
        private System.Windows.Forms.Label lblScore3Name;
        private System.Windows.Forms.Label lblScore4Name;
        private System.Windows.Forms.Label lblScore5Name;
        private System.Windows.Forms.Button btnLeaderMainMenu;
        private System.Windows.Forms.Button btnLeaderExitGame;
    }
}