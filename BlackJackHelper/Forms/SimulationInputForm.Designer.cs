namespace BlackJackHelper.Forms
{
    partial class SimulationInputForm
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
            this.btnSimulate = new System.Windows.Forms.Button();
            this.txtInitialBank = new System.Windows.Forms.TextBox();
            this.txtAmountPerBet = new System.Windows.Forms.TextBox();
            this.txtHandsToPlay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(298, 99);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnSimulate.TabIndex = 0;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // txtInitialBank
            // 
            this.txtInitialBank.Location = new System.Drawing.Point(273, 12);
            this.txtInitialBank.Name = "txtInitialBank";
            this.txtInitialBank.Size = new System.Drawing.Size(100, 23);
            this.txtInitialBank.TabIndex = 1;
            // 
            // txtAmountPerBet
            // 
            this.txtAmountPerBet.Location = new System.Drawing.Point(273, 41);
            this.txtAmountPerBet.Name = "txtAmountPerBet";
            this.txtAmountPerBet.Size = new System.Drawing.Size(100, 23);
            this.txtAmountPerBet.TabIndex = 2;
            // 
            // txtHandsToPlay
            // 
            this.txtHandsToPlay.Location = new System.Drawing.Point(273, 70);
            this.txtHandsToPlay.Name = "txtHandsToPlay";
            this.txtHandsToPlay.Size = new System.Drawing.Size(100, 23);
            this.txtHandsToPlay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Initial Bankroll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount Per Bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hands To Play";
            // 
            // SimulationInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHandsToPlay);
            this.Controls.Add(this.txtAmountPerBet);
            this.Controls.Add(this.txtInitialBank);
            this.Controls.Add(this.btnSimulate);
            this.Name = "SimulationInputForm";
            this.Text = "SimulationInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSimulate;
        private TextBox txtInitialBank;
        private TextBox txtAmountPerBet;
        private TextBox txtHandsToPlay;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}