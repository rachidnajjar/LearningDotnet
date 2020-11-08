using System;

namespace EventsConsole
{
    public delegate void ThresholdReachedEventHandler(Object sender, ThresholdReachedEventArgs e);
    
    public class Counter
    {
        public event ThresholdReachedEventHandler ThresholdReached;

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
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = _threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReachedEventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        // provide remaining implementation for the class
    }
}