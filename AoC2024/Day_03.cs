using AoCHelper;

namespace AoC2024;

public class Day_03 : BaseDay
{
	private readonly string _input;

	public Day_03() => _input = File.ReadAllText(base.InputFilePath);

	public static int Solve_1(string input)
	{
		var result = 0;

		var muls = input.Split("mul(");
		foreach (var mul in muls)
		{
			var i = mul.IndexOf(',');
			if (i == -1) continue;
			var x = mul[..i];
			var firstParsed = int.TryParse(x, out var firstValue);
			if (!firstParsed) continue;

			var j = mul.IndexOf(')', i);
			if (j == -1) continue;
			var y = mul.Substring(i + 1, j - i - 1);
			var secondParsed = int.TryParse(y, out var secondValue);
			if (!secondParsed) continue;

			result += (firstValue * secondValue);
		}
		return result;
	}

	public static int Solve_2(string input)
	{
		var result = 0;
		var enabled = true;

		var muls = input.Split("mul(");
		foreach (var mul in muls)
		{
			if (!enabled)
			{
				CheckDosAndDonts(mul);
				continue;
			};

			var i = mul.IndexOf(',');
			if (i == -1)
			{
				CheckDosAndDonts(mul);
				continue;
			};
			var x = mul[..i];
			var firstParsed = int.TryParse(x, out var firstValue);
			if (!firstParsed)
			{
				CheckDosAndDonts(mul);
				continue;
			};

			var j = mul.IndexOf(')', i);
			if (j == -1)
			{
				CheckDosAndDonts(mul);
				continue;
			};
			var y = mul.Substring(i + 1, j - i - 1);
			var secondParsed = int.TryParse(y, out var secondValue);
			if (!secondParsed)
			{
				CheckDosAndDonts(mul);
				continue;
			};

			result += (firstValue * secondValue);
		}

		void CheckDosAndDonts(string mul)
		{
			var dontIndex = mul.LastIndexOf("don't()");
			var doIndex = mul.LastIndexOf("do()");
			var recent = Math.Max(dontIndex, doIndex);
			if (recent != -1)
			{
				if (dontIndex > doIndex) enabled = false;
				if (dontIndex < doIndex) enabled = true;
			}
		}

		return result;
	}

	#region methods to run the AoCHelper

	public override ValueTask<string> Solve_1() => new(Solve_1(_input).ToString());

	public override ValueTask<string> Solve_2() => new(Solve_2(_input).ToString());

	#endregion methods to run the AoCHelper
}