using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            //returns true if point is inside the map
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }

        public string DisplayMap(Path path, Map map)
        {
            string mapDisplay = "-";
            //numbering so that you can see where certain points are on the map, 
            //k is the x value, have to do this before the loop so that the numbering is on top
            for (int k=0; k < Width; k++)
            {
                mapDisplay += "-" + k;
            }
            mapDisplay += "\n";
            for (int i=0; i < Height; i++)
            {
                //numbering again, i is the y values, can do this inside the loop
                mapDisplay += i;
                for (int j=0; j < Width; j++)
                {
                    MapLocation ijPoint = new MapLocation(j, i, map);
                    if (path.IsOnPath(ijPoint))
                    {
                        mapDisplay += "-P";
                    } 
                    else
                    {
                        mapDisplay += "-M";
                    }

                }
                mapDisplay += "\n";
            }
            return mapDisplay;
        }
    }
}
