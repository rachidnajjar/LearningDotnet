using AreaCalculator.Models;
using AreaCalculator.Views;

namespace AreaCalculator.Presenters
{
    public class RectanglePresenter
    {
        private IRectangleView _view;

        public RectanglePresenter(IRectangleView view)
        {
            _view = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Lenght = int.Parse(_view.LenghtText);
            rectangle.Breadth = int.Parse(_view.BreadthText);

            var area = rectangle.CalculateArea();
            _view.AreaText = area.ToString();
        }
    }
}