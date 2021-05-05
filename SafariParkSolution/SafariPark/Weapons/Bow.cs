using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Weapons
{
    public class Bow : Weapon
    {

        public Bow(string brand = "bow", int ammo = 10, int clip = 1) : base(brand, ammo, clip)
        {
            weaponType = new CanReload();
        }

        public override string Shoot()
        {
            return $"Whistle {base.Shoot()}";

        }
    }
}
