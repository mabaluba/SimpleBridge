using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Motion
    {
        private protected Speed mySpeed;
        public Speed MySpeed { set { mySpeed = value; } }
        public Motion(Speed speed)
        {
            mySpeed = speed;
            //speed.MySpeed();
        }

        public abstract void Move();
    }

    class Run : Motion
    {
        public Run(Speed speed):base(speed) {}
        public sealed override void Move()
        {
            Console.Write("Бегу ");
            mySpeed.MySpeed();
        }
    }
    class Walk : Motion
    {
        public Walk(Speed speed) : base(speed) {}
        public sealed override void Move()
        {
            Console.Write("Иду ");
            mySpeed.MySpeed();
        }
    }
}
