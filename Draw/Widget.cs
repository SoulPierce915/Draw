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
            if ((width < 0) && (height < 0))
            {
                throw new ArgumentException(string.Format("Size parameters must be positive. width:{0}, height:{1}",width,height));
            }
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
            if (size < 0)
            {
                throw new ArgumentException(string.Format("Size parameters must be positive. size:{0}", size));
            }
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
            if ((diameterH < 0) && (diameterV < 0))
            {
                throw new ArgumentException(string.Format("Size parameters must be positive. diameterH:{0}, diameterV:{1}", diameterH, diameterV));
            }
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
            if (size < 0)
            {
                throw new ArgumentException(string.Format("Size parameters must be positive. size:{0}", size));
            }
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
            if ((width < 0) && (height < 0))
            {
                throw new ArgumentException(string.Format("Size parameters must be positive. width:{0}, height:{1}", width, height));
            }
            Width = width;
            Height = height;
            Text = text;
        }

        public override string Output()
        {
            return string.Format("{0} width={1} height={2} Text=\"{3}\"", GetNameAndLocation(), Width, Height,Text);
        }


    }
}
