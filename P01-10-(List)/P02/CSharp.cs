using System;
using System.Linq;
using System.Collections.Generic;

public static class FuncExtensions
{
    public static Func<T, TResult2> After<T, TResult1, TResult2>( this Func<TResult1, TResult2> function2, Func<T, TResult1> function1) => 
        value => function2(function1(value));

    public static Func<T, TResult2> Then<T, TResult1, TResult2>( this Func<T, TResult1> function1, Func<TResult1, TResult2> function2) => 
        value => function2(function1(value));
}

public class Program {
    public static void Main(String[] args) {

        Nullable<T> last<T>(IEnumerable<T> list) where T : struct {
            var init = (new Nullable<T>(), new Nullable<T>());
            return list.Aggregate(init, (acc, x) => (acc.Item2, x)).Item1;
        }

        var list = new List<int> { 1,2,3,4 };

    }
}