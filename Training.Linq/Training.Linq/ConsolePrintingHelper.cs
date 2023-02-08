namespace Training.Linq;

public static class ConsolePrintingHelper
{
    public static string ToSingleString(this IEnumerable<string>? enumerable)
    {
        if (enumerable == null) return string.Empty;
        var list = enumerable.ToList();
        return !list.Any() 
            ? string.Empty 
            : list.Aggregate((x, y) => x + ", " + y);
    }
    
    public static string ToSingleString(this IEnumerable<int>? enumerable)
    {
        if (enumerable == null) return string.Empty;
        var list = enumerable.ToList();
        return !list.Any() 
            ? string.Empty 
            : list.Select(x => x.ToString()).Aggregate((x, y) => x + ", " + y);
    }
}