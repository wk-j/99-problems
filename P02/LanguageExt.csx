#r "../packages/LanguageExt.Core/lib/net451/LanguageExt.Core.dll"
#r "../packages/System.ValueTuple/lib/portable-net40+sl4+win8+wp8/System.ValueTuple.dll"

using LanguageExt;

Option<T> last<T>(Lst<T> lst) {
    Option<T> x = Prelude.None;
    var tup = Prelude.Tuple(x, x);
    return List.fold(lst, tup ,  (a,b) => Prelude.Tuple<Option<T>,Option<T>>(a.Last(), b)).Head();
}


void q<T>(Option<T> x, Lst<T> lst) {
    var k = last(lst);
    Console.WriteLine(x == last(lst));
}

q(3,    Prelude.List(1,2,3,4));
q('c',  Prelude.List('a','b','c','d'));
