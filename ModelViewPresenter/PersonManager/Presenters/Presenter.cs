using System;
using PersonManager.Views;

namespace PersonManager.Presenters
{
    public class Presenter<T> where T : class, IView 
    {
        public T View { get; private set; }
        
        public Presenter(T view)
        {
            if (view == null)
                throw new ArgumentNullException("view");
            
            this.View = view;

            View.Initialize += OnViewInitialize;
            View.Load += OnViewLoad;
        }

        protected virtual void OnViewInitialize(object sender, EventArgs e)
        {

        }

        protected virtual void OnViewLoad(object sender, EventArgs e)
        {
            
        }
    }
}