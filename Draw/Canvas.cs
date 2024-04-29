using System;
using System.Collections.Generic;
using System.Text;

namespace Draw
{
    public class Canvas
    {
        private List<Widget> items;

        public Canvas()
        {
            items = new List<Widget>();
        }

        public void Add(Widget wdgt)
        {
            items.Add(wdgt);
        }

        public void Draw()
        {
            string lineSplit = new string('-', 64);

            Console.WriteLine(lineSplit);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(lineSplit);

            foreach (Widget item in items)
            {
                Console.WriteLine(item.Output());
            }

            Console.WriteLine(lineSplit);
        }
    }
}
