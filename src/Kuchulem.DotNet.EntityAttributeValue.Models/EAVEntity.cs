using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Models
{
    public abstract class EAVEntity<TEntityKey> : IEAVEntity<TEntityKey>
    {
        public IEnumerable<IEAVValue> Values { get; set; } = Enumerable.Empty<IEAVValue>();
        public abstract TEntityKey Identifier { get; }
    }
}
