using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    abstract class Invader : IInvader
    {

        //fields
        private int _pathStep = 0;
        private readonly Path _path;

        //location property
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        protected virtual int StepSize { get; } = 1;

        public abstract int Health { get; protected set; }

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => (Health <= 0);
        public bool IsActive => !(IsNeutralized || HasScored);

        //constructor
        public Invader(Path path)
        {
            _path = path;
        }

        //method
        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
                Health -= factor;
                Console.WriteLine("Shot at and hit an invader");
        }
    }
}
