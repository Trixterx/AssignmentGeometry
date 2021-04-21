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
            // Expected ska vara en float då GetPerimeter returnerar en float
            // Just nu kör du samma metod två gånger och testat att resultet blir samma
            // det kan aldrig faila, för det är som att jämföra if (true==true)
            var expected = 100; // exempel
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
        [TestMethod()]
        public void GetPerimeterTestSquare()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(10) // <-- Tryck F12 över Square
            });

            var expected = 40f;
            Assert.AreEqual(expected, actual);
        }
    }
}