using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime start = moment; // we initialise like actual date(moment) == start
        DateTime end = moment; // we initialise like the date researched(moment) == end
        start = moment.AddSeconds(1000000000); // we add a gigasecond to actual date
        end = start; // so that end == start + gigasecond
        return end;
    }
}