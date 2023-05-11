namespace gyak10
{

    public struct BoolxDoublexStarship
    {
        public bool I;
        public double fp;
        public Starship? ship;
    }
    {
        
    }
    public class Planet
    {
        private string name;
        private List<Starship> ships;

        public Planet(string name)
        {
            this.name = name;
            ship = new List<Starship>();
        }

        public int CountShips()
        {
            return ships.Count();
        }

        public void Defend(Starship ship)
        {
            ships.Add(ship);
        }

        public void Leave(Starship ship) 
        {
            ships.Remove(ship);
        }

        public double SumShield()
        {
            double sum = 0;
            foreach(Starship ship in ships)
            {
                sum += ship.GetShield();
            }    

            return sum;
        }

        public BoolxDoublexStarship MaxFirePower()
        {
            BoolxDoublexStarship result = new BoolxDoublexStarship();

            result.I = false;
            result.fp = 0;
            result.ship = null;

            if (ships.Count() > 0) 
            {
                result.I = true;
                result.fp = ships[0].FirePower();
                result.ship = ships[0];
            }

            foreach(Starship ship in ships.Skip(1))
            {
                if (result.fp < ship.FirePower()
                {
                    result.fp = ship.FirePower();
                    result.ship = ship;
                })
            }
            return result;
        }

        
        
    }
}