
IEnumerable<string> gray(int n) {
    if (n == 0 ) return Enumerable.Empty<string>();
    else { 
        return gray(n - 1).Aggregate(Enumerable.Empty<string>(), (acc,s) => {
            return new [] { "0" + s }.Concat(new [] { "1" + s }).Concat(acc );
        });
    }
}

var x = gray(3);
x.ToList().ForEach(Console.WriteLine);
