using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CS_Basic_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 - 암시적 형변환
             * 작은자료형을 큰자료형으로 바꾸는 경우*/
            System.Char ch = 'a';
            System.Int32 n = ch;

            Console.WriteLine(n);

            /*2 - 명시적 형변환
             * 숫자->문자인경우 명시해야하고, 큰자료형을 작은자료형으로 바꾸는 경우에도 명시해야함*/
            System.Int16 n_2 = 97;
            System.Char ch_2 = (char)n_2;

            Console.WriteLine(ch_2);

            /*3 - 식별자
             * 식별자의 시작은 반드시 문자
             * _기호는 어디든 들어갈 수 있다
             ** 유니코드로도 가능하기에 한글로도 가능하다 **
             * 이미 정해진 int와 같은 예약어를 @int처럼 @를 붙여 굳이 사용할 수도 있다
             * 변수는 식별자의 한 종류
             */

            /*4 - 리터럴
             * 값
             */

            /*5 - 스택과 힙
             * 값 방식은 스택의 한 공간에 변수를 지정하고, 값을 저장
             * 참조 방식은 힙에 값을 저장하고, 해당 힙을 가리키는 참조를 변수에 저장 
             * (여태배운 자료형중 String방식이 유일)
             * C#은 GC가 있기에 메모리를 따로 해지하지 않아도 된다.
             * 
             ** 주의점 **
             * 초기화되지 않은 모든 참조형 변수는 null값을 가진다
             * 혹은 그냥 명시적으로 null을 할당한다
             * 
             **값형 변수는 모두 스택에 메모리가 할당되므로 기본값을 가져야하는데, 
             *닷넷은 무조건 0을 할당bool은 false **
             */

            /*6 - 상수
             * 값이 절대 바뀌지 않음
             * const를 붙이면 다른 값으로 대입이 안됨
             */

            const int num = 98;
            //되지 않는다
            //num = 20;

            /*7 - 배열
             배열은 참조형식이므로, 힙까지 사용한다.
            boolean배열이라면 false로 초기화, 값이면 0, String이면 null로 초기화
            다중배열은 아래와 같이 선언한다.
            
            C#에선 가변배열도 지원하는데, 그냥 2차원 배열에 해당 1차원 배열에 크기가 다른 1차원 배열을 넣는 것
            그냥 공간을 더 효율적으로 쓸 수 있지만, 잘 쓰이진 않는 기능
             */

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[,] array_2 = new int[,] { { 1, 2, 3 },{ 4, 5, 6 } }; 
        }
    }
}
