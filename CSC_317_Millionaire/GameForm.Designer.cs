
namespace CSC_317_Millionaire
{
    partial class GameForm
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
            this.tblGameBG = new System.Windows.Forms.TableLayoutPanel();
            this.tblGameMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestionContents = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTakeMoney = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btn5050 = new System.Windows.Forms.Button();
            this.btnKeepGoing = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblHintText = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQuestionNumTitle = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.lbl1000000 = new System.Windows.Forms.Label();
            this.lbl500000 = new System.Windows.Forms.Label();
            this.lbl250000 = new System.Windows.Forms.Label();
            this.lbl150000 = new System.Windows.Forms.Label();
            this.lbl75000 = new System.Windows.Forms.Label();
            this.lbl50000 = new System.Windows.Forms.Label();
            this.lbl25000 = new System.Windows.Forms.Label();
            this.lbl15000 = new System.Windows.Forms.Label();
            this.lbl10000 = new System.Windows.Forms.Label();
            this.lbl7500 = new System.Windows.Forms.Label();
            this.lbl5000 = new System.Windows.Forms.Label();
            this.lbl3000 = new System.Windows.Forms.Label();
            this.lbl2000 = new System.Windows.Forms.Label();
            this.lbl1000 = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.tblGameBG.SuspendLayout();
            this.tblGameMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblGameBG
            // 
            this.tblGameBG.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tblGameBG.ColumnCount = 4;
            this.tblGameBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblGameBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblGameBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblGameBG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblGameBG.Controls.Add(this.tblGameMain, 1, 1);
            this.tblGameBG.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tblGameBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGameBG.Location = new System.Drawing.Point(0, 0);
            this.tblGameBG.Name = "tblGameBG";
            this.tblGameBG.RowCount = 3;
            this.tblGameBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblGameBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGameBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblGameBG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGameBG.Size = new System.Drawing.Size(838, 441);
            this.tblGameBG.TabIndex = 0;
            // 
            // tblGameMain
            // 
            this.tblGameMain.ColumnCount = 1;
            this.tblGameMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGameMain.Controls.Add(this.lblQuestionContents, 0, 1);
            this.tblGameMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblGameMain.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tblGameMain.Controls.Add(this.lblHintText, 0, 3);
            this.tblGameMain.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tblGameMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGameMain.Location = new System.Drawing.Point(13, 13);
            this.tblGameMain.Name = "tblGameMain";
            this.tblGameMain.RowCount = 5;
            this.tblGameMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblGameMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGameMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblGameMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblGameMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblGameMain.Size = new System.Drawing.Size(607, 415);
            this.tblGameMain.TabIndex = 0;
            // 
            // lblQuestionContents
            // 
            this.lblQuestionContents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestionContents.AutoSize = true;
            this.lblQuestionContents.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionContents.Location = new System.Drawing.Point(147, 68);
            this.lblQuestionContents.Name = "lblQuestionContents";
            this.lblQuestionContents.Size = new System.Drawing.Size(312, 29);
            this.lblQuestionContents.TabIndex = 1;
            this.lblQuestionContents.Text = "This is the text for Question 1?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnTakeMoney, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnHint, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn5050, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKeepGoing, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnTakeMoney
            // 
            this.btnTakeMoney.BackColor = System.Drawing.Color.Firebrick;
            this.btnTakeMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeMoney.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeMoney.Location = new System.Drawing.Point(3, 3);
            this.btnTakeMoney.Name = "btnTakeMoney";
            this.btnTakeMoney.Size = new System.Drawing.Size(144, 29);
            this.btnTakeMoney.TabIndex = 0;
            this.btnTakeMoney.Text = "Take the Money...";
            this.btnTakeMoney.UseVisualStyleBackColor = false;
            this.btnTakeMoney.Visible = false;
            this.btnTakeMoney.Click += new System.EventHandler(this.btnTakeMoney_Click);
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.Indigo;
            this.btnHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHint.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(153, 3);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(144, 29);
            this.btnHint.TabIndex = 1;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btn5050
            // 
            this.btn5050.BackColor = System.Drawing.Color.Indigo;
            this.btn5050.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5050.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5050.ForeColor = System.Drawing.Color.White;
            this.btn5050.Location = new System.Drawing.Point(303, 3);
            this.btn5050.Name = "btn5050";
            this.btn5050.Size = new System.Drawing.Size(144, 29);
            this.btn5050.TabIndex = 2;
            this.btn5050.Text = "50 / 50";
            this.btn5050.UseVisualStyleBackColor = false;
            this.btn5050.Click += new System.EventHandler(this.btn5050_Click);
            // 
            // btnKeepGoing
            // 
            this.btnKeepGoing.BackColor = System.Drawing.Color.OliveDrab;
            this.btnKeepGoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKeepGoing.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeepGoing.Location = new System.Drawing.Point(453, 3);
            this.btnKeepGoing.Name = "btnKeepGoing";
            this.btnKeepGoing.Size = new System.Drawing.Size(145, 29);
            this.btnKeepGoing.TabIndex = 3;
            this.btnKeepGoing.Text = "Keep Going!";
            this.btnKeepGoing.UseVisualStyleBackColor = false;
            this.btnKeepGoing.Visible = false;
            this.btnKeepGoing.Click += new System.EventHandler(this.btnKeepGoing_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAnswer1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAnswer2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAnswer3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAnswer4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 251);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 161);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnswer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnswer1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(3, 3);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(294, 74);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "Answer 1 Text";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnswer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnswer2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(303, 3);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(295, 74);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.Text = "Answer 2 Text";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnswer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnswer3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(3, 83);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(294, 75);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Text = "Answer 3 Text";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnswer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnswer4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(303, 83);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(295, 75);
            this.btnAnswer4.TabIndex = 3;
            this.btnAnswer4.Text = "Answer 4 Text";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // lblHintText
            // 
            this.lblHintText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHintText.AutoSize = true;
            this.lblHintText.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintText.Location = new System.Drawing.Point(169, 192);
            this.lblHintText.Name = "lblHintText";
            this.lblHintText.Size = new System.Drawing.Size(269, 29);
            this.lblHintText.TabIndex = 4;
            this.lblHintText.Text = "This is the text for a hint...";
            this.lblHintText.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblQuestionNumTitle, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTimer, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(601, 35);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lblQuestionNumTitle
            // 
            this.lblQuestionNumTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestionNumTitle.AutoSize = true;
            this.lblQuestionNumTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblQuestionNumTitle.Location = new System.Drawing.Point(75, 0);
            this.lblQuestionNumTitle.Name = "lblQuestionNumTitle";
            this.lblQuestionNumTitle.Padding = new System.Windows.Forms.Padding(120, 0, 0, 0);
            this.lblQuestionNumTitle.Size = new System.Drawing.Size(330, 35);
            this.lblQuestionNumTitle.TabIndex = 0;
            this.lblQuestionNumTitle.Text = "Question 1";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(515, 2);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(51, 30);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "60";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblCurrentMoney, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl1000000, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl500000, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl250000, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl150000, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl75000, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl50000, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl25000, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lbl15000, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.lbl10000, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.lbl7500, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.lbl5000, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.lbl3000, 0, 12);
            this.tableLayoutPanel3.Controls.Add(this.lbl2000, 0, 13);
            this.tableLayoutPanel3.Controls.Add(this.lbl1000, 0, 14);
            this.tableLayoutPanel3.Controls.Add(this.lbl500, 0, 15);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(626, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(198, 415);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMoney.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentMoney.Location = new System.Drawing.Point(15, 2);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(167, 21);
            this.lblCurrentMoney.TabIndex = 0;
            this.lblCurrentMoney.Text = "Current Level";
            // 
            // lbl1000000
            // 
            this.lbl1000000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1000000.AutoSize = true;
            this.lbl1000000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1000000.ForeColor = System.Drawing.Color.White;
            this.lbl1000000.Location = new System.Drawing.Point(27, 28);
            this.lbl1000000.Name = "lbl1000000";
            this.lbl1000000.Size = new System.Drawing.Size(144, 18);
            this.lbl1000000.TabIndex = 1;
            this.lbl1000000.Text = "15    $1,000,000";
            // 
            // lbl500000
            // 
            this.lbl500000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl500000.AutoSize = true;
            this.lbl500000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl500000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl500000.Location = new System.Drawing.Point(35, 53);
            this.lbl500000.Name = "lbl500000";
            this.lbl500000.Size = new System.Drawing.Size(128, 18);
            this.lbl500000.TabIndex = 2;
            this.lbl500000.Text = "14    $500,000";
            // 
            // lbl250000
            // 
            this.lbl250000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl250000.AutoSize = true;
            this.lbl250000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl250000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl250000.Location = new System.Drawing.Point(35, 78);
            this.lbl250000.Name = "lbl250000";
            this.lbl250000.Size = new System.Drawing.Size(128, 18);
            this.lbl250000.TabIndex = 3;
            this.lbl250000.Text = "13    $250,000";
            // 
            // lbl150000
            // 
            this.lbl150000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl150000.AutoSize = true;
            this.lbl150000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl150000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl150000.Location = new System.Drawing.Point(35, 103);
            this.lbl150000.Name = "lbl150000";
            this.lbl150000.Size = new System.Drawing.Size(128, 18);
            this.lbl150000.TabIndex = 4;
            this.lbl150000.Text = "12    $150,000";
            // 
            // lbl75000
            // 
            this.lbl75000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl75000.AutoSize = true;
            this.lbl75000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl75000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl75000.Location = new System.Drawing.Point(40, 128);
            this.lbl75000.Name = "lbl75000";
            this.lbl75000.Size = new System.Drawing.Size(117, 18);
            this.lbl75000.TabIndex = 5;
            this.lbl75000.Text = "11    $75,000";
            // 
            // lbl50000
            // 
            this.lbl50000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl50000.AutoSize = true;
            this.lbl50000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50000.ForeColor = System.Drawing.Color.White;
            this.lbl50000.Location = new System.Drawing.Point(40, 153);
            this.lbl50000.Name = "lbl50000";
            this.lbl50000.Size = new System.Drawing.Size(117, 18);
            this.lbl50000.TabIndex = 6;
            this.lbl50000.Text = "10    $50,000";
            // 
            // lbl25000
            // 
            this.lbl25000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl25000.AutoSize = true;
            this.lbl25000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl25000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl25000.Location = new System.Drawing.Point(46, 178);
            this.lbl25000.Name = "lbl25000";
            this.lbl25000.Size = new System.Drawing.Size(106, 18);
            this.lbl25000.TabIndex = 7;
            this.lbl25000.Text = "9    $25,000";
            // 
            // lbl15000
            // 
            this.lbl15000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl15000.AutoSize = true;
            this.lbl15000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl15000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl15000.Location = new System.Drawing.Point(46, 203);
            this.lbl15000.Name = "lbl15000";
            this.lbl15000.Size = new System.Drawing.Size(106, 18);
            this.lbl15000.TabIndex = 8;
            this.lbl15000.Text = "8    $15,000";
            // 
            // lbl10000
            // 
            this.lbl10000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl10000.AutoSize = true;
            this.lbl10000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl10000.Location = new System.Drawing.Point(46, 228);
            this.lbl10000.Name = "lbl10000";
            this.lbl10000.Size = new System.Drawing.Size(106, 18);
            this.lbl10000.TabIndex = 9;
            this.lbl10000.Text = "7    $10,000";
            // 
            // lbl7500
            // 
            this.lbl7500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl7500.AutoSize = true;
            this.lbl7500.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7500.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl7500.Location = new System.Drawing.Point(51, 253);
            this.lbl7500.Name = "lbl7500";
            this.lbl7500.Size = new System.Drawing.Size(95, 18);
            this.lbl7500.TabIndex = 10;
            this.lbl7500.Text = "6    $7,500";
            // 
            // lbl5000
            // 
            this.lbl5000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl5000.AutoSize = true;
            this.lbl5000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5000.ForeColor = System.Drawing.Color.White;
            this.lbl5000.Location = new System.Drawing.Point(51, 278);
            this.lbl5000.Name = "lbl5000";
            this.lbl5000.Size = new System.Drawing.Size(95, 18);
            this.lbl5000.TabIndex = 11;
            this.lbl5000.Text = "5    $5,000";
            // 
            // lbl3000
            // 
            this.lbl3000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3000.AutoSize = true;
            this.lbl3000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl3000.Location = new System.Drawing.Point(51, 303);
            this.lbl3000.Name = "lbl3000";
            this.lbl3000.Size = new System.Drawing.Size(95, 18);
            this.lbl3000.TabIndex = 12;
            this.lbl3000.Text = "4    $3,000";
            // 
            // lbl2000
            // 
            this.lbl2000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2000.AutoSize = true;
            this.lbl2000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl2000.Location = new System.Drawing.Point(51, 328);
            this.lbl2000.Name = "lbl2000";
            this.lbl2000.Size = new System.Drawing.Size(95, 18);
            this.lbl2000.TabIndex = 13;
            this.lbl2000.Text = "3    $2,000";
            // 
            // lbl1000
            // 
            this.lbl1000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1000.AutoSize = true;
            this.lbl1000.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1000.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl1000.Location = new System.Drawing.Point(51, 353);
            this.lbl1000.Name = "lbl1000";
            this.lbl1000.Size = new System.Drawing.Size(95, 18);
            this.lbl1000.TabIndex = 14;
            this.lbl1000.Text = "2    $1,000";
            // 
            // lbl500
            // 
            this.lbl500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl500.AutoSize = true;
            this.lbl500.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl500.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl500.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl500.Location = new System.Drawing.Point(58, 385);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(81, 20);
            this.lbl500.TabIndex = 15;
            this.lbl500.Text = "1    $500";
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.tblGameBG);
            this.Name = "GameForm";
            this.Text = "Who Wants To Be A Millionaire";
            this.tblGameBG.ResumeLayout(false);
            this.tblGameMain.ResumeLayout(false);
            this.tblGameMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblGameBG;
        private System.Windows.Forms.TableLayoutPanel tblGameMain;
        private System.Windows.Forms.Label lblQuestionContents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTakeMoney;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btn5050;
        private System.Windows.Forms.Button btnKeepGoing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Label lbl1000000;
        private System.Windows.Forms.Label lbl500000;
        private System.Windows.Forms.Label lbl250000;
        private System.Windows.Forms.Label lbl150000;
        private System.Windows.Forms.Label lbl75000;
        private System.Windows.Forms.Label lbl50000;
        private System.Windows.Forms.Label lbl25000;
        private System.Windows.Forms.Label lbl15000;
        private System.Windows.Forms.Label lbl10000;
        private System.Windows.Forms.Label lbl7500;
        private System.Windows.Forms.Label lbl5000;
        private System.Windows.Forms.Label lbl3000;
        private System.Windows.Forms.Label lbl2000;
        private System.Windows.Forms.Label lbl1000;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lblHintText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblQuestionNumTitle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer questionTimer;
    }
}