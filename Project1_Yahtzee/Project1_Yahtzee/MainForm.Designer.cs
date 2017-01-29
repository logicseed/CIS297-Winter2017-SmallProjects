namespace Project1_Yahtzee
{
    partial class MainForm
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
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.rollsRemainLabel = new System.Windows.Forms.Label();
            this.scoreTable = new System.Windows.Forms.TableLayoutPanel();
            this.upperSectionLabel = new System.Windows.Forms.Label();
            this.acesLabel = new System.Windows.Forms.Label();
            this.twosLabel = new System.Windows.Forms.Label();
            this.threesLabel = new System.Windows.Forms.Label();
            this.foursLabel = new System.Windows.Forms.Label();
            this.fivesLabel = new System.Windows.Forms.Label();
            this.sixesLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.acesButton = new System.Windows.Forms.Button();
            this.twosButton = new System.Windows.Forms.Button();
            this.threesButton = new System.Windows.Forms.Button();
            this.foursButton = new System.Windows.Forms.Button();
            this.fivesButton = new System.Windows.Forms.Button();
            this.sixesButton = new System.Windows.Forms.Button();
            this.bonusButton = new System.Windows.Forms.Button();
            this.lowerSectionLabel = new System.Windows.Forms.Label();
            this.threeOfAKindLabel = new System.Windows.Forms.Label();
            this.fourOfAKindLabel = new System.Windows.Forms.Label();
            this.fullHouseLabel = new System.Windows.Forms.Label();
            this.smallStraightLabel = new System.Windows.Forms.Label();
            this.largeStraightLabel = new System.Windows.Forms.Label();
            this.yahtzeeLabel = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.threeOfAKindButton = new System.Windows.Forms.Button();
            this.fourOfAKindButton = new System.Windows.Forms.Button();
            this.fullHouseButton = new System.Windows.Forms.Button();
            this.smallStraightButton = new System.Windows.Forms.Button();
            this.largeStraightButton = new System.Windows.Forms.Button();
            this.yahtzeeButton = new System.Windows.Forms.Button();
            this.chanceButton = new System.Windows.Forms.Button();
            this.die1 = new System.Windows.Forms.CheckBox();
            this.die2 = new System.Windows.Forms.CheckBox();
            this.die3 = new System.Windows.Forms.CheckBox();
            this.die4 = new System.Windows.Forms.CheckBox();
            this.die5 = new System.Windows.Forms.CheckBox();
            this.helpScoreCard = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scoreTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.BackColor = System.Drawing.Color.DarkOrange;
            this.rollDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollDiceButton.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.ForeColor = System.Drawing.Color.Black;
            this.rollDiceButton.Location = new System.Drawing.Point(17, 135);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(424, 81);
            this.rollDiceButton.TabIndex = 5;
            this.rollDiceButton.Text = "ROLL THE DICE!";
            this.rollDiceButton.UseVisualStyleBackColor = false;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // rollsRemainLabel
            // 
            this.rollsRemainLabel.AutoSize = true;
            this.rollsRemainLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollsRemainLabel.ForeColor = System.Drawing.Color.Gray;
            this.rollsRemainLabel.Location = new System.Drawing.Point(17, 223);
            this.rollsRemainLabel.Name = "rollsRemainLabel";
            this.rollsRemainLabel.Size = new System.Drawing.Size(167, 23);
            this.rollsRemainLabel.TabIndex = 6;
            this.rollsRemainLabel.Text = "Rolls remaining: 3";
            // 
            // scoreTable
            // 
            this.scoreTable.AutoSize = true;
            this.scoreTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreTable.ColumnCount = 5;
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scoreTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.scoreTable.Controls.Add(this.upperSectionLabel, 0, 0);
            this.scoreTable.Controls.Add(this.acesLabel, 0, 1);
            this.scoreTable.Controls.Add(this.twosLabel, 0, 2);
            this.scoreTable.Controls.Add(this.threesLabel, 0, 3);
            this.scoreTable.Controls.Add(this.foursLabel, 0, 4);
            this.scoreTable.Controls.Add(this.fivesLabel, 0, 5);
            this.scoreTable.Controls.Add(this.sixesLabel, 0, 6);
            this.scoreTable.Controls.Add(this.bonusLabel, 0, 7);
            this.scoreTable.Controls.Add(this.acesButton, 1, 1);
            this.scoreTable.Controls.Add(this.twosButton, 1, 2);
            this.scoreTable.Controls.Add(this.threesButton, 1, 3);
            this.scoreTable.Controls.Add(this.foursButton, 1, 4);
            this.scoreTable.Controls.Add(this.fivesButton, 1, 5);
            this.scoreTable.Controls.Add(this.sixesButton, 1, 6);
            this.scoreTable.Controls.Add(this.bonusButton, 1, 7);
            this.scoreTable.Controls.Add(this.lowerSectionLabel, 3, 0);
            this.scoreTable.Controls.Add(this.threeOfAKindLabel, 3, 1);
            this.scoreTable.Controls.Add(this.fourOfAKindLabel, 3, 2);
            this.scoreTable.Controls.Add(this.fullHouseLabel, 3, 3);
            this.scoreTable.Controls.Add(this.smallStraightLabel, 3, 4);
            this.scoreTable.Controls.Add(this.largeStraightLabel, 3, 5);
            this.scoreTable.Controls.Add(this.yahtzeeLabel, 3, 6);
            this.scoreTable.Controls.Add(this.chanceLabel, 3, 7);
            this.scoreTable.Controls.Add(this.threeOfAKindButton, 4, 1);
            this.scoreTable.Controls.Add(this.fourOfAKindButton, 4, 2);
            this.scoreTable.Controls.Add(this.fullHouseButton, 4, 3);
            this.scoreTable.Controls.Add(this.smallStraightButton, 4, 4);
            this.scoreTable.Controls.Add(this.largeStraightButton, 4, 5);
            this.scoreTable.Controls.Add(this.yahtzeeButton, 4, 6);
            this.scoreTable.Controls.Add(this.chanceButton, 4, 7);
            this.scoreTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.scoreTable.Location = new System.Drawing.Point(6, 52);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.RowCount = 8;
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.scoreTable.Size = new System.Drawing.Size(281, 319);
            this.scoreTable.TabIndex = 7;
            // 
            // upperSectionLabel
            // 
            this.upperSectionLabel.AutoSize = true;
            this.scoreTable.SetColumnSpan(this.upperSectionLabel, 2);
            this.upperSectionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.upperSectionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperSectionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.upperSectionLabel.Location = new System.Drawing.Point(3, 6);
            this.upperSectionLabel.Name = "upperSectionLabel";
            this.upperSectionLabel.Size = new System.Drawing.Size(116, 19);
            this.upperSectionLabel.TabIndex = 0;
            this.upperSectionLabel.Text = "UPPER SECTION";
            // 
            // acesLabel
            // 
            this.acesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.acesLabel.AutoSize = true;
            this.acesLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesLabel.ForeColor = System.Drawing.Color.Black;
            this.acesLabel.Location = new System.Drawing.Point(13, 39);
            this.acesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.acesLabel.Name = "acesLabel";
            this.acesLabel.Size = new System.Drawing.Size(29, 13);
            this.acesLabel.TabIndex = 1;
            this.acesLabel.Text = "Aces";
            // 
            // twosLabel
            // 
            this.twosLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.twosLabel.AutoSize = true;
            this.twosLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosLabel.ForeColor = System.Drawing.Color.Black;
            this.twosLabel.Location = new System.Drawing.Point(11, 81);
            this.twosLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.twosLabel.Name = "twosLabel";
            this.twosLabel.Size = new System.Drawing.Size(31, 13);
            this.twosLabel.TabIndex = 2;
            this.twosLabel.Text = "Twos";
            // 
            // threesLabel
            // 
            this.threesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.threesLabel.AutoSize = true;
            this.threesLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesLabel.ForeColor = System.Drawing.Color.Black;
            this.threesLabel.Location = new System.Drawing.Point(3, 123);
            this.threesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.threesLabel.Name = "threesLabel";
            this.threesLabel.Size = new System.Drawing.Size(39, 13);
            this.threesLabel.TabIndex = 3;
            this.threesLabel.Text = "Threes";
            // 
            // foursLabel
            // 
            this.foursLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.foursLabel.AutoSize = true;
            this.foursLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursLabel.ForeColor = System.Drawing.Color.Black;
            this.foursLabel.Location = new System.Drawing.Point(9, 165);
            this.foursLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.foursLabel.Name = "foursLabel";
            this.foursLabel.Size = new System.Drawing.Size(33, 13);
            this.foursLabel.TabIndex = 4;
            this.foursLabel.Text = "Fours";
            // 
            // fivesLabel
            // 
            this.fivesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fivesLabel.AutoSize = true;
            this.fivesLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesLabel.ForeColor = System.Drawing.Color.Black;
            this.fivesLabel.Location = new System.Drawing.Point(11, 207);
            this.fivesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.fivesLabel.Name = "fivesLabel";
            this.fivesLabel.Size = new System.Drawing.Size(31, 13);
            this.fivesLabel.TabIndex = 5;
            this.fivesLabel.Text = "Fives";
            // 
            // sixesLabel
            // 
            this.sixesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sixesLabel.AutoSize = true;
            this.sixesLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesLabel.ForeColor = System.Drawing.Color.Black;
            this.sixesLabel.Location = new System.Drawing.Point(11, 249);
            this.sixesLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sixesLabel.Name = "sixesLabel";
            this.sixesLabel.Size = new System.Drawing.Size(31, 13);
            this.sixesLabel.TabIndex = 6;
            this.sixesLabel.Text = "Sixes";
            // 
            // bonusLabel
            // 
            this.bonusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusLabel.ForeColor = System.Drawing.Color.Black;
            this.bonusLabel.Location = new System.Drawing.Point(6, 291);
            this.bonusLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(36, 13);
            this.bonusLabel.TabIndex = 7;
            this.bonusLabel.Text = "Bonus";
            // 
            // acesButton
            // 
            this.acesButton.AutoSize = true;
            this.acesButton.Enabled = false;
            this.acesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesButton.ForeColor = System.Drawing.Color.Black;
            this.acesButton.Location = new System.Drawing.Point(45, 28);
            this.acesButton.Name = "acesButton";
            this.acesButton.Size = new System.Drawing.Size(74, 36);
            this.acesButton.TabIndex = 8;
            this.acesButton.Text = "99";
            this.acesButton.UseVisualStyleBackColor = false;
            this.acesButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // twosButton
            // 
            this.twosButton.AutoSize = true;
            this.twosButton.Enabled = false;
            this.twosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosButton.ForeColor = System.Drawing.Color.Black;
            this.twosButton.Location = new System.Drawing.Point(45, 70);
            this.twosButton.Name = "twosButton";
            this.twosButton.Size = new System.Drawing.Size(74, 36);
            this.twosButton.TabIndex = 9;
            this.twosButton.Text = "99";
            this.twosButton.UseVisualStyleBackColor = false;
            this.twosButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // threesButton
            // 
            this.threesButton.AutoSize = true;
            this.threesButton.Enabled = false;
            this.threesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesButton.ForeColor = System.Drawing.Color.Black;
            this.threesButton.Location = new System.Drawing.Point(45, 112);
            this.threesButton.Name = "threesButton";
            this.threesButton.Size = new System.Drawing.Size(74, 36);
            this.threesButton.TabIndex = 10;
            this.threesButton.Text = "99";
            this.threesButton.UseVisualStyleBackColor = false;
            this.threesButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // foursButton
            // 
            this.foursButton.AutoSize = true;
            this.foursButton.Enabled = false;
            this.foursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursButton.ForeColor = System.Drawing.Color.Black;
            this.foursButton.Location = new System.Drawing.Point(45, 154);
            this.foursButton.Name = "foursButton";
            this.foursButton.Size = new System.Drawing.Size(74, 36);
            this.foursButton.TabIndex = 11;
            this.foursButton.Text = "99";
            this.foursButton.UseVisualStyleBackColor = false;
            this.foursButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // fivesButton
            // 
            this.fivesButton.AutoSize = true;
            this.fivesButton.Enabled = false;
            this.fivesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fivesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesButton.ForeColor = System.Drawing.Color.Black;
            this.fivesButton.Location = new System.Drawing.Point(45, 196);
            this.fivesButton.Name = "fivesButton";
            this.fivesButton.Size = new System.Drawing.Size(74, 36);
            this.fivesButton.TabIndex = 12;
            this.fivesButton.Text = "99";
            this.fivesButton.UseVisualStyleBackColor = false;
            this.fivesButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // sixesButton
            // 
            this.sixesButton.AutoSize = true;
            this.sixesButton.Enabled = false;
            this.sixesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesButton.ForeColor = System.Drawing.Color.Black;
            this.sixesButton.Location = new System.Drawing.Point(45, 238);
            this.sixesButton.Name = "sixesButton";
            this.sixesButton.Size = new System.Drawing.Size(74, 36);
            this.sixesButton.TabIndex = 13;
            this.sixesButton.Text = "99";
            this.sixesButton.UseVisualStyleBackColor = false;
            this.sixesButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // bonusButton
            // 
            this.bonusButton.AutoSize = true;
            this.bonusButton.Enabled = false;
            this.bonusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bonusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusButton.ForeColor = System.Drawing.Color.Black;
            this.bonusButton.Location = new System.Drawing.Point(45, 280);
            this.bonusButton.Name = "bonusButton";
            this.bonusButton.Size = new System.Drawing.Size(74, 36);
            this.bonusButton.TabIndex = 14;
            this.bonusButton.Text = "99";
            this.bonusButton.UseVisualStyleBackColor = false;
            // 
            // lowerSectionLabel
            // 
            this.lowerSectionLabel.AutoSize = true;
            this.scoreTable.SetColumnSpan(this.lowerSectionLabel, 2);
            this.lowerSectionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerSectionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerSectionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lowerSectionLabel.Location = new System.Drawing.Point(125, 6);
            this.lowerSectionLabel.Name = "lowerSectionLabel";
            this.lowerSectionLabel.Size = new System.Drawing.Size(153, 19);
            this.lowerSectionLabel.TabIndex = 15;
            this.lowerSectionLabel.Text = "LOWER SECTION";
            // 
            // threeOfAKindLabel
            // 
            this.threeOfAKindLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.threeOfAKindLabel.AutoSize = true;
            this.threeOfAKindLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindLabel.ForeColor = System.Drawing.Color.Black;
            this.threeOfAKindLabel.Location = new System.Drawing.Point(125, 39);
            this.threeOfAKindLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.threeOfAKindLabel.Name = "threeOfAKindLabel";
            this.threeOfAKindLabel.Size = new System.Drawing.Size(76, 13);
            this.threeOfAKindLabel.TabIndex = 16;
            this.threeOfAKindLabel.Text = "Three of a Kind";
            // 
            // fourOfAKindLabel
            // 
            this.fourOfAKindLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fourOfAKindLabel.AutoSize = true;
            this.fourOfAKindLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfAKindLabel.ForeColor = System.Drawing.Color.Black;
            this.fourOfAKindLabel.Location = new System.Drawing.Point(131, 81);
            this.fourOfAKindLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.fourOfAKindLabel.Name = "fourOfAKindLabel";
            this.fourOfAKindLabel.Size = new System.Drawing.Size(70, 13);
            this.fourOfAKindLabel.TabIndex = 17;
            this.fourOfAKindLabel.Text = "Four of a Kind";
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fullHouseLabel.AutoSize = true;
            this.fullHouseLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHouseLabel.ForeColor = System.Drawing.Color.Black;
            this.fullHouseLabel.Location = new System.Drawing.Point(145, 123);
            this.fullHouseLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(56, 13);
            this.fullHouseLabel.TabIndex = 18;
            this.fullHouseLabel.Text = "Full House";
            // 
            // smallStraightLabel
            // 
            this.smallStraightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.smallStraightLabel.AutoSize = true;
            this.smallStraightLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallStraightLabel.ForeColor = System.Drawing.Color.Black;
            this.smallStraightLabel.Location = new System.Drawing.Point(129, 165);
            this.smallStraightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.smallStraightLabel.Name = "smallStraightLabel";
            this.smallStraightLabel.Size = new System.Drawing.Size(72, 13);
            this.smallStraightLabel.TabIndex = 19;
            this.smallStraightLabel.Text = "Small Straight";
            // 
            // largeStraightLabel
            // 
            this.largeStraightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.largeStraightLabel.AutoSize = true;
            this.largeStraightLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeStraightLabel.ForeColor = System.Drawing.Color.Black;
            this.largeStraightLabel.Location = new System.Drawing.Point(129, 207);
            this.largeStraightLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.largeStraightLabel.Name = "largeStraightLabel";
            this.largeStraightLabel.Size = new System.Drawing.Size(72, 13);
            this.largeStraightLabel.TabIndex = 20;
            this.largeStraightLabel.Text = "Large Straight";
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yahtzeeLabel.AutoSize = true;
            this.yahtzeeLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeLabel.ForeColor = System.Drawing.Color.Black;
            this.yahtzeeLabel.Location = new System.Drawing.Point(158, 249);
            this.yahtzeeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(43, 13);
            this.yahtzeeLabel.TabIndex = 21;
            this.yahtzeeLabel.Text = "Yahtzee";
            // 
            // chanceLabel
            // 
            this.chanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLabel.ForeColor = System.Drawing.Color.Black;
            this.chanceLabel.Location = new System.Drawing.Point(159, 291);
            this.chanceLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(42, 13);
            this.chanceLabel.TabIndex = 22;
            this.chanceLabel.Text = "Chance";
            // 
            // threeOfAKindButton
            // 
            this.threeOfAKindButton.AutoSize = true;
            this.threeOfAKindButton.Enabled = false;
            this.threeOfAKindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeOfAKindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindButton.ForeColor = System.Drawing.Color.Black;
            this.threeOfAKindButton.Location = new System.Drawing.Point(204, 28);
            this.threeOfAKindButton.Name = "threeOfAKindButton";
            this.threeOfAKindButton.Size = new System.Drawing.Size(74, 36);
            this.threeOfAKindButton.TabIndex = 23;
            this.threeOfAKindButton.Text = "99";
            this.threeOfAKindButton.UseVisualStyleBackColor = false;
            this.threeOfAKindButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // fourOfAKindButton
            // 
            this.fourOfAKindButton.AutoSize = true;
            this.fourOfAKindButton.Enabled = false;
            this.fourOfAKindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourOfAKindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfAKindButton.ForeColor = System.Drawing.Color.Black;
            this.fourOfAKindButton.Location = new System.Drawing.Point(204, 70);
            this.fourOfAKindButton.Name = "fourOfAKindButton";
            this.fourOfAKindButton.Size = new System.Drawing.Size(74, 36);
            this.fourOfAKindButton.TabIndex = 24;
            this.fourOfAKindButton.Text = "99";
            this.fourOfAKindButton.UseVisualStyleBackColor = false;
            this.fourOfAKindButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // fullHouseButton
            // 
            this.fullHouseButton.AutoSize = true;
            this.fullHouseButton.Enabled = false;
            this.fullHouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullHouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHouseButton.ForeColor = System.Drawing.Color.Black;
            this.fullHouseButton.Location = new System.Drawing.Point(204, 112);
            this.fullHouseButton.Name = "fullHouseButton";
            this.fullHouseButton.Size = new System.Drawing.Size(74, 36);
            this.fullHouseButton.TabIndex = 25;
            this.fullHouseButton.Text = "99";
            this.fullHouseButton.UseVisualStyleBackColor = false;
            this.fullHouseButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // smallStraightButton
            // 
            this.smallStraightButton.AutoSize = true;
            this.smallStraightButton.Enabled = false;
            this.smallStraightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallStraightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallStraightButton.ForeColor = System.Drawing.Color.Black;
            this.smallStraightButton.Location = new System.Drawing.Point(204, 154);
            this.smallStraightButton.Name = "smallStraightButton";
            this.smallStraightButton.Size = new System.Drawing.Size(74, 36);
            this.smallStraightButton.TabIndex = 26;
            this.smallStraightButton.Text = "99";
            this.smallStraightButton.UseVisualStyleBackColor = false;
            this.smallStraightButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // largeStraightButton
            // 
            this.largeStraightButton.AutoSize = true;
            this.largeStraightButton.Enabled = false;
            this.largeStraightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeStraightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeStraightButton.ForeColor = System.Drawing.Color.Black;
            this.largeStraightButton.Location = new System.Drawing.Point(204, 196);
            this.largeStraightButton.Name = "largeStraightButton";
            this.largeStraightButton.Size = new System.Drawing.Size(74, 36);
            this.largeStraightButton.TabIndex = 27;
            this.largeStraightButton.Text = "99";
            this.largeStraightButton.UseVisualStyleBackColor = false;
            this.largeStraightButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // yahtzeeButton
            // 
            this.yahtzeeButton.AutoSize = true;
            this.yahtzeeButton.Enabled = false;
            this.yahtzeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahtzeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeButton.ForeColor = System.Drawing.Color.Black;
            this.yahtzeeButton.Location = new System.Drawing.Point(204, 238);
            this.yahtzeeButton.Name = "yahtzeeButton";
            this.yahtzeeButton.Size = new System.Drawing.Size(74, 36);
            this.yahtzeeButton.TabIndex = 28;
            this.yahtzeeButton.Text = "99";
            this.yahtzeeButton.UseVisualStyleBackColor = false;
            this.yahtzeeButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // chanceButton
            // 
            this.chanceButton.AutoSize = true;
            this.chanceButton.Enabled = false;
            this.chanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceButton.ForeColor = System.Drawing.Color.Black;
            this.chanceButton.Location = new System.Drawing.Point(204, 280);
            this.chanceButton.Name = "chanceButton";
            this.chanceButton.Size = new System.Drawing.Size(74, 36);
            this.chanceButton.TabIndex = 29;
            this.chanceButton.Text = "99";
            this.chanceButton.UseVisualStyleBackColor = false;
            this.chanceButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // die1
            // 
            this.die1.Appearance = System.Windows.Forms.Appearance.Button;
            this.die1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.die1.FlatAppearance.BorderSize = 0;
            this.die1.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.die1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.die1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.die1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.die1.Image = global::Project1_Yahtzee.Properties.Resources.DieFace0;
            this.die1.Location = new System.Drawing.Point(17, 44);
            this.die1.Name = "die1";
            this.die1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die1.Size = new System.Drawing.Size(80, 80);
            this.die1.TabIndex = 8;
            this.die1.UseVisualStyleBackColor = true;
            // 
            // die2
            // 
            this.die2.Appearance = System.Windows.Forms.Appearance.Button;
            this.die2.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.die2.FlatAppearance.BorderSize = 0;
            this.die2.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.die2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.die2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.die2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.die2.Image = global::Project1_Yahtzee.Properties.Resources.DieFace0;
            this.die2.Location = new System.Drawing.Point(103, 44);
            this.die2.Name = "die2";
            this.die2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die2.Size = new System.Drawing.Size(80, 80);
            this.die2.TabIndex = 9;
            this.die2.UseVisualStyleBackColor = true;
            // 
            // die3
            // 
            this.die3.Appearance = System.Windows.Forms.Appearance.Button;
            this.die3.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.die3.FlatAppearance.BorderSize = 0;
            this.die3.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.die3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.die3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.die3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.die3.Image = global::Project1_Yahtzee.Properties.Resources.DieFace0;
            this.die3.Location = new System.Drawing.Point(189, 44);
            this.die3.Name = "die3";
            this.die3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die3.Size = new System.Drawing.Size(80, 80);
            this.die3.TabIndex = 10;
            this.die3.UseVisualStyleBackColor = true;
            // 
            // die4
            // 
            this.die4.Appearance = System.Windows.Forms.Appearance.Button;
            this.die4.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.die4.FlatAppearance.BorderSize = 0;
            this.die4.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.die4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.die4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.die4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.die4.Image = global::Project1_Yahtzee.Properties.Resources.DieFace0;
            this.die4.Location = new System.Drawing.Point(275, 44);
            this.die4.Name = "die4";
            this.die4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die4.Size = new System.Drawing.Size(80, 80);
            this.die4.TabIndex = 11;
            this.die4.UseVisualStyleBackColor = true;
            // 
            // die5
            // 
            this.die5.Appearance = System.Windows.Forms.Appearance.Button;
            this.die5.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.die5.FlatAppearance.BorderSize = 0;
            this.die5.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.die5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.die5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.die5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.die5.Image = global::Project1_Yahtzee.Properties.Resources.DieFace0;
            this.die5.Location = new System.Drawing.Point(361, 44);
            this.die5.Name = "die5";
            this.die5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die5.Size = new System.Drawing.Size(80, 80);
            this.die5.TabIndex = 12;
            this.die5.UseVisualStyleBackColor = true;
            // 
            // helpScoreCard
            // 
            this.helpScoreCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.helpScoreCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpScoreCard.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpScoreCard.ForeColor = System.Drawing.Color.Gray;
            this.helpScoreCard.Location = new System.Drawing.Point(14, 52);
            this.helpScoreCard.Margin = new System.Windows.Forms.Padding(0);
            this.helpScoreCard.Name = "helpScoreCard";
            this.helpScoreCard.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.helpScoreCard.Size = new System.Drawing.Size(341, 54);
            this.helpScoreCard.TabIndex = 14;
            this.helpScoreCard.Text = "• Roll the dice to begin!\r\n• Click a die to keep it when you roll.\r\n• Click a sco" +
    "re to write that score on your score card.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.scoreTable);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(487, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 375);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SCORECARD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.die1);
            this.groupBox2.Controls.Add(this.rollDiceButton);
            this.groupBox2.Controls.Add(this.rollsRemainLabel);
            this.groupBox2.Controls.Add(this.die5);
            this.groupBox2.Controls.Add(this.die2);
            this.groupBox2.Controls.Add(this.die4);
            this.groupBox2.Controls.Add(this.die3);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(12, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 255);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DICE ROLLER";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.helpScoreCard);
            this.groupBox3.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 125);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HELP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(791, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAHTZEE!";
            this.scoreTable.ResumeLayout(false);
            this.scoreTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Label rollsRemainLabel;
        private System.Windows.Forms.TableLayoutPanel scoreTable;
        private System.Windows.Forms.Label upperSectionLabel;
        private System.Windows.Forms.Label acesLabel;
        private System.Windows.Forms.Label twosLabel;
        private System.Windows.Forms.Label threesLabel;
        private System.Windows.Forms.Label foursLabel;
        private System.Windows.Forms.Label fivesLabel;
        private System.Windows.Forms.Label sixesLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Button acesButton;
        private System.Windows.Forms.Button twosButton;
        private System.Windows.Forms.Button threesButton;
        private System.Windows.Forms.Button foursButton;
        private System.Windows.Forms.Button fivesButton;
        private System.Windows.Forms.Button sixesButton;
        private System.Windows.Forms.Button bonusButton;
        private System.Windows.Forms.Label lowerSectionLabel;
        private System.Windows.Forms.Label threeOfAKindLabel;
        private System.Windows.Forms.Label fourOfAKindLabel;
        private System.Windows.Forms.Label fullHouseLabel;
        private System.Windows.Forms.Label smallStraightLabel;
        private System.Windows.Forms.Label largeStraightLabel;
        private System.Windows.Forms.Label yahtzeeLabel;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Button threeOfAKindButton;
        private System.Windows.Forms.Button fourOfAKindButton;
        private System.Windows.Forms.Button fullHouseButton;
        private System.Windows.Forms.Button smallStraightButton;
        private System.Windows.Forms.Button largeStraightButton;
        private System.Windows.Forms.Button yahtzeeButton;
        private System.Windows.Forms.Button chanceButton;
        private System.Windows.Forms.CheckBox die1;
        private System.Windows.Forms.CheckBox die2;
        private System.Windows.Forms.CheckBox die3;
        private System.Windows.Forms.CheckBox die4;
        private System.Windows.Forms.CheckBox die5;
        private System.Windows.Forms.Label helpScoreCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

