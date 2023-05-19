using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public abstract class EAVAttributeBase
    {
        public virtual string? AttributeName { get; set; }

        public EAVValueKind ValueKind { get; set; }

        public EAVValueListKind ValueListKind { get; set; }
    }
}
