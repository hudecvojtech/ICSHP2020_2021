namespace Excercise04
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 108;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(800, 146);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameListBox_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accuracyLabel,
            this.difficultyLabel,
            this.difficultProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 124);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(46, 17);
            this.correctLabel.Text = "Correct";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(44, 17);
            this.missedLabel.Text = "Missed";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(56, 17);
            this.accuracyLabel.Text = "Accuracy";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(506, 17);
            this.difficultyLabel.Spring = true;
            this.difficultyLabel.Text = "Difficulty";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultProgressBar
            // 
            this.difficultProgressBar.Maximum = 800;
            this.difficultProgressBar.Name = "difficultProgressBar";
            this.difficultProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 146);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;
        private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

