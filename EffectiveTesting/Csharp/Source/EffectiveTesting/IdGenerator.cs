using System;

namespace EffectiveTesting
{
    internal static class IdGenerator
    {
        private static readonly Random seed = new Random();

        public static int NextId()
        {
            return seed.Next(0, 100);
        }
    }
}