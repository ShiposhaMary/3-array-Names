using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var birthDays = new string[30];
            var birthMonths = new string[12];
            var points = new double[30, 12];
            for (var d = 0; d < birthDays.Length; d++) birthDays[d] = (d + 2).ToString();
            for (var m = 0; m < birthMonths.Length; m++) birthMonths[m] = (m + 1).ToString();
            foreach (var x in names)
            {
                if (x.BirthDate.Day != 1)
                {
                    points[x.BirthDate.Day - 2, x.BirthDate.Month - 1]++;
                }
            }
            return new HeatmapData(
                "Пример карты интенсивностей",
                points,
                birthDays,
                birthMonths);
        }
    }
}