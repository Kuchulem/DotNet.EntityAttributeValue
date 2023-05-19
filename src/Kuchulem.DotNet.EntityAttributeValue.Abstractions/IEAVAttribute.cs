using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVAttribute
    {
        string? AttributeName { get; set; }

        EAVValueKind ValueKind { get; set; }

        EAVValueListKind ValueListKind { get; set; }
    }
}
