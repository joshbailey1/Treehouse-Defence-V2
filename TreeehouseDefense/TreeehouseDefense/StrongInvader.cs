using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 3;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
