using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccesfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach(IInvader invader in invaders)
            {
                //shoot if tower is in range of invader and invader is active
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccesfulShot())
                    {
                        invader.DecreaseHealth(Power);

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    //break so that it only shoots one at a time
                    break;
                }
            }
        }
    }
}
