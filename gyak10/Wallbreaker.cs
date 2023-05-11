namespace gyak10
{
    public class Wallbreaker : Starship
    {

        public Wallbreaker(string name, int shield, int armor, int guards) : base(name, shield, armor, guards)
        {

        }

        public override double FirePower()
        {
            return armor/2.0;
        }
    }
}