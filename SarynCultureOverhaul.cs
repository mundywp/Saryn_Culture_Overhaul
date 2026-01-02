using HarmonyLib;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.TwoDimension;

namespace Saryn_Culture_Overhaul
{
    public class SarynCultureOverhaul : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Harmony harmony = new Harmony("SarynCultureOverhaul");
            harmony.PatchAll();
            base.OnSubModuleLoad();
            InformationManager.DisplayMessage(new InformationMessage("Saryn_Culture_Overhaul Loaded"));

            // SpriteLoader.LoadSprites("ui_charactercreation_vanilla");
        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
    }

    [HarmonyPatch(typeof(SpriteData), "GetSprite")]
    public class SpriteData_GetSprite_Patch
    {
        public static void Postfix(string name, ref Sprite __result)
        {
            SpriteData spriteData = UIResourceManager.SpriteData;

            if(name == "CharacterCreation\\Culture\\empire2") // Your custom culture's ID that is impossible to load because there's no Brush, it's hardcoded for some reason
            {
                name = "CharacterCreation\\Culture\\empire"; // The name of the vanilla culture whose asset you want to use for the Character Creation Screen
            }
            // Add more if statments here for each culture you wish to have custom

            Sprite result;
            if (spriteData.Sprites.TryGetValue(name, out result))
            {
                __result = result;
            }
        }
    }
}
