//
// Домашнее задание к занятию 4 "Алгоритмы с циклами"
//
// Часть 1. Задача 1. Квадратный корень числа
//
// Вводим переменную до тела цикла
int numberN;
// Вводим число N, проверяем, что ввели именно число
while (true)
{
    Console.WriteLine();
    Console.Write("Введите значение N:  ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out numberN))
    {
        Console.WriteLine();
        Console.WriteLine("Вы ввели значение N={0}", numberN);
        Console.WriteLine();
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
// Вводим счетчик итерации и переменную для суммы, присваиваем им нулевые значения
numberN = Math.Abs(numberN);
int sumN2 = 0;
int numN = 0;
// Организовываем цикл. Для получения нечетного ряда ставим начальное значние счетчика 1, изменение счетчика равное 2
for (int i = 1; i < (2 * numberN); i += 2)
{
    numN += 1;
    sumN2 += i;
    Console.WriteLine("Квадрат числа {1} равен {0}", sumN2, numN);
}
Console.WriteLine();
Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();