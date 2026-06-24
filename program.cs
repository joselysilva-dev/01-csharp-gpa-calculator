string studentName = "Josely Silva";

string course1 = "English 101";
int grade1 = 4;
int credit1 = 3;

string course2 = "Algebra 101";
int grade2 = 3;
int credit2 = 3;

string course3 = "Biology 101";
int grade3 = 3;
int credit3 = 4;

string course4 = "Computer Science I";
int grade4 = 3;
int credit4 = 4;

string course5 = "Psychology 101";
int grade5 = 4;
int credit5 = 3;

int totalPoints =
    (grade1 * credit1) +
    (grade2 * credit2) +
    (grade3 * credit3) +
    (grade4 * credit4) +
    (grade5 * credit5);

int totalCredits =
    credit1 +
    credit2 +
    credit3 +
    credit4 +
    credit5;

decimal finalGpa = (decimal)totalPoints / totalCredits;

Console.WriteLine("====================================");
Console.WriteLine("         GPA CALCULATOR");
Console.WriteLine("====================================");
Console.WriteLine();

Console.WriteLine($"Student: {studentName}");
Console.WriteLine();

Console.WriteLine("Course\t\t\tGrade\tCredits");
Console.WriteLine("------------------------------------");

Console.WriteLine($"{course1}\t{grade1}\t{credit1}");
Console.WriteLine($"{course2}\t{grade2}\t{credit2}");
Console.WriteLine($"{course3}\t{grade3}\t{credit3}");
Console.WriteLine($"{course4}\t{grade4}\t{credit4}");
Console.WriteLine($"{course5}\t{grade5}\t{credit5}");

Console.WriteLine("------------------------------------");
Console.WriteLine($"Final GPA: {finalGpa:F2}");