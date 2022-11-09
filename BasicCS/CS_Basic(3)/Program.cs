using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 - if문의 경우 if-else if-else로 표현
             if문 대신 삼항연산자로 표현해도 됨*/

            /*2 - 반복문
             * for 똑같고, for each만보면 됨
             */
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            

            /*예제 - 1000보다 작은 자연수 중에 3또는 5의 배수들의 합을 구하시오*/

            int sum = 0;
            for (int num = 1; num < 1000; num++)
            {
                if(num%3==0 || num%5 ==0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
