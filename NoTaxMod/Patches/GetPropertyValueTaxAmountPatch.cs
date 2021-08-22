using System;
using HarmonyLib;

namespace NoTaxMod
{
    [HarmonyPatch(typeof(Taxes), nameof(Taxes.GetPropertyValueTaxAmount), new Type[] { })]
    [HarmonyPatch(typeof(Taxes), nameof(Taxes.GetPropertyValueTaxAmount), new Type[] { typeof(PlotConfig) })]
    public class GetPropertyValueTaxAmountPatch
    {
        public static bool Prefix(ref double __result)
        {
            __result = 0.0;
            return false;
        }
    }
}
