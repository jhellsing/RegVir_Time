using System;
using System.Text.RegularExpressions;

namespace RegVir
{
    internal class Raspisanie
    {
        public void raspisanie()
        {
            string s = "Утром: прес качат 07:00, бегит 07:30, турник 09:00, анжуманя 10:00. " +
                    "Вечером: прес качат 18:00, бегит 18:54, турник 25:03, анжуманя 00:00.";
            Regex regex = new Regex(@"\b(?:[01][0-9]|2[0-3]):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
        }
    }
}
