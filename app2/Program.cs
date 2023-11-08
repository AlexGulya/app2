int a = Convert.ToInt32(Console.ReadLine());
char b = '*';
for (int i = 0; i < a; i++)
{
	Console.WriteLine();
	for (int j = 0; j <= i; j++)
	{
		Console.Write(b);
	}
}
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < a; i++)
{
	
	for (int g = a-i; g > 0; g--)
	{
		Console.Write(b);
		
	}
    
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
char x = ' ';
for (int i = 0; i < a; i++)
{
    for (int g = a - i-1; g > 0; g--)
    {
        Console.Write(x);

    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(b);
    }
	Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < a; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(x);
    }
    for (int g = a - i; g > 0; g--)
    {
        Console.Write(b);

    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < a; i++)
{
    for (int g = a - i - 1; g > 0; g--)
    {
        Console.Write(x);

    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(b);
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(b);
    }

    Console.WriteLine();
}
for (int i = 0; i < a; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(x);
    }
    for (int g = a - i; g > 0; g--)
    {
        Console.Write(b);

    }
    for(int g = a - i; g > 0; g--)
	{
    Console.Write(b);

}
Console.WriteLine();
}
Console.WriteLine("helo");
Console.WriteLine("helo");