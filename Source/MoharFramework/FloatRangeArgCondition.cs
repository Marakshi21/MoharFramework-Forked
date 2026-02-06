using Verse;
// Resharper disable all

namespace Mohar;
    public static class FloatRangeArgConditionMethods
    {

        //
        public static bool RandomRoll(FloatRange floatRange)
        {
            return Rand.Chance(floatRange.RandomInRange);
        }

    }
