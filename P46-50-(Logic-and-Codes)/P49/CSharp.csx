
IEnumerable<IEnumerable<T>> replicateM<T>(IEnumerable<T> input, int n) {
    if (n == 1) foreach(var x in input) yield return new [] { x };
    else  
        foreach(var x in replicateM(input, n - 1)) 
            foreach(var y in input) 
                yield return x.Concat(new [] { y }); 
}

IEnumerable<string> gray(int n) {
    var r = replicateM(new [] { 0, 1 }, n);
    return r.Select(x => string.Join("", x));
}

Console.WriteLine(string.Join(" ", gray(1)));
Console.WriteLine(string.Join(" ", gray(2)));
Console.WriteLine(string.Join(" ", gray(3)));
Console.WriteLine(string.Join(" ", gray(4)));