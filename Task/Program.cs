// ЗАДАЧА:
// Написать программу, которая из имеющегося массива
//  строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

//Метод считывающий данные пользователя
string ReadData(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? " ");
}

//Метод который перепечатывает и приводит к нужному массив строк
void Print1DArr(string[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write($"{arr[arr.Length - 1]}");

    Console.WriteLine("]");

}
//Метод заполняющий массив нужными элементами
string[] FillNewArrayWithCriterion(string[] arr, int count = 0, int criterion = 3)
{
    string[] res = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= criterion)
        {
            res[count] = arr[i];
            count++;
        }
    }
    return res;
}
string readArr = ReadData("Введите строки: ");
char[] removeChar = new char[] { ' ', ',' };
string[] changeReadArr = readArr.Split(removeChar, StringSplitOptions.RemoveEmptyEntries);
string[] outputArr = FillNewArrayWithCriterion(changeReadArr);
Print1DArr(changeReadArr);
Print1DArr(outputArr);
