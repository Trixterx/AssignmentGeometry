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
        [TestMethod()]
        public void GetPerimeterTest()
        {
            // TODO: Skapa Perimetertest
            // 1 - skapa en array av geometric things
            // 2 - Skicka in arrayen till GetPerimeter
            // 3 - Jämför actual och expected
            // actual kommer att bli noll första rundan och det är helt rätt

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

        [TestMethod()]
        public void GetPerimeterTestTriangle()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Triangle(10, 10)
            });

            var expected = 100F;
            Assert.AreEqual(expected, actual);
        }

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
    }
}