using HarmonyLib;

namespace NoNotifySneakDamage.Harmony
{
    [HarmonyPatch(typeof(EntityPlayerLocal), nameof(EntityPlayerLocal.NotifySneakDamage))]
    public class NoNotifySneakDamage
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}