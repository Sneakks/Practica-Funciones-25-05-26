using System;

string texto = LeerCadena("Ingrese un texto: ");

MostrarConversiones(texto);


// ── Lee una cadena no vacía
string LeerCadena(string mensaje)
{
    string entrada;
    Console.Write(mensaje);
    while (string.IsNullOrWhiteSpace(entrada = Console.ReadLine()))
    {
        Console.Write("Texto vacío. Intente de nuevo: ");
    }
    return entrada.Trim();
}

// ── Muestra las distintas conversiones
void MostrarConversiones(string texto)
{
    Console.WriteLine($"Original  : {texto}");
    Console.WriteLine($"Mayúsculas: {texto.ToUpper()}");
    Console.WriteLine($"Minúsculas: {texto.ToLower()}");
    Console.WriteLine($"Longitud  : {texto.Length} caracteres");
}