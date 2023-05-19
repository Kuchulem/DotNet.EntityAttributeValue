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

        IEAVValueConverterProvider Register<T>(IEAVAttribute attribute, EAVValueConverterBase<T> converter);

        EAVValueConverterBase<T> GetConverter<T>(EAVValueKind valueKind);

        EAVValueConverterBase<T> GetConverter<T>(IEAVAttribute attribute);

        bool TryGetConverter<T>(EAVValueKind valueKind, out EAVValueConverterBase<T>? converter);

        bool TryGetConverter<T>(IEAVAttribute attribute, out EAVValueConverterBase<T>? converter);
    }
}
