using System.Diagnostics;

int resultado = Fibonacci(6);
Debug.WriteLine($"Entering {nameoof(Fibonacci)} method");
Debug.WriteLine($"We are looking for the {n}th number");

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int soma;

    for(int i = 2; i <= n; i++)
    {
        soma = n1 + n2;
        n1 = n2;
        n2 = soma;
        Debug.Assert(soma == 1, $"soma foi 1, n1 foi {n1}, n2 foi {n2}");
        return n == 0 ? n1 : n2;

    }

    return n == 0 ? n1 : n2;
}
