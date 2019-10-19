using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    //MapLocation is a sub class (Child class, Derived class) of Point (Base class, Parent class, Super Class)
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
