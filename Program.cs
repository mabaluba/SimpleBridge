using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motion myMotion1 = new Walk (new Speed());
            myMotion1.Move();
            myMotion1 = new Run(new SpeedSlow());//create new implementation
            myMotion1.Move();
            myMotion1.MySpeed = new SpeedFast();// runtime implementation
            myMotion1.Move();

        }
    }
}
