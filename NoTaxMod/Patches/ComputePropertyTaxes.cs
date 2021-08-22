using HarmonyLib;

namespace NoTaxMod
{
    [HarmonyPatch(typeof(Taxes), nameof(Taxes.ComputePropertyTaxes))]
    public class ComputePropertyTaxesPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
