using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.ViewModelCollection.CharacterCreation;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.Library;
using TaleWorlds.TwoDimension;

namespace Saryn_Culture_Overhaul
{
    // sorts cultures by name in the Culture selection list
    [HarmonyPatch(typeof(CharacterCreationCultureStageVM), "SortCultureList")]
    public static class CharacterCreationCultureStageVM_SortCultureList_Patch
    {
        public static bool Prefix(MBBindingList<CharacterCreationCultureVM> listToWorkOn)
        {
            InformationManager.DisplayMessage(new InformationMessage("SortCultureList called"));
            listToWorkOn.Sort(new NameTextComparer());

            foreach (KeyValuePair<string, SpriteCategory> sploadingCategory in UIResourceManager.SpriteData.SpriteCategories)
            {

                foreach (SpritePart spritePart in sploadingCategory.Value.SpriteParts)
                {
                    if (spritePart.Name.Contains("empire") || spritePart.Name.Contains("Empire"))
                    {
                        InformationManager.DisplayMessage(new InformationMessage(spritePart.Name));
                    }
                }
            }
            return false;
        }

        private sealed class NameTextComparer : IComparer<CharacterCreationCultureVM>
        {
            public int Compare(CharacterCreationCultureVM x, CharacterCreationCultureVM y)
            {
                // Prefer NameText; fallback to ShortenedNameText; then Culture.StringId
                string sx = x?.NameText ?? x?.ShortenedNameText ?? x?.Culture?.StringId ?? string.Empty;
                string sy = y?.NameText ?? y?.ShortenedNameText ?? y?.Culture?.StringId ?? string.Empty;
                return StringComparer.InvariantCultureIgnoreCase.Compare(sx, sy);
            }
        }
    }
}
