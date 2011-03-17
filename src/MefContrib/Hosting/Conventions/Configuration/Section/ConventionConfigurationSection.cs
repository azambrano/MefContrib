﻿namespace MefContrib.Hosting.Conventions.Configuration.Section
{
    using System.Configuration;
    using System.Diagnostics;

    public class ConventionConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// Gets a collection of <see cref="PartElement"/> instances.
        /// </summary>
        [ConfigurationProperty("parts", IsDefaultCollection = true)]
        public PartElementCollection Parts
        {
            [DebuggerStepThrough]
            get { return (PartElementCollection)base["parts"]; }
        }
    }
}