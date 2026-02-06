using Verse;
using HarmonyLib;
// Resharper disable all

namespace Mohar;

[StaticConstructorOnStartup]
public static class Mohar_Harmony 
{
    static Mohar_Harmony()
    {
        Harmony MOHAR_HARMONY = new Harmony("dusk.MOHAR");
    }
}