using AoCHelper;

namespace AoC2024;

internal class Day_01 : BaseDay
{
	public override ValueTask<string> Solve_1()
	{
		var lines = File.ReadAllLines(base.InputFilePath);

		List<int> xs = [];
		List<int> ys = [];

		foreach (var line in lines)
		{
			var (x, y) = Parse(line);

			xs.Add(x);
			ys.Add(y);
		}

		xs.Sort();
		ys.Sort();

		var result = xs
			.Zip(ys)
			.Aggregate(0, (seed, zip) => seed + Math.Abs(zip.First - zip.Second))
			.ToString();

		return new(result);
	}

	public override ValueTask<string> Solve_2()
	{
		var lines = File.ReadAllLines(base.InputFilePath);

		List<int> xs = [];
		Dictionary<int, int> dict = [];

		foreach (var line in lines)
		{
			var (x, y) = Parse(line);

			xs.Add(x);

			var value = dict.GetValueOrDefault(y, 0);
			dict[y] = value + 1;
		}

		var result = xs
			.Aggregate(0, (seed, x) => seed + (x * dict.GetValueOrDefault(x, 0)))
			.ToString();

		return new(result);
	}

	private static (int x, int y) Parse(string s)
	{
		var split = s.Split("   ");
		return (int.Parse(split[0]), int.Parse(split[1]));
	}
}