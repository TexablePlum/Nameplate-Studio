using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public readonly record struct FieldId
    {
        public Guid Value { get; init; }
        public FieldId(Guid value)
        {
            Value = value;
        }
    }
}
