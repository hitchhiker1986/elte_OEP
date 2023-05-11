namespace gyak10
{
    public class Starship
    {
        protected string name;
        protected int shield, armor, guards;

        public int GetShield() { return shield; }
        
        protected Planet planet;
        public Starship(string name, int shield, int armor, int guards) {
            this.name = name;
            this.shield = shield;
            this.armor = armon;
            this.guards = guards;
            planet? = null;  //? azt jelenti hogy a planetet uniozzuk a null pointerrel, igy majd a null erteket is el fogja fogadni a planetnel elhagyhato a this mert nincs ilyen nevu parameter
        }

        public void DefendPlanet(Planet p)
        {
            if (planet != null) 
            {
                throw new Exception("already defends another planet")
            }

            planet = p;
            p.Defend(this);
        }

        public void LeavePlanet()
        {
            if (planet == null) 
            {
                throw new Exception("already defends another planet")
            }

            planet = p;
            planet.Leave(this);
            planet = null;
        }

        public virtual double FirePower()
        {
            return 0;
        } 
    }
}