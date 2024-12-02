namespace AoC2024.Tests;

[TestClass]
[Ignore]
public sealed class Day_XX_Tests
{
	private readonly string _example =
		"""

		""";

	[TestMethod]
	public void Solve_1_Example()
	{
		var result = Day_XX.Solve_1(_example);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Solve_2_Example()
	{
		var result = Day_XX.Solve_2(_example);

		Assert.AreEqual(0, result);
	}
}
