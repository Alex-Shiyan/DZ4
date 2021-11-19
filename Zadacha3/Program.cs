//
// Домашнее задание к занятию 4 "Алгоритмы с циклами"
//
// Часть 3. Задача 1. while Заполнение прямоугольника квадратами
//
//
// Вводим число A
int numberA;
do
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Введите положительную длину прямоуголника А:  ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out numberA))
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели значение A={0}", numberA);
            break;
        }
        Console.WriteLine("Не удалось распознать число А, попробуйте еще раз.");
    }
} while (numberA <= 0);
// Вводим число B
int numberB;
do
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Введите положительную высоту прямоуголника B:  ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out numberB))
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели значение В={0}", numberB);
            break;
        }
        Console.WriteLine("Не удалось распознать число В, попробуйте еще раз.");
    }
} while (numberB <= 0);
// Вводим число С
int numberС;
do
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Введите положительную высоту прямоуголника С:  ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out numberС))
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели значение С={0}", numberС);
            break;
        }
        Console.WriteLine("Не удалось распознать число С, попробуйте еще раз.");
    }
} while (numberС <= 0);
int numberN = 0; //количество квадратов всего
int sumX = 0;    // количество квадратов в ряду
int sumY = 0;    // количество рядов
// Раскладка рядов
while (sumY < numberB)
{
    sumY += numberС;
    sumX = 0;  // обнуление количество кваратов в ряду при переходе на следующий ряд
    while (sumX < numberA)
    {
        sumX += numberС;
        numberN++;
       // Console.WriteLine("X={0}", sumX);
       // Console.WriteLine("Y={0}", sumY);
       // Console.WriteLine("N={0}", numberN);
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("В прямоугольнике размещено квадратов N={0} шт.", numberN);




// Завершение программы
Console.WriteLine();
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();
