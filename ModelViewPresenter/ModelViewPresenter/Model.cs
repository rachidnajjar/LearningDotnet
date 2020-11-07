using System;

namespace ModelViewPresenter
{
    public class Model : IModel
    {
        private string _textValue;

        public event EventHandler<CustomArgs> TextSet;

        public Model()
        {
            _textValue = string.Empty;
        }

        public void RaiseTextSetEvent(string before, string after)
        {
            TextSet(this, new CustomArgs(before, after));
        }

        public void Reverse(string value)
        {
            string before = _textValue;
            _textValue = value;
            RaiseTextSetEvent(before, _textValue);
        }

        public void Set(string value)
        {
            string before = _textValue;
            _textValue = value;
            RaiseTextSetEvent(before, _textValue);
        }
    }
}