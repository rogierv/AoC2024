using AoCHelper;

namespace AoC2024;

public class Day_03 : BaseDay
{
	private readonly string _input;

	public Day_03() => _input = File.ReadAllText(base.InputFilePath);

	public static int Solve_1(string input)
	{
		return 0;
	}

	public static int Solve_2(string input)
	{
		return 0;
	}

	#region methods to run the AoCHelper
	public override ValueTask<string> Solve_1() => new(Solve_1(_input).ToString());

	public override ValueTask<string> Solve_2() => new(Solve_2(_input).ToString());
	#endregion
}