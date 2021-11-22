
namespace CSC_317_Millionaire
{
    partial class ScoreEntryForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlayerScoreTitle = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayerNameTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnScoreEntryMainMenu = new System.Windows.Forms.Button();
            this.btnScoreEntryExitGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnEnterPlayerName = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerScoreTitle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerScore, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerNameTitle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnScoreEntryMainMenu, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnScoreEntryExitGame, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CSC_317_Millionaire.Properties.Resources.Millionaire_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlayerScoreTitle
            // 
            this.lblPlayerScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerScoreTitle.AutoSize = true;
            this.lblPlayerScoreTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreTitle.Location = new System.Drawing.Point(96, 248);
            this.lblPlayerScoreTitle.Name = "lblPlayerScoreTitle";
            this.lblPlayerScoreTitle.Size = new System.Drawing.Size(228, 35);
            this.lblPlayerScoreTitle.TabIndex = 1;
            this.lblPlayerScoreTitle.Text = "Your Score:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayerScore.Location = new System.Drawing.Point(464, 248);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(252, 35);
            this.lblPlayerScore.TabIndex = 2;
            this.lblPlayerScore.Text = "PlayerScore";
            // 
            // lblPlayerNameTitle
            // 
            this.lblPlayerNameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerNameTitle.AutoSize = true;
            this.lblPlayerNameTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameTitle.Location = new System.Drawing.Point(50, 330);
            this.lblPlayerNameTitle.Name = "lblPlayerNameTitle";
            this.lblPlayerNameTitle.Size = new System.Drawing.Size(319, 35);
            this.lblPlayerNameTitle.TabIndex = 3;
            this.lblPlayerNameTitle.Text = "Enter Your Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.txtPlayerName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEnterPlayerName, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 310);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 76);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnScoreEntryMainMenu
            // 
            this.btnScoreEntryMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnScoreEntryMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScoreEntryMainMenu.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreEntryMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScoreEntryMainMenu.Location = new System.Drawing.Point(23, 392);
            this.btnScoreEntryMainMenu.Name = "btnScoreEntryMainMenu";
            this.btnScoreEntryMainMenu.Size = new System.Drawing.Size(374, 35);
            this.btnScoreEntryMainMenu.TabIndex = 5;
            this.btnScoreEntryMainMenu.Text = "Main Menu";
            this.btnScoreEntryMainMenu.UseVisualStyleBackColor = false;
            this.btnScoreEntryMainMenu.Click += new System.EventHandler(this.btnScoreEntryMainMenu_Click);
            // 
            // btnScoreEntryExitGame
            // 
            this.btnScoreEntryExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnScoreEntryExitGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScoreEntryExitGame.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreEntryExitGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScoreEntryExitGame.Location = new System.Drawing.Point(403, 392);
            this.btnScoreEntryExitGame.Name = "btnScoreEntryExitGame";
            this.btnScoreEntryExitGame.Size = new System.Drawing.Size(374, 35);
            this.btnScoreEntryExitGame.TabIndex = 6;
            this.btnScoreEntryExitGame.Text = "Exit Game";
            this.btnScoreEntryExitGame.UseVisualStyleBackColor = false;
            this.btnScoreEntryExitGame.Click += new System.EventHandler(this.btnScoreEntryExitGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayerName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(3, 18);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(274, 39);
            this.txtPlayerName.TabIndex = 0;
            // 
            // btnEnterPlayerName
            // 
            this.btnEnterPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnterPlayerName.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPlayerName.Location = new System.Drawing.Point(283, 18);
            this.btnEnterPlayerName.Name = "btnEnterPlayerName";
            this.btnEnterPlayerName.Size = new System.Drawing.Size(88, 39);
            this.btnEnterPlayerName.TabIndex = 1;
            this.btnEnterPlayerName.Text = "Enter";
            this.btnEnterPlayerName.UseVisualStyleBackColor = true;
            this.btnEnterPlayerName.Click += new System.EventHandler(this.btnEnterPlayerName_Click);
            // 
            // ScoreEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScoreEntryForm";
            this.Text = "Leaderboard Entry";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlayerScoreTitle;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblPlayerNameTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnScoreEntryMainMenu;
        private System.Windows.Forms.Button btnScoreEntryExitGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnEnterPlayerName;
    }
}