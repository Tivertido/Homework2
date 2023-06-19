// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели (1-7):");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}