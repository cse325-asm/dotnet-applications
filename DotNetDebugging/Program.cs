using System.Diagnostics;

int result = Fibonacci(6); // 5 is the argument
Console.WriteLine(result);

static int Fibonacci(int n) // n is the parameter
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");

    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");    
    }

    // If n2 is 5 continue, else break.
    Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
    return n == 0 ? n1 : n2; // Ternary operator: if "n" is 0, return "n1", otherwise return "n2"
}

// From 0 going up, the next number is calculated by the sum of two previous numbers