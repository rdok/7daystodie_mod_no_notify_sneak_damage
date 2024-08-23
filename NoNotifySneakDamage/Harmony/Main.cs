namespace NoNotifySneakDamage.Harmony
{
    public class Main
    {
        public class Init : IModApi
        {
            public void InitMod(Mod modInstance)
            {
                const string id = "uk.co.rdok.7daystodie.mods.no_notify_sneak_damage";
                var harmony = new HarmonyLib.Harmony(id);
                harmony.PatchAll();
            }
        }
    }
}