using System;
using System.Collections.Generic;
using System.Globalization;

namespace CSharpDiscovery.Quest04
{
    public class Vehicule
    {
        public string Color { get; set; }
        public int Speed { get; set; }
        private static List<Vehicule> List;

        public Vehicule()
        {
            Color = "Unknown";
            Speed = 0;
            AddToList();
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "I'm a {0} vehicule and I'm moving at a speed of {1} km/h", Color, Speed));
        }

        public static void WhoIsThere()
        {
            Console.WriteLine("---------------------------------");
            if (List != null && List.Count > 0)
            {
                foreach (Vehicule item in List)
                {
                    item.WhoAmI();
                }
            }
            else
            {
                Console.WriteLine("Nobody's here...");
            }
            Console.WriteLine("---------------------------------");
        }

        private void AddToList()
        {
            if (List == null)
                List = new List<Vehicule>();

            List.Add(this);
        }
    }
}
