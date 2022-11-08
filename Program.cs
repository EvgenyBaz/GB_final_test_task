// Задача решена исходя из принципа минимизации затраченной памяти - поэтому первый массив проходится дважды.
// если решать задачу исходя из минимизации затраченного времени, то процедуры ArrayCellNumber и FillNewArray
// можно совместить в  одном проходе по начальному массиву строк 


Console.Clear();
Console.Write("Введите количество вводимых строк ");
int arrayStringLength = int.Parse(Console.ReadLine());
string[] arrayString = new string[arrayStringLength];
// ввод массива строк с клавиатуры
for (int i = 0; i < arrayStringLength; i++)
{
    Console.Write($"Введите  {i+1} строкy: ");
    arrayString[i] = Console.ReadLine();
}
// Проверяемая максимальная длина строки (переменная создана для большей вариативности решения)
int stringLength = 3;
//определяем количество ячеек с длиной строки не больше определенной
int count = ArrayCellNumber (arrayString, stringLength);

if (count == 0) 
{
    Console.WriteLine ($"Все строки больше заданного значения в {stringLength} символов");
}
else
{
// инициализируем новый массив , который будет содержать строки с длиной не превышающей заданную    
    string[] arrayNewString = new string[count];
// запись в новый массив строк с длиной не более заданной    
    FillNewArray(arrayString, arrayNewString, stringLength);
// вывод полученного массива на экран   
    PrintArray(arrayNewString);
} 


int ArrayCellNumber (string[] arrayString, int stringLength)
{
    int cellCount = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= stringLength)
            {
                cellCount++;
            }
    }
    return cellCount;
}

void FillNewArray(string[] arrayString, string[] arrayNewString, int stringLength)
{
    int k = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= stringLength)
            {
                arrayNewString[k] = arrayString[i];
                k++;
            }
    }
}

void PrintArray(string[] array)
{
    int lengthArray = array.Length;

    Console.Write("[");
    for (int i = 0; i < lengthArray; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < lengthArray - 1) Console.Write(",");
    }
    Console.Write("]");
}