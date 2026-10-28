namespace NameplateStudio.Domain
{
    public enum ErrorType
    {
        // TODO: Define specific error types as needed
        Validation,
        NotFound,

    }
    public record Error(string Id, ErrorType Type, string Description);

    public static class Errors
    {
        // TODO: Define specific error instances as needed
        public static readonly Error FieldRequired = new Error("FieldRequired", ErrorType.Validation, "The field is required and can't be null.");
        public static readonly Error FieldAlreadyExists = new Error("FieldAlreadyExists", ErrorType.Validation, "A field with the same ID already exists.");
        public static readonly Error FieldNotFound = new Error("FieldNotFound", ErrorType.NotFound, "The specified field was not found.");
    }
}