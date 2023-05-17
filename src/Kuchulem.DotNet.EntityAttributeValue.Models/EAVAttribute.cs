using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Models
{
    public class EAVAttribute : IEAVAttribute
    {
        public required string AttributeName { get; set; }

        public EAVValueKind ValueKind { get; set; }

        public EAVValueListKind ValueListKind { get; set; }
    }
}
