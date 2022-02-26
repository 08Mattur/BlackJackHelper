namespace BlackJackHelper.Forms
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
            this.btnNewDeck = new System.Windows.Forms.Button();
            this.btnNewHand = new System.Windows.Forms.Button();
            this.gbDealer = new System.Windows.Forms.GroupBox();
            this.ucDealerSuitClubs = new BlackJackHelper.Controls.Suit();
            this.lstDealerHand = new System.Windows.Forms.ListBox();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.lblAdvantageValue = new System.Windows.Forms.Label();
            this.lblAdvantageText = new System.Windows.Forms.Label();
            this.ucPlayerSuitClubs = new BlackJackHelper.Controls.Suit();
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblPlayerValueText = new System.Windows.Forms.Label();
            this.lblWhatDo = new System.Windows.Forms.Label();
            this.gbDeck = new System.Windows.Forms.GroupBox();
            this.lblAProbability = new System.Windows.Forms.Label();
            this.lbl2Probability = new System.Windows.Forms.Label();
            this.lbl3Probability = new System.Windows.Forms.Label();
            this.lbl4Probability = new System.Windows.Forms.Label();
            this.lbl5Probability = new System.Windows.Forms.Label();
            this.lbl6Probability = new System.Windows.Forms.Label();
            this.lbl7Probability = new System.Windows.Forms.Label();
            this.lbl8Probability = new System.Windows.Forms.Label();
            this.lbl9Probability = new System.Windows.Forms.Label();
            this.lbl10Probability = new System.Windows.Forms.Label();
            this.lbl10InDeck = new System.Windows.Forms.Label();
            this.lbl9InDeck = new System.Windows.Forms.Label();
            this.lbl8InDeck = new System.Windows.Forms.Label();
            this.lbl7InDeck = new System.Windows.Forms.Label();
            this.lbl6InDeck = new System.Windows.Forms.Label();
            this.lbl5InDeck = new System.Windows.Forms.Label();
            this.lbl4InDeck = new System.Windows.Forms.Label();
            this.lbl3InDeck = new System.Windows.Forms.Label();
            this.lbl2InDeck = new System.Windows.Forms.Label();
            this.lblAInDeck = new System.Windows.Forms.Label();
            this.lblTotalInDeckValue = new System.Windows.Forms.Label();
            this.lblTotalInDeckText = new System.Windows.Forms.Label();
            this.lblProbabilityText = new System.Windows.Forms.Label();
            this.lblEachLeftInDeckText = new System.Windows.Forms.Label();
            this.btn10Count = new System.Windows.Forms.Button();
            this.btn9Count = new System.Windows.Forms.Button();
            this.btn8Count = new System.Windows.Forms.Button();
            this.btn7Count = new System.Windows.Forms.Button();
            this.btn6Count = new System.Windows.Forms.Button();
            this.btn5Count = new System.Windows.Forms.Button();
            this.btn4Count = new System.Windows.Forms.Button();
            this.btn3Count = new System.Windows.Forms.Button();
            this.btn2Count = new System.Windows.Forms.Button();
            this.btnACount = new System.Windows.Forms.Button();
            this.gbDealer.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.gbDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(12, 388);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeck.TabIndex = 0;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.UseVisualStyleBackColor = true;
            this.btnNewDeck.Click += new System.EventHandler(this.btnNewDeck_Click);
            // 
            // btnNewHand
            // 
            this.btnNewHand.Location = new System.Drawing.Point(843, 388);
            this.btnNewHand.Name = "btnNewHand";
            this.btnNewHand.Size = new System.Drawing.Size(75, 23);
            this.btnNewHand.TabIndex = 1;
            this.btnNewHand.Text = "New Hand";
            this.btnNewHand.UseVisualStyleBackColor = true;
            this.btnNewHand.Click += new System.EventHandler(this.btnNewHand_Click);
            // 
            // gbDealer
            // 
            this.gbDealer.Controls.Add(this.ucDealerSuitClubs);
            this.gbDealer.Controls.Add(this.lstDealerHand);
            this.gbDealer.Location = new System.Drawing.Point(12, 12);
            this.gbDealer.Name = "gbDealer";
            this.gbDealer.Size = new System.Drawing.Size(906, 97);
            this.gbDealer.TabIndex = 7;
            this.gbDealer.TabStop = false;
            this.gbDealer.Text = "Dealer";
            // 
            // ucDealerSuitClubs
            // 
            this.ucDealerSuitClubs.Location = new System.Drawing.Point(6, 22);
            this.ucDealerSuitClubs.Name = "ucDealerSuitClubs";
            this.ucDealerSuitClubs.Size = new System.Drawing.Size(600, 40);
            this.ucDealerSuitClubs.TabIndex = 9;
            // 
            // lstDealerHand
            // 
            this.lstDealerHand.FormattingEnabled = true;
            this.lstDealerHand.ItemHeight = 15;
            this.lstDealerHand.Location = new System.Drawing.Point(612, 22);
            this.lstDealerHand.Name = "lstDealerHand";
            this.lstDealerHand.Size = new System.Drawing.Size(288, 64);
            this.lstDealerHand.TabIndex = 8;
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lblAdvantageValue);
            this.gbPlayer.Controls.Add(this.lblAdvantageText);
            this.gbPlayer.Controls.Add(this.ucPlayerSuitClubs);
            this.gbPlayer.Controls.Add(this.lstPlayerHand);
            this.gbPlayer.Controls.Add(this.lblPlayerValue);
            this.gbPlayer.Controls.Add(this.lblPlayerValueText);
            this.gbPlayer.Location = new System.Drawing.Point(12, 115);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(906, 129);
            this.gbPlayer.TabIndex = 8;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // lblAdvantageValue
            // 
            this.lblAdvantageValue.AutoSize = true;
            this.lblAdvantageValue.Location = new System.Drawing.Point(125, 89);
            this.lblAdvantageValue.Name = "lblAdvantageValue";
            this.lblAdvantageValue.Size = new System.Drawing.Size(13, 15);
            this.lblAdvantageValue.TabIndex = 15;
            this.lblAdvantageValue.Text = "0";
            // 
            // lblAdvantageText
            // 
            this.lblAdvantageText.AutoSize = true;
            this.lblAdvantageText.Location = new System.Drawing.Point(6, 89);
            this.lblAdvantageText.Name = "lblAdvantageText";
            this.lblAdvantageText.Size = new System.Drawing.Size(99, 15);
            this.lblAdvantageText.TabIndex = 14;
            this.lblAdvantageText.Text = "Player Advantage";
            // 
            // ucPlayerSuitClubs
            // 
            this.ucPlayerSuitClubs.Location = new System.Drawing.Point(6, 22);
            this.ucPlayerSuitClubs.Name = "ucPlayerSuitClubs";
            this.ucPlayerSuitClubs.Size = new System.Drawing.Size(600, 40);
            this.ucPlayerSuitClubs.TabIndex = 13;
            // 
            // lstPlayerHand
            // 
            this.lstPlayerHand.FormattingEnabled = true;
            this.lstPlayerHand.ItemHeight = 15;
            this.lstPlayerHand.Location = new System.Drawing.Point(612, 19);
            this.lstPlayerHand.Name = "lstPlayerHand";
            this.lstPlayerHand.Size = new System.Drawing.Size(288, 94);
            this.lstPlayerHand.TabIndex = 6;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Location = new System.Drawing.Point(125, 65);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(0, 15);
            this.lblPlayerValue.TabIndex = 5;
            // 
            // lblPlayerValueText
            // 
            this.lblPlayerValueText.AutoSize = true;
            this.lblPlayerValueText.Location = new System.Drawing.Point(6, 65);
            this.lblPlayerValueText.Name = "lblPlayerValueText";
            this.lblPlayerValueText.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerValueText.TabIndex = 4;
            this.lblPlayerValueText.Text = "Player Value";
            // 
            // lblWhatDo
            // 
            this.lblWhatDo.AutoSize = true;
            this.lblWhatDo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhatDo.Location = new System.Drawing.Point(293, 386);
            this.lblWhatDo.Name = "lblWhatDo";
            this.lblWhatDo.Size = new System.Drawing.Size(0, 25);
            this.lblWhatDo.TabIndex = 9;
            // 
            // gbDeck
            // 
            this.gbDeck.Controls.Add(this.lblAProbability);
            this.gbDeck.Controls.Add(this.lbl2Probability);
            this.gbDeck.Controls.Add(this.lbl3Probability);
            this.gbDeck.Controls.Add(this.lbl4Probability);
            this.gbDeck.Controls.Add(this.lbl5Probability);
            this.gbDeck.Controls.Add(this.lbl6Probability);
            this.gbDeck.Controls.Add(this.lbl7Probability);
            this.gbDeck.Controls.Add(this.lbl8Probability);
            this.gbDeck.Controls.Add(this.lbl9Probability);
            this.gbDeck.Controls.Add(this.lbl10Probability);
            this.gbDeck.Controls.Add(this.lbl10InDeck);
            this.gbDeck.Controls.Add(this.lbl9InDeck);
            this.gbDeck.Controls.Add(this.lbl8InDeck);
            this.gbDeck.Controls.Add(this.lbl7InDeck);
            this.gbDeck.Controls.Add(this.lbl6InDeck);
            this.gbDeck.Controls.Add(this.lbl5InDeck);
            this.gbDeck.Controls.Add(this.lbl4InDeck);
            this.gbDeck.Controls.Add(this.lbl3InDeck);
            this.gbDeck.Controls.Add(this.lbl2InDeck);
            this.gbDeck.Controls.Add(this.lblAInDeck);
            this.gbDeck.Controls.Add(this.lblTotalInDeckValue);
            this.gbDeck.Controls.Add(this.lblTotalInDeckText);
            this.gbDeck.Controls.Add(this.lblProbabilityText);
            this.gbDeck.Controls.Add(this.lblEachLeftInDeckText);
            this.gbDeck.Controls.Add(this.btn10Count);
            this.gbDeck.Controls.Add(this.btn9Count);
            this.gbDeck.Controls.Add(this.btn8Count);
            this.gbDeck.Controls.Add(this.btn7Count);
            this.gbDeck.Controls.Add(this.btn6Count);
            this.gbDeck.Controls.Add(this.btn5Count);
            this.gbDeck.Controls.Add(this.btn4Count);
            this.gbDeck.Controls.Add(this.btn3Count);
            this.gbDeck.Controls.Add(this.btn2Count);
            this.gbDeck.Controls.Add(this.btnACount);
            this.gbDeck.Location = new System.Drawing.Point(12, 250);
            this.gbDeck.Name = "gbDeck";
            this.gbDeck.Size = new System.Drawing.Size(900, 132);
            this.gbDeck.TabIndex = 10;
            this.gbDeck.TabStop = false;
            this.gbDeck.Text = "Deck";
            // 
            // lblAProbability
            // 
            this.lblAProbability.AutoSize = true;
            this.lblAProbability.Location = new System.Drawing.Point(149, 84);
            this.lblAProbability.Name = "lblAProbability";
            this.lblAProbability.Size = new System.Drawing.Size(0, 15);
            this.lblAProbability.TabIndex = 33;
            // 
            // lbl2Probability
            // 
            this.lbl2Probability.AutoSize = true;
            this.lbl2Probability.Location = new System.Drawing.Point(195, 84);
            this.lbl2Probability.Name = "lbl2Probability";
            this.lbl2Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl2Probability.TabIndex = 32;
            // 
            // lbl3Probability
            // 
            this.lbl3Probability.AutoSize = true;
            this.lbl3Probability.Location = new System.Drawing.Point(241, 84);
            this.lbl3Probability.Name = "lbl3Probability";
            this.lbl3Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl3Probability.TabIndex = 31;
            // 
            // lbl4Probability
            // 
            this.lbl4Probability.AutoSize = true;
            this.lbl4Probability.Location = new System.Drawing.Point(287, 84);
            this.lbl4Probability.Name = "lbl4Probability";
            this.lbl4Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl4Probability.TabIndex = 30;
            // 
            // lbl5Probability
            // 
            this.lbl5Probability.AutoSize = true;
            this.lbl5Probability.Location = new System.Drawing.Point(333, 84);
            this.lbl5Probability.Name = "lbl5Probability";
            this.lbl5Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl5Probability.TabIndex = 29;
            // 
            // lbl6Probability
            // 
            this.lbl6Probability.AutoSize = true;
            this.lbl6Probability.Location = new System.Drawing.Point(382, 84);
            this.lbl6Probability.Name = "lbl6Probability";
            this.lbl6Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl6Probability.TabIndex = 28;
            // 
            // lbl7Probability
            // 
            this.lbl7Probability.AutoSize = true;
            this.lbl7Probability.Location = new System.Drawing.Point(428, 84);
            this.lbl7Probability.Name = "lbl7Probability";
            this.lbl7Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl7Probability.TabIndex = 27;
            // 
            // lbl8Probability
            // 
            this.lbl8Probability.AutoSize = true;
            this.lbl8Probability.Location = new System.Drawing.Point(474, 84);
            this.lbl8Probability.Name = "lbl8Probability";
            this.lbl8Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl8Probability.TabIndex = 26;
            // 
            // lbl9Probability
            // 
            this.lbl9Probability.AutoSize = true;
            this.lbl9Probability.Location = new System.Drawing.Point(520, 84);
            this.lbl9Probability.Name = "lbl9Probability";
            this.lbl9Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl9Probability.TabIndex = 25;
            // 
            // lbl10Probability
            // 
            this.lbl10Probability.AutoSize = true;
            this.lbl10Probability.Location = new System.Drawing.Point(566, 84);
            this.lbl10Probability.Name = "lbl10Probability";
            this.lbl10Probability.Size = new System.Drawing.Size(0, 15);
            this.lbl10Probability.TabIndex = 24;
            // 
            // lbl10InDeck
            // 
            this.lbl10InDeck.AutoSize = true;
            this.lbl10InDeck.Location = new System.Drawing.Point(566, 59);
            this.lbl10InDeck.Name = "lbl10InDeck";
            this.lbl10InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl10InDeck.TabIndex = 23;
            // 
            // lbl9InDeck
            // 
            this.lbl9InDeck.AutoSize = true;
            this.lbl9InDeck.Location = new System.Drawing.Point(520, 59);
            this.lbl9InDeck.Name = "lbl9InDeck";
            this.lbl9InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl9InDeck.TabIndex = 22;
            // 
            // lbl8InDeck
            // 
            this.lbl8InDeck.AutoSize = true;
            this.lbl8InDeck.Location = new System.Drawing.Point(474, 59);
            this.lbl8InDeck.Name = "lbl8InDeck";
            this.lbl8InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl8InDeck.TabIndex = 21;
            // 
            // lbl7InDeck
            // 
            this.lbl7InDeck.AutoSize = true;
            this.lbl7InDeck.Location = new System.Drawing.Point(428, 59);
            this.lbl7InDeck.Name = "lbl7InDeck";
            this.lbl7InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl7InDeck.TabIndex = 20;
            // 
            // lbl6InDeck
            // 
            this.lbl6InDeck.AutoSize = true;
            this.lbl6InDeck.Location = new System.Drawing.Point(382, 59);
            this.lbl6InDeck.Name = "lbl6InDeck";
            this.lbl6InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl6InDeck.TabIndex = 19;
            // 
            // lbl5InDeck
            // 
            this.lbl5InDeck.AutoSize = true;
            this.lbl5InDeck.Location = new System.Drawing.Point(333, 59);
            this.lbl5InDeck.Name = "lbl5InDeck";
            this.lbl5InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl5InDeck.TabIndex = 18;
            // 
            // lbl4InDeck
            // 
            this.lbl4InDeck.AutoSize = true;
            this.lbl4InDeck.Location = new System.Drawing.Point(287, 59);
            this.lbl4InDeck.Name = "lbl4InDeck";
            this.lbl4InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl4InDeck.TabIndex = 17;
            // 
            // lbl3InDeck
            // 
            this.lbl3InDeck.AutoSize = true;
            this.lbl3InDeck.Location = new System.Drawing.Point(241, 59);
            this.lbl3InDeck.Name = "lbl3InDeck";
            this.lbl3InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl3InDeck.TabIndex = 16;
            // 
            // lbl2InDeck
            // 
            this.lbl2InDeck.AutoSize = true;
            this.lbl2InDeck.Location = new System.Drawing.Point(195, 59);
            this.lbl2InDeck.Name = "lbl2InDeck";
            this.lbl2InDeck.Size = new System.Drawing.Size(0, 15);
            this.lbl2InDeck.TabIndex = 15;
            // 
            // lblAInDeck
            // 
            this.lblAInDeck.AutoSize = true;
            this.lblAInDeck.Location = new System.Drawing.Point(149, 59);
            this.lblAInDeck.Name = "lblAInDeck";
            this.lblAInDeck.Size = new System.Drawing.Size(0, 15);
            this.lblAInDeck.TabIndex = 14;
            // 
            // lblTotalInDeckValue
            // 
            this.lblTotalInDeckValue.AutoSize = true;
            this.lblTotalInDeckValue.Location = new System.Drawing.Point(80, 19);
            this.lblTotalInDeckValue.Name = "lblTotalInDeckValue";
            this.lblTotalInDeckValue.Size = new System.Drawing.Size(0, 15);
            this.lblTotalInDeckValue.TabIndex = 13;
            // 
            // lblTotalInDeckText
            // 
            this.lblTotalInDeckText.AutoSize = true;
            this.lblTotalInDeckText.Location = new System.Drawing.Point(6, 19);
            this.lblTotalInDeckText.Name = "lblTotalInDeckText";
            this.lblTotalInDeckText.Size = new System.Drawing.Size(55, 15);
            this.lblTotalInDeckText.TabIndex = 12;
            this.lblTotalInDeckText.Text = "Total Left";
            // 
            // lblProbabilityText
            // 
            this.lblProbabilityText.AutoSize = true;
            this.lblProbabilityText.Location = new System.Drawing.Point(61, 84);
            this.lblProbabilityText.Name = "lblProbabilityText";
            this.lblProbabilityText.Size = new System.Drawing.Size(64, 15);
            this.lblProbabilityText.TabIndex = 11;
            this.lblProbabilityText.Text = "Probability";
            // 
            // lblEachLeftInDeckText
            // 
            this.lblEachLeftInDeckText.AutoSize = true;
            this.lblEachLeftInDeckText.Location = new System.Drawing.Point(56, 59);
            this.lblEachLeftInDeckText.Name = "lblEachLeftInDeckText";
            this.lblEachLeftInDeckText.Size = new System.Drawing.Size(69, 15);
            this.lblEachLeftInDeckText.TabIndex = 10;
            this.lblEachLeftInDeckText.Text = "Left In Deck";
            // 
            // btn10Count
            // 
            this.btn10Count.Enabled = false;
            this.btn10Count.Location = new System.Drawing.Point(566, 22);
            this.btn10Count.Name = "btn10Count";
            this.btn10Count.Size = new System.Drawing.Size(40, 34);
            this.btn10Count.TabIndex = 9;
            this.btn10Count.Text = "10";
            this.btn10Count.UseVisualStyleBackColor = true;
            // 
            // btn9Count
            // 
            this.btn9Count.Enabled = false;
            this.btn9Count.Location = new System.Drawing.Point(520, 22);
            this.btn9Count.Name = "btn9Count";
            this.btn9Count.Size = new System.Drawing.Size(40, 34);
            this.btn9Count.TabIndex = 8;
            this.btn9Count.Text = "9";
            this.btn9Count.UseVisualStyleBackColor = true;
            // 
            // btn8Count
            // 
            this.btn8Count.Enabled = false;
            this.btn8Count.Location = new System.Drawing.Point(474, 22);
            this.btn8Count.Name = "btn8Count";
            this.btn8Count.Size = new System.Drawing.Size(40, 34);
            this.btn8Count.TabIndex = 7;
            this.btn8Count.Text = "8";
            this.btn8Count.UseVisualStyleBackColor = true;
            // 
            // btn7Count
            // 
            this.btn7Count.Enabled = false;
            this.btn7Count.Location = new System.Drawing.Point(428, 22);
            this.btn7Count.Name = "btn7Count";
            this.btn7Count.Size = new System.Drawing.Size(40, 34);
            this.btn7Count.TabIndex = 6;
            this.btn7Count.Text = "7";
            this.btn7Count.UseVisualStyleBackColor = true;
            // 
            // btn6Count
            // 
            this.btn6Count.Enabled = false;
            this.btn6Count.Location = new System.Drawing.Point(382, 22);
            this.btn6Count.Name = "btn6Count";
            this.btn6Count.Size = new System.Drawing.Size(40, 34);
            this.btn6Count.TabIndex = 5;
            this.btn6Count.Text = "6";
            this.btn6Count.UseVisualStyleBackColor = true;
            // 
            // btn5Count
            // 
            this.btn5Count.Enabled = false;
            this.btn5Count.Location = new System.Drawing.Point(333, 22);
            this.btn5Count.Name = "btn5Count";
            this.btn5Count.Size = new System.Drawing.Size(40, 34);
            this.btn5Count.TabIndex = 4;
            this.btn5Count.Text = "5";
            this.btn5Count.UseVisualStyleBackColor = true;
            // 
            // btn4Count
            // 
            this.btn4Count.Enabled = false;
            this.btn4Count.Location = new System.Drawing.Point(287, 22);
            this.btn4Count.Name = "btn4Count";
            this.btn4Count.Size = new System.Drawing.Size(40, 34);
            this.btn4Count.TabIndex = 3;
            this.btn4Count.Text = "4";
            this.btn4Count.UseVisualStyleBackColor = true;
            // 
            // btn3Count
            // 
            this.btn3Count.Enabled = false;
            this.btn3Count.Location = new System.Drawing.Point(241, 22);
            this.btn3Count.Name = "btn3Count";
            this.btn3Count.Size = new System.Drawing.Size(40, 34);
            this.btn3Count.TabIndex = 2;
            this.btn3Count.Text = "3";
            this.btn3Count.UseVisualStyleBackColor = true;
            // 
            // btn2Count
            // 
            this.btn2Count.Enabled = false;
            this.btn2Count.Location = new System.Drawing.Point(195, 22);
            this.btn2Count.Name = "btn2Count";
            this.btn2Count.Size = new System.Drawing.Size(40, 34);
            this.btn2Count.TabIndex = 1;
            this.btn2Count.Text = "2";
            this.btn2Count.UseVisualStyleBackColor = true;
            // 
            // btnACount
            // 
            this.btnACount.Enabled = false;
            this.btnACount.Location = new System.Drawing.Point(149, 22);
            this.btnACount.Name = "btnACount";
            this.btnACount.Size = new System.Drawing.Size(40, 34);
            this.btnACount.TabIndex = 0;
            this.btnACount.Text = "A";
            this.btnACount.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 423);
            this.Controls.Add(this.gbDeck);
            this.Controls.Add(this.lblWhatDo);
            this.Controls.Add(this.gbPlayer);
            this.Controls.Add(this.gbDealer);
            this.Controls.Add(this.btnNewHand);
            this.Controls.Add(this.btnNewDeck);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gbDealer.ResumeLayout(false);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbDeck.ResumeLayout(false);
            this.gbDeck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewDeck;
        private Button btnNewHand;
        private GroupBox gbDealer;
        private ListBox lstDealerHand;
        private GroupBox gbPlayer;
        private ListBox lstPlayerHand;
        private Label lblPlayerValue;
        private Label lblPlayerValueText;
        private Controls.Suit ucDealerSuitClubs;
        private Controls.Suit ucPlayerSuitClubs;
        private Label lblAdvantageText;
        private Label lblAdvantageValue;
        private Label lblWhatDo;
        private GroupBox gbDeck;
        private Button btnACount;
        private Button btn10Count;
        private Button btn9Count;
        private Button btn8Count;
        private Button btn7Count;
        private Button btn6Count;
        private Button btn5Count;
        private Button btn4Count;
        private Button btn3Count;
        private Button btn2Count;
        private Label lblAInDeck;
        private Label lblTotalInDeckValue;
        private Label lblTotalInDeckText;
        private Label lblProbabilityText;
        private Label lblEachLeftInDeckText;
        private Label lbl10Probability;
        private Label lbl10InDeck;
        private Label lbl9InDeck;
        private Label lbl8InDeck;
        private Label lbl7InDeck;
        private Label lbl6InDeck;
        private Label lbl5InDeck;
        private Label lbl4InDeck;
        private Label lbl3InDeck;
        private Label lbl2InDeck;
        private Label lblAProbability;
        private Label lbl2Probability;
        private Label lbl3Probability;
        private Label lbl4Probability;
        private Label lbl5Probability;
        private Label lbl6Probability;
        private Label lbl7Probability;
        private Label lbl8Probability;
        private Label lbl9Probability;
    }
}