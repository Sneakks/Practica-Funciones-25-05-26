//Crear una función que determine si un número es par.

void esPar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($"El número {numero} es par");
    }
    else
    {
        Console.WriteLine($"El número {numero} es impar");
    }
}

Console.Write("Dime un número entero: ");
int n = int.Parse(Console.ReadLine());

esPar(n);