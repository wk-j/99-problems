IEnumerable<T> cycle<T>(IEnumerable<T> input) {
    while (true) {
        foreach (var x in input) yield return x;
     }
}

IEnumerable<T> rotate<T>(IEnumerable<T> input, int n)  => 
    cycle(input).Skip(input.Count() + n).Take(input.Count());

var input = "abcdefgh".ToCharArray();
var a1 = rotate(input, 3);      
var a2 = rotate(input, -2);     

Console.WriteLine(a1.Aggregate("", (a,x) => a + x));    // defghabc
Console.WriteLine(a2.Aggregate("", (a,x) => a + x));    // ghabcdef
