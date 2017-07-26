
bool isPrime(int input) => input > 1 && Enumerable.Range(2, input / 2).All(x => input % x != 0);

Console.WriteLine(isPrime(7) == true);
Console.WriteLine(isPrime(100) == false);