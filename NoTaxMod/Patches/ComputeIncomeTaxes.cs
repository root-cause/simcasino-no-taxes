using HarmonyLib;

namespace NoTaxMod
{
    [HarmonyPatch(typeof(Taxes), nameof(Taxes.ComputeIncomeTaxes))]
    public class ComputeIncomeTaxesPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
