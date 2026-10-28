using NameplateStudio.Domain;

namespace Domain.Tests
{
    public class NameplateTests
    {
        [Fact]
        public void AddField_Null_ReturnsRequiredError()
        {
            var nameplate = new Nameplate(new NameplateId(Guid.NewGuid()));

            var result = nameplate.AddField(null);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldRequired, result.Error);
            Assert.Empty(nameplate.Fields);
        }

        [Fact]
        public void AddField_DuplicateId_ReturnsAlreadyExistsErrorWithoutChangingFields()
        {
            var nameplate = new Nameplate(new NameplateId(Guid.NewGuid()));
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var duplicate = new Field(field.Id, "Serial number");
            nameplate.AddField(field);

            var result = nameplate.AddField(duplicate);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldAlreadyExists, result.Error);
            Assert.Equal([field], nameplate.Fields);
        }

        [Fact]
        public void AddField_SameNameWithDifferentIds_AddsBothFields()
        {
            var nameplate = new Nameplate(new NameplateId(Guid.NewGuid()));
            var first = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var second = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            nameplate.AddField(first);

            var result = nameplate.AddField(second);

            Assert.True(result.IsSuccess);
            Assert.Equal([first, second], nameplate.Fields);
        }

        [Fact]
        public void RemoveField_ExistingId_RemovesOnlyMatchingField()
        {
            var nameplate = new Nameplate(new NameplateId(Guid.NewGuid()));
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var remaining = new Field(new FieldId(Guid.NewGuid()), "Serial number");
            nameplate.AddField(field);
            nameplate.AddField(remaining);

            var result = nameplate.RemoveField(field.Id);

            Assert.True(result.IsSuccess);
            Assert.Equal([remaining], nameplate.Fields);
        }

        [Fact]
        public void RemoveField_UnknownId_ReturnsNotFoundErrorWithoutChangingFields()
        {
            var nameplate = new Nameplate(new NameplateId(Guid.NewGuid()));
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            nameplate.AddField(field);

            var result = nameplate.RemoveField(new FieldId(Guid.NewGuid()));

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldNotFound, result.Error);
            Assert.Equal([field], nameplate.Fields);
        }
    }
}
