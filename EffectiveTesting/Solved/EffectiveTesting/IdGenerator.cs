using System;

namespace EffectiveTesting
{
    internal class IdGenerator : IIdGenerator
    {
        private static readonly Random seed = new Random();

        public int NextId()
        {
            return seed.Next(0, 100);
        }
    }
}