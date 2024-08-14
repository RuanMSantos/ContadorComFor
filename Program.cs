for (int n = 0; n <= 10; n++)
{
    #pragma warning disable CA1416
    Thread.Sleep(500);
    Console.Write($"{n} ");
    Console.Beep(5000, 500);
    #pragma warning restore CA1416
}
