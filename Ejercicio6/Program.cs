int edad = LeerEdad();
MostrarResultado(edad);

int LeerEdad()
{
    int edad;
    Console.WriteLine("ingrese su edad: ");
    while (!int.TryParse(Console.ReadLine(), out edad))
    {
        Console.WriteLine("Dato invalido, Intente de nuevo: ");
    }
    return edad;
}

bool ValidarEdad(int edad)
{
    return edad >= 0 && edad <= 120;
}

void MostrarResultado(int edad)
{
    if(ValidarEdad(edad))
    {
        Console.WriteLine($"Edad Valida: {edad} de edad es valida.");
    }
    else
    {
        Console.WriteLine($"edad fuera del rango: {edad} no es valida.");   
    }
}