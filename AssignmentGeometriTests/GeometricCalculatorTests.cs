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
        public void GetPerimeterTest()
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
            var expected = 80F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Perimeter of Square.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTestSquare()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(10)
            });

            var expected = 40F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Perimeter of Rectangle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTestRectangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Rectangle(10, 10)
            });

            var expected = 100F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Perimeter of Triangle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTestTriangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Triangle(10, 10)
            });

            var expected = 30F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Perimeter of Circle.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTestCircle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Circle(10)
            });

            var expected = 100F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Area of square.
        /// </summary>
        [TestMethod()]
        public void GetAreaTestSquare()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Square(10));
            var expected = 40F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Area of Rectangle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTestRectangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Rectangle(10, 10));
            var expected = 40F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Area of Triangle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTestTriangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Triangle(10, 10));
            var expected = 40F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Area of Circle.
        /// </summary>
        [TestMethod()]
        public void GetAreaTestCircle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Circle(10));
            var expected = 314F;
            Assert.AreEqual(expected, actual);
        }
    }
}