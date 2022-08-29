Console.WriteLine($"Число: ");
int number = Convert.ToInt32(Console.ReadLine());
string a = "";

string TenToTwo(int number, string s)
{
    s = number % 2 + s;
    if (number > 1)
    {
        s = TenToTwo(number /= 2, s);
    }
    return s;
}

a = TenToTwo(number, a);
Console.WriteLine($"{a} ");
