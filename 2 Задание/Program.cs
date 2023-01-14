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

int getSumm(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}


int number = GetNumber("Введите число");
int sum = getSumm(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");