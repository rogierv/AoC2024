namespace AoC2024.Extensions;

internal static class TupleExtensions
{
	internal static int GetDistance(this (int a, int b) zip) => Math.Abs(zip.a - zip.b);
}