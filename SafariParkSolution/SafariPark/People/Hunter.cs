using SafariPark;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }
        public IShootable Reloader { get; set; }

        public Hunter() {}
        public Hunter(string fName, string lName, int bullets, IShootable shooter, IShootable reloader) : base(fName, lName, bullets)
        {
            Shooter = shooter;
            Reloader = reloader;
        }

        public string Shoot()
        {
            return $"{Shooter.Shoot()} by {GetFullName()}";
        }

        public override /*sealed*/ string ToString()
        {
            return $"{base.ToString()}";
        }

        public string Reload()
        {
            return $"";
        }
    }
}
