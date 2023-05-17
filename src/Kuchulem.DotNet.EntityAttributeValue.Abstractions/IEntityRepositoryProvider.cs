using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Abstractions
{
    public interface IEntityRepositoryProvider
    {
        IEAVEntityRepository<TEntity, TEntityKey> Get<TEntity, TEntityKey>()
            where TEntity : IEAVEntity<TEntityKey>, new();
    }
}
