Console.Write("Введите 8 чисел через пробел: ");
string numbers = Console.ReadLine();
string[] words = numbers.Split(' ');
int[] ints = Array.ConvertAll(words, s => int.Parse(s));
Console.Write("Полученый массив чисел: ");
for (int i = 0; i < words.Length; i++)
{
    Console.Write(ints[i] + " ");
}
