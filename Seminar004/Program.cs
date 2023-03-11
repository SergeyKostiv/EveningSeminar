// Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//7 -> 28; 4 -> 10; 8 -> 36

/*
int Sum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i++)
    {
        sum+=i;// sum = sum + i
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"Сумма от 1 до {number} = {sum}");
*/

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/* Свой вариант. 
int NumDel(int number)
{
    int index = number;
    int count = 0;
    while (index != 0)
    {
        index /= 10;
        count++;
    }
    return count;

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); - модуль числа
Console.WriteLine($"Количество символов = {NumDel(number)}");
*/

/* Второй вариант.

System.Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
if(int.TryParse(str, out int number))
{
    if(str[0] == '-') // str.Contains("-") // number < 0
    {
        Console.WriteLine($"Цифр в нашем числе {number} = {str.Length - 1}");
    }
    else
    {
        Console.WriteLine($"Цифр в нашем числе {number} = {str.Length}");
    }
}
    else
    {
        System.Console.WriteLine("Ошибка");
    }
*/

/* Третий вариант. 
int Counting(int number)
{
    int count = 0;
    while(number != 0)// == проверка на равенство, != проверка на неравенство
    {
        number/=10;
        count++;
    }

    return count;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = Counting(number);
System.Console.WriteLine($"Цифр в нашем числе {number} = {count}");
*/

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

/* Свой вариант.
int Mult(int A)
{
    int mult = 1;
    for(int i = 1; i <= A; i++)
    {
        mult *= i;
    }
    return mult;

}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение от 1 до {number} = {Mult(number)}");
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/* Свой вариант. 
int[] array = new int[8];

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }

}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
*/
/* Второй вариант. 
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}
System.Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
*/
