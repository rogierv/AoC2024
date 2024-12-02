namespace AoC2024.Tests;

[TestClass]
public sealed class Day_03Tests
{
	private readonly string _example =
		"""

		""";

	[TestMethod]
	public void Solve_1_Example()
	{
		var result = Day_03.Solve_1(_example);

		Assert.AreEqual(0, result);
	}

	[TestMethod]
	public void Solve_2_Example()
	{
		var result = Day_03.Solve_2(_example);

		Assert.AreEqual(0, result);
	}
}
