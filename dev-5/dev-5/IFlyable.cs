using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_5
{
    interface IFlyable //Interface from task
    {
        void FlyTo(Point newPoint);
        string WhoAmI();
        double GetFlyTime();
    }
}
