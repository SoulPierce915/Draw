using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draw;
using System;

namespace UnitTest_Draw
{
    [TestClass]
    public class WidgetUnitTests
    {
        [TestMethod]
        public void TestWidgetLocationUpdates()
        {
            int beginningLocationX = 0;
            int beginningLocationY = 0;
            int updateX = 10;
            int updateY = -20;

            Widget testWidget = new Square(1);

            Assert.AreEqual(beginningLocationX, testWidget.LocationX, "Widget beginning location (x-axis) not initialised to 0");
            Assert.AreEqual(beginningLocationY, testWidget.LocationY,  "Widget beginning location (y-axis) not initialised to 0");

            testWidget.SetLocation(updateX, updateY);

            Assert.AreEqual(updateX, testWidget.LocationX,  "updated widget location (x-axis) incorrect");
            Assert.AreEqual(updateY, testWidget.LocationY,  "updated widget location (y-axis) incorrect");
        }
    }

    [TestClass]
    public class SquareUnitTests
    {
        [TestMethod]
        public void TestWidgetName()
        {
            Square testSquare = new Square(1);

            Assert.AreEqual("Square", testSquare.WidgetName, "Widget Name incorrect");
        }

        [TestMethod]
        public void TestOutput()
        {
            string expectedOutput = "Square (7,8) size=15";
            Square testSquare = new Square(15);

            testSquare.SetLocation(7, 8);

            string actualOutput = testSquare.Output();

            Assert.AreEqual(expectedOutput, actualOutput, "Widget output incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Size parameters must be positive. size:-1")]
        public void TestInvalidSize()
        {
            Square testSquare = new Square(-1);
        }
    }

    [TestClass]
    public class RectangleUnitTests
    {
        [TestMethod]
        public void TestWidgetName()
        {
            Rectangle testRect = new Rectangle(1, 1);

            Assert.AreEqual("Rectangle", testRect.WidgetName, "Widget Name incorrect");
        }

        [TestMethod]
        public void TestOutput()
        {
            string expectedOutput = "Rectangle (10,11) width=7 height=8";
            Rectangle testRect = new Rectangle(7,8);

            testRect.SetLocation(10, 11);

            string actualOutput = testRect.Output();

            Assert.AreEqual(expectedOutput, actualOutput, "Widget output incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Size parameters must be positive. width:-1, height:-1")]
        public void TestInvalidSize()
        {
            Rectangle testSquare = new Rectangle(-2,-3);
        }
    }

    [TestClass]
    public class EllipseUnitTests
    {
        [TestMethod]
        public void TestWidgetName()
        {
            Ellipse testEllipse = new Ellipse(1, 1);

            Assert.AreEqual("Ellipse", testEllipse.WidgetName, "Widget Name incorrect");
        }

        [TestMethod]
        public void TestOutput()
        {
            string expectedOutput = "Ellipse (77,66) diameterH = 17 diameterV = 18";
            Ellipse testEllipse = new Ellipse(17, 18);

            testEllipse.SetLocation(77, 66);

            string actualOutput = testEllipse.Output();

            Assert.AreEqual(expectedOutput, actualOutput, "Widget output incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Size parameters must be positive. diameterH:-1, diameterV:-1")]
        public void TestInvalidSize()
        {
            Ellipse testSquare = new Ellipse(-1, -1);
        }
    }

    [TestClass]
    public class CircleUnitTests
    {
        [TestMethod]
        public void TestWidgetName()
        {
            Circle testCircle = new Circle(1);

            Assert.AreEqual("Circle", testCircle.WidgetName, "Widget Name incorrect");
        }

        [TestMethod]
        public void TestOutput()
        {
            string expectedOutput = "Circle (9,-10) size=123";
            Circle testCircle = new Circle(123);

            testCircle.SetLocation(9, -10);

            string actualOutput = testCircle.Output();

            Assert.AreEqual(expectedOutput, actualOutput, "Widget output incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Size parameters must be positive. size:-1")]
        public void TestInvalidSize()
        {
            Circle testSquare = new Circle(-1);
        }
    }

    [TestClass]
    public class TextBoxUnitTests
    {
        [TestMethod]
        public void TestWidgetName()
        {
            Textbox testTextbox = new Textbox(1, 1, "");

            Assert.AreEqual("Textbox", testTextbox.WidgetName, "Widget Name incorrect");
        }

        [TestMethod]
        public void TestOutput()
        {
            string expectedOutput = "Textbox (-6,123) width=20 height=15 Text=\"Example Text\"";
            Textbox testCircle = new Textbox(20,15,"Example Text");

            testCircle.SetLocation(-6, 123);

            string actualOutput = testCircle.Output();

            Assert.AreEqual(expectedOutput, actualOutput, "Widget output incorrect");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Size parameters must be positive. width:-1, height:-1")]
        public void TestInvalidSize()
        {
            Textbox testSquare = new Textbox(-1,-1,"");
        }
    }

    [TestClass]
    public class CanvasUnitTests
    {
        [TestMethod]
        public void TestCanvasBaseOutput()
        {
            string expectedOutput = new string('-', 64) + "\r\nRequested Drawing\r\n" + new string('-', 64) + "\r\n" + new string('-', 64) + "\r\n";

            Canvas mainCanvas = new Canvas();

            string actualOutput = mainCanvas.Draw();

            Assert.AreEqual(expectedOutput, actualOutput, "Base canvas output not as expected");
        }

        [TestMethod]
        public void TestCanvasAddWidget()
        {
            string expectedOutput = new string('-', 64) + "\r\nRequested Drawing\r\n" + new string('-', 64) +
                "\r\nSquare (0,0) size=1\r\n" + new string('-', 64) + "\r\n";

            Canvas mainCanvas = new Canvas();

            mainCanvas.Add(new Square(1));

            string actualOutput = mainCanvas.Draw();

            Assert.AreEqual(expectedOutput, actualOutput, "Base canvas output not as expected");
        }
    }
}
