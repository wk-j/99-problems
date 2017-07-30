IEnumerable<T> find<T>(IEnumerable<T> input,  int n) {
    var head = input.Take(n - 1);
    if (input.Count() > (n - 1)) 
        return head.Concat(find(input.Skip(n), n));
    return head;
}

var ans = find(new [] { 'a','b','c','d','e','f','g','h','i','k' }, 3);
ans.ToList().ForEach(Console.Write);