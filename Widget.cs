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
        private readonly int RectangleWidth;
        private readonly int RectangleHeight;

        public Rectangle(int Width, int Height) : base("Rectangle")
        {
            RectangleWidth = Width;
            RectangleHeight = Height;
        }

        public override string Output()
        {
            return string.Format("{0} width={1} height={2}", GetNameAndLocation(), RectangleWidth, RectangleHeight);
        }

    }
}
