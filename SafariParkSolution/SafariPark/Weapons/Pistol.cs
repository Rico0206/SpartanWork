using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Pistol : Weapon
    {
        public Pistol(string brand = "Pistol", int ammo = 20, int clip = 10) : base(brand, ammo, clip)
        {
            weaponType = new CanReload();
            weaponType = new CantShoot();
        }
        public override string Shoot()
        {
            return $"Splashh {base.Shoot()}";
        }
    }
}
