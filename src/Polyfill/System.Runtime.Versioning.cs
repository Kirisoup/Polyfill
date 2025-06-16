namespace System.Runtime.Versioning;

[AttributeUsage(
	AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | 
	AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | 
	AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | 
	AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class RequiresPreviewFeaturesAttribute : Attribute
{
	public RequiresPreviewFeaturesAttribute() {}
	public RequiresPreviewFeaturesAttribute(string message) => Message = message;

	public string? Message { get; }
	public string? Url { get; set; }
}
