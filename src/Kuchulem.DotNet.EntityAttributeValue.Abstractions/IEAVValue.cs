using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVValue
    {
        IEAVEntity? Entity { get; set; }
        IEAVAttribute? Attribute { get; set; }
        string? RawValue { get; set; }
    }
}
