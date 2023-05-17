﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface ITypeToValueConverter<T>
    {
        T Convert(IEAVValue value);

        string ConvertBack(T value);
    }
}