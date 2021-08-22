using System.Reflection;
using HarmonyLib;
using SimCasino.Modding;

namespace NoTaxMod
{
    public class Main : BaseMod
    {
        // Properties
        public override string InternalName => "root.NoTaxMod";

        // Fields
        private Harmony _harmony;

        // Methods
        public override void OnLoad(GameEnvironment gameState)
        {
            _harmony = new Harmony(InternalName);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
