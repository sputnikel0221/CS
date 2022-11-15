using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*      열거형  - 값형식, 정수형만 상속받을 수 있다.
    enum의 작동방식은 enum내부의 식별자 순서대로 0..1..2..이런식으로 값을 대응시킴
    System.Object에서 enum의 ToStirng을 재정의 하였기에, 출력시 문자열이 나올 수 있다.

 */ 

namespace CS_Obj_19_
{
    //숫자를 입력 안한다면 0부터 시작이고, 아래처럼 직접 숫자를 대입할 수 있다, 추가로 1씩 증가하지 않게도 설정 가능하다.
    //아래처럼 입력한다면, 정수형 값을 겹칠 수 있다고 함(2진수 비트마다 겹치는듯)
   
    
    //[Flags]
    enum Days
    {
        Sunday = 1, Monday = 2, Tuesday=4, Wednesday=8, Thursday=16, Friday=32, Saturday=64
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.Wednesday | Days.Friday;

            //Days형의 workingDays변수에 Wednesday를 가지고 있는지 bool
            Console.WriteLine(workingDays.HasFlag(Days.Wednesday)); //True

            //출력을 그냥 하면 숫자가 나온다
            Console.WriteLine(workingDays); //42가 나오는데, 42=2+8+32
            Console.WriteLine("" + workingDays.ToString()); //ToStirng()을 해도 안되고, 
            //그냥 enum에 [Flags]라는 것을 붙여야 한다고 함 //붙일시 Monday, Wednesday, Friday


            //추가로 enum에 calc의 add mod이런 기능을 이름만 정의해두고, 실제 switch문에 사용함으로 명시적으로 코드를 간결화할 수도 있다.
        }
    }
}
