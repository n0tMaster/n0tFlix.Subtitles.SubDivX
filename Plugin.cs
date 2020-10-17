using System;
using System.Collections.Generic;
using n0tFlix.Subtitles.SubDivX.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace n0tFlix.Subtitles.SubDivX
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public override Guid Id => new Guid("AA3B7CCD-BF23-4FE2-A9B9-69CCAD2E076B");
        public override string Name => "SubdivX";
        public override string Description => "Download subtitles for Movies and TV Shows using SubdivX";
        public static Plugin Instance { get; private set; }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = this.Name,
                    EmbeddedResourcePath = string.Format("{0}.Configuration.index.html", GetType().Namespace)
                }
            };
        }
    }

}

