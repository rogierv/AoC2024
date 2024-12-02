using AoCHelper;

namespace AoC2024;

public class Day_02 : BaseDay
{
	private readonly string _input;

	public Day_02() => _input = File.ReadAllText(base.InputFilePath);

	public static int Solve_1(string input)
	{
		var reports = input.Split('\n');
		return reports.Aggregate(0, (seed, report) => IsSafe(Parse(report)) ? ++seed : seed);
	}

	public static int Solve_2(string input)
	{
		var reports = input.Split('\n');
		return reports.Aggregate(0, (seed, report) => IsSafe(Parse(report)) ? ++seed : IsSafeWithDampener(Parse(report)) ? ++seed : seed);
	}

	private static int[] Parse(string report) => report.Split(' ').Select(int.Parse).ToArray();

	private static bool IsSafe(int[] levels)
	{
		var prev = levels[0];
		var isIncreasing = levels[1] > prev;

		foreach (var current in levels.Skip(1))
		{
			var difference = isIncreasing ? current - prev : prev - current;
			if (difference < 1 || difference > 3) return false;
			prev = current;
		}
		return true;
	}

	private static bool IsSafeWithDampener(int[] levels)
	{
		foreach (var (i, _) in levels.Index())
		{
			var removeLevel = levels[0..i].Concat(levels[(i + 1)..levels.Length]);
			if (IsSafe([..removeLevel])) return true;
		}
		return false;
	}

	#region methods to run the AoCHelper
	public override ValueTask<string> Solve_1() => new(Solve_1(_input).ToString());

	public override ValueTask<string> Solve_2() => new(Solve_2(_input).ToString());
	#endregion
}