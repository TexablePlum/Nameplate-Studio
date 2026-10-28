using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public abstract record FieldElement(FieldElementId Id);

    public sealed record TextFieldElement(FieldElementId Id, string Text) : FieldElement(Id);
}
