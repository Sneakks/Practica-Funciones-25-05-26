// Crear funciones para suma, resta, multiplicación y división.

int sumar (int a, int b)
{
    return a + b;
}

int restar (int a, int b)
{
    return a - b;
}

int multiplicar (int a, int b)
{
    return a * b;
}

double dividir (int a, int b)
{
    return a/b;
}

Console.Write("Ingrese su primer númeero: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese su segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"La suma de {num1} y {num2} es: {sumar(num1, num2)}");
Console.WriteLine($"La resta de {num1} y {num2} es: {restar(num1, num2)}");
Console.WriteLine($"La multiplicación de {num1} y {num2} es: {multiplicar(num1, num2)}");
Console.WriteLine($"La división de {num1} y {num2} es: {dividir(num1, num2)}");