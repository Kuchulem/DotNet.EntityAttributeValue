using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEAVEntityRepository<TEntity, TEntityKey>
        where TEntity : IEAVEntity<TEntityKey>, new()
    {
        TEntity GetByKey(TEntityKey key);
    }
}
