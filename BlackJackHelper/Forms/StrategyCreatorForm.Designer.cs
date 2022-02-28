namespace BlackJackHelper.Forms
{
    partial class StrategyCreatorForm
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
            this.dgvHard = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.PlayerVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealer2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dealer10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHard
            // 
            this.dgvHard.AllowUserToAddRows = false;
            this.dgvHard.AllowUserToDeleteRows = false;
            this.dgvHard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerVal,
            this.Dealer2,
            this.Dealer3,
            this.Dealer4,
            this.Dealer5,
            this.Dealer6,
            this.Dealer7,
            this.Dealer8,
            this.Dealer9,
            this.Dealer10});
            this.dgvHard.Location = new System.Drawing.Point(6, 22);
            this.dgvHard.Name = "dgvHard";
            this.dgvHard.RowTemplate.Height = 25;
            this.dgvHard.Size = new System.Drawing.Size(1051, 393);
            this.dgvHard.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHard);
            this.groupBox1.Location = new System.Drawing.Point(83, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dealer Upcard";
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.AutoSize = true;
            this.lblPlayerValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerValue.Location = new System.Drawing.Point(5, 224);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(72, 32);
            this.lblPlayerValue.TabIndex = 2;
            this.lblPlayerValue.Text = "Value";
            // 
            // PlayerVal
            // 
            this.PlayerVal.HeaderText = "PlayerVal";
            this.PlayerVal.Name = "PlayerVal";
            this.PlayerVal.ReadOnly = true;
            // 
            // Dealer2
            // 
            this.Dealer2.HeaderText = "2";
            this.Dealer2.Name = "Dealer2";
            // 
            // Dealer3
            // 
            this.Dealer3.HeaderText = "3";
            this.Dealer3.Name = "Dealer3";
            // 
            // Dealer4
            // 
            this.Dealer4.HeaderText = "4";
            this.Dealer4.Name = "Dealer4";
            // 
            // Dealer5
            // 
            this.Dealer5.HeaderText = "5";
            this.Dealer5.Name = "Dealer5";
            // 
            // Dealer6
            // 
            this.Dealer6.HeaderText = "6";
            this.Dealer6.Name = "Dealer6";
            // 
            // Dealer7
            // 
            this.Dealer7.HeaderText = "7";
            this.Dealer7.Name = "Dealer7";
            // 
            // Dealer8
            // 
            this.Dealer8.HeaderText = "8";
            this.Dealer8.Name = "Dealer8";
            // 
            // Dealer9
            // 
            this.Dealer9.HeaderText = "9";
            this.Dealer9.Name = "Dealer9";
            // 
            // Dealer10
            // 
            this.Dealer10.HeaderText = "10";
            this.Dealer10.Name = "Dealer10";
            // 
            // StrategyCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPlayerValue);
            this.Name = "StrategyCreatorForm";
            this.Text = "StrategyCreatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvHard;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblPlayerValue;
        private DataGridViewTextBoxColumn PlayerVal;
        private DataGridViewComboBoxColumn Dealer2;
        private DataGridViewComboBoxColumn Dealer3;
        private DataGridViewComboBoxColumn Dealer4;
        private DataGridViewComboBoxColumn Dealer5;
        private DataGridViewComboBoxColumn Dealer6;
        private DataGridViewComboBoxColumn Dealer7;
        private DataGridViewComboBoxColumn Dealer8;
        private DataGridViewComboBoxColumn Dealer9;
        private DataGridViewComboBoxColumn Dealer10;
    }
}