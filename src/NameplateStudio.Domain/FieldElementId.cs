using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public readonly record struct FieldElementId
    {
        public Guid Value { get; init; }

        public FieldElementId(Guid value)
        {
            Value = value;
        }
    }
}
