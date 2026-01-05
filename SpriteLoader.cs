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
        public static void LoadSprites(string name)
        {
            // This doesn't seem to work and I don't know why, so I've used SpriteData_GetSprite_Patch to force the asset I want on the back end rather than fighting with custom assets
            new SpriteData("Saryn_Culture_OverhaulSpriteData").Load(UIResourceManager.ResourceDepot);

            SpriteData spriteData = UIResourceManager.SpriteData;
            TaleWorlds.Engine.Texture engineTexture = TaleWorlds.Engine.Texture.LoadTextureFromPath(name + ".dds", BasePath.Name + "Modules/Saryn_Culture_Overhaul/AssetSources/GauntletUI");
            engineTexture.PreloadTexture(true);
            TaleWorlds.TwoDimension.Texture texture = new TaleWorlds.TwoDimension.Texture(new EngineTexture(engineTexture));
            SpriteCategory spriteCategory = spriteData.SpriteCategories[name];
            spriteCategory.SpriteSheets.Add(texture);
            spriteCategory.Load(UIResourceManager.ResourceContext, UIResourceManager.ResourceDepot);
            UIResourceManager.BrushFactory.Initialize();
        }
    }
}
