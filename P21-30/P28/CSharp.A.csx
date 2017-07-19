IEnumerable<IEnumerable<T>> sort<T>(IEnumerable<IEnumerable<T>> input) {
    return input.OrderBy(x => x.Count());
}

var input = new [] { 
    new [] { "a", "b", "c"},
    new [] { "d", "e" },
    new [] { "f", "g", "h" },
    new [] { "d", "e" },
    new [] { "i", "j", "k", "l" },
    new [] { "m", "n" },
    new [] { "o" }
};

var rs = sort(input);

var str = String.Join(",", rs.Select(x => string.Join("", x)));
Console.WriteLine(str)