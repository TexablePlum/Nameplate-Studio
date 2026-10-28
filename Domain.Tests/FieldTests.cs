using NameplateStudio.Domain;

namespace Domain.Tests
{
    public class FieldTests
    {
        [Fact]
        public void AddElement_Null_ReturnsRequiredError()
        {
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");

            var result = field.AddElement(null);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldElementRequired, result.Error);
            Assert.Empty(field.Elements);
        }

        [Fact]
        public void AddElement_DuplicateId_ReturnsAlreadyExistsErrorWithoutChangingElements()
        {
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var element = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company name");
            var duplicate = new TextFieldElement(element.Id, "Company address");
            field.AddElement(element);

            var result = field.AddElement(duplicate);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldElementAlreadyExists, result.Error);
            Assert.Equal(new FieldElement[] { element }, field.Elements);
        }

        [Fact]
        public void AddElement_SameTextWithDifferentIds_AddsBothElements()
        {
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var first = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company name");
            var second = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company name");
            field.AddElement(first);

            var result = field.AddElement(second);

            Assert.True(result.IsSuccess);
            Assert.Equal(new FieldElement[] { first, second }, field.Elements);
        }

        [Fact]
        public void RemoveElement_ExistingId_RemovesOnlyMatchingElement()
        {
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var element = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company name");
            var remaining = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company address");
            field.AddElement(element);
            field.AddElement(remaining);

            var result = field.RemoveElement(element.Id);

            Assert.True(result.IsSuccess);
            Assert.Equal(new FieldElement[] { remaining }, field.Elements);
        }

        [Fact]
        public void RemoveElement_UnknownId_ReturnsNotFoundErrorWithoutChangingElements()
        {
            var field = new Field(new FieldId(Guid.NewGuid()), "Manufacturer");
            var element = new TextFieldElement(new FieldElementId(Guid.NewGuid()), "Company name");
            field.AddElement(element);

            var result = field.RemoveElement(new FieldElementId(Guid.NewGuid()));

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.FieldElementNotFound, result.Error);
            Assert.Equal(new FieldElement[] { element }, field.Elements);
        }
    }
}
