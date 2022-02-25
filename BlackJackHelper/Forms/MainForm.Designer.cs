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
            this.lblWhatDo = new System.Windows.Forms.Label();
            this.ucPlayerSuitClubs = new BlackJackHelper.Controls.Suit();
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblPlayerValueText = new System.Windows.Forms.Label();
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
            this.gbPlayer.Controls.Add(this.lblWhatDo);
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
            // lblWhatDo
            // 
            this.lblWhatDo.AutoSize = true;
            this.lblWhatDo.Location = new System.Drawing.Point(612, 155);
            this.lblWhatDo.Name = "lblWhatDo";
            this.lblWhatDo.Size = new System.Drawing.Size(0, 15);
            this.lblWhatDo.TabIndex = 9;
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
            this.lstPlayerHand.Size = new System.Drawing.Size(288, 109);
            this.lstPlayerHand.TabIndex = 6;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Location = new System.Drawing.Point(709, 131);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(0, 15);
            this.lblPlayerValue.TabIndex = 5;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 503);
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
            this.ResumeLayout(false);

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
        private Controls.Suit ucDealerSuitClubs;
        private Controls.Suit ucPlayerSuitClubs;
    }
}