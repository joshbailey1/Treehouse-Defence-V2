using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        public BasicInvader(Path path) : base(path)
        {

        }
    }
}
