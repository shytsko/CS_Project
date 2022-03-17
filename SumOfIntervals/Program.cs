using System;

using Interval = System.ValueTuple<int, int>;

Console.WriteLine(Intervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));

// Console.WriteLine(Intervals.SumIntervals(new Interval[] { }));
// Console.WriteLine(Intervals.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
// Console.WriteLine(Intervals.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
// Console.WriteLine(Intervals.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
// Console.WriteLine(Intervals.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
// Console.WriteLine(Intervals.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
Console.WriteLine(Intervals.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
Console.WriteLine(Intervals.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
Console.WriteLine(Intervals.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));

public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        int sum_intervals = 0;
        List<Interval> ListOfIntervals = new List<Interval>(intervals);
        ListOfIntervals.Sort();

        int i = 0;
        while(i<ListOfIntervals.Count-1)
        {
            if(ListOfIntervals[i+1].Item1 <= ListOfIntervals[i].Item2)
                ListOfIntervals[i].Item2 = Math.Max(ListOfIntervals[i].Item2, ListOfIntervals[i+1].Item2);
        }
        foreach (var interval in intervals)
            sum_intervals  +=  Math.Abs((interval.Item1 - interval.Item2));
        return sum_intervals;
    }
}