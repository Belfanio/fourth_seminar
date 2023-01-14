int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
        break;     
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

double getPow (int firstNumber, int secondNumber)
{
    double result = Math.Pow(firstNumber, secondNumber);
    return result;
}

int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите второе число");
double pow = getPow(firstNumber, secondNumber);
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {pow}");