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
		return reports
			.Aggregate(0, (seed, report) => IsSafe(Parse(report)) ? ++seed : IsSafeWithDampener(Parse(report)) ? ++seed : seed);
	}

	public override ValueTask<string> Solve_1() => new(Solve_1(_input).ToString());

	public override ValueTask<string> Solve_2() => new(Solve_2(_input).ToString());

	private static int[] Parse(string report) => report.Split(' ').Select(int.Parse).ToArray();

	private static bool IsSafe(int[] levels)
	{
		var prev = levels[0];

		var increasing = levels[1] > prev;

		if (increasing)
		{
			for (int i = 1; i < levels.Length; i++)
			{
				if (levels[i] - prev < 1 || levels[i] - prev > 3)
				{
					return false;
				}
				prev = levels[i];
			}
		}
		else
		{
			for (int i = 1; i < levels.Length; i++)
			{
				if (prev - levels[i] < 1 || prev - levels[i] > 3)
				{
					return false;
				}
				prev = levels[i];
			}
		}

		return true;
	}

	private static bool IsSafeWithDampener(int[] levels)
	{
		for (int i = 0; i < levels.Length; i++)
		{
			var toCheck = levels[0..i].Concat(levels[(i + 1)..levels.Length]).ToArray();
			if (IsSafe(toCheck))
			{
				return true;
			}
		}
		return false;
	}
}