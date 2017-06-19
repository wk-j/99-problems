
#r "../packages/LanguageExt.Core/lib/net451/LanguageExt.Core.dll"

using LanguageExt;

T last<T>(Lst<T> lst) =>
    lst.Any() ? lst.Last() : throw new Exception("Empty");

void q<T>(T i, Lst<T> lst) {
    Func<Lst<T>, T> lass = last;
    Func<T,bool> eq = (k) => i.Equals(k);
    lass.Compose(eq).Compose(Console.WriteLine)(lst);
}

q(4,    Prelude.List(1,2,3,4));
q('z',  Prelude.List('x', 'y', 'z'));

