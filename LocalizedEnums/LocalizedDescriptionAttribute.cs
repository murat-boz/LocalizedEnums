using System;
using System.ComponentModel;
using System.Resources;

namespace LocalizedEnums
{
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private ResourceManager resourceManager;
        private readonly string resoucerKey;

        public LocalizedDescriptionAttribute(string resoucerKey, Type resourceType)
        {
            this.resourceManager = new ResourceManager(resourceType);
            this.resoucerKey     = resoucerKey;
        }

        public override string Description 
        {
            get
            {
                string description = this.resourceManager.GetString(resoucerKey);

                return string.IsNullOrEmpty(description)
                    ? $"[[{this.resoucerKey}]]"
                    : description;
            }
        }
    }
}
