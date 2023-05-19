﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public abstract class EAVValueConverterBase<T>
    {
        public abstract T Convert(string value);

        public abstract string ConvertBack(T value);
    }
}