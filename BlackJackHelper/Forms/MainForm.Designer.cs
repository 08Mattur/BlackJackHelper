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
            this.ucDealerSuitSpades = new BlackJackHelper.Controls.Suit();
            this.ucDealerSuitHearts = new BlackJackHelper.Controls.Suit();
            this.ucDealerSuitDiamonds = new BlackJackHelper.Controls.Suit();
            this.ucDealerSuitClubs = new BlackJackHelper.Controls.Suit();
            this.lstDealerHand = new System.Windows.Forms.ListBox();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblPlayerValueText = new System.Windows.Forms.Label();
            this.lblWhatDo = new System.Windows.Forms.Label();
            this.btnWhatDo = new System.Windows.Forms.Button();
            this.ucPlayerSuitClubs = new BlackJackHelper.Controls.Suit();
            this.ucPlayerSuitDiamonds = new BlackJackHelper.Controls.Suit();
            this.ucPlayerSuitHearts = new BlackJackHelper.Controls.Suit();
            this.ucPlayerSuitSpades = new BlackJackHelper.Controls.Suit();
            this.gbDealer.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(12, 473);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeck.TabIndex = 0;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.UseVisualStyleBackColor = true;
            // 
            // btnNewHand
            // 
            this.btnNewHand.Location = new System.Drawing.Point(843, 473);
            this.btnNewHand.Name = "btnNewHand";
            this.btnNewHand.Size = new System.Drawing.Size(75, 23);
            this.btnNewHand.TabIndex = 1;
            this.btnNewHand.Text = "New Hand";
            this.btnNewHand.UseVisualStyleBackColor = true;
            this.btnNewHand.Click += new System.EventHandler(this.btnNewHand_Click);
            // 
            // gbDealer
            // 
            this.gbDealer.Controls.Add(this.ucDealerSuitSpades);
            this.gbDealer.Controls.Add(this.ucDealerSuitHearts);
            this.gbDealer.Controls.Add(this.ucDealerSuitDiamonds);
            this.gbDealer.Controls.Add(this.ucDealerSuitClubs);
            this.gbDealer.Controls.Add(this.lstDealerHand);
            this.gbDealer.Location = new System.Drawing.Point(12, 12);
            this.gbDealer.Name = "gbDealer";
            this.gbDealer.Size = new System.Drawing.Size(906, 210);
            this.gbDealer.TabIndex = 7;
            this.gbDealer.TabStop = false;
            this.gbDealer.Text = "Dealer";
            // 
            // ucDealerSuitSpades
            // 
            this.ucDealerSuitSpades.Location = new System.Drawing.Point(6, 160);
            this.ucDealerSuitSpades.Name = "ucDealerSuitSpades";
            this.ucDealerSuitSpades.Size = new System.Drawing.Size(600, 40);
            this.ucDealerSuitSpades.TabIndex = 12;
            // 
            // ucDealerSuitHearts
            // 
            this.ucDealerSuitHearts.Location = new System.Drawing.Point(6, 114);
            this.ucDealerSuitHearts.Name = "ucDealerSuitHearts";
            this.ucDealerSuitHearts.Size = new System.Drawing.Size(600, 40);
            this.ucDealerSuitHearts.TabIndex = 11;
            // 
            // ucDealerSuitDiamonds
            // 
            this.ucDealerSuitDiamonds.Location = new System.Drawing.Point(6, 68);
            this.ucDealerSuitDiamonds.Name = "ucDealerSuitDiamonds";
            this.ucDealerSuitDiamonds.Size = new System.Drawing.Size(600, 40);
            this.ucDealerSuitDiamonds.TabIndex = 10;
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
            this.lstDealerHand.Size = new System.Drawing.Size(288, 109);
            this.lstDealerHand.TabIndex = 8;
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.ucPlayerSuitSpades);
            this.gbPlayer.Controls.Add(this.ucPlayerSuitHearts);
            this.gbPlayer.Controls.Add(this.ucPlayerSuitDiamonds);
            this.gbPlayer.Controls.Add(this.ucPlayerSuitClubs);
            this.gbPlayer.Controls.Add(this.lstPlayerHand);
            this.gbPlayer.Controls.Add(this.lblPlayerValue);
            this.gbPlayer.Controls.Add(this.lblPlayerValueText);
            this.gbPlayer.Location = new System.Drawing.Point(12, 228);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(906, 201);
            this.gbPlayer.TabIndex = 8;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // lstPlayerHand
            // 
            this.lstPlayerHand.FormattingEnabled = true;
            this.lstPlayerHand.ItemHeight = 15;
            this.lstPlayerHand.Location = new System.Drawing.Point(612, 19);
            this.lstPlayerHand.Name = "lstPlayerHand";
            this.lstPlayerHand.Size = new System.Drawing.Size(288, 109);
            this.lstPlayerHand.TabIndex = 6;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Location = new System.Drawing.Point(709, 131);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(13, 15);
            this.lblPlayerValue.TabIndex = 5;
            this.lblPlayerValue.Text = "0";
            // 
            // lblPlayerValueText
            // 
            this.lblPlayerValueText.AutoSize = true;
            this.lblPlayerValueText.Location = new System.Drawing.Point(612, 131);
            this.lblPlayerValueText.Name = "lblPlayerValueText";
            this.lblPlayerValueText.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerValueText.TabIndex = 4;
            this.lblPlayerValueText.Text = "Player Value";
            // 
            // lblWhatDo
            // 
            this.lblWhatDo.AutoSize = true;
            this.lblWhatDo.Location = new System.Drawing.Point(591, 473);
            this.lblWhatDo.Name = "lblWhatDo";
            this.lblWhatDo.Size = new System.Drawing.Size(0, 15);
            this.lblWhatDo.TabIndex = 9;
            // 
            // btnWhatDo
            // 
            this.btnWhatDo.Location = new System.Drawing.Point(325, 469);
            this.btnWhatDo.Name = "btnWhatDo";
            this.btnWhatDo.Size = new System.Drawing.Size(75, 23);
            this.btnWhatDo.TabIndex = 10;
            this.btnWhatDo.Text = "What Do";
            this.btnWhatDo.UseVisualStyleBackColor = true;
            this.btnWhatDo.Click += new System.EventHandler(this.btnWhatDo_Click);
            // 
            // ucPlayerSuitClubs
            // 
            this.ucPlayerSuitClubs.Location = new System.Drawing.Point(6, 22);
            this.ucPlayerSuitClubs.Name = "ucPlayerSuitClubs";
            this.ucPlayerSuitClubs.Size = new System.Drawing.Size(600, 40);
            this.ucPlayerSuitClubs.TabIndex = 13;
            // 
            // ucPlayerSuitDiamonds
            // 
            this.ucPlayerSuitDiamonds.Location = new System.Drawing.Point(6, 68);
            this.ucPlayerSuitDiamonds.Name = "ucPlayerSuitDiamonds";
            this.ucPlayerSuitDiamonds.Size = new System.Drawing.Size(600, 40);
            this.ucPlayerSuitDiamonds.TabIndex = 14;
            // 
            // ucPlayerSuitHearts
            // 
            this.ucPlayerSuitHearts.Location = new System.Drawing.Point(6, 114);
            this.ucPlayerSuitHearts.Name = "ucPlayerSuitHearts";
            this.ucPlayerSuitHearts.Size = new System.Drawing.Size(600, 40);
            this.ucPlayerSuitHearts.TabIndex = 15;
            // 
            // ucPlayerSuitSpades
            // 
            this.ucPlayerSuitSpades.Location = new System.Drawing.Point(6, 155);
            this.ucPlayerSuitSpades.Name = "ucPlayerSuitSpades";
            this.ucPlayerSuitSpades.Size = new System.Drawing.Size(600, 40);
            this.ucPlayerSuitSpades.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.btnWhatDo);
            this.Controls.Add(this.lblWhatDo);
            this.Controls.Add(this.gbPlayer);
            this.Controls.Add(this.gbDealer);
            this.Controls.Add(this.btnNewHand);
            this.Controls.Add(this.btnNewDeck);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbDealer.ResumeLayout(false);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
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
        private Label lblWhatDo;
        private Button btnWhatDo;
        private Controls.Suit ucDealerSuitSpades;
        private Controls.Suit ucDealerSuitHearts;
        private Controls.Suit ucDealerSuitDiamonds;
        private Controls.Suit ucDealerSuitClubs;
        private Controls.Suit ucPlayerSuitSpades;
        private Controls.Suit ucPlayerSuitHearts;
        private Controls.Suit ucPlayerSuitDiamonds;
        private Controls.Suit ucPlayerSuitClubs;
    }
}