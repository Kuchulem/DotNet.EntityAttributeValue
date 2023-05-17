﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVEntityDefinition
    {
        public string DefinitionName { get; set; }
        public IEnumerable<IEAVAttribute> Attributes { get; set; }
    }
}