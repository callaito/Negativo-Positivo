// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Double numero;

Console.Write("numero: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero > 0)

{
    Console.WriteLine("El numero es positivo");
}

else if (numero == 0)
{
    Console.WriteLine("El numero es neutro");
}

else
{
    Console.WriteLine("El numero es negativo");
}