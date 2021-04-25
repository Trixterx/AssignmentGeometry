﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentGeometri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentGeometri.Geometry;
using System.Data;

namespace AssignmentGeometri.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        /// <summary>
        /// Test Perimeter of Array with shapes with number 10.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_ArrayOfShapes_10()
        {
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
        /// Test Perimeter of Array with shapes with number 20.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_ArrayOfShapes_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(20),
                new Circle(20),
                new Rectangle(10,20),
                new Triangle(20,20)
            });
            var expected = 325.66F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Square with side 10.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Square_10()
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
        /// Test Perimeter of Square with side 20.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Square_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(20)
            });

            var expected = 80F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Rectangle with height 10 and width 20.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Rectangle_10_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Rectangle(10, 20)
            });

            var expected = 60F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Rectangle with height 20 and width 30.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Rectangle_20_30()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Rectangle(20, 30)
            });

            var expected = 100F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Triangle with base 10 and height 20.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Triangle_10_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Triangle(10, 20)
            });

            var expected = 40F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Triangle with base 20 and height 30.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Triangle_20_30()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Triangle(20, 30)
            });

            var expected = 70F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Perimeter of Circle with radius 10.
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
        /// Test Perimeter of Circle with raidus 20.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Circle_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Circle(20)
            });

            var expected = 125.66F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Square with side 10.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Square_10()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Square(10));
            var expected = 100F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Square with side 20.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Square_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Square(20));
            var expected = 400F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Rectangle with height 10 and width 10.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Rectangle_10_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Rectangle(10, 20));
            var expected = 200F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Rectangle with height 20 and width 20.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Rectangle_20_30()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Rectangle(20, 30));
            var expected = 600F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Triangle with base 10 and height 10.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Triangle_10_10()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Triangle(10, 10));
            var expected = 50F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Triangle with base 20 and height 20.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Triangle_20_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Triangle(20, 20));
            var expected = 200F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Circle with Radius 10.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Circle_10()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Circle(10));
            var expected = 314.16F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }

        /// <summary>
        /// Test Area of Circle with Radius 20.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Circle_20()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new Circle(20));
            var expected = 1256.64F;
            Assert.AreEqual(Math.Round(expected, 2), Math.Round(actual, 2));
        }


        /// <summary>
        /// Test Area method with null.
        /// </summary>
        [TestMethod()]
        public void GetAreaTest_Null()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(null);
            var expected = 0F;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test Perimeter method with null.
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest_Null()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(null);
            var expected = 0F;
            Assert.AreEqual(expected, actual);
        }
    }
}