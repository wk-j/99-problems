#r "../../packages/LanguageExt.Core/lib/net451/LanguageExt.Core.dll"

using LanguageExt;

T last<T>(Lst<T> lst) =>
    lst.Any() ? lst.Last() : throw new Exception("Empty");


Console.WriteLine(last(Prelude.List(1,2,3,4)) == 4);

