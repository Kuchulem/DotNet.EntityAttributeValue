using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using Kuchulem.DotNet.EntityAttributeValue.Converters.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Converters.EAVValueConverters
{
    public class EAVValueToIntConverter : EAVValueConverterBase<int>
    {
        public override int Convert(string value)
        {
            if (int.TryParse(value, CultureInfo.InvariantCulture, out int valueInt))
                return valueInt;

            throw new InvalidConversionException(value, typeof(int));
        }

        public override string ConvertBack(int value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
