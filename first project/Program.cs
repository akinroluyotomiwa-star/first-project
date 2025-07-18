using System.Net.Security;

public class Program //class
{
    //Introduction to c#
   //Operators are symbols or keywords that tells a compiler to perform a specific operation on variables , values or object

    private static void Main(string[] args) // entry point
    {
        //Arithmetic operators 

        int a = 32; int b = 8; 
        Console.WriteLine(a + b); // Addition 40
        Console.WriteLine(a - b); // Subtraction 24
        Console.WriteLine(a / b); // division 4
        Console.WriteLine(a % b); //modulus or remaider 0
        Console.WriteLine(a * b); //Multiplication 256

        //Assignment Operator
        int f = 6;
        f += 3; // same thing as f = f + 3
        f -= 3;// same thing as f = f - 3
        f *= 5; // same thing as f = f * 3
        f /= 3; // same thing as f = f / 3
        f %= 3;//same thing as f = f % 3

        //Comparison Operatior
        int t = 6; int n = 10;
        Console.WriteLine(t == n); //Equal false
        Console.WriteLine(t != n); // not equal true
        Console.WriteLine(t > n);// greater than false
        Console.WriteLine(t < n); // less than true
        Console.WriteLine(t >= n);// greater than or equal to false
        Console.WriteLine(t <= n); // less than or equal to true

        //Logical Operator
        bool p = true, q = false;
        Console.WriteLine(p && q);// AND FALSE
        Console.WriteLine(p || q); // OR TRUE
        Console.WriteLine(!p); //Not false

        // Increment and Decrement
        int num = 5;
        num++; //post-increment-> num = 6
        num--; // post-decrement -> num = 4
        ++num; // pre- increment -> num = 6(increament before use)
        --num; // pre-decrement -> num = 5

    }

}