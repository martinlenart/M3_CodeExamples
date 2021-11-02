using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredSpots
{
    public enum SpotColor {Red, Green, Blue, Orange, White }
    interface IColoredSpots
    {
        /// <summary>
        /// Counts the numer of spots with a color
        /// </summary>
        /// <param name="color">Color of spot</param>
        /// <returns></returns>
        public int Count(SpotColor color);

        /// <summary>
        /// Sort the Spots in order of Color, then Size
        /// </summary>
        public void Sort();
    }
}
