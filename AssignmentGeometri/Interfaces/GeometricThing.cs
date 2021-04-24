using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGeometri
{
    public abstract class GeometricThing
    {
        /// <summary>
        /// Calculate Perimeter.
        /// </summary>
        /// <returns>Perimeter in float.</returns>
        public abstract float GetPerimeter();
        /// <summary>
        /// Calculate Area.
        /// </summary>
        /// <returns>Area in float.</returns>
        public abstract float GetArea();
    }
}
