using Verse;
// Resharper disable all

namespace Mohar;
    public static class CurveArgConditionMethods
    {

        //
        public static bool PawnAgeCurveRandomRoll(Pawn p, SimpleCurve curve)
        {
            return Rand.Chance(curve.Evaluate(p.ageTracker.AgeBiologicalYearsFloat));
        }

        public static bool PawnHealthCurveRandomRoll(Pawn p, SimpleCurve curve)
        {
            return Rand.Chance(curve.Evaluate(p.health.summaryHealth.SummaryHealthPercent));
        }

    }
