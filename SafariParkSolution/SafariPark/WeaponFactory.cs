using SafariPark.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public static class WeaponFactory
    {
        public static Weapon Create(string Weapon)
        {
            switch (Weapon)
            {
                case "Rocket":
                return new RocketLauncher("RocketLauncher");
                case "Pistol":
                return new Pistol("Pistol");                
                case "Bow":
                return new Bow("Bow");               
                case "Sniper":
                return new Pistol("Sniper");
                default: return new RocketLauncher("RocketLauncher");
            }
        }       
    }
}
