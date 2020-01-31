using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExcercise
{
    public abstract class Vehicle
    {
        public  int Wheels { get; set; }
        public int Doors { get; set; }
        public abstract void Drive();
    }
}
