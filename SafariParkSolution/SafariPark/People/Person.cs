using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Person : IMoveable
    {
        private string _firstName;
        private string _lastName;
        private int _bullets;

        private int _age;
        public int Age
        {
            get { return _age; }
            set { if(value >=0) _age = value; }
        }

        public Person(){}
        public Person(string fName, string lName, int bullets = 50)
        {
            _firstName = fName;
            _lastName = lName;
            _bullets = bullets;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}";
        }

        public string Move()
        {
            return "Walking Along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
