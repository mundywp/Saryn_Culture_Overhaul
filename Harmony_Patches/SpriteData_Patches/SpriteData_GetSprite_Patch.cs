using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.TwoDimension;

namespace Saryn_Culture_Overhaul
{
    [HarmonyPatch(typeof(SpriteData), "GetSprite")]
    public class SpriteData_GetSprite_Patch
    {
        public static void Postfix(string name, ref Sprite __result)
        {
            SpriteData spriteData = UIResourceManager.SpriteData;

            // Your custom culture's ID that is impossible to load because there's no Brush, it's hardcoded for some reason
            // I'm using Contains() here to make it resilient to adding new cultures with "empireX" IDs without having to edit the code every time
            if (name.Contains("CharacterCreation\\Culture\\empire"))
            {
                name = "CharacterCreation\\Culture\\empire"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\aserai"))
            {
                name = "CharacterCreation\\Culture\\aserai"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\battania"))
            {
                name = "CharacterCreation\\Culture\\battania"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\khuzait"))
            {
                name = "CharacterCreation\\Culture\\khuzait"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\nord"))
            {
                name = "CharacterCreation\\Culture\\nord"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\sturgia"))
            {
                name = "CharacterCreation\\Culture\\sturgia"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            if (name.Contains("CharacterCreation\\Culture\\vlandia"))
            {
                name = "CharacterCreation\\Culture\\vlandia"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            // Add more if statments here for each culture you wish to have custom

            Sprite result;
            if (spriteData.Sprites.TryGetValue(name, out result))
            {
                __result = result;
            }
            // If you find nothing, use orginal null return without overwriting it, no need to do another override here
        }
    }
}
