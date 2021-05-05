using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class SniperRifle : Weapon
    {
        public SniperRifle(string brand, int ammo = 5, int clip = 1) : base(brand, ammo, clip)
        {
            weaponType = new CanShoot();
            weaponType = new CanReload();
        }

        public override string Shoot()
        {
            return $"Zing!! {base.Shoot()}";
        }
    }
}
