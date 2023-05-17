using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Converters
{
    public class ValueConverter
    {
        private readonly IEntityRepositoryProvider entityRepositoryProvider;

        public ValueConverter(IEntityRepositoryProvider entityRepositoryProvider)
        {
            this.entityRepositoryProvider = entityRepositoryProvider;
        }

        public T? Convert<T>(IEAVValue value)
        {
            if (!MatchesType<T>(value))
                throw new Exception("Invalid type");

            return (T?)DoConvert(value);
        }

        private bool MatchesType<T>(IEAVValue value)
        {
            if(!MatchesListType<T>(value))
                return false;

            var type = typeof(T);

            return value.Attribute?.ValueKind switch
            {
                EAVValueKind.Boolean => type == typeof(bool),
                EAVValueKind.DateTime => type == typeof(DateTime),
                EAVValueKind.Entity => type.IsAssignableFrom(typeof(IEAVEntity)),
                EAVValueKind.Integer => 
                    type == typeof(int),
                EAVValueKind.Double =>
                    type == typeof(double),
                _ => type == typeof(string)
            };
        }

        private bool MatchesListType<T>(IEAVValue value)
        {
            return (typeof(T).IsAssignableFrom(typeof(IEnumerable<object>))
                && EAVValueListKind.Multiple == value.Attribute?.ValueListKind)
                || EAVValueListKind.Multiple != value.Attribute?.ValueListKind;
        }

        private object? DoConvert(IEAVValue value)
        {
            return value.Attribute?.ValueKind switch
            {
                EAVValueKind.Boolean => value.RawValue == true.ToString(CultureInfo.InvariantCulture),
                EAVValueKind.DateTime => DateTime.Parse(value.RawValue ?? "", CultureInfo.InvariantCulture),
                //EAVValueKind.Entity => entityRepository.GetByKey(value.RawValue),
                EAVValueKind.Double => double.Parse(value.RawValue ?? "", CultureInfo.InvariantCulture),
                EAVValueKind.Integer => int.Parse(value.RawValue ?? "", CultureInfo.InvariantCulture),
                _ => value.RawValue
            };
        }
    }
}
