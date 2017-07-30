// #r "../../packages/System.ValueTuple/lib/portable-net40+sl4+win8+wp8/System.ValueTuple.dll"

/*
 public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
    {
        return k == 0 ? new[] { new T[0] } :
          elements.SelectMany((e, i) => elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] {e}).Concat(c)));
    }
 */

using System;

IEnumerable<Tuple<bool,bool,bool>> diff()
{
    var l = new[] { true, false };
    var q =
       from a in l
       from b in l
       from c in l
       select Tuple.Create(a,b,c);
    return q;
}

void table(Func<bool,bool,bool, bool> a) {
  var comb = diff();
  foreach(var x in comb) {
    var rs = a(x.Item1, x.Item2, x.Item3);
    Console.WriteLine($"{x.Item1} {x.Item2} {x.Item3} => {rs}");
  }
}

table((a,b,c) => a || b || c);