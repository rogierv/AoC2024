namespace AoC2024.Tests;

[TestClass]
public sealed class Day_01Tests
{
	private readonly string _example =
		"""
		3   4
		4   3
		2   5
		1   3
		3   9
		3   3
		""";

	[TestMethod]
	public void Solve_1_Example()
	{
		var result = Day_01.Solve_1(_example);

		Assert.AreEqual(11, result);
	}

	[TestMethod]
	public void Solve_2_Example()
	{
		var result = Day_01.Solve_2(_example);

		Assert.AreEqual(31, result);
	}
}