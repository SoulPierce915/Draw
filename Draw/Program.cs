using System;
using System.Collections.Generic;

namespace Draw
{
    class Program
    {

        static void Main(string[] args)
        {
            Canvas mainCanvas = new Canvas();

            mainCanvas.Add(new Rectangle(30,40).SetLocation(10,10));
            mainCanvas.Add(new Square(35).SetLocation(15,30));
            mainCanvas.Add(new Ellipse(300,200).SetLocation(100,150));
            mainCanvas.Add(new Circle(300).SetLocation(1,1));
            mainCanvas.Add(new Textbox(200,100,"sample text").SetLocation(5,5));

            mainCanvas.Draw();
            Console.ReadLine();
        }
    }

}
