using System;
using System.Linq;

namespace ManyToManyExample.Helpers
{
    public static class PrintHelper
    {
        public static void Title(string title)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));
            Console.WriteLine(title);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", title.Length)));

            Console.WriteLine();
        }

        public static void SubTitle(string subTitle)
        {
            Console.WriteLine(subTitle);
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", subTitle.Length)));
        }

        public static void Text(string text)
        {
            Console.WriteLine(text);
        }

        public static void BlankLine()
        {
            Console.WriteLine();
        }
    }
}
