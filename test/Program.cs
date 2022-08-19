
int i = 2;
while(i <= 10)
{
    int j = 2;
    while(j<= 10)
    {
        Console.WriteLine($"{i} * {j} == {i * j}");
        j++;
    }
    Console.WriteLine();
    i++;
}
