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
        int n = list.Count;
        int gap = n;
        bool swapped = true;

        while (gap > 1 || swapped)
        {
            gap = (int)(gap / 1.3);

            if (gap < 1)
            {
                gap = 1;
            }

            int i = 0;
            swapped = false;

            while (i + gap < n)
            {
                if (list[i].CompareTo(list[i + gap]) > 0)
                {
                    var temp = list[i];
                    list[i] = list[i + gap];
                    list[i + gap] = temp;
                    swapped = true;
                }

                i++;
            }
        }

        return list;
    }
}
