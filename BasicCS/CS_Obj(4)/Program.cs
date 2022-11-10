using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_4_
{
    /*      캡슐화
    * 사용자가 내부 멤버를 모르도록 은닉하고, 사용을 제한할 수 있다.
    * 
    * 캡슐화를 위해 getter setter를 쓰기도 한다.
    * 그리고, 유지보수를 위해 쓰는 경우가 많다
    */
    class Circle
    {
       float pi = 3.14f;


        public float getpi()
        {
            return pi;
        }
        public void settpi(float ft)
        {
            pi = ft;
        }


        /*      프로퍼티
         * C#에선 위의 2가지 메서드를 만드는 대신, 프로퍼티라는 문법을 두었다
         * 아래처럼 만들면, 위의 메소드와 기능이 같다*/
        public float Pi
        {
            get { return pi; }
            set { pi = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine(c.getpi());

            //프로퍼티 -  아래처럼 작동시킬 수 있다. 굳이 메소드명도 적지 않아도 되어 편리.
            Circle cc = new Circle();
            cc.Pi = 3.0f;
            Console.WriteLine(cc.Pi);

        }
    }

}
