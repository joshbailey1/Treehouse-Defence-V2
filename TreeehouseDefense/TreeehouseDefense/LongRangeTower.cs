using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 5;
        public LongRangeTower(MapLocation location) : base(location) { }
    }
}
