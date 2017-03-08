namespace EffectiveTesting
{
    internal static class IdGenerator
    {
        /// <summary>
        /// Only for tests
        /// </summary>
        internal static int Current { get; set; }

        public static int NextId()
        {
            Current++;
            return Current;
        }
    }
}