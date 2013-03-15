using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata
{
    public interface IDiceRollScorer
    {
        int Score(IEnumerable<int> dieValues); 
    }

    public class DiceRollScorer : IDiceRollScorer
    {
        public int Score(IEnumerable<int> dieValues)
        {
            var enumerable = dieValues as int[] ?? dieValues.ToArray();
            if (enumerable.Count() > 6) throw new ArgumentException("A maximum of 6 die can be rolled");

            var score = 0; 
            score += ScoreOnes(enumerable);
            score += ScoreTwos(enumerable);
            score += ScoreThrees(enumerable);
            score += ScoreFours(enumerable);
            score += ScoreFives(enumerable);
            score += ScoreSixes(enumerable);
            return score; 
        }

        private static int ScoreOnes(IEnumerable<int> dieValues)
        {
            var score = 0; 

            var ones = dieValues.Where(x => x == 1);
            if (ones.Count() >= 3)
            {
                score += 1000;
                ones.Skip(3).ToList().ForEach(x => score += 100);
            }
            else
            {
                ones.ToList().ForEach(x => score += 100);
            }
            return score;
        }

        private int ScoreTwos(IEnumerable<int> dieValues)
        {
            var score = 0;
            var twos = dieValues.Where(x => x == 2);
            if (twos.Count() == 3)
            {
                score = 200;
            }

            return score;
        }

        private int ScoreThrees(IEnumerable<int> dieValues)
        {
            var score = 0;
            var threes = dieValues.Where(x => x == 3);
            if (threes.Count() == 3)
            {
                score = 300;
            }

            return score;
        }

        private int ScoreFours(IEnumerable<int> dieValues)
        {
            var score = 0;
            var fours = dieValues.Where(x => x == 4);
            if (fours.Count() == 3)
            {
                score = 400;
            }

            return score;
        }

        private static int ScoreFives(IEnumerable<int> dieValues)
        {
            var score = 0;
 
            var fives = dieValues.Where(x => x == 5);
            if (fives.Count() >= 3)
            {
                score += 500;
                fives.Skip(3).ToList().ForEach(x => score += 50);
            }
            else
            {
                fives.ToList().ForEach(x => score += 50);
            }

            return score;
        }

        private static int ScoreSixes(IEnumerable<int> dieValues)
        {
            var score = 0; 
            var sixes = dieValues.Where(x => x == 6);
            if (sixes.Count() >= 3)
            {
                score += 600; 
            }
            return score;
        }
    }
}
