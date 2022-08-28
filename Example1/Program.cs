// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] createArray()
{
    Console.Write("Введите колличество чисел: ");
    int elementsCount = int.Parse(Console.ReadLine());
    int[] array = new int[elementsCount];
    for(int i = 0; i < array.Length; i++ )
    {
        Console.Write($"Введите число под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int[] arr = createArray();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во чисел > 0: {count}");