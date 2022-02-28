namespace BlackJackHelper.Forms
{
    partial class SimulationResultForm
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
            this.lblEndResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEndResult
            // 
            this.lblEndResult.AutoSize = true;
            this.lblEndResult.Location = new System.Drawing.Point(14, 8);
            this.lblEndResult.Name = "lblEndResult";
            this.lblEndResult.Size = new System.Drawing.Size(13, 15);
            this.lblEndResult.TabIndex = 0;
            this.lblEndResult.Text = "0";
            // 
            // SimulationResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEndResult);
            this.Name = "SimulationResultForm";
            this.Text = "SimulationResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEndResult;
    }
}