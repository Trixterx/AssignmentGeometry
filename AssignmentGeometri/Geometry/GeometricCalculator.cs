﻿using AssignmentGeometri.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri.Geometry
{
    /// <summary>
    /// Class for the Geometric Calculator.
    /// </summary>
    public class GeometricCalculator
    {
        /// <summary>
        /// Method to calculate Area for the shapes.
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetArea(GeometricThing thing)
        {
            if (thing == null) { return 0F; }
            else { return thing.GetArea(); }
        }

        /// <summary>
        /// Method to calculate the Perimeter of the shapes.
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetPerimeter(GeometricThing[] thing)
        {
            if (thing == null) { return 0F; }
            else
            {
                if (thing.Length == 1)
                {
                    foreach (var shape in thing)
                    {
                        return shape.GetPerimeter();
                    }
                }
                else if (thing.Length > 1)
                {
                    var sum = 0F;
                    foreach (var shape in thing)
                    {
                        sum += shape.GetPerimeter();
                    }
                    return sum;
                }
            }
            return 0;
        }
    }
}
