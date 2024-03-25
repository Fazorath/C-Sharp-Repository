using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace Drawing
{
    class Circle : IDraw, IColor
    {
        private int diameter;
        private int locX = 0, locY = 0;
        private Ellipse circle = null;
        public Circle(int diameter)
        {
            this.diameter = diameter;
        }
        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }
        void IDraw.Draw(Canvas canvas)
        {
            this.circle = new Ellipse();
            this.circle.Height = this.diameter;
            this.circle.Width = this.diameter;
            Canvas.SetTop(this.circle, this.locY);
            Canvas.SetLeft(this.circle, this.locX);
            canvas.Children.Add(this.circle);
        }
        void IColor.SetColor(Color color)
        {
            if (this.circle is not null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;
            }
        }



    }

}
