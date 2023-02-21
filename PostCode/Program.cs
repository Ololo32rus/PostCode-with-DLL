
public static class Library
{
    public static int GetNumber()
    {
        Console.Write("Введите число от 0 До хз: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
}