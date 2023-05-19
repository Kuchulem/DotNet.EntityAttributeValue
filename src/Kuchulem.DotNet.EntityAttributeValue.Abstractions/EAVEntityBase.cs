using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public abstract class EAVEntityBase
    {
        public IEnumerable<EAVValueBase> Values { get; set; } = Enumerable.Empty<EAVValueBase>();
    }
}
