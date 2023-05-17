﻿using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Tests.Converters.Models
{
    internal class MockedEntityRepositoryProvider : IEntityRepositoryProvider
    {
        public IEAVEntityRepository<TEntity, TEntityKey> Get<TEntity, TEntityKey>()
            
            where TEntity : IEAVEntity<TEntityKey>, new()
        {
        }
    }
}