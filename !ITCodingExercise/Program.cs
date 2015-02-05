using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ITCodingExercise
{
	class Program
	{
		private static void Main()
		{
			var questions = File.ReadAllText("QuestionsToBeAnswered.txt");
			var names = File.ReadAllText("IT Coding Excercise.txt").Split(',').Select(s => s.Trim('"')).ToArray();
			Array.Sort(names);

			var scores = names.Select((s, i) => (i + 1) * s.Select(c => c - 64).Sum());

			Console.WriteLine(questions);
			Console.WriteLine(scores.Sum());
			Console.ReadLine();
		}
	}
}
