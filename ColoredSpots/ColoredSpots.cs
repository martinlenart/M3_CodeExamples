using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredSpots
{
    public struct Spot : IComparable<Spot>
    {
        public SpotColor Color { get; set; }
        public int Size { get; set; }

        public int CompareTo(Spot s1)
        {
            if (Color != s1.Color)
                return Color.CompareTo(s1.Color);
            else
                return Size.CompareTo(s1.Size);
        }
    }

    class ColoredSpots : IColoredSpots
    {
        List<Spot> mySpots = new List<Spot>();

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < mySpots.Count; i++)
            {
                sRet += $"{mySpots[i].Color,8}/{mySpots[i].Size, -4} ";

                if ((i+1) % 5 == 0)
                    sRet += $"\n";
            }
            return sRet;
        }
        public ColoredSpots (int number)
        {
            var rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                var col = (SpotColor) rnd.Next((int) SpotColor.Red, (int) SpotColor.White + 1);
                var si = rnd.Next(10, 101);

                mySpots.Add(new Spot { Color = col, Size = si });
            }
        }

        public int Count(SpotColor color)
        {
            int count = 0;
            foreach (var item in mySpots)
            {
                if (item.Color == color)
                {
                    count++;
                }
            }
            return count;
        }

        public void Sort()
        {
            mySpots.Sort();
        }
    }
}
