﻿using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Tiers.Settings.Service.Db
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnectionString { get; set; }

        public string DataConnectionString { get; set; }
    }
}