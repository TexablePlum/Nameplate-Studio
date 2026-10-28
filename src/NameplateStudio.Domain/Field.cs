using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public class Field
    {
        public FieldId Id { get; init; }
        public string Name { get; init; }

        public Field(FieldId id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
