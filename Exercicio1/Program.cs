// 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.



int a = 0;
int b = 1;
int soma = 0;


Console.WriteLine($"Insira um numero");
int n = int.Parse(Console.ReadLine()!);



while (soma < n)
{
    soma = a + b;
    a = b;
    b = soma;

}
if (soma == n)
{
    Console.WriteLine($"O numero {n} pertence a sequencia Fibonacci");

}
else
{
    Console.WriteLine($"O numero {n} não pertence a sequencia Fibonacci");
}


