using System;
using System.Diagnostics;

using JRB.ProbabilityCollection;

namespace JRB.ProbabilityCollection.TestConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TestProbabilityCollection();
        }

        static void TestProbabilityCollection()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
            {
                { 'A', 0 },
                { 'B', 0 },
                { 'C', 0 },
                { 'D', 0 },
            };

            ProbabilityCollection<char> collection = new ProbabilityCollection<char>();
            for (int i = 0; i < dictionary.Count; i++)
            {
                char c = dictionary.Keys.ElementAt(i);
                int probability = dictionary.Count - i;
                collection.Add(probability, c);
            }

            dictionary.Add('X', 0);
            
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                char c = collection.GetRandom();
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] += 1;
                }
                else
                {
                    dictionary['X'] += 1;
                }
            }
            sw.Stop();

            Console.WriteLine($"Elapsed time:  {sw.Elapsed}");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}:  {item.Value}");
            }
        }

    }
}
