using System.Linq;

Nullable<T> last<T>(IEnumerable<T> list) where T : struct {
    var init = (new Nullable<T>(), new Nullable<T>());
    return list.Aggregate(init, (acc, x) => (acc.Item2, x)).Item1;
}

var l1 = new List<int> { 1,2,3,4 };
var l2 = new List<char> { 'z', 'y', 'z' };

Console.WriteLine(last(l1) == 3);
Console.WriteLine(last(l2) == 'y');
