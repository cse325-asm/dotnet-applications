int result = Fibonacci(5); // 5 is the argument
Console.WriteLine(result);

static int Fibonacci(int n) // n is the parameter
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2; // Ternary operator: if "n" is 0, return "n1", otherwise return "n2"
}

// From 0 going up, the next number is calculated by the sum of two previous numbers