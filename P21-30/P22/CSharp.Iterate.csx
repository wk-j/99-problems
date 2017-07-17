IEnumerable<int> iterate(int s) {
    while(true)
        yield return s++;
}

IEnumerable<int> range(int s, int e) =>
    iterate(s).Take(e - s + 1);

Console.WriteLine(string.Join(",", range(4, 9)));