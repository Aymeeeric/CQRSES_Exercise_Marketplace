using System;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class ClassifiedAdText : Value<ClassifiedAdText>
    {
        public static ClassifiedAdText FromString(string text) => new ClassifiedAdText(text);

        private readonly string _value;

        private ClassifiedAdText(string value)
        {
            if (value.Length > 1000)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Text cannot be longer that 1000 characters");

            _value = value;
        }
    }
}