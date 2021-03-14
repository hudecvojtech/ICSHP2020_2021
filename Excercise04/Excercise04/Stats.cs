using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise04
{
    class Stats
    {
        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);
        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public double Accuracy { get; private set; }

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey)
            {
                Correct++;
            }
            else
            {
                Missed++;
            }
            Accuracy = ((Correct * 1.0) / (Correct + Missed)) * 100;
            OnUpdatedStats();
        }
    }
}
