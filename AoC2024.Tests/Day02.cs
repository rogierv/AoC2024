namespace AoC2024.Tests;

[TestClass]
public sealed class Day_02Tests
{
	private readonly string _example =
		"""
		7 6 4 2 1
		1 2 7 8 9
		9 7 6 2 1
		1 3 2 4 5
		8 6 4 4 1
		1 3 6 7 9
		""";

	[TestMethod]
	public void Solve_1_Example()
	{
		var result = Day_02.Solve_1(_example);

		Assert.AreEqual(2, result);
	}

	[TestMethod]
	public void Solve_2_Example()
	{
		var result = Day_02.Solve_2(_example);

		Assert.AreEqual(4, result);
	}
}
