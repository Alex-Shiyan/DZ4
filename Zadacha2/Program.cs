//
// Домашнее задание к занятию 4 "Алгоритмы с циклами"
//
// Часть 2. Задача 1. do - while
//
// Вводим переменные до тела цикла
int numberN = 0;
int numberM = 0;
int numberB = 0;
// Организовываем ввод числа с постусловием N=0
do
{
    Console.WriteLine();
    Console.Write("Введите значение N:  ");
    numberN = Convert.ToInt32(Console.ReadLine());
    // Одновременно считаем количество + и -
    int maxNumber =  (numberN > 0) ? numberB++: numberM++;
} while (numberN != 0);
// Корректируем число минусов, чтобы не считать последний ввод "0"
numberM--;
// Выводим полученные значения + и -
Console.WriteLine();
Console.WriteLine("Введено положительных цифр: {0}", numberB);
Console.WriteLine("Введено отрицательных цифр: {0}", numberM);
Console.WriteLine();
// Делаем вывод, чего больше
int deltaD = numberB - numberM;
if (deltaD == 0)
{
    Console.WriteLine("Количество положительных и отрицательных чисел равно");
}
else if (deltaD > 0)
{
    Console.WriteLine("Больше положительных чисел");
}
else
{
    Console.WriteLine("Больше отрицательных чисел");
}
// Завершение программы
Console.WriteLine();
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();
