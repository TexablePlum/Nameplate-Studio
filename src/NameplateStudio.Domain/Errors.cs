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

        public static readonly Error FieldElementRequired = new("FieldElement.Required", ErrorType.Validation, "The field element is required.");
        public static readonly Error FieldElementAlreadyExists = new("FieldElement.AlreadyExists", ErrorType.Validation, "A field element with the same ID already exists.");
        public static readonly Error FieldElementNotFound = new("FieldElement.NotFound", ErrorType.NotFound, "The specified field element was not found.");

        public static readonly Error SvgContentRequired = new("SvgContent.Required", ErrorType.Validation, "The SVG content is required.");
        public static readonly Error SvgContentInvalidXml = new("SvgContent.InvalidXml", ErrorType.Validation, "The SVG content must be a well-formed XML document without a DTD.");
        public static readonly Error SvgContentInvalidRoot = new("SvgContent.InvalidRoot", ErrorType.Validation, "The document root must be an svg element in the http://www.w3.org/2000/svg namespace.");
    }
}
