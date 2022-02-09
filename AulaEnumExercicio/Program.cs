using System.Globalization;
using AulaEnumExercicio.Entities;
using AulaEnumExercicio.Entities.Enums;

Console.WriteLine("Digite o nome do departamento: ");
string dptName = Console.ReadLine();

Console.WriteLine("Entre com os dados do funcionario: ");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level= Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Salario Base: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(dptName);

Worker worker = new Worker(name, level, baseSalary, dept);

Console.WriteLine("Quantos Contratos?");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Entre com o #{i} contrato: ");
    Console.Write("Data (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Valor por Hora: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duração em Horas: ");
    int hours =int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}
Console.WriteLine();
Console.WriteLine("Entre com o Mes e Ano para calcular o salario");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0, 2));
int Year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Departamento: " + worker.Department.Name);
Console.WriteLine("Salario para: " + monthAndYear + ": " + worker.Income(Year, month));



