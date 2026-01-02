using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.CampaignBehaviors;

namespace Saryn_Culture_Overhaul
{
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior), "GetMotherEquipmentId")]
    public class CharacterCreationCampaignBehavior_GetMotherEquipmentId_Patch
    {
        private static void Postfix(ref string __result, string cultureId)
        {
            var vanillaCultureId = Helpers.ConvertCultureIdToVanillaCultureGroup(cultureId);
            __result = __result.Replace("_" + cultureId, "_" + vanillaCultureId);
        }
    }
}
