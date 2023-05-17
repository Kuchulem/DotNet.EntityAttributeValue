using Kuchulem.DotNet.EntityAttributeValue.Abstractions;
using Kuchulem.DotNet.EntityAttributeValue.Converters;
using Kuchulem.DotNet.EntityAttributeValue.Tests.Converters.Models;

namespace Kuchulem.DotNet.EntityAttributeValue.Tests.Converters
{
    public class ValueConverter_Should
    {
        private IEAVEntityRepository<MockEntity, string> entityRepositoryProvider = new MockEntityRepository();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertToString()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<string>(entity.Values.Where(v => v.Attribute?.AttributeName == "string-value").First());

            Assert.That(value is string strValue && strValue == "lorem ipsum", Is.True);
        }

        [Test]
        public void ConvertToInt()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<int>(entity.Values.Where(v => v.Attribute?.AttributeName == "int-value").First());

            Assert.That(value is int intValue && intValue == 2, Is.True);
        }

        [Test]
        public void ConvertToDouble()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<double>(entity.Values.Where(v => v.Attribute?.AttributeName == "double-value").First());

            Assert.That(value is double doubleValue && doubleValue == 3.1415, Is.True);
        }

        [Test]
        public void ConvertToBoolean_True()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<bool>(entity.Values.Where(v => v.Attribute?.AttributeName == "bool-value-true").First());

            Assert.That(value is bool boolValue && boolValue, Is.True);
        }

        [Test]
        public void ConvertToBoolean_False()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<bool>(entity.Values.Where(v => v.Attribute?.AttributeName == "bool-value-false").First());

            Assert.That(value is bool boolValue && !boolValue, Is.True);
        }

        [Test]
        public void ConvertToDateTime()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<DateTime>(entity.Values.Where(v => v.Attribute?.AttributeName == "datetime-value").First());

            Assert.That(value is DateTime boolValue && boolValue == new DateTime(2023, 5, 15, 19, 4, 0), Is.True);
        }

        [Test]
        public void ConvertToEntity()
        {
            var entity = entityRepositoryProvider.GetByKey("valid");

            var valueConverter = new ValueConverter(entityRepositoryProvider);

            var value = valueConverter.Convert<MockEntity>(entity.Values.Where(v => v.Attribute?.AttributeName == "entity-value").First());

            Assert.That(value is MockEntity child && child.Identifier == "child", Is.True);
        }
    }
}