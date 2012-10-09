
namespace Euler.Solvers
{
    public static class NumberExtensions
    {
        public static string ByExtensive(this int number)
        {
            if (number >= 1000)
            {
                var i = number / 1000;
                var i1 = number - (i * 1000);
                var juntion = i1 == 0 ? "" : " and ";
                return string.Format("{0} thousand{1}{2}", i.ByExtensive(), juntion, i1.ByExtensive());
            }
            if (number >= 100)
            {
                var i = number / 100;
                var i1 = number - (i * 100);
                string juntion = i1 == 0 ? "" : " and ";
                return string.Format("{0} hundred{1}{2}", i.ByExtensive(), juntion, i1.ByExtensive());
            }
            if (number >= 90)
            {
                var i = number - 90;
                return "ninety " + i.ByExtensive();
            }
            if (number >= 80)
            {
                var i = number - 80;
                return "eighty " + i.ByExtensive();
            }
            if (number >= 70)
            {
                var i = number - 70;
                return "seventy " + i.ByExtensive();
            }
            if (number >= 60)
            {
                var i = number - 60;
                return "sixty " + i.ByExtensive();
            }
            if (number >= 50)
            {
                var i = number - 50;
                return "fifty " + i.ByExtensive();
            }
            if (number >= 40)
            {
                var i = number - 40;
                return "forty " + i.ByExtensive();
            }
            if (number >= 30)
            {
                var i = number - 30;
                return "thirty " + i.ByExtensive();
            }
            if (number >= 20)
            {
                var i = number - 20;
                return "twenty " + i.ByExtensive();
            }
            if (number >= 10)
            {
                switch (number)
                {
                    case 10: return "ten";
                    case 11: return "eleven";
                    case 12: return "twelve";
                    case 13: return "thirteen";
                    case 14: return "fourteen";
                    case 15: return "fifteen";
                    case 16: return "sixteen";
                    case 17: return "seventeen";
                    case 18: return "eighteen";
                    case 19: return "nineteen";
                }
            }
            switch (number)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }
    }
}