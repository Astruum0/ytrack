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
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Je suis un véhicule non-identifié de couleur {0} qui se déplace à {1} km/h", Color, Speed));
        }

        public static void WhoIsThere()
        {
            Console.WriteLine("---------------------------------");
            if (List != null && List.Count > 0)
            {
                Console.WriteLine("Il y a du monde ici !");
                foreach (Vehicule item in List)
                {
                    item.WhoAmI();
                }
            }
            else
            {
                Console.WriteLine("Personne dans les parages...");
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
