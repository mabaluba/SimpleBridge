using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Speed
    {
        public virtual void MySpeed()
        {
            Console.WriteLine("кое-как!");
        }
    }
    class SpeedFast : Speed
    {
        public override void MySpeed()
        {
            Console.WriteLine("быстро!");
            //base.MySpeed();
        }
    }
    class SpeedSlow : Speed
    {
        public override void MySpeed()
        {
            Console.WriteLine("медленно!");
            //base.MySpeed();
        }
    }

}
