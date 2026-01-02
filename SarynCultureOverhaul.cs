using HarmonyLib;
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

            SpriteLoader.LoadSprites();
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
}
