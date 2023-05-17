using Kuchulem.DotNet.EntityAttributeValue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Tests.Converters.Models
{
    public class MockEntity : EAVEntity<string>
    {
        public string Id { get; set; } = string.Empty;

        public override string Identifier => Id;
    }
}
