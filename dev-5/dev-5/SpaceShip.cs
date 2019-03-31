using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class SpaceShip : FlyingObjects, IFlyable
    {
        public SpaceShip() // Sets speed and ID
        {
            speed = 28800000;
            ID = "Space Ship!";
        }
        public double GetFlyTime()// Calculates time
        {
            if (NextPoint == null)// Is next point set?
            {
                Console.WriteLine("No nextpoint set. Try using FlyTo before GetFlyTime.");
                return 0;
            }
            double time=0;
            for (int i=0; i < Point.dimension; i++ )
            {
                time += Math.Pow(StartingPoint.Coords[i] - NextPoint.Coords[i], 2);
            }
            return Math.Sqrt(time)/speed;
        }
        public void FlyTo(Point newPoint)// Receives point 
        {
            NextPoint = newPoint;//Sets it as next
            Console.WriteLine("Fly time : " + GetFlyTime() + " hours ");// calculates fly time
            StartingPoint = NextPoint;// Set new starting point
            NextPoint = null;// Next point is unknown again
        }
        public string WhoAmI()// Return ID
        {
            return ID;
        }
    }
}
