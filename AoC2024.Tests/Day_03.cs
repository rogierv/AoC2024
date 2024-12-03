namespace AoC2024.Tests;

[TestClass]
public sealed class Day_03Tests
{
	private readonly string _example =
		"""
		xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
		""";

	private readonly string _example2 =
		"""
		xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))
		""";

	[TestMethod]
	public void Solve_1_Example()
	{
		var result = Day_03.Solve_1(_example);

		Assert.AreEqual(161, result);
	}

	[TestMethod]
	public void Solve_2_Example()
	{
		var result = Day_03.Solve_2(_example2);

		Assert.AreEqual(48, result);
	}
}
