// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, quais operações iremos fazer hoje ?");
Console.WriteLine("1. Soma");
Console.WriteLine("2. Subtração");
Console.WriteLine("3. Divisão");
Console.WriteLine("4. Multiplicação");
Console.WriteLine("5. Sair");

int operacao = Convert.ToInt32(Console.ReadLine());

Console.Write("Me de o primeiro numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Me de o segundo numero: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
        Console.WriteLine("O resultado da soma é :" + (numero1 + numero2));
        break;

    case 2:
        Console.WriteLine("O resultado da Subtração é:" + (numero1 - numero2));
        break;
    case 3:
        if (numero2 <= 0){
            Console.WriteLine("Invalido");
            return;
        }
        else{
            Console.WriteLine("O resultado da Divisão é:" + (numero1 / numero2));
        }
        break;
    case 4:
        Console.WriteLine("O resultado da Multiplicação é:" + (numero1*numero2));
        break;

    case 5:
        return;
}







