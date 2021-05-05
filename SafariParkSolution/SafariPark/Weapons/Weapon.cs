using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        string _brand;
        int _ammo;
        int _clip;

        public int Ammo { get; set; }
        public int Clip { get; set; }
        public int Brand { get; set; }


        public IShootable weaponType;

        public Weapon()
        {

        }

        public Weapon(string brand, int ammo, int clip)
        {
            _brand = brand;
            _ammo = ammo;
            _clip = clip;
        }

        public virtual string Shoot()
        {
            return "";
        }

        public virtual string Reload()
        {
            return "";
        }

        public override string ToString()
        {
            return base.ToString() + $"Brand: {_brand}";
        }



        public string TryToReload()
        {
            return weaponType.Reload();
        }
        public string TryToShoot()
        {
            return weaponType.Shoot();
        }

        public void SetReloadAbility(IShootable newWeaponType)
        {
            weaponType = newWeaponType;
        }
        public void SetShootAbility(IShootable newWeaponType)
        {
            weaponType = newWeaponType;
        }
    }
}
