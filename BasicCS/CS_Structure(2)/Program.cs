using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      구조체
    class와 유사하다  
    큰 차이점은, 클래스는 참조형, 구조체는 값형이라는 것이다.
    
*/

namespace CS_Structure_2_
{
    struct sSquare
    {
        public int x;
        public int y;

        //4번의 방법처럼 suqare의 모든 필드, x,y의 값을 어떻게 부여할지 정의 해야한다. 즉 생성되는 시점에 어떤 값을 가질지 정해놔야한다.
        public sSquare(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //System.Object의 ToString메서드를 재정의함
        public override string ToString()
        {
            return "넓이는 " + x + "*" + y + "= " + x * y + " 입니다.";
        }

    }

    class cSquare
    {
        public int x;
        public int y;

        public cSquare()
        {

        }

        public cSquare(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            {
                return "넓이는 " + x + "*" + y + "= " + x * y + " 입니다.";
            }
        }
    }


    //구조체는 값형식, 깊은복사
    //클래스는 참조형식, 얕은복사
    class Program
    {
        static void Main(string[] args)
        {
            //1번처럼 new를 붙이지 않아도 된다, 붙여도 됨, 하지만 값이 할당이 되지 않음
            sSquare s_1 = new sSquare(1,2);
            sSquare s_2 = s_1;

            s_2.x = 7;
            s_2.y = 7;

            Console.WriteLine(s_1.ToString());
            Console.WriteLine(s_2.ToString());

            cSquare c_1 = new cSquare(1, 2);
            cSquare c_2 = c_1;

            Console.WriteLine("====================================================");

            c_2.x = 7;
            c_2.y = 7;

            Console.WriteLine(c_1.ToString());
            Console.WriteLine(c_2.ToString());
        }
    }
}

/*  출력창

넓이는 1*2= 2 입니다.
넓이는 7*7= 49 입니다.
====================================================
넓이는 7*7= 49 입니다.
넓이는 7*7= 49 입니다.


*/

/*
구조체는 값만 넘기는거라 신경안써도 되지만,
클래스는 c_2 = c_1이라고 하면,
c_1의 집 주소까지 넘기는거라, 앞으로 c_2가 c_1까지 책임지는 것이 되어버려서
c_2를 출력해도 c_2, c_1을 출력해도 c_2에 저장한 값이 나온다.
그 역도 성립

그래서 참조형의 대입의 경우에는 신경을 써야한다.
보통 다른 메서드에서 클래스 객체를 받는 경우에 많이 발생.
 */ 

/*
 클래스와 구조체는 큰특징외에 그냥 같다고 보면 된다.
 클래스와 구조체로 설정하는 기준에 대해 보면

1. 모든 사용자 정의 타입은 클래스로 구현
2. 값의 변화에 민감한 타입은 구조체로 구현
3. 참조형식은 GC의 관리를 받기에, GC의 부하를 피하기 위한다면 클래스로 구현할걸 보통 구조체로 구현

 */