using System;
using System.Windows.Forms;

namespace Excercise04
{
    public partial class Form1 : Form
    {
        Random random;
        Stats stats;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            stats = new Stats();
            stats.UpdatedStats += UpdatedStatsHandler;
        }

        private void UpdatedStatsHandler(object sender, EventArgs e)
        {
            correctLabel.Text = "Correct: " + stats.Correct.ToString();
            missedLabel.Text = "Missed: " + stats.Missed.ToString();
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameListBox.Items.Add((Keys)random.Next('A', 'Z'));
            if (gameListBox.Items.Count >= 6)
            {
                timer1.Stop();
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over");
            }
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameListBox.Items.Contains(e.KeyCode))
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();

                if (timer1.Interval > 400)
                {
                    timer1.Interval -= 60;
                }
                else if (timer1.Interval > 250)
                {
                    timer1.Interval -= 15;
                }
                else if (timer1.Interval > 150)
                {
                    timer1.Interval -= 8;
                }

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            if (timer1.Interval > 0 && timer1.Interval < 800)
            {
                difficultProgressBar.Value = 800 - timer1.Interval;
            }
            else
            {
                difficultProgressBar.Value = 0;
            }
        }
    }
}
