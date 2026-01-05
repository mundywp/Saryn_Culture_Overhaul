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

            // Not using this anymore, but leaving it in to remember where it was called if I did want to load sprites
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

    // GetRandomTemplateByOccupation - use this to do the culture blending
}
