using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentGeometri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        [TestMethod()]
        public void GetPerimeterTest()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Square(10)
            });
        }
    }
}