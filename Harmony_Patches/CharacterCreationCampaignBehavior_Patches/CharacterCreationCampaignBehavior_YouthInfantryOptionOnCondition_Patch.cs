using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;

namespace Saryn_Culture_Overhaul
{
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior), "YouthInfantryOptionOnCondition")]
    public class CharacterCreationCampaignBehavior_YouthInfantryOptionOnCondition_Patch
    {
        private static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            __result = characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("aserai") || characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("battania") ||
                characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("empire") || characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("khuzait") ||
                characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("sturgia") || characterCreationManager.CharacterCreationContent.SelectedCulture.StringId.Contains("vlandia");
        }
    }
}
