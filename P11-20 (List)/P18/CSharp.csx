
IEnumerable<T> split<T>(IEnumerable<T> input, int n1, int n2) {
    return input.Skip(n1 - 1).Take(n2 - n1 + 1);
}

var input = "abcdefghik".ToCharArray();
var ans = split(input, 3, 7);
ans.ToList().ForEach(Console.Write);
Console.WriteLine();
