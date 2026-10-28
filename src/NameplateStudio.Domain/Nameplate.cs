

namespace NameplateStudio.Domain
{
    public class Nameplate
    {
        private List<Field> _fields = new List<Field>();
        public NameplateId Id { get; init; }
        public IReadOnlyList<Field> Fields => _fields.AsReadOnly();

        public Nameplate(NameplateId id)
        {
            Id = id;
        }

        public Result AddField(Field? field)
        {
            if (field is null)
                return Result.Failure(Errors.FieldRequired);

            if (_fields.Any(f => f.Id == field.Id))
                return Result.Failure(Errors.FieldAlreadyExists);

            _fields.Add(field);

            return Result.Success();
        }

        public Result RemoveField(FieldId id)
        {
            var removedCount = _fields.RemoveAll(f => f.Id == id);

            if (removedCount == 0)
                return Result.Failure(Errors.FieldNotFound);

            return Result.Success();
        }
    }
}
