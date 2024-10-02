// 3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

int indice = 12;
int soma = 0;
int k = 1;


while (k < indice)
{

    k = k + 1;
    soma = soma + k;

    Console.WriteLine($"nesse momento o k é {k} e a soma é igual a {soma}");


}

//soma final = 77

