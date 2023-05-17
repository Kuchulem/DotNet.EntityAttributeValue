using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using Kuchulem.DotNet.EntityAttributeValue.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.DotNet.EntityAttributeValue.Tests.Converters.Models
{
    internal class MockEntityRepository : IEAVEntityRepository<MockEntity, string>
    {
        private IEnumerable<MockEntity> entities = new[]
        {
            new MockEntity
            {
                Id = "valid-entity",
                Values = new[]
                {
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "string-value",
                            ValueKind = EAVValueKind.String,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = "lorem ipsum"
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "int-value",
                            ValueKind = EAVValueKind.Integer,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = 2.ToString(CultureInfo.InvariantCulture)
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "double-value",
                            ValueKind = EAVValueKind.Double,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = 3.1415.ToString(CultureInfo.InvariantCulture)
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "bool-value-true",
                            ValueKind = EAVValueKind.Boolean,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = true.ToString(CultureInfo.InvariantCulture)
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "bool-value-false",
                            ValueKind = EAVValueKind.Boolean,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = false.ToString(CultureInfo.InvariantCulture)
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "datetime-value",
                            ValueKind = EAVValueKind.DateTime,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = new DateTime(2023, 5, 15, 19, 4, 0).ToString(CultureInfo.InvariantCulture)
                    },
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "entity-value",
                            ValueKind = EAVValueKind.Entity,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = new DateTime(2023, 5, 15, 19, 4, 0).ToString(CultureInfo.InvariantCulture)
                    },
                }
            },
            new MockEntity
            {
                Id = "child",
                Values = new[] 
                {
                    new EAVValue
                    {
                        Attribute = new EAVAttribute
                        {
                            AttributeName = "string-value",
                            ValueKind = EAVValueKind.String,
                            ValueListKind = EAVValueListKind.None
                        },
                        Entity = null,
                        RawValue = "lorem ipsum"
                    },
                }
            }
        };

        public MockEntity GetByKey(string key)
        {
            var entity = entities.Where(e => e.Id == key).FirstOrDefault();
            if (entity is not null)
                return entity;

            throw new Exception($"{key} not found in stored entities");
        }
    }
}
