﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Nehawu.MembershipRegistration.Backend.Localization
{
    public static class ShaProjectNameLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource("ShaProjectName",
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ShaProjectNameLocalizationConfigurer).GetAssembly(),
                        "Nehawu.MembershipRegistration.Backend.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
