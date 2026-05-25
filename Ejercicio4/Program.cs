// . Modularizar un programa de cálculo de salario.

double calcularSalario(double horasTrabajada, double PagoHora)
{
    return horasTrabajada * PagoHora;
}

void mostrarSalario(double salario)
{
    Console.Write($"El salario estimado es de {salario} córdobas");
}

Console.Write("Ingrese las horas trabajadas: ");
double horasTrabajada = double.Parse(Console.ReadLine());

Console.Write("Ingrese el pago por hora: ");
double PagoHora = double.Parse(Console.ReadLine());

double salario = calcularSalario(horasTrabajada, PagoHora);

mostrarSalario(salario);
