using AoC2024.Extensions;
using AoCHelper;

namespace AoC2024;

public class Day_01 : BaseDay
{
	private readonly string _input;

	public Day_01() => _input = File.ReadAllText(base.InputFilePath);

	public static int Solve_1(string input)
	{
		List<int> xs = [];
		List<int> ys = [];

		foreach (var line in input.Split('\n'))
		{
			var (x, y) = Parse(line);

			xs.Add(x);
			ys.Add(y);
		}

		xs.Sort();
		ys.Sort();

		return xs
			.Zip(ys, (a, b) => (a, b).GetDistance())
			.Sum();
	}

	public static int Solve_2(string input)
	{
		List<int> xs = [];
		Dictionary<int, int> dict = [];

		foreach (var line in input.Split('\n'))
		{
			var (x, y) = Parse(line);

			xs.Add(x);

			var value = dict.GetValueOrDefault(y, 0);
			dict[y] = value + 1;
		}

		int GetSimilarityScore(int x) => x * dict.GetValueOrDefault(x, 0);

		return xs.Sum(GetSimilarityScore);
	}

	private static (int x, int y) Parse(string s)
	{
		var split = s.Split("   ");
		return (int.Parse(split[0]), int.Parse(split[1]));
	}

	public override ValueTask<string> Solve_1() => new(Solve_1(_input).ToString());

	public override ValueTask<string> Solve_2() => new(Solve_2(_input).ToString());
}