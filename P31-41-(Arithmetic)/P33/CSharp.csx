int gcd(int a, int b) =>
    a == 0 ? b : a > b ? gcd(b, a) : gcd (b % a, a);

bool coprime(int x1, int x2) => gcd(x1, x2) == 1;

Console.WriteLine(coprime(35, 64));