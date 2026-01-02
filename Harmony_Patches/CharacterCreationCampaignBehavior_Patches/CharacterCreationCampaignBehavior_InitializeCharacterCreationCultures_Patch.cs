using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace Saryn_Culture_Overhaul
{
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior), "InitializeCharacterCreationCultures")]
    public static class CharacterCreationCampaignBehavior_InitializeCharacterCreationCultures_Patch
    {
        public static bool Prefix(CharacterCreationManager characterCreationManager)
        {
            //InformationManager.DisplayMessage(new InformationMessage("InitializeCharacterCreationCultures Called"));
            foreach (CultureObject cultureObject in Game.Current.ObjectManager.GetObjectTypeList<CultureObject>())
            {
                if (cultureObject.StringId.Contains("aserai") || 
                    cultureObject.StringId.Contains("battania") || 
                    cultureObject.StringId.Contains("empire") || 
                    cultureObject.StringId.Contains("khuzait") ||
                    cultureObject.StringId.Contains("nord") ||
                    cultureObject.StringId.Contains("sturgia") || 
                    cultureObject.StringId.Contains("vlandia"))
                {
                    characterCreationManager.CharacterCreationContent.AddCharacterCreationCulture(cultureObject, 1, 10);
                }
            }
            return false;
        }

            //List<CultureObject> allCultures = Helpers.GetAllCultures();
            //foreach (var culture in allCultures)
            //{
            //    InformationManager.DisplayMessage(new InformationMessage($"Culture ID: {culture.StringId}, Name: {culture.Name}"));
            //}
    }
}

