using System;

//delegate 연습2
namespace day02_02
{
    class Program
    {
        delegate void CalDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Devide(int x, int y) { Console.WriteLine(x / y); }
        static void Main(string[] args)
        {
            CalDelegate calv = Add;
            calv += Subtract;
            calv += Multiply;
            calv += Devide;

            Console.WriteLine("MulticastDelegate의 이름처럼 여러개를 동시에 처리하는것이다.");
            calv(10, 5);

            calv -= Devide;
            calv -= Multiply;

            Console.WriteLine("함수 두개를 제외하고 수행한 것");
            calv(10, 5);
        }
    }
}
