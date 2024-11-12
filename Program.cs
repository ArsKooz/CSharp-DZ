using System;

public class Calculator
{
     static void Main()
    {
        float a = 0 , b = 0;

        Console.WriteLine("Введите 2 числа");

        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("a + b = "+ Convert.ToString(Addition(a,b)));
        Console.WriteLine("a - b = " + Convert.ToString(Substraction(a,b)));
        Console.WriteLine(("a * b = " + Convert.ToString(Multiplication(a,b))));
        Console.WriteLine(("a / b = " + Convert.ToString(Division(a,b))));
    }

    static private float Addition(float a, float b) {return a + b;}
    static private float Substraction(float a,float b) { return a - b; }
    static private float Multiplication(float a,float b) {return a * b;}
    static private float Division(float a,float b) {  return (a / b); }
}