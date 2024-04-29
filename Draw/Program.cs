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

            mainCanvas.Draw();
            Console.ReadLine();
        }
    }

}
