using System.Collections.Generic;
using System.Diagnostics;

namespace YieldHelloWorld
{
    public static class GalaxyClass
    {
        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }

        public class Galaxies
        {

            public IEnumerable<Galaxy> NextGalaxy
            {
                get
                {
                    yield return new Galaxy { Name = "Tadpole", MegaLightYears = 400 };
                    yield return new Galaxy { Name = "Pinwheel", MegaLightYears = 25 };
                    yield return new Galaxy { Name = "Milky Way", MegaLightYears = 0 };
                    yield return new Galaxy { Name = "Andromeda", MegaLightYears = 3 };
                }
            }
        }

        public static void ShowGalaxies()
        {
            var galaxies = new Galaxies();
            foreach (Galaxy galaxy in galaxies.NextGalaxy)
            {
                Debug.WriteLine(galaxy.Name + " " + galaxy.MegaLightYears.ToString());
            }
        }
    }
}