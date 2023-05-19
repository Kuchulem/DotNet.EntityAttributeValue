using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public abstract class EAVValueBase
    {
        public string? RawValue { get; set; }

        public EAVAttributeBase? Attribute { get; set; }

        public EAVEntityBase? Entity { get; set; }
    }
}
