using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class Bird : FlyingObjects, IFlyable
    {
        public int min = 0;//min and max speed for bird
        public int max = 20;
        public Bird()//generates random speed between min and max
        {
            Random a = new Random();
            speed = Convert.ToDouble(a.Next(min*100, max*100))/100;
            ID = "Bird!";
        }
        public void FlyTo(Point newPoint) // Receives point 
        {
            NextPoint = newPoint; //sets it as next
            Console.WriteLine("Fly time : " + GetFlyTime() + " hours "); // calculates fly time
            StartingPoint = NextPoint;// Set new starting point
            NextPoint = null;// Next point is unknown again
        }
        public string WhoAmI()// Returns ID
        {
            return ID;
        }
        public double GetFlyTime()//Calculates Fly Time
        {
            if (NextPoint == null)// Is next point set?
            {
                Console.WriteLine("No nextpoint set. Try using FlyTo before GetFlyTime.");
                return 0;
            }
            double time = 0;
            for (int i = 0; i < Point.dimension; i++)
            {
                time += Math.Pow(StartingPoint.Coords[i] - NextPoint.Coords[i], 2);
            }
            return Math.Sqrt(time) / speed;
        }
    }
}
