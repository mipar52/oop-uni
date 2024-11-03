using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// nacrt objekta -> klasa
// instanca -> objekt

namespace Zadatak01
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
            pointTL.X = 5; pointTL.Y = 8;
            
            Point pointBR = new Point();
            pointBR.X = 10; pointBR.Y = 20;

            window.TopLeft = pointTL;
            window.BottomRight = pointBR;

            Color color = new Color(10, 10, 50);
            window.Color = color;
            // ovo je long way
            Console.WriteLine($"Title: {window.Title}, Label: {window.Label}, Top left: ({window.TopLeft.X}, {window.BottomRight.Y}), Bottom right: ({window.BottomRight.X}, {window.BottomRight.Y}), Color: ({window.Color.Red}, {window.Color.Green}, {window.Color.Blue}), is active: {(window.Active ? "YES" : "NO")}");

            // ovo radi toString()

            Console.WriteLine(window);

            Console.WriteLine($"Sirina: {window.Width()}, Visina: {window.Height()}, Area: {window.Area()}, Perimeter: {window.Perimeter()}");

            Window window2 = new Window("Drugi prozor");
            Window window3 = new Window(); // aktivira se konstruktor s this, di se injetka title

            Window window4 = new Window(
                "Cetvrti prozor", 
                new Point(2,3),
                new Point(4,1),
                new Color(10, 8,8));

            Console.WriteLine(window4);
        }
    }
}
