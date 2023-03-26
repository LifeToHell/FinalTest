//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();
Console.WriteLine("Финальный Тест. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
Console.WriteLine("Введите массив строк через пробел");
string[] size = Console.ReadLine().Split(" ");
string[] selected = new string[size.Length];



void ValueCheck(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }


    }

}
void PrintValue(string[] array)
{
Console.WriteLine("Подходище элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ValueCheck(size, selected);
PrintValue(selected);

