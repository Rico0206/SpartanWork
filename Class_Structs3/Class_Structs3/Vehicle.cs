using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Structs3
{
    class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed;

        public int NumPassengers { get; set; }
        public int Position { get; set; }



        public string Move()
        {
            return "";
        }

        public string Move(int times)
        {
            return "";
        }

        public  Vehicle()
        {
        }

        public Vehicle(int capacity, int speed = 10)
        {

        }
    }
}
