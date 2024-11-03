using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            window.Title = "Prozor";
            window.Label = "P1";
            window.Active = true;

            Point pointTL = new Point();
            pointTL.X=5; pointTL.Y=8;

            Point pointBR = new Point();
            pointBR.X=105; pointBR.Y=20;

            window.TopLeft = pointTL;
            window.BottomRight = pointBR;

            Color color = new Color();
            color.Red = 200;
            color.Green = 100;
            color.Blue = 0;

            window.Color = color;

            Console.WriteLine($"Title: {window.Title}, Label: {window.Label}, " +
                $"Top Left:({window.TopLeft.X},{window.TopLeft.Y}), " +
                $"Bottom Right:({window.BottomRight.X},{window.BottomRight.Y}), " +
                $"Color: ({window.Color.Red},{window.Color.Green}, {window.Color.Blue}), " +
                $"Active: {(window.Active?"YES":"NO")}");
            Console.WriteLine(window /*.ToString()*/);

            Console.WriteLine($"Sirina: {window.Width()}");
            Console.WriteLine($"Visina: {window.Height()}");
            Console.WriteLine($"Opseg: {window.Area()}");
            Console.WriteLine($"Povrsina: {window.Perimeter()}");


            Window window2= new Window("Drugi prozor");
            window2.Label = "P2";
            Console.WriteLine(window2);

            Window window3 = new Window();
            Console.WriteLine(window3);

            Window window4 = new Window("Cetvrti Prozor",new Point(2,3),new Point(8,9),new Color(150,125,100));
            Console.WriteLine(window4);
            Console.WriteLine($"Sirina: {window4.Width()}");
            Console.WriteLine($"Visina: {window4.Height()}");
            Console.WriteLine($"Opseg: {window4.Area()}");
            Console.WriteLine($"Povrsina: {window4.Perimeter()}");
            window4.Draw();
        }
    }
}
