using Verse;

namespace Mohar.Ubet;
    public static class FloatRangeArgConditionMethods
    {

        //
        public static bool RandomRoll(FloatRange floatRange)
        {
            return Rand.Chance(floatRange.RandomInRange);
        }

    }
