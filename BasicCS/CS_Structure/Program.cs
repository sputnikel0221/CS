using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      구조체
    class와 유사하다  
    큰 차이점은, 클래스는 참조형, 구조체는 값형이라는 것이다.
    
차이점
    - 1. 객체 생성시 new를 붙이지 않아도 된다.
    - 2. 기본 생성자를 명시적으로 정의할 수 없다 - 다른 사용자가 지정하는 매개변수를 갖는 생성자만 원하는대로 바꿀 수 있다
    - 3. 대신 매개변수를 갖는 생성자만 정의해도 자동으로 기본생성자가 정의된다 (클래스는 자동으로 기본생성자가 포함이 안된다 - JAVA는 됐는데, C#은 안되나봄)
    - 4. 매개변수를 받는 생성자의 경우, 구조체 내의 모든 필드에 반드시 값을 부여해야한다.
*/

namespace CS_Structure
{
    struct Square
    {
        public int x;
        public int y;

        //4번의 방법처럼 suqare의 모든 필드, x,y의 값을 어떻게 부여할지 정의 해야한다. 즉 생성되는 시점에 어떤 값을 가질지 정해놔야한다.
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //System.Object의 ToString메서드를 재정의함
        public override string ToString()
        {
            return "넓이는 " + x + "*" + y + "= " + x * y +" 입니다.";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //1번처럼 new를 붙이지 않아도 된다, 붙여도 됨, 하지만 값이 할당이 되지 않음
            Square s_1;
            Square s_2 = new Square(3,4);
            //3번처럼 new를 붙인다면, 자동으로 매개변수로 0의 값이 부여된다
            Square s_3 = new Square();

            //new를 붙이지 않았다면 아래처럼 직접 개별할당
            s_1.x = 1;
            s_1.y = 2;

            Console.WriteLine(s_1.ToString());
            Console.WriteLine(s_2.ToString());
            Console.WriteLine(s_3.ToString());
        }
    }
}

/*  출력창
 
넓이는 1*2= 2 입니다.
넓이는 3*4= 12 입니다.
넓이는 0*0= 0 입니다.

*/
