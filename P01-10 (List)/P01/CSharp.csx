
T last<T>(IEnumerable<T> input)
     => input.Any() ? input.Last() : throw new Exception("Empty");

void q<T>(T i , IEnumerable<T> x) where T : IEquatable<T>
    => Console.WriteLine(i.Equals(last(x)));

//void q2<T>(T i , IEnumerable<T> x) where T : IEquatable<T>
//    => Console.WriteLine(last(x) == i);

q(4,    new List<int> { 1,2,3,4} );
q('z',  new List<char> { 'x', 'y', 'z'});

