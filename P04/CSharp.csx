

var list = new List<int> { 1,2,3, 4, 10 };

var x = list.Aggregate((a, x) => a + 1);
var y = list.Aggregate(0, (a, x) => a + 1);
var z = list.Aggregate(0, (a, x) => a + 1, a => a);

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);