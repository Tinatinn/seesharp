using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54notdone
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IClub> {
            new Club() { scoredBalls = 34, passedBalls = 26 },
            new Club() { scoredBalls = 18, passedBalls = 21 },
            new Club() { scoredBalls = 28, passedBalls = 25 },
            new Club() { scoredBalls = 16, passedBalls = 12 },
            new Club() { scoredBalls = 23, passedBalls = 26 },
        };
            
            list.Sort();
            foreach (var item in list)
            {
                if (item.IsPositiveBallRatio())
                {
                    Console.WriteLine(item.BallRatio());
                }
            }
        }
    }
    public class Club : IClub, IComparable<Club>
    {
        public string name
        {
            get;
            set;

        }
        public int year
        {
            get;
            set;
        }
        public int scoredBalls
        {

            get;
            set;
        }
        public int passedBalls
        {

            get;
            set;
        }
        public bool IsPositiveBallRatio()
        {
            if (scoredBalls >= passedBalls)
            { return true; }
            else
            {
                return false;
            }
        }
        public int BallRatio()
        {

            return scoredBalls - passedBalls;
        }
        public int CompareTo(Club other)
        {

            return BallRatio().CompareTo(other.BallRatio());

        }
    }

    interface IClub
    {
        bool IsPositiveBallRatio();
        int BallRatio();
    }
    interface Icomparable {

        int CompareTo(Club other);
    }
}
