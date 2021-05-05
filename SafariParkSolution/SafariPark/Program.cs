using SafariPark.Weapons;
using System;
using System.Collections.Generic;


namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            var pistol = WeaponFactory.Create("Pistol");
            var bow = WeaponFactory.Create("Bow");
            var rocketLauncher = WeaponFactory.Create("Rocket");
            var Sniper = WeaponFactory.Create("Sniper");

            Console.WriteLine(rocketLauncher.TryToShoot());
            Console.WriteLine(Sniper.TryToShoot());
            //Sniper.SetShootAbility(new CantShoot("blah", 10,10));


            //var pistol = new Pistol("SuperSoaker");
            //Weapon laserGun = new SniperRifle("Acme");
            //var rocket = new RocketLauncher("RPG-7");
            //Weapon bow = new Bow("Bow");
            //var riko = new Hunter("Riko", "Jamal", default, bow, bow);
            

            //rocket.SetShootAbility(new CantShoot());
            //Console.WriteLine(rocket.TryToShoot());
            //Console.WriteLine(rocket.TryToShoot());

            //Console.WriteLine(RL.TryToShoot());

            //rocket.SetShootAbility(new CanShoot());
            //Console.WriteLine(rocket.TryToShoot());
            //Console.WriteLine(rocket.TryToReload());


        }
    }
}
