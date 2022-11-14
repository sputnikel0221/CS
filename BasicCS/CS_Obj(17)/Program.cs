using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      인터페이스와 콜백
콜백함수를 delegate를 이용해 구현하는 것은 해당 delegate라는 자료형으로 사용할 메소드가 여러개 있어서 다중호출할떄에나 쓰이고,
보통 인터페이스를 콜백으로 주로 쓴다.

*/

interface forCallback
{
    int GetResult();
    int Text();
}

class Target
{
    public void Do(forCallback obj)
    {
        Console.WriteLine(obj.GetResult());

        //해당 인터페이스에 존재하는 기능이 아닌것은 사용이 불가능하다.
        Console.WriteLine(obj.Text());
    }
}

namespace CS_Obj_17_
{
    class Program : forCallback
    {
        public int GetResult() { return 10; }

        public int Text()
        {
            return 1;
        }

        public void Test()
        {
            Target t = new Target();
            t.Do(this);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
        }
    }
}

/*
작동순서

1. Main에서 Progam객체생성 / program은 forCallback이라는 인터페이스를 참조하는 클래스
2. 해당 program에서 Test메소드를 실행
3. Test메소드는 Target클래스 객체를 만들어서 t의 Do라는 메소드를 실행하는데, 인자로 program을 넘기지만, 받는건 인터페이스로 받음
4. 해당 Do메소드 속에 콜백코드로 인해서 다시 받았던 인터페이스의 GetResult를 실행하는데, program을 실행하는듯 

*/

/*콜백이란 Source가 Target을 호출할때, Target에서 특정 연산을 위해 다시 Source에 되묻는 방식인데,
 *그냥 객체 통째로 전달해서 그 객체의 특정 연산을 위한 메소드를 골라서 쓰면 된다.
 *하지만
 *이 과정을 delegate나 인터페이스로 넘겨주는 이유는 무분별한 내부 코드의 사용 가능성을 막기 위함이고,
 *정해진 코드만 사용하도록 제한을 거는 것이다.
 *delegate는 딱 해당 delegate자료형으로 정한 메소드들을 사용이 가능한 것이고, interface도 해당 내부의 메소드들만 사용이 가능한 것이다.
 *
 * delegate의 다중호출 콜백에 대해선 정확한 예시를 모르겠다.
 */