using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class EntryPoint// This program calculates time for moving from one point to the other
    {
        static void Main(string[] args)// Method for testing
        {
            try
            {
                SpaceShip ship = new SpaceShip();
                Console.WriteLine(ship.WhoAmI());
                ship.FlyTo(new Point(new double[] { 100, 200, 800 }));
                Plane plane = new Plane();
                Console.WriteLine(plane.WhoAmI());
                plane.FlyTo(new Point(new double[] { 100, 200, 800 }));
                Bird bird = new Bird();
                Console.WriteLine(bird.WhoAmI());
                bird.FlyTo(new Point(new double[] { 100, 200, 800 }));
            }
            catch(Exception)
            {
                Console.WriteLine("Something is wrong...");
            }
        }
    }
}
