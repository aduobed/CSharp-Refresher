partial class Program
{
    static void Main(string[] args)
    {
        var number = new Nullable<int>();
        Console.WriteLine($"value: {number.HasValue()}");
        Console.WriteLine($"Number value:  {number.GetValueOrDefault()}");
    }
}