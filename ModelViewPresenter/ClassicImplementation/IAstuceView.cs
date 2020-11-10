using System;

namespace ClassicImplementation
{
    public interface IAstuceView
    {
        string Astuce { set;}
        event EventHandler CloseRequested;
        event EventHandler NextRequested;
        void Close();
    }
}