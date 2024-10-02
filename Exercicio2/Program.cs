// 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

int quantidade = 0;

Console.WriteLine($"Insira um texto");
string texto = Console.ReadLine()!;


foreach (char x in texto)
{
    if (x == 'a' || x == 'A')
    {
        quantidade++;
    }

}

if (quantidade > 0)
{
    Console.WriteLine($"A letra 'A' aparece {quantidade} vezes no seu texto");

}
else
{
    Console.WriteLine($"A letra 'A' não aparece no seu texto");

}