using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace Clean
{
    internal class CleanManifestFilter : IManifestFilter
    {
        public void Filter(List<PackageManifest> manifests)
        {
            var assembly = typeof(CleanManifestFilter).Assembly;

            manifests.Add(new PackageManifest
            {
                PackageName = "Clean",
                Version = assembly.GetName()?.Version?.ToString(3) ?? "3.1.3",
                AllowPackageTelemetry = true
            });
        }
    }
}