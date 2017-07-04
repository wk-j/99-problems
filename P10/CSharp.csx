
var list = new List<string> { "a", "a", "a", "b", "c", "c", "a", "a", "d", "e", "e", "e", "e" };
var result = list.Aggregate(Enumerable.Empty<string>(), (a, x) =>  
    a.LastOrDefault() == x ? a : a.Concat(new List<string> { x }));

var expects =  new List<string> {"a", "b", "c", "a", "d", "e" };

var ok = expects.Zip(result, (x, y) => x == y).All(x => x);
Console.WriteLine(ok);