using System;
using System.IO;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.Library;
using TaleWorlds.ModuleManager;
using TaleWorlds.TwoDimension;

namespace Saryn_Culture_Overhaul
{
    public class SpriteLoader
    {
        public static void LoadSprites()
        {
            new SpriteData("Saryn_Culture_OverhaulSpriteData").Load(UIResourceManager.ResourceDepot);

            SpriteData spriteData = UIResourceManager.SpriteData;
            TaleWorlds.Engine.Texture engineTexture = TaleWorlds.Engine.Texture.LoadTextureFromPath("ui_charactercreation_vanilla" + ".dds", BasePath.Name + "Modules/Saryn_Culture_Overhaul/AssetSources/GauntletUI");
            engineTexture.PreloadTexture(true);
            TaleWorlds.TwoDimension.Texture texture = new TaleWorlds.TwoDimension.Texture(new EngineTexture(engineTexture));
            SpriteCategory spriteCategory = spriteData.SpriteCategories["ui_charactercreation_vanilla"];
            spriteCategory.SpriteSheets.Add(texture);
            spriteCategory.Load(UIResourceManager.ResourceContext, UIResourceManager.ResourceDepot);
            UIResourceManager.BrushFactory.Initialize();
        }
    }
}
