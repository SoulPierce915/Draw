using System;
using System.Collections.Generic;
using System.Text;

namespace Draw
{
    public abstract class Widget
    {

        public int LocationX, LocationY;
        public readonly string WidgetName;

        public Widget(string name)
        {
            WidgetName = name;
        }

        public string GetNameAndLocation()
        {
            return string.Format("{0} ({1},{2})", WidgetName, LocationX, LocationY);
        }

        public Widget SetLocation(int XCoord, int YCoord)
        {
            LocationX = XCoord;
            LocationY = YCoord;

            return this;
        }

        //Method returns string representation of widget
        public abstract string Output();
    }

    //Strict class definition of a rectangle object built by extending the Widget abstract class
    public class Rectangle : Widget
    {
        private readonly int Width;
        private readonly int Height;

        public Rectangle(int width, int height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override string Output()
        {
            return string.Format("{0} width={1} height={2}", GetNameAndLocation(), Width, Height);
        }

    }

    //Strict class definition of a Square object built by extending the Widget abstract class
    public class Square : Widget
    {
        private readonly int Size;

        public Square(int size) : base("Square")
        {
            Size = size;
        }

        public override string Output()
        {
            return string.Format("{0} size={1}", GetNameAndLocation(), Size);
        }

    }

    //Strict class definition of a Square object built by extending the Widget abstract class
    public class Ellipse : Widget
    {
        private readonly int DiameterH;
        private readonly int DiameterV;

        public Ellipse(int diameterH, int diameterV) : base("Ellipse")
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public override string Output()
        {
            return string.Format("{0} diameterH = {1} diameterV = {2}", GetNameAndLocation(), DiameterH, DiameterV);
        }

    }

    //Strict class definition of a Square object built by extending the Widget abstract class
    public class Circle : Widget
    {
        private readonly int Size;

        public Circle(int size) : base("Circle")
        {
            Size = size;
        }

        public override string Output()
        {
            return string.Format("{0} size={1}", GetNameAndLocation(), Size);
        }

    }

    //Strict class definition of a Textbox object built by extending the Widget abstract class
    public class Textbox : Widget
    {
        private readonly int Width;
        private readonly int Height;
        private readonly string Text;


        public Textbox(int width, int height, string text) : base("Textbox")
        {
            Width = width;
            Height = height;
            Text = text;
        }

        public override string Output()
        {
            return string.Format("{0} width={1} height={2}", GetNameAndLocation(), Width, Height);
        }


    }
}
