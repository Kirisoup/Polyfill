namespace System.Diagnostics;

public sealed class UnreachableException : Exception
{
	const string Arg_UnreachableException = "The program executed an instruction that was thought to be unreachable.";
	public UnreachableException() : base(Arg_UnreachableException) {}

	public UnreachableException(string? message) : base(message ?? Arg_UnreachableException) {}

	public UnreachableException(string? message, Exception? innerException) 
		: base(message ?? Arg_UnreachableException, innerException) {}
}