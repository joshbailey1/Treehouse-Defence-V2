using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Path
    {
        private MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
        
        /* my old method for seeing if a point is on the path or not
        public bool OnPath(int X, int Y)
        {
            //returns true if point is on the path
            foreach (MapLocation maplocation in _path)
            {
                if (maplocation.X == X && maplocation.Y == Y)
                {
                    return true;
                }
            }
            return false;
        }
        */
        
        //the new method that treehouse showed me, for this we overrided
        //the  equals method from the base object class
        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if (location.Equals(pathLocation))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
