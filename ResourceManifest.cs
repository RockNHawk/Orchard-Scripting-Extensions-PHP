﻿using Orchard.UI.Resources;

namespace OrchardHUN.Scripting.Php
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineStyle("ScriptingPhpAdmin").SetUrl("orchardhun-scripting-php-admin.css");
        }
    }
}