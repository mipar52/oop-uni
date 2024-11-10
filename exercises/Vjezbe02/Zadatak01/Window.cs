using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    internal class Window // internal -> unutar projekt
    {
        public string Title { get; set; }
        public string Label { get; set; }
        public bool Active { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Color Color { get; set; }

        public Window(string title)
        {
            Title = title;
        }

        public Window():this("Window1")
        {
            TopLeft = new Point(0, 0);
            BottomRight = new Point(80, 20);
        }

        public Window(string title, Point topLeft, Point bottomRight, Color color) : this(title)
        {

            TopLeft = topLeft;
            BottomRight = bottomRight;
            Color = color;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Label: {Label}, Active: {(Active?"YES":"NO")}, Top left: {TopLeft}" ;
        }

        public int Width()
        {
            return Math.Abs(TopLeft.X - BottomRight.X);
        }

        public int Height() => Math.Abs(TopLeft.Y - BottomRight.Y); // lamba - skracena verzije od ovog povise u widthz

        public int Area()
        {
            return Width() * Height();
        }

        public int Perimeter()
        {
            return 2 * Width() + Height();
        }
    }
}
