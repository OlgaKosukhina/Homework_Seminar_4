/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
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

void GetDegree(int firstNumber, int secondNumber)
{
    double degree = 1;

    for (int i = 1; i <= secondNumber; i++)
    {
        degree = Math.Pow(firstNumber, i);
    }
    Console.Clear();
    Console.WriteLine($"The number {firstNumber} to the {secondNumber} degree is {degree}.");
}

int firstNumber = GetNumber("Insert first number.");
int secondNumber = GetNumber("Insert second number.");
GetDegree(firstNumber, secondNumber);