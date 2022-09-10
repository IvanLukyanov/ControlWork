Описание действий при выполнении контрольной работы после прохождения блока Разработчик

Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Выполнение задачи:

1.Задаем массив strArray размером size = 4
int size = 4;
string[] strArray = new string[size];

2.Наполняем массив методом FillArray
FillArray(strArray);
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }

}

3.Выводим массив методом PrintArray
Console.WriteLine("Массив"); 
PrintArray(strArray);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}'");
        else
        {
            Console.Write($"'{array[i]}', ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

4.Используем метод SizeResultArray с вводными данными maxLength = 3. Таким образом ограничивая размер строи меньше или равной трем. Вносим результат в переменную resultArraySize.
int maxLength = 3;
int resultArraySize = SizeResultArray(strArray, maxLength);

int SizeResultArray(string[] array, int maxcount)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxcount)
        {
            count++;
        }
    }
    return count;
}

5.Создаем результирующий массив resultArray размерности resultArraySize и заполняем его методом FillResultArray
string[] resultArray = new string[resultArraySize];
int maxLength = 3;
FillResultArray(strArray, resultArray, maxLength);
void FillResultArray(string[] array1, string[] array2, int maxcount)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxcount)
        {
            array2[index] = array1[i];
            index++;
        }
    }
}

6.Выводим результат методом PrintArray
Console.WriteLine("РезалтМассив");
PrintArray(resultArray);

