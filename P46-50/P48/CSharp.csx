
/*
 public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
    {
        return k == 0 ? new[] { new T[0] } :
          elements.SelectMany((e, i) => elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] {e}).Concat(c)));
    }
 */

IEnumerable<IEnumerable<bool>> diff()
{
    var l = new[] { true, false };
    var q =
       from a in l
       from b in l
       from c in l
       select new [] { a, b, c };

    return q;
}

var rs2 = diff();
var str2 = string.Join("\n", rs2.Select(x => string.Join(",", x)));
Console.WriteLine(str2);