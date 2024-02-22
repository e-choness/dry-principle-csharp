using Newtonsoft.Json;

namespace ExtensionsLibrary;
public static class Dumper
{
    private static string ToPrettyString(this object value)
    {
        return JsonConvert.SerializeObject(value, Formatting.Indented);
    }

    public static T Dump<T>(this T value)
    {
        Console.WriteLine(value.ToPrettyString());
        return value;
    }

    public static T Dump<T>(this T value, string prefix)
    {
        Console.WriteLine(prefix + " " + value.ToPrettyString());
        return value;
    }

    // public static void Dump<T>(this T obj, string value)
    // {
    //     Console.WriteLine(value.ToPrettyString());
    // }
}