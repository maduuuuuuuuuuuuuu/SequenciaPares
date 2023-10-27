int numero;
int numeropar = 0;
do
{
    Console.Write("Digite um numero inteiro e positivo: ");
    Int32.TryParse(Console.ReadLine(), out numero);
}
while (numero <= 0);

while (numeropar <= numero)
{
    Console.Write($"{numeropar} ");
    numeropar = numeropar + 2;
}
