
#r "../packages/LanguageExt.Core/lib/net451/LanguageExt.Core.dll"

using LanguageExt;

T last<T>(Lst<T> lst) =>
    lst.Any() ? lst.Last() : throw new Exception("Empty");

void q<T>(T i, Lst<T> lst) {
    Action<T> p = (T t) => Console.WriteLine(t);
    Func<Lst<T>, T> l = last;
    l.Compose(p)(lst);
}

q(4,    Prelude.List(1,2,3,4));
q('z',  Prelude.List('x', 'y', 'z'));
