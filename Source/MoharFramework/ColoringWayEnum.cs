using Verse;


namespace Mohar
{
    public enum ColoringWay
    {
        [Description("Skin first color")]
        SkinFirst = 1,
        [Description("Skin second color")]
        SkinSecond = 2,

        [Description("Insect")]
        Insect = 3,
        [Description("Human")]
        Human = 4,

        [Description("BloodFilth")]
        BloodFilth = 5,

        [Description("defaultColor")]
        DefaultColor = 6,

        [Description("Debug")]
        Debug = 7,

       [Description("Unset")]
        Unset = 8
    }
}
