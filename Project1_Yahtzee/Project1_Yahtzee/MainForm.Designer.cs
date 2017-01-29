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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.BackColor = System.Drawing.Color.DarkOrange;
            this.rollDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollDiceButton.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.ForeColor = System.Drawing.Color.Black;
            this.rollDiceButton.Location = new System.Drawing.Point(12, 181);
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
            this.rollsRemainLabel.Location = new System.Drawing.Point(12, 265);
            this.rollsRemainLabel.Name = "rollsRemainLabel";
            this.rollsRemainLabel.Size = new System.Drawing.Size(90, 13);
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
            this.scoreTable.Location = new System.Drawing.Point(458, 52);
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
            this.scoreTable.Size = new System.Drawing.Size(292, 319);
            this.scoreTable.TabIndex = 7;
            // 
            // upperSectionLabel
            // 
            this.upperSectionLabel.AutoSize = true;
            this.scoreTable.SetColumnSpan(this.upperSectionLabel, 2);
            this.upperSectionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.upperSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperSectionLabel.Location = new System.Drawing.Point(3, 8);
            this.upperSectionLabel.Name = "upperSectionLabel";
            this.upperSectionLabel.Size = new System.Drawing.Size(120, 17);
            this.upperSectionLabel.TabIndex = 0;
            this.upperSectionLabel.Text = "Upper Section";
            // 
            // acesLabel
            // 
            this.acesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.acesLabel.AutoSize = true;
            this.acesLabel.Location = new System.Drawing.Point(12, 39);
            this.acesLabel.Name = "acesLabel";
            this.acesLabel.Size = new System.Drawing.Size(31, 13);
            this.acesLabel.TabIndex = 1;
            this.acesLabel.Text = "Aces";
            // 
            // twosLabel
            // 
            this.twosLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.twosLabel.AutoSize = true;
            this.twosLabel.Location = new System.Drawing.Point(10, 81);
            this.twosLabel.Name = "twosLabel";
            this.twosLabel.Size = new System.Drawing.Size(33, 13);
            this.twosLabel.TabIndex = 2;
            this.twosLabel.Text = "Twos";
            // 
            // threesLabel
            // 
            this.threesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.threesLabel.AutoSize = true;
            this.threesLabel.Location = new System.Drawing.Point(3, 123);
            this.threesLabel.Name = "threesLabel";
            this.threesLabel.Size = new System.Drawing.Size(40, 13);
            this.threesLabel.TabIndex = 3;
            this.threesLabel.Text = "Threes";
            // 
            // foursLabel
            // 
            this.foursLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.foursLabel.AutoSize = true;
            this.foursLabel.Location = new System.Drawing.Point(10, 165);
            this.foursLabel.Name = "foursLabel";
            this.foursLabel.Size = new System.Drawing.Size(33, 13);
            this.foursLabel.TabIndex = 4;
            this.foursLabel.Text = "Fours";
            // 
            // fivesLabel
            // 
            this.fivesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fivesLabel.AutoSize = true;
            this.fivesLabel.Location = new System.Drawing.Point(11, 207);
            this.fivesLabel.Name = "fivesLabel";
            this.fivesLabel.Size = new System.Drawing.Size(32, 13);
            this.fivesLabel.TabIndex = 5;
            this.fivesLabel.Text = "Fives";
            // 
            // sixesLabel
            // 
            this.sixesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sixesLabel.AutoSize = true;
            this.sixesLabel.Location = new System.Drawing.Point(11, 249);
            this.sixesLabel.Name = "sixesLabel";
            this.sixesLabel.Size = new System.Drawing.Size(32, 13);
            this.sixesLabel.TabIndex = 6;
            this.sixesLabel.Text = "Sixes";
            // 
            // bonusLabel
            // 
            this.bonusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(6, 291);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(37, 13);
            this.bonusLabel.TabIndex = 7;
            this.bonusLabel.Text = "Bonus";
            // 
            // acesButton
            // 
            this.acesButton.AutoSize = true;
            this.acesButton.Enabled = false;
            this.acesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesButton.Location = new System.Drawing.Point(49, 28);
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
            this.twosButton.Location = new System.Drawing.Point(49, 70);
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
            this.threesButton.Location = new System.Drawing.Point(49, 112);
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
            this.foursButton.Location = new System.Drawing.Point(49, 154);
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
            this.fivesButton.Location = new System.Drawing.Point(49, 196);
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
            this.sixesButton.Location = new System.Drawing.Point(49, 238);
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
            this.bonusButton.Location = new System.Drawing.Point(49, 280);
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
            this.lowerSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerSectionLabel.Location = new System.Drawing.Point(129, 8);
            this.lowerSectionLabel.Name = "lowerSectionLabel";
            this.lowerSectionLabel.Size = new System.Drawing.Size(160, 17);
            this.lowerSectionLabel.TabIndex = 15;
            this.lowerSectionLabel.Text = "Lower Section";
            // 
            // threeOfAKindLabel
            // 
            this.threeOfAKindLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.threeOfAKindLabel.AutoSize = true;
            this.threeOfAKindLabel.Location = new System.Drawing.Point(129, 39);
            this.threeOfAKindLabel.Name = "threeOfAKindLabel";
            this.threeOfAKindLabel.Size = new System.Drawing.Size(80, 13);
            this.threeOfAKindLabel.TabIndex = 16;
            this.threeOfAKindLabel.Text = "Three of a Kind";
            // 
            // fourOfAKindLabel
            // 
            this.fourOfAKindLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fourOfAKindLabel.AutoSize = true;
            this.fourOfAKindLabel.Location = new System.Drawing.Point(136, 81);
            this.fourOfAKindLabel.Name = "fourOfAKindLabel";
            this.fourOfAKindLabel.Size = new System.Drawing.Size(73, 13);
            this.fourOfAKindLabel.TabIndex = 17;
            this.fourOfAKindLabel.Text = "Four of a Kind";
            // 
            // fullHouseLabel
            // 
            this.fullHouseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fullHouseLabel.AutoSize = true;
            this.fullHouseLabel.Location = new System.Drawing.Point(152, 123);
            this.fullHouseLabel.Name = "fullHouseLabel";
            this.fullHouseLabel.Size = new System.Drawing.Size(57, 13);
            this.fullHouseLabel.TabIndex = 18;
            this.fullHouseLabel.Text = "Full House";
            // 
            // smallStraightLabel
            // 
            this.smallStraightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.smallStraightLabel.AutoSize = true;
            this.smallStraightLabel.Location = new System.Drawing.Point(138, 165);
            this.smallStraightLabel.Name = "smallStraightLabel";
            this.smallStraightLabel.Size = new System.Drawing.Size(71, 13);
            this.smallStraightLabel.TabIndex = 19;
            this.smallStraightLabel.Text = "Small Straight";
            // 
            // largeStraightLabel
            // 
            this.largeStraightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.largeStraightLabel.AutoSize = true;
            this.largeStraightLabel.Location = new System.Drawing.Point(136, 207);
            this.largeStraightLabel.Name = "largeStraightLabel";
            this.largeStraightLabel.Size = new System.Drawing.Size(73, 13);
            this.largeStraightLabel.TabIndex = 20;
            this.largeStraightLabel.Text = "Large Straight";
            // 
            // yahtzeeLabel
            // 
            this.yahtzeeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.yahtzeeLabel.AutoSize = true;
            this.yahtzeeLabel.Location = new System.Drawing.Point(163, 249);
            this.yahtzeeLabel.Name = "yahtzeeLabel";
            this.yahtzeeLabel.Size = new System.Drawing.Size(46, 13);
            this.yahtzeeLabel.TabIndex = 21;
            this.yahtzeeLabel.Text = "Yahtzee";
            // 
            // chanceLabel
            // 
            this.chanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chanceLabel.AutoSize = true;
            this.chanceLabel.Location = new System.Drawing.Point(165, 291);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(44, 13);
            this.chanceLabel.TabIndex = 22;
            this.chanceLabel.Text = "Chance";
            // 
            // threeOfAKindButton
            // 
            this.threeOfAKindButton.AutoSize = true;
            this.threeOfAKindButton.Enabled = false;
            this.threeOfAKindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeOfAKindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfAKindButton.Location = new System.Drawing.Point(215, 28);
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
            this.fourOfAKindButton.Location = new System.Drawing.Point(215, 70);
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
            this.fullHouseButton.Location = new System.Drawing.Point(215, 112);
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
            this.smallStraightButton.Location = new System.Drawing.Point(215, 154);
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
            this.largeStraightButton.Location = new System.Drawing.Point(215, 196);
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
            this.yahtzeeButton.Location = new System.Drawing.Point(215, 238);
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
            this.chanceButton.Location = new System.Drawing.Point(215, 280);
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
            this.die1.Location = new System.Drawing.Point(12, 76);
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
            this.die2.Location = new System.Drawing.Point(98, 76);
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
            this.die3.Location = new System.Drawing.Point(184, 76);
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
            this.die4.Location = new System.Drawing.Point(270, 76);
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
            this.die5.Location = new System.Drawing.Point(356, 76);
            this.die5.Name = "die5";
            this.die5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.die5.Size = new System.Drawing.Size(80, 80);
            this.die5.TabIndex = 12;
            this.die5.UseVisualStyleBackColor = true;
            // 
            // helpScoreCard
            // 
            this.helpScoreCard.BackColor = System.Drawing.Color.White;
            this.helpScoreCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpScoreCard.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpScoreCard.Location = new System.Drawing.Point(12, 296);
            this.helpScoreCard.Margin = new System.Windows.Forms.Padding(0);
            this.helpScoreCard.Name = "helpScoreCard";
            this.helpScoreCard.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.helpScoreCard.Size = new System.Drawing.Size(424, 75);
            this.helpScoreCard.TabIndex = 14;
            this.helpScoreCard.Text = "HELP\r\n\r\nClick a die to keep it between rolls.\r\nClick a score to write that score " +
    "on your score card.\r\nRoll the dice to begin!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 60);
            this.label1.TabIndex = 15;
            this.label1.Text = "DICE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Black", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 60);
            this.label2.TabIndex = 16;
            this.label2.Text = "SCORECARD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.helpScoreCard);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.rollsRemainLabel);
            this.Controls.Add(this.rollDiceButton);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAHTZEE!";
            this.scoreTable.ResumeLayout(false);
            this.scoreTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

