using System;

namespace reFlex
{
    class RuleAttribute : Attribute
    {
        public string Name;
        public string Description;

        public RuleAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
