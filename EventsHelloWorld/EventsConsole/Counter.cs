using System;

namespace EventsConsole
{
    public class Counter
    {
        public event EventHandler ThresholdReached;

        private int _threshold;
        private int _total;
        
        public Counter(int threshold)
        {
            _threshold = threshold;
        }

        public void Add(int x)
        {
            _total += x;
            if (_total >= _threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        
    }
}