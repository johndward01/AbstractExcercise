using System;

namespace AbstractExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var civic = new Car();
            var hayabusa = new Motorcycle();
            hayabusa.Drive();
            civic.Drive();
        }
    }
}
