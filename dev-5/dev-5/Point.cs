using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    class Point // Every method can work in different dimensions
    {
        public static int dimension = 3;// Current dimensions
        public double[] Coords = new double[dimension]; // Array for coordinates
        public Point()// Default constructor makes Point ( 0, 0, 0 )
        {
            Coords = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                Coords[i] = 0;
            }
        }
        public Point(double[] Arr)// Constructor for initial coordinates 
        {
            for (int i=0; i< dimension; i++)
            {
                Coords[i] = Arr[i];
            }
        }
    }
}
