namespace Program
{
    public class Laser : Starship
    {

        public Wallbreaker(string name, int shield, int armor, int guards) : base(name, shield, armor, guards)
        {

        }

        public override double FirePower()
        {
            return shield/2.0;
        }
    }
}