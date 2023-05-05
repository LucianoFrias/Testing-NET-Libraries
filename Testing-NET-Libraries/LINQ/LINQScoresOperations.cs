using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_NET_Libraries.LINQ
{
    internal class LINQScoresOperations
    {
        public List<int>? Scores { get; set; }
        public List<int>? SecondaryScores { get; set; }

        public List<int>? getScoresGreaterThanFifty()
        {
            IEnumerable<int> scoresGreaterThanFifty =
                from score in Scores
                where score > 50
                select score;

            return scoresGreaterThanFifty.ToList();
        }

        public List<int>? compareSameNumbers()
        {
            IEnumerable<int> compareSameNumbers =
                from score in Scores
                join secondScore in SecondaryScores
                on score equals secondScore
                select score;

            return compareSameNumbers.ToList();
        }

        public List<int>? orderNumbersAsc()
        {
            IEnumerable<int> orderScoresAsc =
                from score in Scores
                orderby score ascending
                select score;

            return orderScoresAsc.ToList();

        }

        public List<int> orderNumbersDesc()
        {
            IEnumerable<int> orderScoresDesc =
                from score in Scores
                orderby score descending
                select score;

            return orderScoresDesc.ToList();
        }

        public void checkListContents(List<int> list)
        {
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(" ");

        }

    }
}
