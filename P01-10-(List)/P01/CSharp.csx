
T last<T>(IEnumerable<T> input)
     => input.Any() ? input.Last() : throw new Exception("Empty");

Console.WriteLine(last(new [] { 1,2,3,4}) == 4);