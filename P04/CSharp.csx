
using System.Diagnostics.Contracts;

int add1(int x, int y) => x + 1;

void A1() {
    var list = new List<int> { 199,2,3,4,10,101 };
    var x = list.Aggregate(0, add1);
    var y = list.Aggregate(0, add1);
    var z = list.Aggregate(0, add1, k => k);
    var a = list.Sum(k => 1);

    Console.WriteLine(a);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
}

void A2() {
    var list = new List<int> { 199,2,3,4,10,101 };
    Console.WriteLine(list.LastIndexOf(list.Last()) + 1);
}

A1();
A2();