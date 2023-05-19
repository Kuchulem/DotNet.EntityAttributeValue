using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVValueConverterProvider
    {
        IEAVValueConverterProvider Register<T>(EAVValueKind valueKind, EAVValueConverterBase<T> converter);

        IEAVValueConverterProvider Register<T>(EAVAttributeBase attribute, EAVValueConverterBase<T> converter);

        EAVValueConverterBase<T> GetConverter<T>(EAVValueKind valueKind);

        EAVValueConverterBase<T> GetConverter<T>(EAVAttributeBase attribute);

        bool TryGetConverter<T>(EAVValueKind valueKind, out EAVValueConverterBase<T>? converter);

        bool TryGetConverter<T>(EAVAttributeBase attribute, out EAVValueConverterBase<T>? converter);
    }
}
