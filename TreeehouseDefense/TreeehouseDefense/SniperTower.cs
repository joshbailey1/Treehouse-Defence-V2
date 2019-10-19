using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;
        protected override double Accuracy { get; } = 1.0;
        public SniperTower(MapLocation location) : base(location) { }
    }
}
