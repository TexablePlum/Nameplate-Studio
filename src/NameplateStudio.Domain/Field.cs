using System;
using System.Collections.Generic;
using System.Text;

namespace NameplateStudio.Domain
{
    public class Field
    {
        public FieldId Id { get; init; }
        public string Name { get; init; }
        private List<FieldElement> _elements = new List<FieldElement>();
        public IReadOnlyList<FieldElement> Elements => _elements.AsReadOnly();

        public Field(FieldId id, string name)
        {
            Id = id;
            Name = name;
        }

        public Result AddElement(FieldElement? element)
        {
            if (element is null)
                return Result.Failure(Errors.FieldElementRequired);
            if (_elements.Any(e => e.Id == element.Id))
                return Result.Failure(Errors.FieldElementAlreadyExists);
            _elements.Add(element);
            return Result.Success();
        }

        public Result RemoveElement(FieldElementId id)
        {
            var removedCount = _elements.RemoveAll(e => e.Id == id);
            if (removedCount == 0)
                return Result.Failure(Errors.FieldElementNotFound);
            return Result.Success();
        }
    }
}
