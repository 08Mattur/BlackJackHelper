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
            this.lblDealerHand = new System.Windows.Forms.Label();
            this.cmbDealerFace = new System.Windows.Forms.ComboBox();
            this.cmbDealerSuit = new System.Windows.Forms.ComboBox();
            this.btnAddDealerCard = new System.Windows.Forms.Button();
            this.lblDealerValueText = new System.Windows.Forms.Label();
            this.gbDealer = new System.Windows.Forms.GroupBox();
            this.lstDealerHand = new System.Windows.Forms.ListBox();
            this.lblDealerValue = new System.Windows.Forms.Label();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblPlayerValueText = new System.Windows.Forms.Label();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.btnAddPlayerCard = new System.Windows.Forms.Button();
            this.cmbPlayerSuit = new System.Windows.Forms.ComboBox();
            this.cmbPlayerFace = new System.Windows.Forms.ComboBox();
            this.lblWhatDo = new System.Windows.Forms.Label();
            this.btnWhatDo = new System.Windows.Forms.Button();
            this.gbDealer.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewDeck
            // 
            this.btnNewDeck.Location = new System.Drawing.Point(12, 415);
            this.btnNewDeck.Name = "btnNewDeck";
            this.btnNewDeck.Size = new System.Drawing.Size(75, 23);
            this.btnNewDeck.TabIndex = 0;
            this.btnNewDeck.Text = "New Deck";
            this.btnNewDeck.UseVisualStyleBackColor = true;
            // 
            // btnNewHand
            // 
            this.btnNewHand.Location = new System.Drawing.Point(713, 415);
            this.btnNewHand.Name = "btnNewHand";
            this.btnNewHand.Size = new System.Drawing.Size(75, 23);
            this.btnNewHand.TabIndex = 1;
            this.btnNewHand.Text = "New Hand";
            this.btnNewHand.UseVisualStyleBackColor = true;
            this.btnNewHand.Click += new System.EventHandler(this.btnNewHand_Click);
            // 
            // lblDealerHand
            // 
            this.lblDealerHand.AutoSize = true;
            this.lblDealerHand.Location = new System.Drawing.Point(6, 19);
            this.lblDealerHand.Name = "lblDealerHand";
            this.lblDealerHand.Size = new System.Drawing.Size(72, 15);
            this.lblDealerHand.TabIndex = 2;
            this.lblDealerHand.Text = "Dealer Hand";
            // 
            // cmbDealerFace
            // 
            this.cmbDealerFace.FormattingEnabled = true;
            this.cmbDealerFace.Location = new System.Drawing.Point(6, 37);
            this.cmbDealerFace.Name = "cmbDealerFace";
            this.cmbDealerFace.Size = new System.Drawing.Size(121, 23);
            this.cmbDealerFace.TabIndex = 3;
            // 
            // cmbDealerSuit
            // 
            this.cmbDealerSuit.FormattingEnabled = true;
            this.cmbDealerSuit.Location = new System.Drawing.Point(133, 37);
            this.cmbDealerSuit.Name = "cmbDealerSuit";
            this.cmbDealerSuit.Size = new System.Drawing.Size(121, 23);
            this.cmbDealerSuit.TabIndex = 4;
            // 
            // btnAddDealerCard
            // 
            this.btnAddDealerCard.Location = new System.Drawing.Point(260, 36);
            this.btnAddDealerCard.Name = "btnAddDealerCard";
            this.btnAddDealerCard.Size = new System.Drawing.Size(81, 24);
            this.btnAddDealerCard.TabIndex = 5;
            this.btnAddDealerCard.Text = "+";
            this.btnAddDealerCard.UseVisualStyleBackColor = true;
            this.btnAddDealerCard.Click += new System.EventHandler(this.btnAddDealerCard_Click);
            // 
            // lblDealerValueText
            // 
            this.lblDealerValueText.AutoSize = true;
            this.lblDealerValueText.Location = new System.Drawing.Point(358, 19);
            this.lblDealerValueText.Name = "lblDealerValueText";
            this.lblDealerValueText.Size = new System.Drawing.Size(71, 15);
            this.lblDealerValueText.TabIndex = 6;
            this.lblDealerValueText.Text = "Dealer Value";
            // 
            // gbDealer
            // 
            this.gbDealer.Controls.Add(this.lstDealerHand);
            this.gbDealer.Controls.Add(this.lblDealerValue);
            this.gbDealer.Controls.Add(this.lblDealerHand);
            this.gbDealer.Controls.Add(this.lblDealerValueText);
            this.gbDealer.Controls.Add(this.cmbDealerFace);
            this.gbDealer.Controls.Add(this.btnAddDealerCard);
            this.gbDealer.Controls.Add(this.cmbDealerSuit);
            this.gbDealer.Location = new System.Drawing.Point(12, 12);
            this.gbDealer.Name = "gbDealer";
            this.gbDealer.Size = new System.Drawing.Size(776, 85);
            this.gbDealer.TabIndex = 7;
            this.gbDealer.TabStop = false;
            this.gbDealer.Text = "Dealer";
            // 
            // lstDealerHand
            // 
            this.lstDealerHand.FormattingEnabled = true;
            this.lstDealerHand.ItemHeight = 15;
            this.lstDealerHand.Location = new System.Drawing.Point(534, 19);
            this.lstDealerHand.Name = "lstDealerHand";
            this.lstDealerHand.Size = new System.Drawing.Size(236, 49);
            this.lstDealerHand.TabIndex = 8;
            // 
            // lblDealerValue
            // 
            this.lblDealerValue.AutoSize = true;
            this.lblDealerValue.Location = new System.Drawing.Point(358, 40);
            this.lblDealerValue.Name = "lblDealerValue";
            this.lblDealerValue.Size = new System.Drawing.Size(13, 15);
            this.lblDealerValue.TabIndex = 7;
            this.lblDealerValue.Text = "0";
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.lstPlayerHand);
            this.gbPlayer.Controls.Add(this.lblPlayerValue);
            this.gbPlayer.Controls.Add(this.lblPlayerValueText);
            this.gbPlayer.Controls.Add(this.lblPlayerHand);
            this.gbPlayer.Controls.Add(this.btnAddPlayerCard);
            this.gbPlayer.Controls.Add(this.cmbPlayerSuit);
            this.gbPlayer.Controls.Add(this.cmbPlayerFace);
            this.gbPlayer.Location = new System.Drawing.Point(12, 103);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(776, 140);
            this.gbPlayer.TabIndex = 8;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // lstPlayerHand
            // 
            this.lstPlayerHand.FormattingEnabled = true;
            this.lstPlayerHand.ItemHeight = 15;
            this.lstPlayerHand.Location = new System.Drawing.Point(534, 19);
            this.lstPlayerHand.Name = "lstPlayerHand";
            this.lstPlayerHand.Size = new System.Drawing.Size(236, 109);
            this.lstPlayerHand.TabIndex = 6;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Location = new System.Drawing.Point(358, 40);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(13, 15);
            this.lblPlayerValue.TabIndex = 5;
            this.lblPlayerValue.Text = "0";
            // 
            // lblPlayerValueText
            // 
            this.lblPlayerValueText.AutoSize = true;
            this.lblPlayerValueText.Location = new System.Drawing.Point(358, 19);
            this.lblPlayerValueText.Name = "lblPlayerValueText";
            this.lblPlayerValueText.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerValueText.TabIndex = 4;
            this.lblPlayerValueText.Text = "Player Value";
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Location = new System.Drawing.Point(6, 19);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(71, 15);
            this.lblPlayerHand.TabIndex = 3;
            this.lblPlayerHand.Text = "Player Hand";
            // 
            // btnAddPlayerCard
            // 
            this.btnAddPlayerCard.Location = new System.Drawing.Point(260, 36);
            this.btnAddPlayerCard.Name = "btnAddPlayerCard";
            this.btnAddPlayerCard.Size = new System.Drawing.Size(81, 23);
            this.btnAddPlayerCard.TabIndex = 2;
            this.btnAddPlayerCard.Text = "+";
            this.btnAddPlayerCard.UseVisualStyleBackColor = true;
            this.btnAddPlayerCard.Click += new System.EventHandler(this.btnAddPlayerCard_Click);
            // 
            // cmbPlayerSuit
            // 
            this.cmbPlayerSuit.FormattingEnabled = true;
            this.cmbPlayerSuit.Location = new System.Drawing.Point(133, 37);
            this.cmbPlayerSuit.Name = "cmbPlayerSuit";
            this.cmbPlayerSuit.Size = new System.Drawing.Size(121, 23);
            this.cmbPlayerSuit.TabIndex = 1;
            // 
            // cmbPlayerFace
            // 
            this.cmbPlayerFace.FormattingEnabled = true;
            this.cmbPlayerFace.Location = new System.Drawing.Point(6, 37);
            this.cmbPlayerFace.Name = "cmbPlayerFace";
            this.cmbPlayerFace.Size = new System.Drawing.Size(121, 23);
            this.cmbPlayerFace.TabIndex = 0;
            // 
            // lblWhatDo
            // 
            this.lblWhatDo.AutoSize = true;
            this.lblWhatDo.Location = new System.Drawing.Point(398, 419);
            this.lblWhatDo.Name = "lblWhatDo";
            this.lblWhatDo.Size = new System.Drawing.Size(0, 15);
            this.lblWhatDo.TabIndex = 9;
            // 
            // btnWhatDo
            // 
            this.btnWhatDo.Location = new System.Drawing.Point(308, 415);
            this.btnWhatDo.Name = "btnWhatDo";
            this.btnWhatDo.Size = new System.Drawing.Size(75, 23);
            this.btnWhatDo.TabIndex = 10;
            this.btnWhatDo.Text = "What Do";
            this.btnWhatDo.UseVisualStyleBackColor = true;
            this.btnWhatDo.Click += new System.EventHandler(this.btnWhatDo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWhatDo);
            this.Controls.Add(this.lblWhatDo);
            this.Controls.Add(this.gbPlayer);
            this.Controls.Add(this.gbDealer);
            this.Controls.Add(this.btnNewHand);
            this.Controls.Add(this.btnNewDeck);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbDealer.ResumeLayout(false);
            this.gbDealer.PerformLayout();
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewDeck;
        private Button btnNewHand;
        private Label lblDealerHand;
        private ComboBox cmbDealerFace;
        private ComboBox cmbDealerSuit;
        private Button btnAddDealerCard;
        private Label lblDealerValueText;
        private GroupBox gbDealer;
        private ListBox lstDealerHand;
        private Label lblDealerValue;
        private GroupBox gbPlayer;
        private ListBox lstPlayerHand;
        private Label lblPlayerValue;
        private Label lblPlayerValueText;
        private Label lblPlayerHand;
        private Button btnAddPlayerCard;
        private ComboBox cmbPlayerSuit;
        private ComboBox cmbPlayerFace;
        private Label lblWhatDo;
        private Button btnWhatDo;
    }
}