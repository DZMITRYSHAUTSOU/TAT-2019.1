using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class Plane : FlyingObjects, IFlyable
    {
        private double startingspeed = 200;
        private double acceleration_distance = 10;
        private double acceleration = 10;
        public double GetSpeed()
        {
            return speed;
        }
        public Plane()//Set id and starting speed
        {
            speed = startingspeed;
            ID = "Plane!";
        }
        public void FlyTo(Point newPoint)//Receives point 
        {
            NextPoint = newPoint;//Sets it as next
            Console.WriteLine("Fly time : " + GetFlyTime() + " hours ");// calculates fly time
            StartingPoint = NextPoint;// Set new starting point
            NextPoint = null;// Next point is unknown again
        }
        public string WhoAmI()
        {
            return ID;
        }
        public double GetFlyTime()// calculates fly time
        {
            double distance = 0;
            if (NextPoint == null)
            {
                Console.WriteLine("No nextpoint set. Try using FlyTo before GetFlyTime.");
                return 0;
            }
            double time = 0;
            for (int i = 0; i < Point.dimension; i++)
            {
                time += Math.Pow(StartingPoint.Coords[i] - NextPoint.Coords[i], 2);
            }
            time = Math.Sqrt(time);// At this point "time" contains distance
            distance = time;
            time = 0;
            for (int i=0;i < distance / acceleration_distance;i++)
            {
                time += acceleration_distance / speed;
                speed += acceleration;
            }
            time += (distance - (int) distance / acceleration_distance * acceleration_distance) / speed;
            return time;
        }
    }
}
