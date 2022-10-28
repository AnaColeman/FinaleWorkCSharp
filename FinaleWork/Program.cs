// Написать программу, которая из сформированного массива строк содержащих 
// символы и числа создать массив из строк, в который попадут только символы, не являющиеця цифрами.

Console.Clear();
char[] elements = new char[10];
string alfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
for (int i = 0; i < elements.Length; i++)
{
    int number = new Random().Next(1, 33);
    string number2;
    if (i % 2 == 0)
    {
        number2 = Convert.ToString(alfabet[number]);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
    else
    {
        number = number % 10;
        number2 = Convert.ToString(number);
        elements[i] = Convert.ToChar(number2);
        Console.Write(elements[i] + ",");
    }
}
Console.WriteLine();

