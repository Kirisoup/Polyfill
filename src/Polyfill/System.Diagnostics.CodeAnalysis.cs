namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class ConstantExpectedAttribute : Attribute {
	public object? Min { get; set; }
	public object? Max { get; set; }
}

[AttributeUsage(
	AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | 
	AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | 
	AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | 
	AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, 
	Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class ExperimentalAttribute(string diagnosticId) : Attribute {
	public string DiagnosticId { get; } = diagnosticId;
	public string? UrlFormat { get; set; }
}

[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class SetsRequiredMembersAttribute : Attribute;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, 
	AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class StringSyntaxAttribute : Attribute
{
	public StringSyntaxAttribute(string syntax) {
		Syntax = syntax;
		Arguments = [];
	}

	public StringSyntaxAttribute(string syntax, params object?[] arguments) {
		Syntax = syntax;
		Arguments = arguments;
	}

	public string Syntax { get; }

	public object?[] Arguments { get; }

	public const string 
		CompositeFormat = "CompositeFormat",
		DateOnlyFormat = "DateOnlyFormat",
		DateTimeFormat = "DateTimeFormat",
		EnumFormat = "EnumFormat",
		GuidFormat = "GuidFormat",
		Json = "Json",
		NumericFormat = "NumericFormat",
		Regex = "Regex",
		TimeOnlyFormat = "TimeOnlyFormat",
		TimeSpanFormat = "TimeSpanFormat",
		Uri = "Uri",
		Xml = "Xml";
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, 
	AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class UnscopedRefAttribute : Attribute;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class AllowNullAttribute : Attribute;


[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class DisallowNullAttribute : Attribute;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class DoesNotReturnAttribute : Attribute;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class DoesNotReturnIfAttribute(bool parameterValue) : Attribute
{
	public bool ParameterValue { get; } = parameterValue;
}

[AttributeUsage(
	AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | 
	AttributeTargets.ReturnValue, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class MaybeNullAttribute : Attribute;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class MaybeNullWhenAttribute(bool returnValue) : Attribute
{
	public bool ReturnValue { get; } = returnValue;
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
[ExcludeFromCodeCoverage]
public sealed class MemberNotNullAttribute : Attribute {
	public MemberNotNullAttribute(string member) => this.Members = [member];
	public MemberNotNullAttribute(params string[] members) => this.Members = members;
	public string[] Members { get; }
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
[ExcludeFromCodeCoverage]
public sealed class MemberNotNullWhenAttribute : Attribute
{
	public MemberNotNullWhenAttribute(bool returnValue, string member) {
		ReturnValue = returnValue;
		Members = [member];
	}

	public MemberNotNullWhenAttribute(bool returnValue, params string[] members) {
		ReturnValue = returnValue;
		Members = members;
	}

	public bool ReturnValue { get; }
	public string[] Members { get; }
}

[AttributeUsage(
	AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | 
	AttributeTargets.ReturnValue, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class NotNullAttribute : Attribute;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, 
	AllowMultiple = true, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class NotNullIfNotNullAttribute(string parameterName) : Attribute
{
	public string ParameterName { get; } = parameterName;
}

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class NotNullWhenAttribute(bool returnValue) : Attribute
{
	public bool ReturnValue { get; } = returnValue;
}
