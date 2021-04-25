using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentGeometri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentGeometri.Geometry;

namespace AssignmentGeometri.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        /// <summary>
        /// Test Perimeter of Array with shapes.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_ArrayOfShapes()
        {
            // TODO: Skapa Perimetertest
            // 1 - skapa en array av geometric things
            // 2 - Skicka in arrayen till GetPerimeter
            // 3 - Jämför actual och expected

            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(10),
                new Circle(10),
                new Rectangle(10,10),
                new Triangle(10,10)
            });
            var expected = 172.83F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Square.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Square()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(10)
            });

            var expected = 40F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Rectangle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Rectangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Rectangle(10, 10)
            });

            var expected = 40F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Triangle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Triangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Triangle(10, 10)
            });

            var expected = 30F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Circle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Circle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Circle(10)
            });

            var expected = 62.83F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of square.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Square()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Square(10));
            var expected = 100F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Rectangle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Rectangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Rectangle(10, 10));
            var expected = 100F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Triangle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Triangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Triangle(10, 10));
            var expected = 50F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Circle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Circle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Circle(10));
            var expected = 314.16F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        [TestMethod()]
        public void GetAreaTest_Null()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(null);
            var expected = 0F;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_Null()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(null);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}