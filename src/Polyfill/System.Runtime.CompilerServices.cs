namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class CollectionBuilderAttribute(Type builderType, string methodName) : Attribute
{
	public Type BuilderType { get; } = builderType;
	public string MethodName { get; } = methodName;
}

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class CompilerFeatureRequiredAttribute(string featureName) : Attribute
{
	public string FeatureName { get; } = featureName;
	public bool IsOptional { get; set; }
	public const string RefStructs = "RefStructs", RequiredMembers = "RequiredMembers";
}

[CompilerGenerated, Embedded]
[AttributeUsage(
	AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | 
	AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | 
	AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
public sealed class NullableAttribute : Attribute
{
	public NullableAttribute(byte A_1) => NullableFlags = [A_1];
	public NullableAttribute(byte[] A_1) => NullableFlags = A_1;
	public readonly byte[] NullableFlags;
}

[CompilerGenerated, Embedded]
[AttributeUsage(
	AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | 
	AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
public sealed class NullableContextAttribute(byte A_1) : Attribute
{
	public readonly byte Flag = A_1;
}

[AttributeUsage(
	AttributeTargets.Constructor | AttributeTargets.Method | 
	AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class OverloadResolutionPriorityAttribute(int priority) : Attribute
{
	public int Priority { get; } = priority;
}

[AttributeUsage(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
[ExcludeFromCodeCoverage]
public sealed class ParamCollectionAttribute : Attribute;

[CompilerGenerated, Embedded]
[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
public sealed class RefSafetyRulesAttribute(int A_1) : Attribute
{
	public readonly int Version = A_1;
}

[AttributeUsage(
		AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | 
	AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class RequiredMemberAttribute : Attribute;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
[EditorBrowsable(EditorBrowsableState.Never)]
[ExcludeFromCodeCoverage]
public sealed class RequiresLocationAttribute : Attribute;

[AttributeUsage(
	AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | 
	AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, 
	Inherited = false, AllowMultiple = false)]
[ExcludeFromCodeCoverage]
internal sealed class AsyncMethodBuilderAttribute(Type builderType) : Attribute
{
	public Type BuilderType { get; } = builderType;
}

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class CallerArgumentExpressionAttribute(string parameterName) : Attribute
{
	public string ParameterName { get; } = parameterName;
}

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
{
	public InterpolatedStringHandlerArgumentAttribute(string argument) => Arguments = [argument];
	public InterpolatedStringHandlerArgumentAttribute(params string[] arguments) => Arguments = arguments;
	public string[] Arguments { get; }
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class InterpolatedStringHandlerAttribute : Attribute;

[EditorBrowsable(EditorBrowsableState.Never)]
[ExcludeFromCodeCoverage]
public static class IsExternalInit;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class ModuleInitializerAttribute : Attribute;

[AttributeUsage(
	AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | 
	AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | 
	AttributeTargets.Event | AttributeTargets.Interface, Inherited = false)]
[ExcludeFromCodeCoverage]
public sealed class SkipLocalsInitAttribute : Attribute;
