using System;

class MetodosRaiz
{
    // Função f(x) = x - 2 * sin(x) - 1
    static double Funcao(double x)
    {
        return x - 2 * Math.Sin(x) - 1;
    }

    static void Main(string[] args)
    {
        double a = 0, b = 0, c = 0, d = 0;

        // Entrada dos valores
        Console.WriteLine("\nEscolha o valor a: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha o valor b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha o valor c: ");
        c = double.Parse(Console.ReadLine());

        d = (a + b) / 2;

        // Saída dos valores das funções
        Console.WriteLine($"\nValor médio d: {d}");
        Console.WriteLine($"\nf({a}) = {Funcao(a)}");
        Console.WriteLine($"\nf({b}) = {Funcao(b):F4}");
        Console.WriteLine($"\nf({c}) = {Funcao(c):F4}");
        Console.WriteLine($"\nf({d}) = {Funcao(d):F4}");

        double x2 = 0;
        int iteracao = 0;
        double tolerancia = 0.01; // Critério de tolerância para a convergência
        int maxIteracoes = 10;   // Número máximo de iterações

        // Método da secante
        while (Math.Abs(Funcao(d)) > tolerancia && iteracao < maxIteracoes)
        {
            x2 = (a * Funcao(d) - d * Funcao(a)) / (Funcao(d) - Funcao(a));

            // Atualiza os valores para a próxima iteração
            a = d;
            d = x2;

            iteracao++;
            Console.WriteLine($"\nIteração {iteracao}: x = {d:F5}, f(x) = {Funcao(d):F5}");
        }
        
        if (iteracao == maxIteracoes)
        {
            Console.WriteLine("\nO método não convergiu dentro do número máximo de iterações.");
        }
        else
        {
            Console.WriteLine($"\nA raiz aproximada é x = {d:F5}, com f(x) = {Funcao(d):F5}");
        }
    }
}
