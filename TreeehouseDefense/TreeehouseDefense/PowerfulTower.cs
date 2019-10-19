using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class PowerfulTower : Tower
    {
        protected override int Power { get; } = 3;
        public PowerfulTower(MapLocation location) : base(location) { }
    }
}
