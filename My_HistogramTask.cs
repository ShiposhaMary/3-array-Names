using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var birthsDays = new double[31];
            var pointDays = new string[31];
            for (var y = 0; y < pointDays.Length; y++)
                pointDays[y] = (y + 1).ToString();
            foreach (var x in names)
            {
                if (x.Name == name && x.BirthDate.Day != 1)
                {
                    birthsDays[x.BirthDate.Day - 1]++;
                }
            }
            return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), pointDays, birthsDays);
        }
    }
}