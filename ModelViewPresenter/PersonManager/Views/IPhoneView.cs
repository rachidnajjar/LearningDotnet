using System;

namespace PersonManager.Views
{
    public interface IPhoneView : IView
    {
        int PhoneId { get; set; } 
        string PhoneNumber { get; set; } 

        event EventHandler SavePhone;
    }
}