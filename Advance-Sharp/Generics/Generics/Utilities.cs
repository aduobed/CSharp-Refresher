// Generics can help implement an interface, a type or sub-classes, a stuct, class, value or reference type or default constructor
public class Utilities<T> where T : IComparable, new()
{
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    //Using an interface with generics
    public T Max(T a,  T b)
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    //using default constructor with generics
    public void DoSomething(T value)
    {
        var obj = new T();
    }
}