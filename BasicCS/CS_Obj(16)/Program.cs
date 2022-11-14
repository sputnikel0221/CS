using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      인터페이스는 다른말로 Contract , 계약이라고 부를 수 있다
 *      아래 예제
 *      
 */

namespace CS_Obj_16_
{
    interface ImVillain
    {

    }

    //사용자가 명시적으로 imbad라는 메소드를 가진 클래스를 imVillain인터페이스를 물려받도록 지정했다.
    class A : ImVillain
    {
        public void imbad()
        {
            Console.WriteLine("Im bad");
        }
    }

    class B
    {
        public void imgood()
        {
            Console.WriteLine("Im good~!");
        }
    }

    class C : ImVillain
    {
        public void imbad()
        {
            Console.WriteLine("Im bad");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Object[] objs = new Object[] { new A(), new B(), new C()};
            foreach(Object item in objs)
            {
                //imVillain으로 형변환이 가능한 클래스라면 BAD를 출력
                if(item is ImVillain)
                {
                    Console.WriteLine("BAD");
                }
                else
                {
                    Console.WriteLine("GOOD");
                }
            }
        }
    }
}

/*      출력창
    
BAD
GOOD
BAD

*/