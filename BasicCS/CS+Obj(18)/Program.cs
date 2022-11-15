using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//System.Colletions에는 IComparer라는 이미 만들어진 인터페이스가 존재한다
//해당 인터페이스는 Compare라는 메서드 하나만을 가지고 있다.
using System.Collections;

namespace CS_Obj_18_
{
    class intCompare : IComparer
    {

        //기본적으로 Comaper메서드는 x인자가 크면1, 같으면 0, 작으면 -1으로 만들지만,
        //아래 메서드의 경우, 역으로 정렬하기위해 해당 값을 뒤집음
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if (xValue > yValue) return -1;
            else if (xValue == yValue) return 0;
            else return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 5, 4, 3, 2 };

            //Array.Sort를하고 Array만 넘겨줘도 되지만,
            //ICompare인터페이스를 상속하고 있는 객체도 매개변수로 받으면, 해당 객체내의 Compare 규칙대로 정렬한다.
            Array.Sort(intArray, new intCompare());
            foreach(int item in intArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}

//참고 https://learn.microsoft.com/ko-kr/dotnet/api/system.array.sort?view=net-7.0
