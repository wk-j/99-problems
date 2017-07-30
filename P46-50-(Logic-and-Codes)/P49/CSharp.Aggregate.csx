
IEnumerable<string> gray(int n) {
    if (n == 0 ) { 
        //Console.WriteLine($"n = {n}");
        return new [] { "" };
    }
    else { 
        return gray(n - 1).Aggregate(Enumerable.Empty<string>(), (acc,s) => {
            var x = acc.Concat(new [] { "0" + s }).Concat(new [] { "1" + s });
             Console.WriteLine($"s = {s}, acc = {string.Join(" ",acc)}, x = {string.Join(" ", x)}");
             return x;
        });
    }
}

var x = gray(3);
x.ToList().ForEach(Console.WriteLine);
