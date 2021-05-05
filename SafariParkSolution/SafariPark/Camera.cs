using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    class Camera : IShootable
    {
        string _brand;
        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Reload()
        {
            return $"Successfully Reloaded current ammo is ";
        }

        public string Shoot()
        {
            return $"Picture has been taken with {_brand} ";
        }

        public override string ToString()
        {
            return base.ToString() + $"Brand: {_brand}";
        }
    }
}
