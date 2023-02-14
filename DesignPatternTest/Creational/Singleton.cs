using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Creational.Singleton
{
    public class TheWarp
    {
        private static readonly Lazy<TheWarp> lazy = new(() => new TheWarp());
        public static TheWarp Instance { get => lazy.Value; }

        private int accessablePower = 30;
        public int AccessablePower { get => accessablePower; }

        public void DrawPower(int amount)
        {
            Console.WriteLine("Drawing power from the warp!");

            if(amount > 0 && amount <= AccessablePower)
            {
                Console.WriteLine("Power drawn! Cast your spell, psyker!");
                accessablePower -= amount;
            }
            else if(amount > AccessablePower)
            {
                Console.WriteLine("You've tried to draw too much power! Suffer the consequences of the warp!");
            }
        }
    }
}
