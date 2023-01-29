/* Написать программу, которая из имеющегося массива строк сформирует массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*/

 // Метод разбиения строки на элементы массива по пробелам
 string[] SplitStringToArray (string elements)
  {
    string[] array = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Убираем пустые подстроки, чтобы они не попали в результирующий массив
    return array;
 }

 // Метод получения суммы строк, удовлетворяющих условию

 string SumShortElements (string[]array, int maxStringLenght)
 {
    string sum = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sum += array[i]+" ";
        }
    }
    return sum;
 }

// Метод печати массива
void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

Console.WriteLine("Введите элементы массива через пробел");
string elements = Console.ReadLine() ??"";
string[] arr = SplitStringToArray(elements);
string sum = SumShortElements(arr, 3);
string[] result = SplitStringToArray(sum);
PrintArray(result);