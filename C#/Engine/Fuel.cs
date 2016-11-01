using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Fuel : Sprite
    {
        // Future place to store the fuel properties 
        // Currently resides in Sprite.cs

        // Fuel check on the .car object
        public float fuelSystem(float fuel, float force)
        {
            if (fuel > 0 && force > 0 && force <= 5)
            {
                return fuel = Convert.ToSingle(fuel - 0.05);
            }
            else if (fuel > 0 && force > 5 && force <= 10)
            {
                return fuel = Convert.ToSingle(fuel - 0.1);
            }
            else if (fuel > 0 && force > 10 && force <= 20)
            {
                return fuel = Convert.ToSingle(fuel - 0.15);
            }
            else if (fuel > 0 && force == 0)
            {
                return fuel = Convert.ToSingle(fuel - 0.001);
            }
            return fuel;
        }
    }
}
