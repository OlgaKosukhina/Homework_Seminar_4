/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You input not a number. Please input the correct number.");
        }
    }
    return result;
}

int GetSum(int number)
{
    int result = 0;

    while (number > 0)
    {
        int lastNumber = number % 10;
        result += lastNumber;
        number = number / 10;
    }
    return result;
}

int num = GetNumber("Insert number");
int sum = GetSum(num);
Console.WriteLine(sum);