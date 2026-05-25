double baseNum = LeerDouble("Ingrese la base: ");
double exp     = LeerDouble("Ingrese el exponente: ");


double resultado = Math.Pow(baseNum, exp);

Console.WriteLine($"{baseNum} ^ {exp} = {resultado}");



double LeerDouble(string mensaje)
{
    double valor;
    Console.Write(mensaje);
    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Dato inválido. Intente de nuevo: ");
    }
    return valor;
}