
int gcd(int a, int b) =>
    a == 0 ? b : a > b ? gcd(b, a) : gcd (b % a, a);

Console.WriteLine(gcd(1,2) == 1);
Console.WriteLine(gcd(2,4) == 2);
Console.WriteLine(gcd(5,13) == 1);
Console.WriteLine(gcd(36, 63) == 9);