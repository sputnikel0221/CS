using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_11_
{    /*     델리게이트
      * 변수값으로 메소드를 담는다는 개념
      * 189p.가 중요
      */

    public class Mathmatics
    {
        //아래 Add메서드 형식을 담는 형식을 만들고 싶다면,
        //반환형 int와 매개변수 int2개를 다음과 같이 정의한다
        //그냥 식별자 이름만 바꾸고 앞에 delegate붙이면 된다.
        //그러면 해당 메서드를 담을 수 있는 자료형이 생기게 되는 것이다.
        public delegate int AddDelegate(int x, int y);

        public int Add(int x, int y) { return x + y; }
        public int TestDelegate()
        {
            //a라는 delegate변수에 메서드를 담았다
            AddDelegate a = this.Add;
            return a(1, 2);
        }


        //아래의 코드는 delegate에 담긴 메소드를 반환할 수 있는가에 대해 해본 코드이다
        public AddDelegate GetMethod()
        {
            AddDelegate b = this.Add;
            return b;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Mathmatics m = new Mathmatics();
            Console.WriteLine(m.TestDelegate()); //3


            //_method변수에 해당 b라는 Add메서드를 줬으나, 출력을 보니 인식하지 않는 것을 볼 수 있다. 
            Object _method = m.GetMethod();
            Console.WriteLine(_method); //CS_Obj_11_.Mathmatics+AddDelegate


            //어떻게 활용할지 미지수이다.
            _method = m.Add(1,2);
            Console.WriteLine(_method); //3

            //그냥 일단 현재까지는 다른 클래스의 메서드를
            //그곳에서 정의하든 현재 클래스에 정의하든 delegate로 정의하여
            //보다 쉽게 사용할 수 있다는거말고 활용점을 못찾았다.


        }
    }
}


