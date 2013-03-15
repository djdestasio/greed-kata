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
}
