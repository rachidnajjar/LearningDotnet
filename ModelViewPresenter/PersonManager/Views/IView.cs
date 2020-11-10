using System;

namespace PersonManager.Views
{
    public interface IView
    {
        event EventHandler Initialize;
        event EventHandler Load;
    }
}