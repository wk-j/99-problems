int gcd(int a, int b) =>
    a == 0 ? b : a > b ? gcd(b, a) : gcd (b % a, a);

bool coprime(int x1, int x2) => gcd(x1, x2) == 1;

int totient(int x) => Enumerable.Range(1, x - 1).Where(k => coprime(k, x)).Count();

Console.WriteLine(totient(10) == 4);
Console.WriteLine(totient(10090) == 4032);
