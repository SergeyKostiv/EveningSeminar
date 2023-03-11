// Task 1.
/*
int CutNumber(int num)
{
    int hundreds = num / 100;
    int ones = num % 10;

    return hundreds * 10 + ones;
}

int randNumber = new Random().Next(100, 1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Task 2.

/*
bool IsDevided(int number, int firstDivider, int secondDivider)
{
    
    return number % firstDivider == 0 && number % secondDivider == 0;

    //if(number % firstDivider == 0 && number % secondDivider == 0)
    //    return true;
    //else
    //    return false;
}

Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a firstDivider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a secondDivider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsDevided(num, div1, div2));
*/

// Task 3. Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int MaxNumber(int num)
{
    int ten = num / 10;
    int one = num % 1;
     
    if (ten < num)
        return ten;
    else
        return one;
}

int randNumber = new Random().Next(10, 99);

int newNumber = MaxNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

// Task 4. Напишите программу, которая принимает
// на вход два числа и проверяет, 
//является ли одно число квадратом другого.

/*
bool IsQuad ( int firstNum, int secondNum)
{
    if (firstNum == secondNum * secondNum || secondNum == firstNum * firstNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write("Input a number for checking: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number for checking: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsQuad(num, num1));
*/

