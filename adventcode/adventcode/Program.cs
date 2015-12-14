using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace adventcode
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Jour1
			Console.WriteLine("Result Jour1 part1: " + Jour1.GetResult ());
			Console.WriteLine("Result Jour1 part2: " + Jour1.GetResultPart2 ());

			//Jour2
			Console.WriteLine("Result Jour2 part1: " + Jour2.GetResultPart1 ());
			Console.WriteLine("Result Jour2 part2: " + Jour2.GetResultPart2 ());

			//Jour3
			Console.WriteLine("Result Jour3 part1: " + Jour3.GetResultPart1 ());
			Console.WriteLine("Result Jour3 part2: " + Jour3.GetResultPart2 ());

			//Jour4

			Task j4Part1 = Task.Run (() => {

				Stopwatch sw = Stopwatch.StartNew();
				Console.WriteLine("Start j4Part1");
				int result =  Jour4.GetResult(5, "00000");
				Console.WriteLine("Result Jour4 part1: " + result);
				sw.Stop();
				Console.WriteLine("Time taken J4 Part1: {0} s", sw.Elapsed.TotalSeconds);

			});

			Task j4Part2 =  Task.Run (() => {

				Stopwatch sw = Stopwatch.StartNew();
				Console.WriteLine("Start j4Part2");
				int result2 =  Jour4.GetResult(6, "000000");
				Console.WriteLine("Result Jour4 part2: " + result2);
				sw.Stop();
				Console.WriteLine("Time taken J4 Part1: {0} s", sw.Elapsed.TotalSeconds);

			});
			j4Part1.Wait ();
			j4Part2.Wait ();
			Console.WriteLine ("Done");
		}
	}
}
