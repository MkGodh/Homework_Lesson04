//  Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;
 
public class Example
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4 };
        Array.Reverse(array);
 
        Console.WriteLine(String.Join(',', array));
    }
}
 