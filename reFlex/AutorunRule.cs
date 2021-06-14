using System;
using System.Collections.Generic;
using System.Text;

namespace reFlex
{
    [Rule("Autorun Rule", "This rule is needed to start process...lalalalala")]
    class AutorunRule : IRule
    {
        public string Name { get; set; }
        public bool Autorun { get; set; }
    }
}
