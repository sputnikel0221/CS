using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_12_
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);
        
        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Sub(int x, int y) { Console.WriteLine(x - y); }
        static void Mod(int x, int y) { Console.WriteLine(x * y); }
        static void Div(int x, int y) { Console.WriteLine(x / y); }

        
        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Sub;
            calc += Mod;
            calc += Div;
            calc -= Mod;
             
            calc(15, 5); //20 10  3

            //delegate타입 변수에 메소드를 넣는건 뻔한데, 여러개를 넣을 수 있었다.
            //이래서 Delegate를 쓰나보다.
        }
    }
}
