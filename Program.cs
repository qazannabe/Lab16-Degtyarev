Console.Write("Сколько студентов в группе?");
int studentCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentCount];
int sum = 0;
for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
    sum += grades[i];
}
foreach (int grade in grades)
{
    Console.WriteLine(grade);
}
double average = (double)sum / studentCount;
Console.WriteLine($"Средний балл группы: {average}");

int[] points = { 4, 7, 2, 9, 5 };
for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
}
foreach (int point in points)
{
    Console.WriteLine(point);
}