using System;
using System.Diagnostics.CodeAnalysis;
using static System.Formats.Asn1.AsnWriter;

namespace Bowling;

internal class Program {
    static void Main(string[] args) {

        List<int> scores = new List<int>();

        for(int f = 1; f <= 10; f++) {
            Console.Write($"Enter a score for frame {f}: ");
            string response = Console.ReadLine();
            var frameScore = Convert.ToInt32(response);
            scores.Add(frameScore);

            
        }

        var sum = 0;

        foreach (var score in scores) {         // sum = scores.Sum();
            sum += score;
        }

        Console.WriteLine($"The total score is: {sum}");
    }
}
