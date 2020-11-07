using System;

namespace ModelViewPresenter
{
    public class Presenter
    {
        private readonly IView _view;
        private IModel _model;

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
        }

        public void ReverseTextValue()
        {
            string reversed = ReverseString(_view.TextValue);
            _model.Reverse(reversed);
        }

        public void SetTextValue()
        {
            _model.Set(_view.TextValue);
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}