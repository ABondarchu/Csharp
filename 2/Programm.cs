using System;

 namespace LB_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            A aObject = new A(18.4F, 3.4F); 
            B bObject = new B(2.4F, 9.4F, 60.4F);

            Console.WriteLine($"Result: {aObject.c}");
            Console.WriteLine($"Result: {bObject.c2}");
            Console.Read();
        }
    }
}
