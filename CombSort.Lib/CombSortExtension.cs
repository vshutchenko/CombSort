using System;

namespace CombSort.Lib;

public static class CombSortExtension
{
    public static IEnumerable<T> CombSort<T>(this IEnumerable<T> values)
        where T : IComparable<T>
    {
        return Sort(values.ToList());
    }

    private static IList<T> Sort<T>(IList<T> list)
        where T : IComparable<T>
    {
        var gap = (int)(list.Count / 1.247);
        while (gap > 0)
        {
            for (var i = 0; i + gap < list.Count; i++)
            {
                if (list[i].CompareTo(list[i + gap]) > 0)
                {
                    var temp = list[i + gap];
                    list[i + gap] = list[i];
                    list[i] = temp;
                }
            }
            gap = (int)(gap / 1.247);
        }

        return list;
    }
}
