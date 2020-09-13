using System.Text.RegularExpressions;

namespace Shop
{
    internal class RegEx
    {
        private string v;
        private RegexOptions ignoreCase;

        public RegEx(string v, RegexOptions ignoreCase)
        {
            this.v = v;
            this.ignoreCase = ignoreCase;
        }

        public static bool IsMa { get; internal set; }
    }
}