namespace Program
{
    public class Landingship : Starship
    {

        public Landingship(string name, int shield, int armor, int guards) : base(name, shield, armor, guards)
        {

        }

        public override double FirePower()
        {
            return guards/2.0;
        }
    }
}