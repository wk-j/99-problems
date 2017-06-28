
public class Nested<T> {
    public T Value { set;get;}
    public List<Nested<T>> List { set;get;} = new List<Nested<T>>();
}

var v = new Nested<int> {
    List = new List<Nested<int>> {
        new Nested<int> { Value = 100 },
        new Nested<int> { Value = 100 },
        new Nested<int> { List = new List<Nested<int>> { new Nested<int> { Value = 200} , new Nested<int> { Value = 200} }},
        new Nested<int> { List = new List<Nested<int>> { new Nested<int> { Value = 100} , new Nested<int> { Value = 500} }}
    }
};

void f1(Nested<int> n, List<int> a) {
    if (n.List.Count == 0) a.Add(n.Value);
    else n.List.ForEach(x => f1(x, a));
}

var a = new List<int>();

f1(v, a);

a.ToList().ForEach(Console.WriteLine);