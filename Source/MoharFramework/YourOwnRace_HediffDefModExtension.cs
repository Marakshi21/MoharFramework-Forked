using Verse;
// Resharper disable all

namespace Mohar
{
    public class HediffDefModExtension : DefModExtension
    {
        // if pawn is not from this race, hediff wont apply, can be undefined
        public string race;
        // if pawn does not have this body part, hediff wont apply, can be undefined
        public BodyPartDef conditionalBodyPart;

        public bool debug;

        public bool TriggeredOnHediffAdded = false;
        public bool TriggeredOnIntervalPassed = true;
    }
}