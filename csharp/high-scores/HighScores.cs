using System.Collections.Generic;
using System.Linq;

namespace HighScores
{
    public class HighScores
    {
        private readonly List<int> scores;

        public HighScores(List<int> list) => scores = list;

        public List<int> Scores() => scores;

        public int Latest() => scores[^1];

        public int PersonalBest() => scores.Max();

        public List<int> PersonalTopThree() => scores.OrderByDescending(s => s).Take(3).ToList();
    }
}