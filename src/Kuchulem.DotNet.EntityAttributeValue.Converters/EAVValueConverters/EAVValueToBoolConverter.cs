﻿using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using Kuchulem.DotNet.EntityAttributeValue.Converters.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Converters.EAVValueConverters
{
    public class EAVValueToBoolConverter : EAVValueConverterBase<bool>
    {
        public override bool Convert(string value)
        {
            if (bool.TryParse(value, out bool result))
                return result;

            throw new InvalidConversionException(value, typeof(bool));
        }

        public override string ConvertBack(bool value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
