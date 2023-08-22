using Aula2;

int num1 = 20;
int num2 = 11;
double result;

Somador soma;
soma = new Somador();

result = soma.Soma(num1 , num2);
Console.WriteLine($"a soma de {num1} + {num2} é {result}");





double n1 = 60;
Console.WriteLine("a medida {0} metros corresponde a {1}",n1,Conversor.converte(n1));