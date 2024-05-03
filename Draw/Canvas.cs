using System;
using System.Collections.Generic;
using System.Text;

namespace Draw
{
    public class Canvas
    {
        readonly int LineSplitLength = 64;
        private List<Widget> items;

        public Canvas()
        {
            items = new List<Widget>();
        }

        public void Add(Widget wdgt)
        {
            items.Add(wdgt);
        }

        public string Draw()
        {
            StringBuilder output = new StringBuilder();

            string lineSplit = new string('-', LineSplitLength);

            output.AppendLine(lineSplit);
            output.AppendLine("Requested Drawing");
            output.AppendLine(lineSplit);

            foreach (Widget item in items)
            {
                output.AppendLine(item.Output());
            }

            output.AppendLine(lineSplit);

            return output.ToString();
        }
    }
}
