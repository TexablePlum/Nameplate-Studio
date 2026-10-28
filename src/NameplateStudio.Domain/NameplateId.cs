using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public readonly record struct NameplateId
    {
        public Guid Value { get; init; }
        public NameplateId(Guid value)
        {
            Value = value;
        }
    }
}
