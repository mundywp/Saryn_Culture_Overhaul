using System;
using System.Collections.Generic;

using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace Saryn_Culture_Overhaul
{
    public class Helpers
    {
        // For debugging. Helps you easily return the list of cultures the game has loaded so you can print them to the console.
        public static List<CultureObject> GetAllCultures()
        {
            if (Game.Current != null)
            {
                return Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            }
            return new List<CultureObject>();
        }
        /// <summary>
        /// This is the core innovation of this mod.
        /// By using IDs for new cultures that contain the original names of the vanilla culture IDs, we can use this method to quickly find the appropriate "culture group"
        /// to place that culture in, and we can use this to quickly and easily patch a lot of the game's files that directly reference cultureID.
        /// (Mostly in CharacterCreationCampaignBehavior, as of Bannerlord 1.3)
        /// 
        /// This means that if you add any new culture, as long as you make the culture's Id value something like "empire2" you won't have to do ANY additional Harmony patching
        /// to get that culture to work out of the box. It will automatically be affected by all the patches I have already written.
        /// (You still have to set up the XSLT files for each culture's module data, but if you configure them to use vanilla culture sprites, as described in the README.txt of
        /// the GUI folder of this mod, you can do so without having to compile any new image sources.)
        /// 
        /// </summary>
        /// <param name="cultureId">The cultureID of the modded culture that contains a string of the culture you want it to be compared with. i.e. empire2, aserai3</param>
        /// <returns>The vanilla cultureId that corresponds to the culture. Defaults to "vlandia" in the case of a cultureId not matching - we want it to return a useful value.</returns>
        public static string ConvertCultureIdToVanillaCultureGroup(string cultureId)
        {
            InformationManager.DisplayMessage(new InformationMessage("Convert Culture called on culture ID: " + cultureId));

            if (cultureId.Contains("empire"))
            {
                return "empire";
            }
            if (cultureId.Contains("aserai"))
            {
                return "aserai";
            }
            if (cultureId.Contains("battania"))
            {
                return "battania";
            }
            if (cultureId.Contains("khuzait"))
            {
                return "khuzait";
            }
            if (cultureId.Contains("nord"))
            {
                return "nord";
            }
            if (cultureId.Contains("sturgia"))
            {
                return "sturgia";
            }
            return "vlandia";
        }
    }
}
