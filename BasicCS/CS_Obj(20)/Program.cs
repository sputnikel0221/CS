using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      readonly
readonly를 쓰는 이유는, 변수를 읽기만 하겠다고 암묵적으로 다짐하는 것이 아니라
아예 바뀌지 않아야하고, 프로그래머의 실수를 막기위해 명시적 규칙을 정하는 것이다.
*/

/*      const
const는 상수를 만들기 위한 것
const는 readonly와 유사하다.

readonly와 다른점
1. static이 붙을 수 없다(그냥 그 의미 자체로 이미 static이다)
2. 기본자료형에 대해서만 const를 붙일 수 있다
3. 반드시 생성할 때 값을 부여해야만 한다.
4. 컴파일시 소스코드에 단순히 const 값이 치환되는 식으로 작동된다.
*/

namespace CS_Obj_20_
{
    public class Num
    {
        public readonly int zero = 0;
        public int a=3;
    }

    public class exPoint
    {
        int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public exPoint(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Num n = new Num();
            Console.WriteLine(n.zero);
            //n.zero = 1; 이 구문은 오류가 난다. readonly가 붙은 객체는 불변객체로 설정이 되기 때문
            n.a = 1; //이 구문은 실행된다. 가변객체 즉 상태가 한번 지정되어도 변할 수 있는 객체기에 가능.

            exPoint ex = new exPoint(1,2);  //해당 클래스는 불변객체이다. 내부 메소드상 가져오는 get만 있지
                                            //set이 없어서, 내부 값을 변경할 수 없기 때문. (set설정시 가변객체가 된다)

            const string TXT = "해당 상수를 많이 사용하는 경우이고, 그 경우마다 수정하기 싫을 때 상수를 사용";
            Console.WriteLine("사용하는이유 :" + TXT);
            Console.WriteLine("사용하는이유2 :" + TXT);
            //TXT의 값만 바꿔준다면, 굳이 다른 코드를 일일이 수정할 필요가 없다.


            //이미 정해진 const로는, MinValue-MaxValue가 있다.
            Console.WriteLine(int.MinValue);
        }
    }
}
