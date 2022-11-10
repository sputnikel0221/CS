using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//이처럼 미리 japan.japan이라는 디렉토리를 지정해두면, 다른 namespace에서 추가 입력없이 그냥 불러올 수 있다.
using japan.life;

/*  namespace
 * namespace 내부에 같은 이름의 변수가 있을 순 없다.
 * 그래서 namespace를 여러개 생성하고 쓰곤 하고,
 * 다른 namespace의 클래스를 불러와 쓸 수 있다.
 * 
 * namespace안에 namespace를 또 둘 수 있어서
 * 그냥 카테고리 분류식으로 문맥상 분류하는 느낌인 것 같다.
 */

namespace CS_Obj_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            korea.food K_food = new korea.food();
            japan.life.food J_food = new japan.life.food();
            house home = new house();
        }
    }
}

namespace korea
{
    class food
    {

    }
}

namespace japan
{
    class food
    {

    }
    namespace life
    {
        class food
        {

        }

        class house
        {

        }
    }
}