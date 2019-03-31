using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class FlyingObjects // Base class for flying objects
    {
        protected string ID = "flying object"; // ID for objects
        protected Point StartingPoint = new Point(new double[] { 0, 0, 0 });//Starting point for all objects is zeros by default (new Point(); would work too)
        protected Point NextPoint = null; // Next point is unknown by default
        protected double speed; // Speed
    }
}
