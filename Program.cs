//
// Домашнее задание к занятию 5 "Массивы"
//
// Задача 5. Запросить у пользователя целочисленное значение N.
// Сформировать двумерный массив размера NxN следующего вида:
//
// Запрашиваем число N
int numberN;
do
{
    while (true)
    {
        Console.WriteLine();
        Console.Write("Введите целочисленное значение N:  ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out numberN))
        {
            Console.WriteLine();
            Console.WriteLine("Вы ввели значение N={0}", numberN);
            break;
        }
        Console.WriteLine("Не удалось распознать число N, попробуйте еще раз.");
    }
} while (numberN <= 0);
Console.WriteLine();
// Создание двухмерного массива NxN
int[,] arrayA = new int[numberN, numberN];
//Замена нулей на единицы
for (int i = 0; i < numberN; i ++)
{
    float d = i % 2;
    for (int j = 0; j < numberN; j++)
    {
        float k = j % 2;
        if (d == k)
        {
            arrayA[i, j] = 1;
        }

        Console.Write("{0}", arrayA[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
// Завершение программы
Console.Write("Для завершения программы нажмите любую клавишу");
Console.ReadKey();