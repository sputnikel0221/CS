using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CS_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 - 정수형
            정수에는 sbyte(부호있는8)가 있고, 부호없음은 byte
            short-16 int-32 long-64 가 있고, 부호 없는건 u만 붙임
            
            ** CLI언어에서 호환하기 위해 System.Int32로 쓰기도 한다 ** */

            sbyte n_1 = 10;
            sbyte n_2 = 20;
            System.Int32 n_3 = 10;
            System.Int32 n_4 = 20;
            long sum = n_1 + n_2;
            Console.WriteLine(sum);
            sum = n_3 + n_4;
            Console.WriteLine(sum);

            /*2 - 실수형
             실수에는 float-4 double-8 decimal-16이 있고,
            System.Single/Double/Decimal로 바꿀 수도 있다.
            
            ** 주의점 **
            float의 경우, 값에 f를 붙여야한다. decimal의 경우이면서 소숫점이 있는 값일 경우, m을 붙여야 한다.
             */

            System.Single f = 10.0f;
            System.Double d = 15.5;
            System.Decimal de = 20.0m;

            Console.WriteLine(f + d);
            Console.WriteLine(de);

            /*3 - 문자형
            char string이 존재,
            char은 16비트 유니코드이고, 'a'처럼 감싸야한다
            \u를붙인 유니코드를 사용하여 특수 기호도 가능하다
            
            string은 "hello world"
            +를 이용하여 문자열끼리 합치는 연산이 가능.

            ** 주의점 **
            문자열이 아니더라도 문자열 + (다른자료형) 이면 해당 다른자료형이 "문자열"로 형변환되어 합쳐짐
             */
            System.Char ch_1 = '\t';
            System.Char ch_2 = 'O';
            System.Char ch_3 = '\u2022';

            Console.WriteLine(ch_1) ;
            Console.WriteLine(ch_2);
            Console.WriteLine(ch_3);

            System.String st_1 = "hello world";
            Console.WriteLine(st_1);
            System.String st_2 = "\"";
            Console.WriteLine(st_2 + st_1 + st_2);

            /*4 - Boolean
            true false값만 담음*/

            System.Boolean lie = true;
            Console.WriteLine(lie);

        }
    }
}
