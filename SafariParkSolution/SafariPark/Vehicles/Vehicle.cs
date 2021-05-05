﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle : IMoveable
    {
        private int _capacity;
        private int _speed = 10;
        private int _numPassengers;
        public int Position
        { get; private set; }
        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (value >= 0 && value <= _capacity)
                {
                    _numPassengers = value;
                }
                else if (value > _capacity)
                {
                    _numPassengers = _capacity;
                }
            }
        }


        public Vehicle() { }


        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }
        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public override string ToString()
        {
            return base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: { Position}";
        }
    }
}
