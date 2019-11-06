﻿using SMLHelper.V2.Patchers;
using SMLHelper.V2.Utility;

namespace SMLHelper
{
    [System.Obsolete("Use SMLHelper.V2 instead.")]
    public class CustomCraftTab
    {
        public string SpriteId
        {
            get
            {
                return Scheme.ToString() + "_" + System.IO.Path.GetFileName(Path);
            }
        }

        public string LanguageId
        {
            get
            {
                return Scheme.ToString() + "Menu_" + System.IO.Path.GetFileName(Path);
            }
        }

        public CraftTree.Type Scheme;
        public string Path;
        public string Name;
        public CustomSprite Sprite;

        public CustomCraftTab(string path, string name, CraftTree.Type scheme, Atlas.Sprite sprite)
        {
            Path = path;
            Name = name;
            Scheme = scheme;
            Sprite = new CustomSprite(SpriteManager.Group.Category, SpriteId, sprite);

            string modName = ReflectionHelper.CallingAssemblyNameByStackTrace();

            LanguagePatcher.AddCustomLanguageLine(modName, LanguageId, name);
            CustomSpriteHandler.customSprites.Add(Sprite);
        }
        
        public CustomCraftTab(string path, string name, CraftTree.Type scheme, UnityEngine.Sprite sprite) : this(path, name, scheme, new Atlas.Sprite(sprite, false))
        {
        }

        [System.Obsolete("Use CraftTree.Type instead.")]
        public CustomCraftTab(string path, string name, CraftScheme scheme, Atlas.Sprite sprite) 
            : this(path, name, Utility.CraftSchemeMap[scheme], sprite)
        {
        }

        [System.Obsolete("Use CraftTree.Type instead.")]
        public CustomCraftTab(string path, string name, CraftScheme scheme, UnityEngine.Sprite sprite)
            : this(path, name, Utility.CraftSchemeMap[scheme], sprite)
        {
        }
    }
}