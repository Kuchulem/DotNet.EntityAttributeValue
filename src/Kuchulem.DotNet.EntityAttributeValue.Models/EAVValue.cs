using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Models
{
    public class EAVValue : IEAVValue
    {
        public string? RawValue { get; set; }

        public IEAVAttribute? Attribute { get; set; }

        public IEAVEntity? Entity { get; set; }
    }
}
