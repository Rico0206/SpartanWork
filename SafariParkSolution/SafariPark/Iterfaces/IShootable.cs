using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public interface IShootable
    {
        public string Shoot();
        public string Reload();
    }

    public class CanReload : Weapon, IShootable
    {
        public CanReload()
        {

        }
        public CanReload(string brand, int ammo, int clip) : base(brand, ammo, clip)
        {

        }


        public override string Shoot()
        {
            Clip -= 1;

            if (Clip <= 0)
            {
                Clip = 0;
                return $"{Brand} clip is {Clip}, ammo is {Ammo} please reload";
            }
            else
            {
                return $"{Brand} Has Been Shot clip is {Clip} ";
            }
        }

        public override string Reload()
        {
            if (Ammo > 0)
            {
                Clip += Ammo;
                Ammo = Clip - Ammo;
                return $" {Brand} Successfully Reloaded current ammo is {Ammo} \n {Brand}s current clip is {Clip} ";
            }
            else
            {
                return $"{Brand} Reload Failed You Have {Ammo} Ammo!!!!!!";
            }
        }
    }

    public class NoReload : Weapon,  IShootable
    {
        public NoReload()
        {

        }
        public NoReload(string brand, int ammo, int clip) : base(brand, ammo, clip)
        {

        }
        public override string Shoot()
        {
            return $"Ammo Has Been Shot";
        }

        public override  string Reload()
        {
            return $"Cant Reload Check Ammo";
        }
    }

    public class CanShoot : Weapon, IShootable
    {
        public CanShoot()
        {

        }
        public CanShoot(string brand = "RL", int ammo = 10, int clip = 2) : base(brand, ammo, clip)
        {

        }

        public override string Shoot()
        {
            if (Ammo > 0)
            {
                Clip += Ammo;
                Ammo = Clip - Ammo;
                return $" {Brand} Successfully Reloaded current ammo is {Ammo} \n {Brand}s current clip is {Clip} ";
            }
            else
            {
                return $"{Brand} Reload Failed You Have {Ammo} Ammo!!!!!!";
            }
        }

        public override string Reload()
        {
            return $"Ammo Has Been Reloaded Successfully";
        }
    }

    public class CantShoot : Weapon, IShootable
    {
        public CantShoot()
        {

        }
        public CantShoot(string brand, int ammo, int clip) : base(brand, ammo, clip)
        {

        }
        public override string Shoot()
        {
            return $" CLICK CLICK  Weapon Wont Shoot Check Ammo ";
        }

        public override string Reload()
        {
            return $"Ammo Has been Reloaded Successfully";
        }
    }
}
