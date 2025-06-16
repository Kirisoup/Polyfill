namespace System;

[ExcludeFromCodeCoverage]
public readonly struct Index : IEquatable<Index>
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Index(int value, bool fromEnd = false) {
		if (value < 0) ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
		_value = fromEnd ? ~value : value;
	}

	private Index(int value) => _value = value;

	public static Index Start => new(0);
	public static Index End => new(-1);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Index FromStart(int value) {
		if (value < 0)ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
		return new(value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Index FromEnd(int value) {
		if (value < 0)ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
		return new(~value);
	}

	public int Value => (_value < 0) ? ~_value : _value;
	public bool IsFromEnd => _value < 0;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int GetOffset(int length) {
		int offset = _value;
		if (IsFromEnd) offset += length + 1;
		return offset;
	}

	public bool Equals(Index other) => _value == other._value;
	public override bool Equals([NotNullWhen(true)] object? value) => 
		value is Index index && _value == index._value;

	public override int GetHashCode() => _value;

	public static implicit operator Index(int value) => FromStart(value);

	public override string ToString() => 
		IsFromEnd ? ToStringFromEnd() : ((uint)Value).ToString();

	private string ToStringFromEnd() => "^" + Value.ToString();

	private readonly int _value;

	private static class ThrowHelper {
		[DoesNotReturn]
		public static void ThrowValueArgumentOutOfRange_NeedNonNegNumException() => 
			throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
	}
}

[ExcludeFromCodeCoverage]
public readonly struct Range(Index start, Index end) : IEquatable<Range>
{
	public Index Start { get; } = start;
	public Index End { get; } = end;

	public override bool Equals([NotNullWhen(true)] object? value) => 
		value is Range r && r.Start.Equals(Start) && r.End.Equals(End);

	public bool Equals(Range other) => 
		other.Start.Equals(Start) && other.End.Equals(End);

	public override int GetHashCode() => 
		HashHelpers.Combine(Start.GetHashCode(), End.GetHashCode());

	public override string ToString() => $"{Start}..{End}";

	public static Range StartAt(Index start) => new(start, Index.End);

	public static Range EndAt(Index end) => new(Index.Start, end);

	public static Range All => new(Index.Start, Index.End);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public (int Offset, int Length) GetOffsetAndLength(int length) {
		int start = Start.GetOffset(length);
		int end = End.GetOffset(length);
		if ((uint)end > (uint)length || (uint)start > (uint)end) 
			ThrowHelper.ThrowArgumentOutOfRangeException();
		return (start, end - start);
	}

	private static class HashHelpers {
		public static int Combine(int h1, int h2) {
            uint rol5 = ((uint)h1 << 5) | ((uint)h1 >> 27);
            return ((int)rol5 + h1) ^ h2;
		}
	}

	private static class ThrowHelper {
		[DoesNotReturn]
		public static void ThrowArgumentOutOfRangeException() => 
			throw new ArgumentOutOfRangeException("length");
	}
}
