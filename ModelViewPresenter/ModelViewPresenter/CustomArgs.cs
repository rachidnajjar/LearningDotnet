using System;

namespace ModelViewPresenter
{
    public class CustomArgs : EventArgs
    {
        public string m_before { get; set; }
        public string m_after { get; set; }
 
        public CustomArgs(string before, string after)
        {
            m_before = before;
            m_after = after;
        }
    }
}