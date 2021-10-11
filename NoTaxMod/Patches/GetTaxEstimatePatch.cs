using HarmonyLib;

namespace NoTaxMod
{
    [HarmonyPatch(typeof(Taxes), nameof(Taxes.GetTaxEstimate))]
    public class GetTaxEstimatePatch
    {
        public static bool Prefix(out double income, out double incomeTax, out double propertyTax, ref double __result)
        {
            income = Taxes.CalculateIncome(GameTimer.Day - 1, false);
            incomeTax = 0.0;
            propertyTax = 0.0;
            __result = 0.0; // unused?
            return false;
        }
    }
}
