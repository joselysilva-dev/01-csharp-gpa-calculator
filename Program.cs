Console.WriteLine("=================================");
Console.WriteLine("        GPA CALCULATOR");
Console.WriteLine("=================================");
Console.WriteLine();

Console.Write("Digite o nome do aluno: ");
string studentName = Console.ReadLine();

Console.Write("Nota da disciplina 1: ");
double grade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota da disciplina 2: ");
double grade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota da disciplina 3: ");
double grade3 = Convert.ToDouble(Console.ReadLine());

double gpa = (grade1 + grade2 + grade3) / 3;

Console.WriteLine();
Console.WriteLine($"Aluno: {studentName}");
Console.WriteLine($"GPA Final: {gpa:F2}");