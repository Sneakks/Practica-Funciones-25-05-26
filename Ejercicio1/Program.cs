// Calcular el área de un triángulo

double areaTriangulo(double baseTriangulo, double alturaTriangulo)
{
    return (baseTriangulo * alturaTriangulo) /2;
}

Console.Write("Brindame la base del triángulo: ");
double baseTriangulo = double.Parse(Console.ReadLine());

Console.Write("Brindame la altura del triángulo: ");
double alturaTriangulo = double.Parse(Console.ReadLine());

double area = areaTriangulo(baseTriangulo, alturaTriangulo);


Console.WriteLine($"El área del triángulo es: {area}");



