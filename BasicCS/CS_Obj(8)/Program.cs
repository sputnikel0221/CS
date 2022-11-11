using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * object는 하위타입을아래의 4가지로 정의해 두었고
 * -System.ValueType
 * -String
 * -System.Array
 * -class 타입들
 *
 * 이 중 System.Array는 모든 배열의 부모이고,
 * 배열을 만들면 C# 컴파일러는 해당 부모를 자동으로 상속하는 것으로 처리한다.
 * 그렇기에 모든 배열은 System.Array에 정의된 기본 메소드를 사용이 가능하다.
 * 
 * 1. Rank - 배열의 차원 수 반환
 * 2. Length - 요소 수를 반환
 * 3. Sort - 요소를 값 순서대로 정렬
 *      
 *
*/

namespace CS_Obj_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Rank 프로퍼티 예제
            int[] arr = new int[] { 3, 1, 2 };
            int[,] arr2 = new int[,] { {2, 1} , { 4, 3 } };
            Console.WriteLine(arr.Rank); //1
            Console.WriteLine(arr2.Rank); //2

            //---------------------------------------------------

            //2 Length 프로퍼티 예제
            Console.WriteLine(arr.Length); //3
            Console.WriteLine(arr2.Length); //4

            //---------------------------------------------------

            //3 Sort 메소드 예제
            //사용자정의 배열 print함수
            PrintArr(arr); //3,1,2

            //반환형이 void라서 2줄로 나눠서 써야함
            Array.Sort(arr);
            PrintArr(arr); //1,2,3으로 정렬됨

            //---------------------------------------------------

            //4 GetValue 메소드 예제
            Console.WriteLine(arr.GetValue(1)); //2
            //sort도 포함해서 2차원으로 하고싶지만, 반환형이 object라 나중에 어떻게 하는지 학습필요

            //---------------------------------------------------

            //5 Copy 메소드 예제
            int[] brr = new int[4];
            Array.Copy(arr, brr,2); //1,2,0,0
            PrintArr(brr);

        }

        public static void PrintArr(int[] arr)
        {
            Console.Write("[");
            foreach(int elem in arr)
            {
                Console.Write(elem + "  ");           
            }
            Console.Write("] \n");
        }

    }
}

