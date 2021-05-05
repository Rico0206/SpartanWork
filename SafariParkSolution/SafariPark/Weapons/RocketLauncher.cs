using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class RocketLauncher : Weapon 
    {
        public RocketLauncher()
        {

        }
        public RocketLauncher(string brand = "RocketLauncher", int ammo = 2, int clip = 2) : base(brand, ammo, clip) 
        {
            weaponType = new CanReload();
            weaponType = new CanShoot();
        }
        //public override string Shoot()
        //{
        //    return $" BOOOOOOOM!!!! {base.Shoot()}";
        //}

        //    public override string Reload()
        //    {
        //        return $"{base.Reload()}";
        //    }
    }
}
