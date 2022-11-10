using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Obj_2_
{
    class Person
    {
        public string name;
        static public Person firstman;

        public Person(string st)
        {
            Console.WriteLine("일반 생성자 호출됨");
            name = st;
            Console.WriteLine("이름 : " + st);
        }

        static Person()
        {
            Console.WriteLine("정적생성자가 항상 먼저 호출이 된다.");
            firstman = new Person("adam");
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
           Person person1 = new Person("Eve");
        }
    }
}

/*  결과창
정적생성자가 항상 먼저 호출이 된다.
일반 생성자 호출됨
이름 : adam
일반 생성자 호출됨
이름 : Eve

계속하려면 아무 키나 누르십시오 . . .
*/


/* 
 * class가 호출되면
 * 그냥 무조건 정적생성자가 가장 먼저, 단 한번만, 실행된다.
 * 그 후에야 Main에서 작성한 class생성자가 호출이 된다.
 */

/*  namespace
 * namespace 내부에 같은 이름의 변수가 있을 순 없다.
 * 그래서 namespace를 여러개 생성하고 쓰곤 하고,
 * 다른 namespace의 클래스를 불러와 쓸 수 있다.
 * 
 * namespace안에 namespace를 또 둘 수 있어서
 * 그냥 카테고리 분류식으로 문맥상 분류하는 느낌인 것 같다.
 */